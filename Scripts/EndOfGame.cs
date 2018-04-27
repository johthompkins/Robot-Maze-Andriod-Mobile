using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndOfGame : MonoBehaviour {

    float target = 25.5f;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x >= target)
        {
            SceneManager.LoadScene(3);
        }
	}
}
