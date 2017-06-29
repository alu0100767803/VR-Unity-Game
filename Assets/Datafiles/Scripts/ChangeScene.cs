using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public void loadPlay() {
		SceneManager.LoadScene ("PlayScene");		
	}

	public void quitGame() {
		Application.Quit ();
		Debug.Log ("quit button");
	}
}
