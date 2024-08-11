using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CloudSpawnScript : MonoBehaviour
{
    public GameObject[] clouds;
    public float spawnRate = 2;
    private float timer = 2;
    private System.Random random = new System.Random();

    private float spawnRateOffset = .5f;
    private float heightOffset = .1f;
    private float minScale = 0.5f;
    private float maxScale = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(clouds.Length);
        //Debug.Log(clouds[0].name + clouds[1].name + clouds[2].name);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            spawnRate = UnityEngine.Random.Range(1 - spawnRateOffset, 1 + spawnRateOffset);
            SpawnCloud();
        }

    }

    void SpawnCloud()
    {
        int index = random.Next(0, clouds.Length);
        Instantiate(clouds[index], new Vector3(transform.position.x, transform.position.y + UnityEngine.Random.Range(-heightOffset, heightOffset), 0), transform.rotation);
        Debug.Log("Nuage créé : " + clouds[index].name + "");
    }
}
