using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetCard : MonoBehaviour {

	public Button resetButton;

	void Start()
	{
		Button btn = resetButton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log ("Reset Button Clicked");
		SceneManager.LoadScene ("InsertCard");
	}

}
