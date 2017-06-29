using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkandShoot : MonoBehaviour {
	
	public GameObject Dagger;
	public float shootingSpeed = 10;
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;

		if (Input.GetButtonDown ("Fire1")) {
			GameObject game = Instantiate (Dagger);
			game.transform.position = transform.position;
			Rigidbody rb = game.GetComponent<Rigidbody> ();
			Camera cam = GetComponentInChildren<Camera> ();
			rb.velocity = cam.transform.rotation * Vector3.forward * shootingSpeed;
				
		}
	}
}
