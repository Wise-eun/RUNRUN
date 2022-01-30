using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NextButton : MonoBehaviour
{

    public GameObject getPoint;
    public GameObject lossPoint;


    public void NextButtonClicked()
    {
        getPoint.SetActive(false);
        lossPoint.SetActive(true);
   
    }


}
