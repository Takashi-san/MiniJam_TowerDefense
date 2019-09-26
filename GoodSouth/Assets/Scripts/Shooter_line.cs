using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter_line : MonoBehaviour {
	[SerializeField] GameObject _projectile;
	[SerializeField] float _speed = 0;

	void Start() {
		if (!_projectile) {
			Debug.Log("No projectile assigned to the shooter!");
		}
	}

	public void Shoot(GameObject target) {
		GameObject projectile = Instantiate(_projectile, transform.position, transform.rotation);
		Rigidbody rb = projectile.GetComponent<Rigidbody>();

		if (rb) {
			rb.AddRelativeForce(Vector3.forward * _speed, ForceMode.VelocityChange);
		}
		else {
			Debug.Log("Projectile doesn't have a RigidBody!");
		}
	}
}
