using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShaderSujeira : MonoBehaviour
{
    [SerializeField]
    Renderer render;
    [SerializeField]
    Shader ShaderDaSujeira;
    [SerializeField]
    Material materialDaSujeira; // Material o qual voce quer que tenha interação ração.

    float SujieraDaRoupaDoTuca = 1f;// roupa 100% limpa 

	void Update ()
    {
       SujieraDaRoupaDoTuca = Mathf.Lerp(1f,0.1f,Time.time*0.1f);// aqui é o tempo  o qual vai fazer com que o personagem se suje
       materialDaSujeira.SetFloat("_SujeiraQuantidade", SujieraDaRoupaDoTuca);// Aqui ele pega o material o que voce jogou e a tarves do shader sujeira ele acessa a _SujeiraQuantidade para sujar o personagem.
    }

}
