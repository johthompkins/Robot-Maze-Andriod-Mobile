using UnityEngine;
using System.Collections;

public class RandomMove : MonoBehaviour {
    public float timer;
    public float speed;
    public int newtarget;
    public NavMeshAgent nav;
    public Vector3 Target;


	// Use this for initialization
	void Start () {

        nav = gameObject.GetComponent<NavMeshAgent>();
	}

  

	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;
        if(timer >= newtarget)
        {
            newTarget();
            timer = 0;
        }
	}

    void newTarget()
    {
        float myX = gameObject.transform.position.x;
        float myZ = gameObject.transform.position.z;

        float xPos = myX + 8000;
        float zPos = myZ + Random.Range(myZ - 100, myZ + 100);

        Target = new Vector3(xPos, gameObject.transform.position.y, zPos);
        nav.SetDestination(Target);
    }
}
