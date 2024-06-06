using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10.0f;

    private Rigidbody2D bulletRB;

    private void Awake()
    {
        bulletRB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (transform.position.y > 6)
        {
            gameObject.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        bulletRB.velocity = Vector3.up * movementSpeed;
    }
}