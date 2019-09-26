using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_collision : MonoBehaviour {
	void OnCollisionEnter(Collision other) {
		if (other.gameObject.layer == 9) {
			Rigidbody rb = gameObject.GetComponent<Rigidbody>();
			//rb.velocity = Vector3.zero;
			rb.isKinematic = true;

			gameObject.GetComponent<Projectile_orientation>().Stop();
		}
	}
}
