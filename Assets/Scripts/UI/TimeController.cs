using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// NEW USING STATEMENT
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeController : MonoBehaviour {

    public float time;
    public string nextScene;

    private float timeRemaining;
    private Text timeText;

	// Use this for initialization
	void Start () {
        timeRemaining = time;
        timeText = GetComponent<Text>();

        // Update UI once
        UpdateText();
	}
	
    void FixedUpdate()
    {
        timeRemaining -= Time.deltaTime;

        // Update UI
        UpdateText();

        if(timeRemaining <= 0)
        {
            // change scenes
            SceneManager.LoadScene(nextScene);
        }
    }

    void UpdateText()
    {
        timeText.text = "Time: " + Mathf.CeilToInt(timeRemaining);
    }

}
