using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Unity�G���W���̃V�[���Ǘ��v���O�����𗘗p����

public class SceneLoader : MonoBehaviour //change�Ƃ������O�ɂ��܂�
{
    public void Start_button(string Sceneneme) //change_button�Ƃ������O�ɂ��܂�
    {
        SceneManager.LoadScene(Sceneneme);//second���Ăяo���܂�
    }
}
