using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VarjoExample;
using System;
public class cubeDetection : MonoBehaviour
{
    public SpawnCube spawn;
    public GameObject right;
    public GameObject wrong;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        //StartCoroutine(ShowAndHide(right, 3.0f));
        if (other.gameObject.CompareTag("BlueCube"))
        {
            Debug.Log("Sininen kuutio toimii.");
            other.gameObject.SetActive(false);
            spawn.SpawnObject();
            //right.SetActive(true);
            StartCoroutine(ShowAndHide(right, 3.0f));

        }
        else
        {
            Debug.Log("Väärän värinen kuutio laitettu");
            wrong.SetActive(true);
        }
    }


    private IEnumerator ShowAndHide(GameObject gameObject, float delay)
    {
        gameObject.SetActive(true);
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        right.SetActive(false);
        wrong.SetActive(false);
    }
}
