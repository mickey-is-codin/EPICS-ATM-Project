using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PINInputControl : MonoBehaviour {

	public Text inputInstruction = null;
	public Text PINField = null;

	private string prompt = "Please input Personal Identification Number (1234), then push the 'Enter' button.";

	void Start()
	{
		inputInstruction.text = prompt;
	}

	void Update()
	{
		
	}
}
