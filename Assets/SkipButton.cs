using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SkipButton : MonoBehaviour {

	public Button skipButton;

	void Start()
	{
		Button btn = skipButton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log ("Skip Button Clicked");
		SceneManager.LoadScene ("InsertCard");
	}

}
