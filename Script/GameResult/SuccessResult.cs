using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SuccessResult : MonoBehaviour
{

    public GameObject successResult;
    public GameObject playerInfo;


    public Text gemText;
    public Text hpText;
    public Text resultText;

    public int hp ;
    public int originHP;
    public int result = 0 ;
    public int hp_result = 0 ;

    void Start()
    {
    
        successResult.SetActive(false);

    }

    public void ShowResult()
    {

        successResult.SetActive(true);

   
        //체력Text 올라가는 애니메이션 동시에 체력바 내려가는모습 보여줌
        StartCoroutine(HPPointUp());

     
     
    }

    IEnumerator HPPointUp()
    {
        
        int hpPoint = 0;
        Debug.Log("originHP = " + originHP);
        for (int i=0; i<originHP; i++)
        {

            //playerInfo.GetComponent<Player>().HpBar.fillAmount = (hp - hpPoint) / 100f;
            hp -= 1;
            hpPoint += 1;
            hpText.text = hpPoint.ToString();
            yield return new WaitForSeconds(0.5f);

            Debug.Log("hp = " + hp);
        }

        //총점 올라가는 모습 보여줌 , 체력 다음에..
        StartCoroutine(ResultPointUp());

    }


    IEnumerator ResultPointUp()
    {
        int resultShow = 0;


        for (int i = 0; resultShow < result; i++)
        {

            resultShow++;
            resultText.text = resultShow.ToString();
            yield return new WaitForSeconds(0.2f);


        }

    }
}
