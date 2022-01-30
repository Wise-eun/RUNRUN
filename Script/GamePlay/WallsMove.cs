using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsMove : MonoBehaviour
{
 
    bool isDown = false;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 3.0f) //일정높이 이상 올라갔을 경우

        {
            transform.Translate(Vector3.down * Random.Range(1,41) * Time.deltaTime * 1);
            isDown = true;
        }
        
        else if (transform.position.y < -4.8f) // 일정높이 이상 내려갔을 경우

        {
            transform.Translate(Vector3.down * Random.Range(1, 11) * Time.deltaTime * -1);
            isDown = false;
        }
        else //그 외
        {
            if (isDown == true)
            {
                transform.Translate(Vector3.down * Random.Range(1, 41) * Time.deltaTime * 1);
            }
            else if (isDown == false)
            {
                transform.Translate(Vector3.down * Random.Range(1, 11) * Time.deltaTime * -1);
            }
        }
      


        

        
    }
    
}
