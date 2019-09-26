using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_collision : MonoBehaviour {
	void OnCollisionEnter(Collision other) {
		gameObject.GetComponent<Rigidbody>().isKinematic = true;
		gameObject.GetComponent<Projectile_orientation>().Stop();
		gameObject.GetComponent<Collider>().enabled = false;
	}
}
