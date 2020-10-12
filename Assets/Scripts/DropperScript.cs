using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperScript : MonoBehaviour {
    public Rigidbody rb;
    public float moveSpeed = 2.0f;
    public GameObject coin;
    public GameObject leftwall;
    private float leftWallXcoord;
    public GameObject rightwall;
    private float rightWallXcoord;
    public GameObject scoreText;
    private ScoreScript ss;

    // Start is called before the first frame update
    void Start() {
        // get the Rigidbody and the coords for the walls
        rb = this.GetComponent<Rigidbody>();
        leftWallXcoord = leftwall.transform.position.x;
        rightWallXcoord = rightwall.transform.position.x;

        // get the score script from the scoreText object
        ss = scoreText.GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update() {
        // restrict the dropper to be between the two walls
        Vector3 currentPosition = this.transform.position;
        currentPosition.x = Mathf.Clamp(currentPosition.x, 
            leftWallXcoord, rightWallXcoord);
        this.transform.position = currentPosition;

        // get the position of the input on the x-axis and
        // turn it into a vector
        float x = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(x, 0, 0);

        // define the velocity of movement
        rb.velocity = direction * moveSpeed;

        // if user wants to drop a coin, create a coin and decrease
        // the user's score by 1
        if (Input.GetKeyDown("space")) {
            Instantiate(coin, this.transform.position, this.transform.rotation);
            ss.decreaseScore(1);
        }
    }
}
