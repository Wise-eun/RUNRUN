using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class EffectVolume : MonoBehaviour
{

    public Slider slider;
    public AudioSource audio;

    private float effectVol = 1f;

    // Start is called before the first frame update
    void Start()
    {
        effectVol = PlayerPrefs.GetFloat("effectVol", 1f);
        slider.value = effectVol;
        audio.volume = slider.value;

    }
  
    public void SoundSlider()
    {
        audio.volume = slider.value;

        effectVol = slider.value;
        PlayerPrefs.SetFloat("effectVol", effectVol);

 
    }

}
