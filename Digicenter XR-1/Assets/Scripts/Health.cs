using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private static int score;
    //private GameObject scoreText = GameObject.FindGameObjectWithTag("Score");

    public int health = 100;
    public GameObject fracturedObject; 
    
    public void OnDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            AddScore();
            Destroy();
        }
    }
    public void AddScore()
    {
        GameObject scoreText = GameObject.FindGameObjectWithTag("Score");
        score += 1;
        scoreText.GetComponent<TextMesh>().text = "Score: " + score;
        Debug.Log(score);
    }

    public void Destroy()
    {
        Instantiate(fracturedObject, transform.position, transform.rotation);
        Destroy(gameObject);
    }

   

}
