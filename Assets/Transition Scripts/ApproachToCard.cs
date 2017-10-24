using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApproachToCard : MonoBehaviour 
{
	public Collider playercollider;

	void OnTriggerEnter(Collider collider)
	{
		Debug.Log ("Trigger Entered");
		StartCoroutine (ChangeLevel());
		//SceneManager.LoadScene ("InsertCard");

	}

	IEnumerator ChangeLevel()
	{
		Debug.Log ("ChangeLevel Referenced");

		float fadeTime = GameObject.Find ("PathFollower").GetComponent<Fade> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);
		SceneManager.LoadScene ("PINEnter");
	}
	
	// Update is called once per frame
	void Update () {
	}
}
