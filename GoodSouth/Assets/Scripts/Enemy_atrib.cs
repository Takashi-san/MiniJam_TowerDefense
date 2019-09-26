using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_atrib : MonoBehaviour {
	[SerializeField] int _hp = 50;

	public void TakeDamage(int dmg) {
		if (dmg > 0) {
			_hp -= dmg;
		}

		if (_hp <= 0) {
			// death.
		}
	}
}
