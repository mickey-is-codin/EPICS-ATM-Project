using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardToScreen : MonoBehaviour 
{
	public Collider cardCollider;
	public string loadLevel = "PINEnter";

	void OnTriggerEnter(Collider collider)
	{
		if (collider == cardCollider) 
		{
			Debug.Log ("Card entered trigger");
			StartCoroutine (ChangeLevel ());
		} 
	}

	IEnumerator ChangeLevel ()
	{
		float fadeTime = GameObject.Find("PathFollower").GetComponent<Fade>().BeginFade(1);
		yield return new WaitForSeconds (fadeTime);
		UnityEngine.SceneManagement.SceneManager.LoadScene (loadLevel);
	}
		
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
