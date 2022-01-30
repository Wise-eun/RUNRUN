using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo : MonoBehaviour
{

    public GameObject gameinfo;
    public GameObject getPoint;
    public GameObject lossPoint;

    // Start is called before the first frame update
    void Start()
    {
        gameinfo.SetActive(false);
        getPoint.SetActive(false);
        lossPoint.SetActive(false);
    }

    public void ButtonClicked()
    {
        gameinfo.SetActive(true);
        getPoint.SetActive(true);
        lossPoint.SetActive(false);
    }
}
