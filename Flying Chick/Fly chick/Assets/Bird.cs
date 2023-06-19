using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public GameManager gameManager;
    public Rigidbody2D rigidBody;
    public float forse = 6;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigidBody.AddForce(Vector2.up * forse, mode: ForceMode2D.Impulse);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
