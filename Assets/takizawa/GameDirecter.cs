using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirecter : MonoBehaviour
{
    [SerializeField]
    Text timerText;
    [SerializeField]
    Text PointText;
    [SerializeField]
    Text MoneyText;
    [SerializeField]
    float time = 3.0f;
    [SerializeField]
    int point = 0;
    int money = 0;
    public void GetPoint(int p)
    {
        if (p > money)
        {
            point -= p - money;
            money = 0;
        }
        else
        {
            this.point += p;
            this.money -= p;
        }
    }



    public void Getmoney(int m)
    {
        this.money += m;
    }

    private void Start()

    {
       
    }
    void Update ()
    {
        this.time -= Time.deltaTime;

        if (this.time < 0)
        {
            this.time = 0;
        }

        this.timerText.text =
            this.time.ToString("00");
        this.PointText.text =
            this.point.ToString() + "point";
        this.MoneyText.text =
            this.money.ToString() + "‰~";
        
    }
}