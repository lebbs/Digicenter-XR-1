using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RightHand")
            || other.gameObject.CompareTag("LeftHand"))
        {
            Debug.Log("Trigger toimii");
            
            gameObject.SetActive(false);

        }
    }

    //private void OnParticleCollision(GameObject other)
    //{
    //    if (other.tag.Equals("RightHand"))
    //    {
    //        particleEffect.GetComponent<ParticleSystem>().Play();
    //    }
    //}

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