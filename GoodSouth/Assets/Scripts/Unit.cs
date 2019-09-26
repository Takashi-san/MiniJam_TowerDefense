using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {
	[SerializeField] Shooter_line _shooter;
	[SerializeField] float _shot_cd = 0;
	float _time_cd;

	[SerializeField] GameObject _target;

	void Start() {
		if (!_shooter) {
			Debug.Log("No Shooter assigned!");
		}

		_time_cd = Time.time;
	}

	void Update() {
		if (Time.time > _time_cd) {
			_time_cd = Time.time + _shot_cd;
			transform.LookAt(_target.transform.position);
			_shooter.Shoot(_target);
		}
	}
}
