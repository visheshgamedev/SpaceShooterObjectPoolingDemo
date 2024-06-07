using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletSpawnPosition;

    private float moveHorizontal;

    private float fireRate = 0.2f;
    private float nextFire = 0f;

    private Rigidbody2D playerRB;
    private BulletPoolManager bulletPoolManager;

    private void Awake()
    {
        playerRB = GetComponent<Rigidbody2D>();
        bulletPoolManager = GameObject.FindObjectOfType<BulletPoolManager>();
    }

    private void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();
        }
    }

    private void FixedUpdate()
    {
        playerRB.velocity = new Vector2(moveHorizontal * moveSpeed, 0);
        /*Vector3 mousePosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        mousePosition.z = 0f;
        
        Vector2 playerDirection = (mousePosition - transform.position).normalized;

        Vector2 targetPosition = (Vector2)transform.position + playerDirection * 50f;

        Vector2 newPosition = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.fixedDeltaTime);
        playerRB.MovePosition(newPosition);*/
    }

    private void Shoot()
    {
        GameObject bullet = bulletPoolManager.GetBullet();
        if(bullet != null)
        {
            bullet.transform.position = bulletSpawnPosition.transform.position;
        }
    }
}