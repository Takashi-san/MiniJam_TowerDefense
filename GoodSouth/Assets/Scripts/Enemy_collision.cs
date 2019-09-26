using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_collision : MonoBehaviour {
	Enemy_atrib _atrib;

	void Start() {
		_atrib = gameObject.GetComponent<Enemy_atrib>();
		if (!_atrib) {
			Debug.Log("Enemy without atributes!");
		}
	}

	void OnCollisionEnter(Collision other) {
		Projectile_atrib projectile = other.gameObject.GetComponent<Projectile_atrib>();
		if (projectile) {
			_atrib.TakeDamage(projectile.Dmg);
			projectile.gameObject.transform.SetParent(transform);
		}
	}
}
