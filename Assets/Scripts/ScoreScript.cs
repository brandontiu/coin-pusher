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
        printScore(initScore);
    }

    public void increaseScore(int n) {
        currentScore += n;
        printScore(currentScore);
    }

    public void decreaseScore(int n) {
        currentScore -= n;
        printScore(currentScore);
    }

    // a helper method to print generate a text representation
    private void printScore(int n) {
        scoreText.text = n.ToString();
    }
}

