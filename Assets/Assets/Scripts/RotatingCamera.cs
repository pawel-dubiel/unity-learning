using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCamera : MonoBehaviour {

	public float speed = 50;

	void FixedUpdate() {
		transform.RotateAround( Input.mousePosition, Input.mousePosition, speed * Mathf.Sin( Time.fixedDeltaTime) * Mathf.Cos( Time.fixedDeltaTime) );
	}
}
