using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCalculator : MonoBehaviour {

	public int counter;
	public TextMesh totalMonsters;

	void Start () {
		counter = 0;
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void totalCount() {
		counter = counter + 1;
		totalMonsters.text = counter.ToString ();
		Debug.Log ("Monster collected:" + counter);
	}
}
