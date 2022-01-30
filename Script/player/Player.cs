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

    //���� �÷��̾�� ��������
    public Transform actual_goal;
    public Transform actual_player;


   

    // Update is called once per frame
    void Update()
    {
        
        GemCount.text = "x " + gem.ToString();
        HpBar.fillAmount = health / 100f;

        GoalPlayer.GetComponent<RectTransform>().anchoredPosition = new Vector3(Goal.GetComponent<RectTransform>().anchoredPosition.x - Vector3.Distance(actual_goal.position , actual_player.position), -35,0);

    }
 
    public void EattingGem() //���� ���� ��� => ���� ����
    {
        gem += 1;
        Debug.Log("Gem : " + gem);
      
    }

    public void ReduceHealth() //���Ϳ��� ���̰ų� ��ֹ��� ���ϰ�� =>ü�°���
    {

        if(InputManager.Instance.IsVibrate())
        Vibration.Vibrate((long)1000);

        if(health >5)
        health -= 5;
        else
        {
            health = 0;
            HpBar.fillAmount = 0;

            //���� => �Ͻ�����
        }
    }

    public void IncreaseHealth() //���͸� ���� ��� => ü������
    {
        if (health <= 90)
            health += 10;
        else if (health == 95)
            health += 5;
        else if (health == 100) ;

    }

  
}
