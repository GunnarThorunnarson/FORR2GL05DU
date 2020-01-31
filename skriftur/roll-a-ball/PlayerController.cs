using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// MonoBehaviour is the base class from which every Unity script derives.
public class PlayerController : MonoBehaviour
{
    // public variables will show in our Inspector as an editable property.
    // to control speed on player
    public float speed;

    // To access the Rigidbody component in our game object from this script create variable of type Rigidbody to hold this reference.
    private Rigidbody rb;

	// Start is called before the first frame update
    void Start(){
        // Debug.Log("I am alive!");

		// rb holds attached reference to Rigidbody component if there is one.
    	rb = GetComponent<Rigidbody>();  
    }

    // Most of game code. Update is called once per frame, before render
    void Update(){
        
    }

    // Physics code. Called before physics calculation. 
    void FixedUpdate() {

    	// Grab Input from the player via keyboard
    	float moveHorizontal = Input.GetAxis("Horizontal");
    	float moveVertical = Input.GetAxis("Vertical");

    	// Game player object uses a rigidbody and interacts with the physics engine
    	// Use the input to add force to the rigidbody and move the player object
    	
    	// Vector3(x,y,z);
    	Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
    	rb.AddForce(movement * speed); 
    }
    // þegar object snertir fyrst trigger collider
    // other er reference á það sem er snert.
    void OnTriggerEnter(Collider other){
        // we are given a reference to our collider (other)
        // if its tag is the same as string value. then deactivate that game object
        if (other.gameObject.CompareTag ("PickUp")){
            other.gameObject.SetActive (false);
        }
    }
    // Destroy(other.gameObject);

}
