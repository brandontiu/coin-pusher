using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayoutScript : MonoBehaviour {

    // destroys anything that comes into contact with it
    // and increases the user's score by 1 
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Coin") {
            Destroy(collision.gameObject);
        }
    }
}

    
