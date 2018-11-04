using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TURNY : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void Update () {
        transform.position += transform.rotation * new Vector3(0, 0, Input.GetAxis("Vertical") / 3);
        transform.Rotate(0, Input.GetAxis("Horizontal") * 10, 0);
    }
}
