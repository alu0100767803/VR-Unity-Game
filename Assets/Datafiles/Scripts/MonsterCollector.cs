using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCollector : MonoBehaviour {

	MonsterCalculator mcalc;

	void Start () {
		mcalc = FindObjectOfType<MonsterCalculator>();
	}

	public void OnTriggerEnter(Collider collide) {

        if (collide.gameObject.CompareTag ("Enemy"))
        {
            Destroy(collide.gameObject);
            Destroy(gameObject);
            mcalc.totalCount();
        }


    }

    void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag ("ground")) {
			Destroy (gameObject);
		}
	}
}
