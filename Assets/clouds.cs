using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    public int moving = 2;
    public float deadZones = -45;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moving = (LogicScript.playScore / 2) + 2;
        transform.position = transform.position + (Vector3.left * moving) * Time.deltaTime;

        if (transform.position.x < deadZones)
        {
            //  Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}

