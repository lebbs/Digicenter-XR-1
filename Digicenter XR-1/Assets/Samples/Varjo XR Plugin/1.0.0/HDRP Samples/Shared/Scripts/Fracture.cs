using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fracture : MonoBehaviour
{
    public GameObject fracturedObject;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RightHand")
            || other.gameObject.CompareTag("LeftHand"))
        {
            Destroy();
        }
    }

    public void Destroy()
    {
        Instantiate(fracturedObject, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
