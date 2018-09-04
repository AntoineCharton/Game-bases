using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedYPosition : MonoBehaviour {
	float fixedPosition = 0;
	// Use this for initialization
	void Awake () {
		fixedPosition = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x, fixedPosition, transform.position.z);
	}
}
