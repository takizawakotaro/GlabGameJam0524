
using UnityEngine;
using UnityEngine.SceneManagement;//Unityエンジンのシーン管理プログラムを利用する

public class SceneLoader : MonoBehaviour //changeという名前にします
{
    public void Start_button() //change_buttonという名前にします
    {
        SceneManager.LoadScene("GameScene");//secondを呼び出します
    }
}
