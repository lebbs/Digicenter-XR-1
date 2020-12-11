using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ontriggerenter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BlueTarget"))
        {
            Debug.Log("Sininen maalitaulu toimii.");
            // right.SetActive(true);
            //other.gameObject.SetActive(false);
            //spawn.SpawnObject();
            //StartCoroutine(ShowAndHide(right, 3.0f));
        }
    }
}
