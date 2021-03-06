﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu: MonoBehaviour {
	public int hudMenuIndex;
	public GameObject roomManager;
	
	public void OnRetryPressed() {
		Time.timeScale = 1f;
		roomManager.GetComponent<RoomManager>().Restart();
		gameObject.GetComponentInParent<LiteMenuManager>().OpenMenu(
			hudMenuIndex,
			true
		);
	}

	public void OnQuitPressed()	{
		Debug.Log("Quit button pressed!! Load scene script required!");
		//SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		SceneManager.LoadScene(0, LoadSceneMode.Single);
	}
}
