/*
 * Author : Eddie Huang 
 * Date : 17 July 2018 
 * PlayerController Script Version 1.0 
 * 
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerController : MonoBehaviour {
    [SerializeField]
    public float playerSpeed = 10.0f; 
    [SerializeField]
    public float playerOriginalSpeed = 10f;// the original player speed 
    [SerializeField]
    public float playerRunSpeed = 1.1f;
    private Rigidbody playerRB;  
    private float moveInX;     // this is the player to move in x axis 
    private float moveInZ;  // 
    private Camera cameraPosition; // this is to get the main camera rotation from fps 
    public static double latitude;
    public static double longitude;
    
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerOriginalSpeed = playerSpeed;
        cameraPosition = this.gameObject.GetComponentInChildren<Camera>();
        Renderer rend = GetComponent<Renderer>();
        rend.material.color = Random.ColorHSV();
        latitude = 42.30508581367254;
        longitude = -83.06436567994649;


    }
	
	// FixedUpdate is to move our player consistently 
	void Update () {
         


        moveInX = Input.GetAxis ("Horizontal");
        moveInZ = Input.GetAxis ("Vertical");
        // get axis and y axis on the controller to move 
        if (moveInX != 0 || moveInZ != 0)
        {
            latitude += moveInX / 100000;
            longitude += moveInZ / 100000;
            Debug.Log(latitude);
            Debug.Log(longitude);
        }
    
         


       // Debug.Log (cameraPosition.transform.rotation);
          Vector3 movement = new Vector3 (moveInX, 0.0f, moveInZ); // this is to move the player in the corresponding position 
        if (Input.GetButton ("Fire2")) {        // this is to make the player to run 
            
            movement *= playerRunSpeed;
        } 
         
        // to give the camera rotation 
        playerRB.AddForce(cameraPosition.transform.rotation * movement * playerSpeed);
        // this is to add the force to the rigid body instead of using the translate or transform position ethod 
         
       




         
        
	}
}
