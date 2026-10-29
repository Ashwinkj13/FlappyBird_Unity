using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipescript : MonoBehaviour
{
    public static pipescript instance;
    public int moveSpeed = 5;
    //private int incriment = 0;
    public float deadZone = -45;
    public birdscript birdLive;

    //public LogicScript scoreee;
    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeed = (LogicScript.playScore/2)+5;
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
          //  Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }

}
