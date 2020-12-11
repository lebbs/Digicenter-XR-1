using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitDetection : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="BlueTarget"
            || collision.gameObject.tag == "RedTarget")
        {
            Destroy(collision.gameObject);
        }
    }


    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("RightHand"))
    //    {
    //        Debug.Log("Sininen maalitaulu toimii.");
    //        // right.SetActive(true);
    //        //other.gameObject.SetActive(false);
    //        //spawn.SpawnObject();
    //        //StartCoroutine(ShowAndHide(right, 3.0f));
    //    }
    //}
}