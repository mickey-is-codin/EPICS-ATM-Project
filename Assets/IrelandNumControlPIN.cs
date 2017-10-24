using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IrelandNumControlPIN : MonoBehaviour {

	public GameObject Num0Button = null;
	public GameObject Num1Button;
	public GameObject Num2Button;
	public GameObject Num3Button;
	public GameObject Num4Button;
	public GameObject Num5Button;
	public GameObject Num6Button;
	public GameObject Num7Button;
	public GameObject Num8Button;
	public GameObject Num9Button;
	public GameObject EnterButton;
	public GameObject DeleteButton;

	private Collider numTrigPIN0;
	private Collider numTrigPIN1;
	private Collider numTrigPIN2;
	private Collider numTrigPIN3;
	private Collider numTrigPIN4;
	private Collider numTrigPIN5;
	private Collider numTrigPIN6;
	private Collider numTrigPIN7;
	private Collider numTrigPIN8;
	private Collider numTrigPIN9;
	private Collider PINDelete;
	private Collider PINEnter;

	public Text PINTextUI = null;
	public Text inputInstruction = null;

	private int pinValue;

	public static bool buttonEnterPressed = false;

	void Start()
	{
		inputInstruction.text = "Please input Personal Identification Number (1234), then push the 'Enter' button.";
		numTrigPIN0 = GetComponent<BoxCollider>();
		numTrigPIN1 = GetComponent<BoxCollider>();
		numTrigPIN2 = GetComponent<BoxCollider>();
		numTrigPIN3 = GetComponent<BoxCollider>();
		numTrigPIN4 = GetComponent<BoxCollider>();
		numTrigPIN5 = GetComponent<BoxCollider>();
		numTrigPIN6 = GetComponent<BoxCollider>();
		numTrigPIN7 = GetComponent<BoxCollider>();
		numTrigPIN8 = GetComponent<BoxCollider>();
		numTrigPIN9 = GetComponent<BoxCollider>();
		PINDelete = GetComponent<BoxCollider>();
		PINEnter = GetComponent<BoxCollider>();
	}

	void Update()
	{
		StartCoroutine (Looping ());

		StartCoroutine (wait4Enter ());
	}

	IEnumerator Looping()
	{
		while (!checkEnterState()) {
			if (PIN0.numButtonPressed) {
				PINTextUI.text += "0";
				disableKeyPad ();
			} else if (PIN1.numButtonPressed) {
				disableKeyPad ();
				PINTextUI.text += "1";
			} else if (PIN2.numButtonPressed) {
				disableKeyPad ();
				PINTextUI.text += "2";
			} else if (PIN3.numButtonPressed) {
				disableKeyPad ();
				PINTextUI.text += "3";
			} else if (PIN4.numButtonPressed) {
				disableKeyPad ();
				PINTextUI.text += "4";
			} else if (PIN5.numButtonPressed) {
				disableKeyPad ();
				PINTextUI.text += "5";
			} else if (PIN6.numButtonPressed) {
				disableKeyPad ();
				PINTextUI.text += "6";
			} else if (PIN7.numButtonPressed) {
				disableKeyPad ();
				PINTextUI.text += "7";
			} else if (PIN8.numButtonPressed) {
				disableKeyPad ();
				PINTextUI.text += "8";
			} else if (PIN9.numButtonPressed) {
				disableKeyPad ();
				PINTextUI.text += "9";
			}

			StartCoroutine (wait4Enter ());

			yield return null;
		}
		yield return null;
	}

	private bool checkEnterState() //returns true if 8 is pressed
	{
		if (EnterTriggerPIN.buttonIsPressed) {
			buttonEnterPressed = true;

			disableKeyPad ();
			pinValue = int.Parse (PINTextUI.text);
			if (pinValue == 1234) {
				inputInstruction.text = "Great Job!";
				StartCoroutine (ChangeLevel ());
			} else if (pinValue != 1234) {
				PINTextUI.text = null;
				inputInstruction.text = "Please try again, your PIN is 1234.";
			}

			Debug.Log ("Recognizing Enter pressed in checkEnterstate()");

			StartCoroutine (ChangeLevel ());

			//Still need to: finish disabling buttons, get enter to change the scene,

		} else {
			buttonEnterPressed = false;
		}
		return(buttonEnterPressed);
	}

	IEnumerator wait4Enter()
	{
		yield return new WaitUntil (checkEnterState);
	}

	IEnumerator ChangeLevel()
	{
		float fadeTime = GameObject.Find("PathFollower").GetComponent<Fade>().BeginFade(1);
		yield return new WaitForSeconds (fadeTime);
		SceneManager.LoadScene ("ScreenAccess");
	}

	public void disableKeyPad()
	{
		numTrigPIN0.enabled = false;
		numTrigPIN1.enabled = false;
		numTrigPIN2.enabled = false;
		numTrigPIN3.enabled = false;
		numTrigPIN4.enabled = false;
		numTrigPIN5.enabled = false;
		numTrigPIN6.enabled = false;
		numTrigPIN7.enabled = false;
		numTrigPIN8.enabled = false;
		numTrigPIN9.enabled = false;
		PINEnter.enabled = false;
		PINDelete.enabled = false;

		StartCoroutine (buttonDelay ());

		numTrigPIN0.enabled = true;
		numTrigPIN1.enabled = true;
		numTrigPIN2.enabled = true;
		numTrigPIN3.enabled = true;
		numTrigPIN4.enabled = true;
		numTrigPIN5.enabled = true;
		numTrigPIN6.enabled = true;
		numTrigPIN7.enabled = true;
		numTrigPIN8.enabled = true;
		numTrigPIN9.enabled = true;
		PINEnter.enabled = true;
		PINDelete.enabled = true;
	}

	IEnumerator buttonDelay()
	{
		yield return new WaitForSeconds (3);
	}
}
