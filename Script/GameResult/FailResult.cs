using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailResult : MonoBehaviour
{
    public GameObject failResult;


    void Start()
    {

        failResult.SetActive(false);

    }

    public void ShowResult()
    {

        failResult.SetActive(true);
    }


 }
