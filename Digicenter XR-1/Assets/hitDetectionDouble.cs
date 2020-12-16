using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitDetectionDouble : MonoBehaviour
{

    public GameObject fracturedObject;
    public static int i = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RightHand")
           || other.gameObject.CompareTag("LeftHand"))
        {
            i++;
            Debug.Log(i);
            if (i >= 2)
            {
                Debug.Log(i);
                Destroy();
                gameObject.SetActive(false);
            }           
        }
    }

    public void Destroy()
    {
        Instantiate(fracturedObject, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
