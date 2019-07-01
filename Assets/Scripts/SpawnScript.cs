 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject enemy;
    float randX,randY;
    Vector3 spawnPlace;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    void Start()
    {
        
    }

    void Update()
    {
        if(Time.time > nextSpawn){
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-8.4f, 8.4f);
            randY = Random.Range(-8.4f, 8.4f);
            spawnPlace = new Vector3(randX, randY, transform.position.z);
            Instantiate(enemy, spawnPlace, enemy.transform.rotation);
        }
    }
}
