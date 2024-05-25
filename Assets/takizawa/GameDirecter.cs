using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

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
    float _lastSpurtTime;
    [SerializeField]
    ObjectCreator _objCreator;
    [SerializeField]
    float _LimitFirst = 20;
    [SerializeField]
    float _LimitSecond = 10;
    [SerializeField]
    ObjectCreator _objCreator_obj;
    [SerializeField]
    float _LimitFirst1 = 20;
    [SerializeField]
    float _LimitSecond2 = 10;
    public static int point = 0;
    int money = 100;

    public bool IsLastSpurt;

    public void GetPoint(int p)
    {
        if (p > money)
        {
            point -= p - money;
            money = 0;
        }
        else
        {
            point += p;
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
            SceneManager.LoadScene("Clearscene");
        }

        this.timerText.text =
            this.time.ToString("00");
        this.PointText.text =
            point.ToString() + "point";
        this.MoneyText.text =
            this.money.ToString() + "‰~";

        if (!IsLastSpurt && time < _lastSpurtTime)
        {
            IsLastSpurt = true;
        }

        if (this.time <= _LimitFirst)
        {
            _objCreator.SetCreateInterval(1.5f);
            if (this.time <= _LimitSecond)
            {
                _objCreator.SetCreateInterval(2f);
            }
        }

        if (!IsLastSpurt && time < _lastSpurtTime)
        {
            IsLastSpurt = true;
        }

        if (this.time <= _LimitFirst1)
        {
            _objCreator_obj.SetCreateInterval(0.3f);
            if (this.time <= _LimitSecond2)
            {
                _objCreator_obj.SetCreateInterval(0.1f);
            }
        }



    }
    

}