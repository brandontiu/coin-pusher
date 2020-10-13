using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
    public int initScore;
    private int currentScore;
    public Text scoreText;

    // Start is called before the first frame update
    void Start() {
        // get a copy of the initial score and display it
        currentScore = initScore;
        scoreText = this.GetComponent<Text>();
        displayScore(initScore);
    }

    public void increaseScore(int num) {
        currentScore += num;
        displayScore(currentScore);
    }

    public void decreaseScore(int num) {
        currentScore -= num;
        displayScore(currentScore);
    }

    // a helper method to generate a text representation
    private void displayScore(int num) {
        scoreText.text = num.ToString();
    }
}

