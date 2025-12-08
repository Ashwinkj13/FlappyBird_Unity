using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudspawner : MonoBehaviour
{
    public GameObject cloud;
    private float spawnRates = 8;
    private float timers = 0;
    public float heightOffsets = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timers < spawnRates)
        {
            timers = timers + Time.deltaTime;
        }
        else
        {
            spawnCloud();
            ///Debug.Log("clouded");
            timers = 0;
        }
    }

    void spawnCloud()
    {
        float lowestPoint = transform.position.y - heightOffsets;
        float heighestPoint = transform.position.y + heightOffsets;

        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, heighestPoint), 0), transform.rotation);
    }
}
