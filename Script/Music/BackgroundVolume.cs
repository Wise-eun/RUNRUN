using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class BackgroundVolume : MonoBehaviour
{
 
    public Slider slider;
    public AudioSource audio;

    private float backVol = 1f;

    // Start is called before the first frame update
    void Start()
    {
        backVol = PlayerPrefs.GetFloat("backvol", 1f);
        slider.value = backVol;
        audio.volume = slider.value;
      
    }

    public void SoundSlider()
    {
        audio.volume = slider.value;

        backVol = slider.value;
        PlayerPrefs.SetFloat("backvol", backVol);
    }

   
}
