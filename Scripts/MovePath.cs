using UnityEngine;
using System.Collections;

public class MovePath : MonoBehaviour {

    public Transform[] path;
    public float speed = 2.0f;
    public float reachDist = 1.0f;
    public int currentPoint=0;
    public float timer;
    public int newtarget;


    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= newtarget)
        { 
            Vector3 dir = path[currentPoint].position - transform.position;
            transform.position += dir * Time.deltaTime * speed;
            if (dir.magnitude <= reachDist)
            {
                currentPoint++;
                timer = 0;
            }
            if (currentPoint >= path.Length)
            {
                 currentPoint = 0;
            }
        }
	}

    void onDrawGizmos()
    {
        if(path.Length > 0)
        {
            for(int i=0; i < path.Length;  i++)
            {
                if(path[i] != null)
                {
                    Gizmos.DrawSphere(path[i].position, reachDist);

                }
            }
        }
    }
}
