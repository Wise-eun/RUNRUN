using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectMusic : MonoBehaviour
{
    static public EffectMusic instance;
    private AudioSource audioSource;

    void Awake()
    {

        if (instance == null)   // ���� ����
        {
            instance = this;  // ������ �ڱ� �ڽ�(�ν��Ͻ�)�� �Ҵ�
            DontDestroyOnLoad(transform.gameObject);  // �� ��ȯ�ǵ� �ڱ� �ڽ��� �ı����� �ʰ� �����ǵ���
        }
       

        audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
 
        audioSource.Play();
    }

  
}
