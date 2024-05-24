using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Move : MonoBehaviour
{
    //左右移動をする力
    [SerializeField] float m_movePower = 5f;

    /// <summary>水平方向の入力値</summary>
    float m_h;
    float m_scaleX;
    Rigidbody2D m_rb = default;

    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
     
        m_h = Input.GetAxisRaw("Horizontal");

        m_rb.velocity = m_h * m_movePower * Vector2.right;


    }
 
}
