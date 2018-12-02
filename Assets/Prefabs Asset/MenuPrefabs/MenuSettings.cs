using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuSettings : MonoBehaviour {

    public AudioSource click;
    public AudioMixer audioMixer;
    public int width;
    public int height;
    public bool isFullscreen=false;

    
   

    #region Menu and Pause
    
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        //controlador de volume ( para o slider)
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        click.Play();
        // Seleção de qualidade pelo index gerado no editor;
    }

    public void SetFullscreen()
    {
        Screen.SetResolution(width, height, true);
        click.Play();

    }
    public void SetWidth(int newWidth)
    {
        width = newWidth; // largura da tela
        click.Play();
    }
    public void SetHeight(int newHeight)
    {
        height = newHeight; // altura da tela;
        click.Play();
    }
    public void SetResolution()
    {
        Screen.SetResolution(width, height,false); // Fullscreen on ou off
    }
    #endregion

   
    
}
