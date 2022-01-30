using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting : MonoBehaviour
{

    public GameObject gameSetting;

    // Start is called before the first frame update
    void Start()
    {
      
        gameSetting.SetActive(false);

    }

    public void settingVisible()
    {
        gameSetting.SetActive(true);
    }

    public void settingInVisible()
    {
        gameSetting.SetActive(false);
    }
}
