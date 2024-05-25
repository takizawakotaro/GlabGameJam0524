using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClearDitecter : MonoBehaviour
{
    [SerializeField] Text _text;
    private void Awake()
    {
        _text.text = GameDirecter.point.ToString();
        GameDirecter.point = 0;
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("Start Scene");
        }
    }
    
    
        
    }

