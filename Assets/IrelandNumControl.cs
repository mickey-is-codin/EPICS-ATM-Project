using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IrelandNumControl : MonoBehaviour {

	public Collider numTrig0 = null;
	public Collider numTrig1 = null;
	public Collider numTrig2 = null;
	public Collider numTrig3 = null;
	public Collider numTrig4 = null;
	public Collider numTrig5 = null;
	public Collider numTrig6 = null;
	public Collider numTrig7 = null;
	public Collider numTrig8 = null;
	public Collider numTrig9 = null;
	public Collider delete = null;
	public Collider enter = null;

	public Text NumTextUI = null;
	public Text errorDisplay = null;
	public Text message7 = null;

	private int withdrawAmount;

	public static bool buttonEnterPressed = false;

	void Start()
	{
		
	}

	void Update()
	{
		StartCoroutine (Looping ());
		StartCoroutine (wait4Enter ());
	}
		
	IEnumerator Looping()
	{
		while (!checkEnterState()) {
			if ((NumButton0Trigger.pressed0) && ((IrelandTripATMControl.inWithdraw) || (IrelandTripATMControl.inFastCash) || (IrelandTripATMControl.inDeposit))) {
				NumTextUI.text += "0";
				disableKeyPad ();
			} else if ((NumButton1Trigger.pressed1) && ((IrelandTripATMControl.inWithdraw) || (IrelandTripATMControl.inFastCash) || (IrelandTripATMControl.inDeposit))) {
				NumTextUI.text += "1";
				disableKeyPad ();
			} else if ((NumButton2Trigger.pressed2) && ((IrelandTripATMControl.inWithdraw) || (IrelandTripATMControl.inFastCash) || (IrelandTripATMControl.inDeposit))) {
				NumTextUI.text += "2";
				disableKeyPad ();
			} else if ((NumButton3Trigger.pressed3) && ((IrelandTripATMControl.inWithdraw) || (IrelandTripATMControl.inFastCash) || (IrelandTripATMControl.inDeposit))) {
				NumTextUI.text += "3";
				disableKeyPad ();
			} else if ((NumButton4Trigger.pressed4) && ((IrelandTripATMControl.inWithdraw) || (IrelandTripATMControl.inFastCash) || (IrelandTripATMControl.inDeposit))) {
				NumTextUI.text += "4";
				disableKeyPad ();
			} else if ((NumButton5Trigger.pressed5) && ((IrelandTripATMControl.inWithdraw) || (IrelandTripATMControl.inFastCash) || (IrelandTripATMControl.inDeposit))) {
				NumTextUI.text += "5";
				disableKeyPad ();
			} else if ((NumButton6Trigger.pressed6) && ((IrelandTripATMControl.inWithdraw) || (IrelandTripATMControl.inFastCash) || (IrelandTripATMControl.inDeposit))) {
				NumTextUI.text += "6";
				disableKeyPad ();
			} else if ((NumButton7Trigger.pressed7 && ((IrelandTripATMControl.inWithdraw) || (IrelandTripATMControl.inFastCash) || (IrelandTripATMControl.inDeposit)))) {
				NumTextUI.text += "7";
				disableKeyPad ();
			} else if ((NumButton8Trigger.pressed8) && ((IrelandTripATMControl.inWithdraw) || (IrelandTripATMControl.inFastCash) || (IrelandTripATMControl.inDeposit))) {
				NumTextUI.text += "8";
				disableKeyPad ();
			} else if ((NumButton9Trigger.pressed9) && ((IrelandTripATMControl.inWithdraw) || (IrelandTripATMControl.inFastCash) || (IrelandTripATMControl.inDeposit))) {
				NumTextUI.text += "9";
				disableKeyPad ();
			}

			StartCoroutine (wait4Enter ());

			yield return null;
		}

		StartCoroutine (ChangeLevel ());
	}

	private bool checkEnterState() //returns true if 8 is pressed
	{
		if (EnterTrigger.buttonIsPressed) {
			disableKeyPad ();

			buttonEnterPressed = true;

			withdrawAmount = int.Parse (NumTextUI.text);

			if ((withdrawAmount % 20) != 0) {
				NumTextUI.text = " ";
				message7.text = " ";
				errorDisplay.text = "Please input the withdraw amount in multiples of 20.";
			} else if (withdrawAmount > 500) {
				NumTextUI.text = " ";
				message7.text = " ";
				errorDisplay.text = "Insufficient funds";
				buttonEnterPressed = false;
			} else if ((withdrawAmount % 20 == 0) && (withdrawAmount < 500)) {
				//Output money
				StartCoroutine (ChangeLevel ());
			}

			Debug.Log ("Recognizing Enter pressed in checkEnterstate()");

			buttonEnterPressed = true;

		} else {
			buttonEnterPressed = false;
		}
		return(buttonEnterPressed);
	}

	IEnumerator wait4Enter()
	{
		yield return new WaitUntil (checkEnterState);
	}


	public void disableKeyPad()
	{
		numTrig0.enabled = false;
		numTrig1.enabled = false;
		numTrig2.enabled = false;
		numTrig3.enabled = false;
		numTrig4.enabled = false;
		numTrig5.enabled = false;
		numTrig6.enabled = false;
		numTrig7.enabled = false;
		numTrig8.enabled = false;
		numTrig9.enabled = false;
		enter.enabled = false;
		delete.enabled = false;

		StartCoroutine (buttonDelay ());

		numTrig0.enabled = true;
		numTrig1.enabled = true;
		numTrig2.enabled = true;
		numTrig3.enabled = true;
		numTrig4.enabled = true;
		numTrig5.enabled = true;
		numTrig6.enabled = true;
		numTrig7.enabled = true;
		numTrig8.enabled = true;
		numTrig9.enabled = true;
		enter.enabled = true;
		delete.enabled = true;
	}

	IEnumerator ChangeLevel()
	{
		float fadeTime = GameObject.Find("PathFollower").GetComponent<Fade>().BeginFade(1);
		yield return new WaitForSeconds (fadeTime);
	}

	IEnumerator buttonDelay()
	{
		yield return new WaitForSeconds (3);
	}
}
