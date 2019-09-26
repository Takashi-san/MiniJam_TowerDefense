using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {
	[SerializeField] Shooter_arc _shooter_arc;
	[SerializeField] float _shot_cd = 0;
	float _time_cd;

	[SerializeField] GameObject _target;

	void Start() {
		_time_cd = 0;
	}

	void Update() {
		_time_cd += Time.deltaTime;
		if (_shot_cd < _time_cd) {
			_time_cd = 0;

			transform.LookAt(new Vector3(_target.transform.position.x, transform.position.y, _target.transform.position.z));
			_shooter_arc.Shoot(_target);
		}
	}
}
