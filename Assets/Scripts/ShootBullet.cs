using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour {

	public GameObject Bullet;
	GameObject _player;

	Actions _actions;
	float _timeToStartShooting = 0.2f;
    float _time = 0.0f;
    float _nextFire = 0.5f;

    void Awake()
	{
		
		_player = GameObject.FindGameObjectWithTag ("Player");
		_actions = _player.GetComponent<Actions>();
	}

	void Update()
	{
		_time += Time.deltaTime;

		if (Input.GetButton ("Fire1") && _time > _nextFire) 
		{
			_actions.Aiming ();
			Invoke ("Shoot", _timeToStartShooting);
			_time = 0.0f;

		}
	}

	void Shoot()
	{
		Instantiate (Bullet, transform.position, transform.rotation);
	}
}
