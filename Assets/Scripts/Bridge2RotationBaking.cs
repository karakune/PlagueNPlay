﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bridge2RotationBaking : MonoBehaviour {

	private NavMeshObstacle obstacle;
	private float rotation;


	// Use this for initialization
	void Start () {
		obstacle = GetComponent<NavMeshObstacle> ();
		rotation = 0;

	}

	// Update is called once per frame


	void OnTriggerEnter(Collider other){
		Debug.Log (other.tag);	
		if (other.tag == "Possessable") {
			
			rotation += 90;
			GetComponentInParent<Transform>().eulerAngles =  new Vector3 (-90,rotation , 0);
			if (rotation == 360) {
				rotation = 0;
			}
		}
	}
}
