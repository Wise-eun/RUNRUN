using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectMusic : MonoBehaviour
{
    static public EffectMusic instance;
    private AudioSource audioSource;

    void Awake()
    {

        if (instance == null)   // 최초 생성
        {
            instance = this;  // 현재의 자기 자신(인스턴스)를 할당
            DontDestroyOnLoad(transform.gameObject);  // 씬 전환되도 자기 자신이 파괴되지 않고 유지되도록
        }
       

        audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
 
        audioSource.Play();
    }

  
}
