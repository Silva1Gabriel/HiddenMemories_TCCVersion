Shader "Custom/Sujeira"
{
	Properties
	{
		// cor que influencia o personagem
		_Cor("Cor",Color)=(1,1,1,1)

		//textura do personagem e as texturas
		_MainTex("Albendo Personagem", 2D) = "white" {}
		_MainNormal("Normal Personagem",2D) = "white"{}
		_MainSpecular("Specular Personagem",2D) = "white"{}
		_MainHeight("Height Personagem",2D) = "white" {}
		_MainMetallic("Metallic Personagem",2D) = "white"{}
		_MainAmbientOcclusion("Ambient Occlusion Personagem",2D) ="white"{}

		// texturas da sujeira
		_SujeiraTextura("Sujeira Textura",2D) = "white"{}
		_SujeiraNormal("Sujeira Normal",2D) = "white"{}
		_SujeiraMaskText("Sujeira Mascara",2D) ="white"{}

		//Quantidade de sujeira
		_SujeiraQuantidade("Sujeira Quantidade", Range(0,1)) = 0.0

		//controle melheor dos mapas uv 
		_Metallic("Metallic", Range(0,1)) = 0.0
		_Glossiness("Smoothness", Range(0,1)) = 0.5
		_AmbientOcclusion("AmbientOcclusion",Range(0,1))= 0.0
		_Specular("Specular",Range(0,1)) = 0.5

	}
		SubShader
		{
			Tags { "RenderType" = "Opaque" }
			LOD 200

			CGPROGRAM
		
		#pragma surface surf Standard fullforwardshadows

		
		#pragma target 3.0

		// coloca as texturas de cada UV
		sampler2D _MainTex;
		sampler2D _MainNormal;
		sampler2D _MainSpecular;
		sampler2D _MainHeight;
		sampler2D _MainMetallic;
		sampler2D _MainAmbientOcclusion;

		sampler2D _SujeiraTextura;
		sampler2D _SujeiraNormal;
		sampler2D _SujeiraMaskText;

		//acesso as UV das texturas.
		struct Input 
		{
			float2 uv_MainTex;
			float2 uv_MainNormal;
			float2 uv_MainSpecular;
			float2 uv_MainHeight;
			float2 uv_MainMetallic;
			float2 uv_MainAmbientOcclusion;

			float2 uv_SujeiraTextura;
			float2 uv_SujeiraNormal;
			float2 uv_SujeiraMaskText;
		};

		float _Specular;

		half _SujeiraQuantidade;

		half _Glossiness;
		half _Metallic;


		fixed4 _Cor;
	

		UNITY_INSTANCING_BUFFER_START(Props)
			
		UNITY_INSTANCING_BUFFER_END(Props)

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);// textura princilpal (Albendo)
			fixed4 r = tex2D(_SujeiraTextura, IN.uv_MainTex);// textura de sujeira o qual vai na uv _MainText(Albendo)
			fixed4 mt = tex2D(_SujeiraMaskText, IN.uv_SujeiraMaskText);//mascara
			fixed3 n = UnpackNormal(tex2D(_SujeiraNormal, IN.uv_SujeiraNormal));// sujeira normal map
			

			if (mt.x < _SujeiraQuantidade)
			{

				if (c.x < 0.5 && c.y < 0.5 && c.z < 0.5)
				{
					o.Albedo = _Cor;
				}
				o.Smoothness = _Glossiness * mt * _SujeiraQuantidade;
				o.Albedo = (c.rgb*((1 - mt * _SujeiraQuantidade)) + r.rgb*mt*_SujeiraQuantidade) / 2;
			}

			else
			{
				o.Albedo = r.rgb;
				o.Normal = n;
			}
			
			
			o.Metallic = _Metallic;
			o.Alpha = c.a;

			
		}
		ENDCG
	}
		FallBack "Diffuse"
}