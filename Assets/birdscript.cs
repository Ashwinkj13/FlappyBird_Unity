using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public float blaa = -16;
    public float death = -16;
    public LogicScript logic;
    public static bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)  && birdIsAlive)
        {
            Debug.Log("inside");
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        if ((transform.position.y < death)&& birdIsAlive)
        {
            ///Debug.Log("Bird Died");
            birdIsAlive = false;
            //Destroy(myRigidbody);
            logic.gameOver();
           
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
