using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public GameObject scoreText;
    private static int score;

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.CompareTag("RightHand")
    //        || collision.gameObject.CompareTag("LeftHand"))
    //    {
    //        score += 1;
    //        scoreText.GetComponent<TextMesh>().text = "Score: " + score;
    //        Debug.Log("Käsi toimii!!!!!!!!!!!");
    //    }
    //}


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("RedTarget")
            || other.gameObject.CompareTag("BlueTarget"))
        {
            score += 1;
            scoreText.GetComponent<TextMesh>().text = "Score: " + score;
            Debug.Log("Käsi trigger toimii");
        }
    }
}
