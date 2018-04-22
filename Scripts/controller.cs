using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {

    private Vector3 spawnPoint;
    // private bool walking = false;

    // Use this for initialization
    public float speed = 2f;
    public float sensitivity = 2f;
    public GameObject eyes;

    CharacterController player;
    float moveFB;
    float moveLR;

    float rotX;
    float rotY;

	void Start () {
        spawnPoint = transform.position;
        player = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        moveFB = Input.GetAxis("Vertical") * speed;
        moveLR = Input.GetAxis("Horizontal") * speed;

        rotX = Input.GetAxis("Mouse X") * sensitivity;
        rotY -= Input.GetAxis("Mouse Y") * sensitivity;

        Vector3 movement = new Vector3(moveLR, 0, moveFB);
        transform.Rotate(0, rotX, 0);
        eyes.transform.Rotate(rotY,0,0);

        movement = transform.rotation * movement;
        player.Move(movement * Time.deltaTime);


       if(transform.position.y < -10f)
         {
           transform.position = spawnPoint;
         }



   //     Debug.Log("hi");
    //    if (walking = true){
//
     //       transform.position = transform.position + Camera.main.transform.forward * .5f * Time.deltaTime;
    //        Debug.Log(Camera.main.transform.forward);
       // }

      



     //   Ray ray = Camera.main.ViewportPointToRay(new Vector3(.5f, .5f, 0));
     //   RaycastHit hit;

      //  if(Physics.Raycast(ray, out hit)) {

       //     if (hit.collider.name.Contains("plane"))
      //      {
       //         walking = false;
       //     }
    //
       //     else walking = true;
      //  }
          
        
 
	}
}
