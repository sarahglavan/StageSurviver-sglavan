using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectSpawner : MonoBehaviour
{

    public GameObject Enemy;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-5.8f, 5.8f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(Enemy, whereToSpawn, Quaternion.identity);
        }

    }
}

// Objekte (Tomaten und Coins) sollen spawnen
//Quelle: https://www.youtube.com/watch?v=AI8XNNRpTTw