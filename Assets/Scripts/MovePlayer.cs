﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

	private int _boost = 1;
    private Actions _actions;
    private bool _IsRunning = false;

    // Use this for initialization
    void Awake()
    {
        _actions = GetComponent<Actions>();
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            _boost = 5;
            _IsRunning = true;
        }
        else
        {
            _boost = 1;
            _IsRunning = false;
            _actions.Stay();
        }

        if (Input.GetKey (KeyCode.W))
        {
            gameObject.transform.Translate(0, 0, 1 * Time.deltaTime * _boost);

            if(_IsRunning)
                _actions.Run();
            else
                _actions.Walk();
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(0, 0, -1 * Time.deltaTime * _boost);

            if (_IsRunning)
                _actions.Run();
            else
                _actions.Walk();
        }

		if(Input.GetKey(KeyCode.A))
			gameObject.transform.Rotate (0, -50* Time.deltaTime * _boost, 0);

		if(Input.GetKey(KeyCode.D))
			gameObject.transform.Rotate (0, 50 * Time.deltaTime * _boost, 0);


		if(Input.GetKeyUp(KeyCode.Space))
			gameObject.transform.Translate (0, -100 * Time.deltaTime, 0);

		if(Input.GetKeyDown(KeyCode.Space))
			gameObject.transform.Translate (0, 100 * Time.deltaTime, 0);




    }
}
