using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMoveScript : MonoBehaviour
{
    public float moveSpeed = 2;
    private float deadZone = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime * transform.localScale.x);
        if (transform.position.x <= deadZone)
        {
            Destroy(gameObject);
        }
    }
}
