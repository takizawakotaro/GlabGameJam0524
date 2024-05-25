using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDitecter : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("Start Scene");
        }
    }

    // Update is called once per frame
    
    
        
    }

