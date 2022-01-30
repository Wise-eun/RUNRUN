using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float speed;
    public SpriteRenderer render;
    float time;
    bool isTwinkle = false;
    public Player player;
    public GameObject successResult;
    public GameObject failResult;
    Vector3 NowPos;
    bool ShowResultt = false;
    bool stopMove = false;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        NowPos = this.gameObject.transform.position;
        //Debug.Log("Now pos = " + NowPos);
        
        if (NowPos.y <=-4 && ShowResultt == false) //캐릭터가 일정높이 이하로 떨어졌다고 인식
        {
            ShowResultt = true;
            /*
            StartCoroutine(ReMove());
            Debug.Log("health = " + player.health);*/
            rigid.constraints = RigidbodyConstraints2D.FreezeAll;
            stopMove = true;
       
            //successResult 클래스안에 변수 값들 설정
            successResult.GetComponent<SuccessResult>().gemText.text = "x " + player.gem.ToString(); //얻은 보석 그대로 복사
            successResult.GetComponent<SuccessResult>().result += player.gem;
            successResult.GetComponent<SuccessResult>().result += player.health;

            successResult.GetComponent<SuccessResult>().hp = player.health;
            successResult.GetComponent<SuccessResult>().originHP = player.health;
            successResult.GetComponent<SuccessResult>().ShowResult();

            return;
        }

        if (player.health ==0)
        {
            stopMove = true;
            failResult.GetComponent<FailResult>().ShowResult();
        }

        if(isTwinkle == true)
        {   
            rigid.AddForce(Vector2.left * 8, ForceMode2D.Impulse);
            StartCoroutine(Twinkle());
            isTwinkle = false;
        }
        if(stopMove == false)
        {
            
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
       
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "monster")
        {
            Debug.Log("Meet Monster");
            isTwinkle = true;
            player.ReduceHealth();

        }

        else if (collision.gameObject.tag =="wall")
        {
            isTwinkle = true;
            player.ReduceHealth();
        }

       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "gem")
        {
            Debug.Log("Meet Gem!");
            Gem gem = collision.gameObject.GetComponent<Gem>();
            gem.Eatting();

            player.EattingGem();
        }

        if(collision.gameObject.tag == "goal")
        {
            stopMove = true;
            successResult.GetComponent<SuccessResult>().ShowResult();

            //successResult 클래스안에 변수 값들 설정
            successResult.GetComponent<SuccessResult>().gemText.text = "x " + player.gem.ToString(); //얻은 보석 그대로 복사
            successResult.GetComponent<SuccessResult>().result += player.gem;
            successResult.GetComponent<SuccessResult>().result += player.health;


        }
    }

    IEnumerator Twinkle()
    {

        render.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.2f);
        render.color = new Color(1, 1, 1, 1f);
        yield return new WaitForSeconds(0.2f);
        render.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.2f);
        render.color = new Color(1, 1, 1, 1f);
        yield return new WaitForSeconds(0.2f);
        render.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.2f);
        render.color = new Color(1, 1, 1, 1f);

    }

    IEnumerator ReMove()
    {
      

        transform.position = new Vector3(NowPos.x - 7, -1, 0);
        player.ReduceHealth();

        //깜빡거리다가
        render.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.2f);
        render.color = new Color(1, 1, 1, 1f);
        yield return new WaitForSeconds(0.2f);
        render.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.2f);
        render.color = new Color(1, 1, 1, 1f);
        yield return new WaitForSeconds(0.2f);
        render.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.2f);
        render.color = new Color(1, 1, 1, 1f);

        //다시 시작

        yield return new WaitForSeconds(1f * 0.001f);

    }
}
