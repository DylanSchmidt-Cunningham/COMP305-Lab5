using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// NEW USING STATEMENT
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    private int currentScore;
    private Text scoreText;

	// Use this for initialization
	void Start () {
        currentScore = 0;
        scoreText = GetComponent<Text>();
        // Update UI once
        UpdateText();
	}
	
    public void UpdateScore(int valueToAdd)
    {
        currentScore += valueToAdd;
        // currentScore = currentScore + valueToAdd;
        // Update UI
        UpdateText();
    }

    void UpdateText()
    {
        scoreText.text = "Score: " + currentScore;
    }
}
