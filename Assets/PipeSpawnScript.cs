using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 2;

    //Déjà au maximum de la hauteur
    private float heightOffset = -1.8f;
    // Start is called before the first frame update
    void Start()
    {
        //SpawnPipe();
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
            SpawnPipe();
        }
    }

    void SpawnPipe()
    {

        Instantiate(pipe, new Vector3(transform.position.x, transform.position.y + Random.Range(heightOffset, 0.2f), 0), transform.rotation);
    }
}
