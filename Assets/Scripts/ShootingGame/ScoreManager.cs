using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text currentScoreUI;
    private int currentScore;

    public void SetScore(int value)
    {
        currentScore = value;
        currentScoreUI.text = "LIFE\nSCORE : " + currentScore;
    }

    public int GetScore()
    {
        return currentScore;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
