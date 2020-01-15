using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {
	public float moveSpeed = 10f;
	private Rigidbody rbody;
	void Start () {
		rbody=GetComponent<Rigidbody>();
	}

	void Update () {

		float inputX = Input.GetAxis("Horizontal");
		float inputZ = Input.GetAxis("Vertical");

		float moveX = inputX*moveSpeed*Time.deltaTime;
		float moveZ = inputZ*moveSpeed*Time.deltaTime;

		rbody.AddForce(moveX,0f,moveZ);


	}
}



