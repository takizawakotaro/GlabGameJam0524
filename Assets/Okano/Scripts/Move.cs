using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Move : MonoBehaviour
{
    //¶‰EˆÚ“®‚ğ‚·‚é—Í
    [SerializeField] float m_movePower = 5f;

    /// <summary>…•½•ûŒü‚Ì“ü—Í’l</summary>
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
