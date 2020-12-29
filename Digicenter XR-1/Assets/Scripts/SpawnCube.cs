using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public GameObject[] objects;

    public Vector3 distance = new Vector3(0f, 0.01f, 0f);

    // Start is called before the first frame update
    void Start()
    {
      //  SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            SpawnObject();
        }
        
    }

    public void SpawnObject()
    {
        int randomIndex = Random.Range(0, objects.Length);
        GameObject instantiatedObject = Instantiate(objects[randomIndex],transform.position + (distance),transform.rotation);
    }

}

