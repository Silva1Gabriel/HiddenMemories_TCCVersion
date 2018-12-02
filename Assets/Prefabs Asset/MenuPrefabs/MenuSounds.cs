using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class MenuSounds : MonoBehaviour
{

    public AudioSource click;
    public AudioSource thunderClick;
   

    public Animation IntroSoundRain;
    
    
    public Animation fadesoundThunder;

    public void Awake()
    {//Som inicial
        IntroSoundRain.Play("RainSoundFadeIn");
        
        
    }
    public void clickPlay()
    {
        //som ao clicar
        click.Play();
    }
    public void thunderPlay()
    {//Som ao clickar no play
        thunderClick.Play();
        fadesoundThunder.Play("ThunderSoundFadeOut");
       
      

    }
}
