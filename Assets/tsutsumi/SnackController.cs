using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnackController : MonoBehaviour
{
    [SerializeField] float delete;
    [SerializeField] int _point;
    GameDirecter _game;
    private void Start()
    {
        var g = GameObject.Find("GameDirecter");
        _game = g.GetComponent<GameDirecter>();
    }


    private void Update()
    {
        if (transform.position.y < delete)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "kago")
        {
            _game.GetPoint(_point);
            Destroy(gameObject);
        }

    }
}
