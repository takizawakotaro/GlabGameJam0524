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
    float time = 3.0f;
    [SerializeField]
    int point = 0;
    public void GetApple()
    {
        this.point += 100;
    }

    public void GetBomb()
    {
        this.point /= 2;
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
        
    }
}