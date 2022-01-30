using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{


    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    

    public void Death()
    {
        animator.SetBool("isDeath", true);

        Destroy(gameObject, 1); //1초뒤에 오브젝트 사라짐
    }
}
