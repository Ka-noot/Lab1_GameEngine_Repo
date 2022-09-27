using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; //singleton example
    public TextMeshProUGUI pointText;
    public TextMeshProUGUI healthText;
    public int score = 0;
    public int health = 50;

    // Start is called before the first frame update
    void Awake()
    {
        pointText = GetComponent<TextMeshProUGUI>();
        pointText.text = "POINTS: " + score.ToString();
        healthText.text = "HEALTH: " + health.ToString();
        if (!instance)
        {
            instance = this;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        pointText.text = "POINTS: "+score.ToString();
        Debug.Log(score);
    }

    public void ChangeHealth(int healthValue)
    {
        health -= healthValue;
        healthText.text = "HEALTH: " + health.ToString();
        Debug.Log(health);
    }

}
