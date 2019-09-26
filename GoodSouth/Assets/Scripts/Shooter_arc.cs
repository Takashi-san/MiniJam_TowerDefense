using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter_arc : MonoBehaviour {
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
			Vector3 offset = target.transform.position - transform.position;
			float target_t = new Vector2(offset.x, offset.z).magnitude / _speed;
			float speed_y = (offset.y / target_t) - ((-9.81f) * target_t / 2);

			rb.useGravity = true;
			rb.AddRelativeForce((Vector3.forward * _speed) + (Vector3.up * speed_y), ForceMode.VelocityChange);
		}
		else {
			Debug.Log("Projectile doesn't have a RigidBody!");
		}
	}
}
