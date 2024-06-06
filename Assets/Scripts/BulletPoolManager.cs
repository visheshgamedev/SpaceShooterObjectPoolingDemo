using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPoolManager : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    private int poolSize = 5;

    private List<GameObject> bulletPool;

    private void Awake()
    {
        bulletPool = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform);
            bullet.SetActive(false);
            bulletPool.Add(bullet);
        }
    }

    public GameObject GetBullet()
    {
        foreach (GameObject bullet in bulletPool)
        {
            if (!bullet.activeInHierarchy)
            {
                bullet.SetActive(true);
                return bullet;
            }
        }

        return null;
    }
}