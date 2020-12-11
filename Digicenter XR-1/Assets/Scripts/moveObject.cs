using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{


    Rigidbody rigidbody;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = -transform.forward * speed;
    }
}
