﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ClickToStart : MonoBehaviour {

	public string scene;
	private bool loadLock;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && !loadLock)
			loadScene ();
	}

	void loadScene(){
		loadLock = true;
		SceneManager.LoadScene (scene);
	}
}
