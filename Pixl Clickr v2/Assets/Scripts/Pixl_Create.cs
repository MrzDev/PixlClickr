using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeStage.AntiCheat.ObscuredTypes;

public class Pixl_Create : MonoBehaviour
{
    public ObscuredDouble Counter = 0;
    public GameObject Error;
    public ObscuredDouble Time = 0;
    public GameObject ErrorText;

    public void ClickTheButton()
    {
        //+1 Pixl
        Counter += 1;
        if (Counter < 20)
        {
            SavePixls.PixlCount += SavePixls.PixlsAdded;
            SavePixls.StatisticPixlCount += SavePixls.PixlsAdded;
            SavePixls.StatisticsClicks += 1;
        }


    }

    public void ErrorButton()
    {
        Time = 10;
    }

    public void Start()
    {
        InvokeRepeating("PeachS", 0, 1);
        InvokeRepeating("Anti", 0, 1);
        InvokeRepeating("CloseTime", 0, 1);
    }

    private void PeachS()
    {
        SavePixls.PixlCount += SavePixls.PeachS * SavePixls.PeachSMulti; //* PowerUps.PowerUpPixls;
        SavePixls.StatisticPixlCount += SavePixls.PeachS * SavePixls.PeachSMulti; //* PowerUps.PowerUpPixls;
    }
    private void Anti()
    {
        if (Counter >= 20)
        {
            Error.SetActive(true);
            Time = 10;
            Counter = 0;

        }
        if (Counter < 20)
        {
            Counter = 0;
        }

    }/*
    private void CloseTime()
    {
        Time -= 1;
        ErrorText.GetComponent<Text>().text = "Stop your Auto-Clicker!;)    " + Time + "s";
        if (Time == 0)
        {
            Error.SetActive(false);
        }

    }*/
}
