using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Unityエンジンのシーン管理プログラムを利用する

public class SceneLoader : MonoBehaviour //changeという名前にします
{
    public void Start_button() //change_buttonという名前にします
    {
        SceneManager.LoadScene("2DSample");//secondを呼び出します
    }
}
