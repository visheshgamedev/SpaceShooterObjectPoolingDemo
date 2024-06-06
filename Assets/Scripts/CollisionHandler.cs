using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            collision.gameObject.SetActive(false);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over");
        }
    }
}