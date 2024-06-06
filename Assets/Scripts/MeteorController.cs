using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 30.0f;
    [SerializeField] private float moveSpeed = 2.0f;

    private Rigidbody2D meteorRB;

    private void Awake()
    {
        meteorRB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime, Space.Self);

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        meteorRB.velocity = Vector2.down * moveSpeed;
    }
}