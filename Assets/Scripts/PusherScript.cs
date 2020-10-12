using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PusherScript : MonoBehaviour {   
    public Vector3 initPosition;
    public Vector3 newPosition;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start() {
        // get the initial position and Rigidbody
        initPosition = this.transform.position;
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        // update the pushers position
        newPosition = new Vector3(initPosition.x, initPosition.y, 
            initPosition.z + Mathf.Sin(Time.time));

        // move the pusher to the new position 
        this.rb.MovePosition(newPosition);
    }
}
