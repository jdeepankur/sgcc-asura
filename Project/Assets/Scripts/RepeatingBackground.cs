using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {
	public float speed = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.x -= speed*Time.deltaTime * GameController.speedModifier;
		if (transform.position.x < -5f) {
			pos.x += 13f;
		}
		transform.position = pos;
	}

}
