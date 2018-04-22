using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDestory : MonoBehaviour {

	void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "wall")
        {
            Destroy(col.collider);
           
        }
    }
}
