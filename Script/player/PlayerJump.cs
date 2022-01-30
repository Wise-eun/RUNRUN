using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    public Rigidbody2D rigid;
    public float jumpHeight;
    Animator animator;
    public Player player;
 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (InputManager.Instance == null)
        {

            return;

        }

        if (InputManager.Instance.IsJump())

        {
          

            // Debug.Log(jumpCount);
            if (InputManager.Instance.IsFirst())

            {

                //jumpCount = jumpCount + 1;

                rigid.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
                animator.SetBool("isJumping", true);
             
            }

            if (InputManager.Instance.IsSecond())
            {

                rigid.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
                animator.SetBool("isJumping", true);
        
            }

        }
    

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
        
            InputManager.Instance.ClearJumpFlag();
            animator.SetBool("isJumping", false);
        }

        if(collision.gameObject.tag=="monster")
        {
            Debug.Log("Monster!");
            rigid.AddForce(Vector2.up * 4, ForceMode2D.Impulse);
            animator.SetBool("isJumping", true);

            Monster monster = collision.gameObject.GetComponent<Monster>();
            monster.Death();
            player.IncreaseHealth();
            InputManager.Instance.ClearJumpFlag();

        }
    }



}
