using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] meteorPrefab;

    private void Start()
    {
        InvokeRepeating("SpawnMeteor", 2f, 2f);
    }

    private void SpawnMeteor()
    {
        float randomX = Random.Range(-8f, 8f);
        Vector2 spawnPostion = new Vector2(randomX, transform.position.y);
        Instantiate(meteorPrefab[0], spawnPostion, Quaternion.identity);
    }
}