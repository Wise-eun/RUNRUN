using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlide : MonoBehaviour
{

    public Rigidbody2D rigid;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        transform.localEulerAngles = new Vector3(0, 0, 0);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (InputManager.Instance == null)
        {

            return;

        }
        if (InputManager.Instance.IsSlide())
        {

            //transform.localEulerAngles = new Vector3(0, 0, 90);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            animator.SetBool("isCrawl", true);
        }
        else {

            //transform.localEulerAngles = new Vector3(0, 0, 0);
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            animator.SetBool("isCrawl", false);
        }
    }
}
