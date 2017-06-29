using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDagger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (300, -300, 300) * Time.deltaTime);
	}
}
