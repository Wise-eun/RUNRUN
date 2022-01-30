using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public  int gem = 0;
    public int health = 100;
    RectTransform pos;
    int playerPosition ;

    public Image GoalPlayer;
    public Image Goal;
    public Text GemCount;
    public Text GemResult;
    public Image HpBar;

    //실제 플레이어와 도착지점
    public Transform actual_goal;
    public Transform actual_player;


   

    // Update is called once per frame
    void Update()
    {
        
        GemCount.text = "x " + gem.ToString();
        HpBar.fillAmount = health / 100f;

        GoalPlayer.GetComponent<RectTransform>().anchoredPosition = new Vector3(Goal.GetComponent<RectTransform>().anchoredPosition.x - Vector3.Distance(actual_goal.position , actual_player.position), -35,0);

    }
 
    public void EattingGem() //젬을 먹을 경우 => 점수 증가
    {
        gem += 1;
        Debug.Log("Gem : " + gem);
      
    }

    public void ReduceHealth() //몬스터에게 닿이거나 장애물에 닿일경우 =>체력감소
    {

        if(InputManager.Instance.IsVibrate())
        Vibration.Vibrate((long)1000);

        if(health >5)
        health -= 5;
        else
        {
            health = 0;
            HpBar.fillAmount = 0;

            //죽음 => 일시정지
        }
    }

    public void IncreaseHealth() //몬스터를 밟을 경우 => 체력증가
    {
        if (health <= 90)
            health += 10;
        else if (health == 95)
            health += 5;
        else if (health == 100) ;

    }

  
}
