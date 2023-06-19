using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public GameManager GameManager;
    public Rigidbody2D RigidBody;
    public float Forse = 6;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RigidBody.AddForce(Vector2.up * Forse, mode: ForceMode2D.Impulse);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.GameOver();
    }
}
