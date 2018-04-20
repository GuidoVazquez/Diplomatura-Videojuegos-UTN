using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

	float _bulletSpeed = 0.5f;
	Vector3 _offset;
	Vector3 _maximumRange = new Vector3(0,0,1);

	void Awake()
	{
		_offset = transform.position;
	}

	// Update is called once per frame
	void Update () {

		transform.Translate (0, 0, _bulletSpeed * Time.deltaTime);

		if (transform.position.z >= _offset.z + _maximumRange.z) 
		{
			Destroy (gameObject);
		}

	}

}
