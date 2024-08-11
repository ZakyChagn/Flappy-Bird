using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public new Rigidbody2D rigidbody2D;
    public float flapStrenght;
    public LogicScript logic;
    public bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //rigidbody2D.velocity = Vector2.right * 5;
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            rigidbody2D.velocity = Vector2.up * flapStrenght;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        isAlive = false;
    }
}
