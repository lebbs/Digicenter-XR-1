using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTarget : MonoBehaviour
{

    public GameObject target;
    public float targetSpeed;

    public float maxTime = 5;
    public float minTime = 2;

    private float time;
    private float spawnTime;
   private void Start()
    {
        SetRandomTime();
        time = minTime;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }
        
    }

   void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

    void SpawnObject()
    {
        time = 0;
        GameObject spawn = GameObject.Instantiate(target, transform.position, transform.rotation);
        spawn.GetComponent<Rigidbody>().AddRelativeForce(-transform.forward * targetSpeed);
    }
}

       



