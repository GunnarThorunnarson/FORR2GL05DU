using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
	// hraði eftir keyboard
	public float speed = 10.0F;

    void Start(){

     // ekki sýna mouse cursor á skjá, stay inside game window
     // ef þú vilt vinna með mús í editor kveikja
     Cursor.lockState = CursorLockMode.Locked;   
    }

    // Stjórna characater 
    void Update() {

    	// Vertical og Horizontal gildin koma úr Unity (global setting sem hægt er að tengja við lyklaborðssipanir)
    	// Sjá Edit > Project Settings -> Input > Axes t.d. Horizontal og Vertical
    	// Vertical (z-ás) fram og aftur hreyfing 
        float translation = Input.GetAxis("Vertical") * speed;

        // Horizontal (x-ás): hægri og vinstri hliðarhreyfing
        float straffe = Input.GetAxis("Horizontal") * speed;

        // deltaTime: Til að tryggja að fá mjúka hreyfingu í takt við update refresh rate (sem er mism ekki fasti).
        translation *= Time.deltaTime; 
        straffe *= Time.deltaTime;

        // push on the X and Z axis
        transform.Translate(straffe,0,translation);

        // til að fá mús aftur í default mode, t.d geta notað músina aftur í editor
        if(Input.GetKeyDown("escape"))
        	Cursor.lockState = CursorLockMode.None;
    }
}
