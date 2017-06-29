using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMonsters : MonoBehaviour {

	public GameObject[] monsters;

	void Start () {
		for (int i = 0; i < Random.Range(200, 300) ; i++) {
			monsterCount ();
		}
	}
	
	void Update () {
		
	}

	void monsterCount() {
		int monsterIndex = Random.Range (0, monsters.Length);
		GameObject rmonster = Instantiate (monsters [monsterIndex]);
		rmonster.transform.parent = transform;
		rmonster.transform.localPosition = new Vector3 (Random.Range(-95,95), 0.0f,Random.Range(-95,95));
	}
}
