using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Explode : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Deadly")
			OnExplode ();
	}

	void OnExplode(){
		Destroy (gameObject);

		GameObject go = new GameObject ("ClickToStart");
		ClickToStart script = go.AddComponent<ClickToStart> ();
		SceneManager.LoadScene ("Preparation");
		go.AddComponent<RestartText> ();
	}
}
