using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public int score;
 

    void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        Debug.Log(score);
    }
}
