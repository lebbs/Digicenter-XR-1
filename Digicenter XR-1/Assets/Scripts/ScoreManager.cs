using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public GameObject scoreText;
    private int score;
    
    public void IncrementScore()
    {
        score++;
        scoreText.GetComponent<TextMesh>().text = score.ToString();
    }
}
