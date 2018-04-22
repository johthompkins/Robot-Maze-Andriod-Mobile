using UnityEngine;

public class ClickWalk : MonoBehaviour {
    //speed of moving forawrd
    public float speed = 1.0f;
    // should i move forward?
    public bool moveForward;
    // controller script
    private CharacterController controller;
    // script   
    public Camera camera;
    //head
    private Transform vrhead;



    void Start()
    {
        controller = GetComponent<CharacterController>();
        camera = transform.GetChild(0).GetComponent<Camera>();
        vrhead = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //if i press my VR button(screen) 
        if(Input.GetButton("Fire1"))
        {
            // change state to moveforward
            moveForward = !moveForward;
        }

        if(moveForward)
        {
            //find forward dirtetion
            Vector3 forward = vrhead.TransformDirection(Vector3.forward);
            //tell char controller to mvoe forward
            controller.SimpleMove(forward * speed);
        }
    }
}
