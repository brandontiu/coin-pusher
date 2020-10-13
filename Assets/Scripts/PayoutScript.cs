using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayoutScript : MonoBehaviour {
    public GameObject scoreText;
    private ScoreScript ss;

    void Start() {
        ss = scoreText.GetComponent<ScoreScript>();
    }

    // destroys anything that comes into contact with it
    // and increases the user's score by 1 
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Coin") {
            Destroy(collision.gameObject);
            ss.increaseScore(1);
        }
    }
}

    
