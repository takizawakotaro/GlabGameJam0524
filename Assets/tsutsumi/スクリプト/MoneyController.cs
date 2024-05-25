using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyController : MonoBehaviour
{
    [SerializeField] float delete;
    [SerializeField] int _money;
    [SerializeField] float _lastSpartGrav;
    GameDirecter _game;

    private void Start()
    {
        var g = GameObject.Find("GameDirecter");
        _game = g.GetComponent<GameDirecter>();
        Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();
        if (_game.IsLastSpurt)
        {
            rigidbody2D.gravityScale = _lastSpartGrav;
        }
    }


    private void Update()
    {
        if(transform.position.y < delete)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "kago")
        {
            _game.Getmoney(_money);
            Destroy(gameObject);
        }
    }
  
}
