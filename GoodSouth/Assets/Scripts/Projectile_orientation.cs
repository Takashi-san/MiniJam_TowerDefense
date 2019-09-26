using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_orientation : MonoBehaviour {
	Rigidbody _rb;

	void Start() {
		_rb = gameObject.GetComponent<Rigidbody>();
		if (!_rb) {
			Debug.Log("No Rigidbody assigned!");
		}
	}

	void FixedUpdate() {
		Vector3 rot = -90 * _rb.velocity.normalized.y * Vector3.right + transform.rotation.eulerAngles.y * Vector3.up;
		_rb.MoveRotation(Quaternion.Euler(rot));
	}

	public void Stop() {
		this.enabled = false;
	}
}
