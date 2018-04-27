using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMoving : MonoBehaviour {

    public Transform[] target;
    public float speed;
    public float timer;
    public float newTarget=45;

    private int current;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        if (timer >= newTarget) {
            current = (current + 1) % target.Length;
            timer = 0;

        }
              	
	}
}
