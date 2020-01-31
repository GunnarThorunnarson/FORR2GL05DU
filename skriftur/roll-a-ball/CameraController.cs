using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	// reference to player. Við viljum tengja myndvél við game player
	public GameObject player;

	// offset value
	private Vector3 offset;

    // Use this for initialization
    // Start is called before the first frame update (before render)
    void Start(){
          // offset = Distance from player and camera objects (x,y,z values)
          offset = transform.position - player.transform.position;
    }

    // LateUpdate runs every frame,like Update 
    // Guaranted to run after all items has processed in Update
    // For follow camera, presudural animation, and gathering last know states
    // When we set the position of the camera, we know absolutly that the player has moved for that frame.
    void LateUpdate(){
          
        // Camera location is moved (updated) to a new position, aligned with the player object
        // Camera follows without rotating around game object.
        transform.position = player.transform.position + offset;
    }
}
