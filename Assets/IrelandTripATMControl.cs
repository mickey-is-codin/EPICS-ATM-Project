using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IrelandTripATMControl : MonoBehaviour {

	//STILL CANT SELECT AN OPTION AFTER PUSHING BACK!!!

	public static bool inPreferences = false;
	public static bool inCashCheck = false;
	public static bool inBalance = false;
	public static bool inStatements = false;
	public static bool inWithdraw = false;
	public static bool inDeposit = false;
	public static bool inFastCash = false;

	public Collider buttonCollider = null;
	public static bool button8Pressed = false;
	public Collider indexTip = null;

	public Image screen = null;

	public Sprite nobuttons = null;
	public Sprite buttons = null;

	public static int control = 0;

	public static bool leave = false;

	public Text Button1TextUI;
	public Text Button2TextUI;
	public Text Button3TextUI;
	public Text Button4TextUI;
	public Text Button5TextUI;
	public Text Button6TextUI;
	public Text Button7TextUI;
	public Text Button8TextUI;

	public Text Message1Text;
	public Text Message2Text;
	public Text Message3Text;
	public Text Message4Text;
	public Text Message5Text;
	public Text Message6Text;
	public Text Message7Text;
	public Text MessageMain;
	public Text MessageEnter;

	void Start()
	{
		screen.sprite = buttons;
		Button1TextUI.text = "Preferences";
		Button2TextUI.text = "Cash Check";
		Button3TextUI.text = "Balance";
		Button4TextUI.text = "Statements";
		Button5TextUI.text = "Withdraw";
		Button6TextUI.text = "Deposit";
		Button7TextUI.text = "Fast Cash";
		Button8TextUI.text = "Back";
		Message1Text.text = " ";
		Message2Text.text = " ";
		Message3Text.text = " ";
		Message4Text.text = " ";
		Message5Text.text = " ";
		Message6Text.text = " ";
		Message7Text.text = " ";
		MessageEnter.text = " ";

	}

	void Update()
	{
		checkTree();
	}

	public void allButtonsBlank()
	{
		Button1TextUI.text = " ";
		Button2TextUI.text = " ";
		Button3TextUI.text = " ";
		Button4TextUI.text = " ";
		Button5TextUI.text = " ";
		Button6TextUI.text = " ";
		Button7TextUI.text = " ";
		Button8TextUI.text = "Back";
	}
		

	private bool check8State() //returns true if 8 is pressed
	{
		//Debug.Log ("Checking 8 State");
		if (Button8Trigger.pressedScreen8) {
			button8Pressed = true;

			Debug.Log ("Recognizing 8 pressed in check8state()");

			inPreferences = false;
			inCashCheck = false;
			inBalance = false;
			inStatements = false;
			inWithdraw = false;
			inDeposit = false;
			inFastCash = false;

			Button1Trigger.buttonCount1 = 0;
			Button2Trigger.buttonCount2 = 0;
			Button3Trigger.buttonCount3 = 0;
			Button4Trigger.buttonCount4 = 0;
			Button5Trigger.buttonCount5 = 0;
			Button6Trigger.buttonCount6 = 0;
			Button7Trigger.buttonCount7 = 0;
			Button8Trigger.buttonCount8 = 0;

			//SceneManager.LoadScene ("ScreenAccess");

			//Start ();
		} else {
			button8Pressed = false;
		}
		return(button8Pressed);
	}

	IEnumerator wait48()
	{
		yield return new WaitUntil (check8State);
	}

	IEnumerator ChangeLevel()
	{
		float fadeTime = GameObject.Find("PathFollower").GetComponent<Fade>().BeginFade(1);
		yield return new WaitForSeconds (fadeTime);
		SceneManager.LoadScene ("ScreenAccess");
	}
		
	void checkTree()
	{
		if ((Button1Trigger.pressedScreen1) && (Button1Trigger.buttonCount1 == 1) && (!inPreferences) && (!inCashCheck) && (!inBalance) && (!inStatements) && (!inWithdraw) && (!inDeposit) && (!inFastCash)) {
			inPreferences = true;
			//Debug.Log ("In Preferences Bool");
		} else if ((Button2Trigger.pressedScreen2) && (Button2Trigger.buttonCount2 == 1) && (!inPreferences) && (!inCashCheck) && (!inBalance) && (!inStatements) && (!inWithdraw) && (!inDeposit) && (!inFastCash)) {
			inCashCheck = true;
			//Debug.Log ("In Cash Check Bool");
		} else if ((Button3Trigger.pressedScreen3) && (Button3Trigger.buttonCount3 == 1) && (!inPreferences) && (!inCashCheck) && (!inBalance) && (!inStatements) && (!inWithdraw) && (!inDeposit) && (!inFastCash)) {
			inBalance = true;
			//Debug.Log ("In Balance Bool");
		} else if ((Button4Trigger.pressedScreen4) && (Button4Trigger.buttonCount4 == 1) && (!inPreferences) && (!inCashCheck) && (!inBalance) && (!inStatements) && (!inWithdraw) && (!inDeposit) && (!inFastCash)) {
			inStatements = true;
			//Debug.Log ("In Statements Bool");
		} else if ((Button5Trigger.pressedScreen5) && (Button5Trigger.buttonCount5 == 1) && (!inPreferences) && (!inCashCheck) && (!inBalance) && (!inStatements) && (!inWithdraw) && (!inDeposit) && (!inFastCash)) {
			inWithdraw = true;
			//Debug.Log ("In Withdraw Bool");
		} else if ((Button6Trigger.pressedScreen6) && (Button6Trigger.buttonCount6 == 1) && (!inPreferences) && (!inCashCheck) && (!inBalance) && (!inStatements) && (!inWithdraw) && (!inDeposit) && (!inFastCash)) {
			inDeposit = true;
			//Debug.Log ("In Deposit Bool");
		} else if ((Button7Trigger.pressedScreen7) && (Button7Trigger.buttonCount7 == 1) && (!inPreferences) && (!inCashCheck) && (!inBalance) && (!inStatements) && (!inWithdraw) && (!inDeposit) && (!inFastCash)) {
			inFastCash = true;
			//Debug.Log ("In Fast Cash Bool");
		} else if (Button8Trigger.pressedScreen8) {
			inPreferences = false;
			inCashCheck = false;
			inBalance = false;
			inStatements = false;
			inWithdraw = false;
			inDeposit = false;
			inFastCash = false;

			leave = true;

			screen.sprite = buttons;
			Button1TextUI.text = "Preferences";
			Button2TextUI.text = "Cash Check";
			Button3TextUI.text = "Balance";
			Button4TextUI.text = "Statements";
			Button5TextUI.text = "Withdraw";
			Button6TextUI.text = "Deposit";
			Button7TextUI.text = "Fast Cash";
			Button8TextUI.text = "Back";
			Message1Text.text = " ";
			Message2Text.text = " ";
			Message3Text.text = " ";
			Message4Text.text = " ";
			Message5Text.text = " ";
			Message6Text.text = " ";
			Message7Text.text = " ";
			MessageEnter.text = " ";
		}

		StartCoroutine(Looping ());
		return;
	}

	IEnumerator Looping()
	{
		//Debug.Log ("In Looping");
		while ((!check8State()) && (inPreferences)) {
			//Debug.Log ("In Preferences Loop");

			Button1Trigger.pressedScreen1 = false;

			screen.sprite = buttons;
			Button1TextUI.text = "Language";
			Button2TextUI.text = "Hand Model";
			Button3TextUI.text = "Currency Type";
			Button4TextUI.text = "Hearing assistance";
			Button5TextUI.text = "Hand constraint";
			Button6TextUI.text = "Time";
			Button7TextUI.text = "Date";
			Button8TextUI.text = "Back";

			if ((Button1Trigger.buttonCount1==2) && (inPreferences)) {
				Button1TextUI.text = "English";
				Button2TextUI.text = "Gaeilge";
				Button3TextUI.text = "Espanol";
				Button4TextUI.text = "Francais";
				Button5TextUI.text = "Deutsche";
				Button6TextUI.text = "Magyarul";
				Button7TextUI.text = "Italiano";
			} else if ((Button2Trigger.pressedScreen2) && (inPreferences)) {
				
			} else if ((Button3Trigger.pressedScreen3) && (inPreferences)) {
				
			} else if ((Button4Trigger.pressedScreen4) && (inPreferences)) {
				
			} else if ((Button5Trigger.pressedScreen5) && (inPreferences)) {
				
			} else if ((Button6Trigger.pressedScreen6) && (inPreferences)) {
				
			} else if ((Button7Trigger.pressedScreen7) && (inPreferences)) {
				
			}

			StartCoroutine(wait48());

			Button8Trigger.pressedScreen8 = false;
				
			if (button8Pressed) {
				control++;
				Button1Trigger.pressedScreen1 = false;
				Button8Trigger.pressedScreen8 = false;
				Button8Trigger.buttonCount8 = 0;
				inPreferences = false;

				screen.sprite = buttons;
				Button1TextUI.text = "Preferences";
				Button2TextUI.text = "Cash Check";
				Button3TextUI.text = "Balance";
				Button4TextUI.text = "Statements";
				Button5TextUI.text = "Withdraw";
				Button6TextUI.text = "Deposit";
				Button7TextUI.text = "Fast Cash";
				Button8TextUI.text = "Back";
				Message1Text.text = " ";
				Message2Text.text = " ";
				Message3Text.text = " ";
				Message4Text.text = " ";
				Message5Text.text = " ";
				Message6Text.text = " ";
				Message7Text.text = " ";
				MessageEnter.text = " ";
			}
			button8Pressed = false;
			break;
			yield return null;
		}
		control = 0;

	
		while ((!check8State()) && (inCashCheck)) {
			//Debug.Log ("In Check Loop");

			Button2Trigger.pressedScreen2 = false;

			screen.sprite = nobuttons;
			Message2Text.text = "Insert check now";
			allButtonsBlank ();

			if (Button1Trigger.pressedScreen1) {
			} else if (Button2Trigger.pressedScreen2) {
			} else if (Button3Trigger.pressedScreen3) {
			} else if (Button4Trigger.pressedScreen4) {
			} else if (Button5Trigger.pressedScreen5) {
			} else if (Button6Trigger.pressedScreen6) {
			} else if (Button7Trigger.pressedScreen7) {
			}

			StartCoroutine(wait48());

			Button8Trigger.pressedScreen8 = false;

			if (button8Pressed) {
				control++;
				Button2Trigger.pressedScreen2 = false;
				Button8Trigger.pressedScreen8 = false;
				Button8Trigger.buttonCount8 = 0;
				inCashCheck = false;

				screen.sprite = buttons;
				Button1TextUI.text = "Preferences";
				Button2TextUI.text = "Cash Check";
				Button3TextUI.text = "Balance";
				Button4TextUI.text = "Statements";
				Button5TextUI.text = "Withdraw";
				Button6TextUI.text = "Deposit";
				Button7TextUI.text = "Fast Cash";
				Button8TextUI.text = "Back";
				Message1Text.text = " ";
				Message2Text.text = " ";
				Message3Text.text = " ";
				Message4Text.text = " ";
				Message5Text.text = " ";
				Message6Text.text = " ";
				Message7Text.text = " ";
				MessageEnter.text = " ";
			}
			button8Pressed = false;
			break;
			yield return null;
		}
		control = 0;


		while ((!check8State()) && (inBalance)) {
			//Debug.Log ("In Balance Loop");

			Button3Trigger.pressedScreen3 = false;

			screen.sprite = nobuttons;
			Message3Text.text = "Your balance is: 500";
			allButtonsBlank ();

			if (Button1Trigger.pressedScreen1) {
			} else if (Button2Trigger.pressedScreen2) {
			} else if (Button3Trigger.pressedScreen3) {
			} else if (Button4Trigger.pressedScreen4) {
			} else if (Button5Trigger.pressedScreen5) {
			} else if (Button6Trigger.pressedScreen6) {
			} else if (Button7Trigger.pressedScreen7) {
			}

			StartCoroutine(wait48());

			Button8Trigger.pressedScreen8 = false;

			if (button8Pressed) {
				control++;
				Button3Trigger.pressedScreen3 = false;
				Button8Trigger.pressedScreen8 = false;
				Button8Trigger.buttonCount8 = 0;
				inBalance = false;

				screen.sprite = buttons;
				Button1TextUI.text = "Preferences";
				Button2TextUI.text = "Cash Check";
				Button3TextUI.text = "Balance";
				Button4TextUI.text = "Statements";
				Button5TextUI.text = "Withdraw";
				Button6TextUI.text = "Deposit";
				Button7TextUI.text = "Fast Cash";
				Button8TextUI.text = "Back";
				Message1Text.text = " ";
				Message2Text.text = " ";
				Message3Text.text = " ";
				Message4Text.text = " ";
				Message5Text.text = " ";
				Message6Text.text = " ";
				Message7Text.text = " ";
				MessageEnter.text = " ";
			}
			button8Pressed = false;
			break;
			yield return null;
		}
		control = 0;


		while ((!check8State()) && (inStatements)) {
			//Debug.Log ("In History Loop");

			Button4Trigger.pressedScreen4 = false;

			screen.sprite = nobuttons;
			Message4Text.text = "Transactions made this session: ";
			allButtonsBlank ();

			if (Button1Trigger.pressedScreen1) {
			} else if (Button2Trigger.pressedScreen2) {
			} else if (Button3Trigger.pressedScreen3) {
			} else if (Button4Trigger.pressedScreen4) {
			} else if (Button5Trigger.pressedScreen5) {
			} else if (Button6Trigger.pressedScreen6) {
			} else if (Button7Trigger.pressedScreen7) {
			}

			StartCoroutine(wait48());

			Button8Trigger.pressedScreen8 = false;

			if (button8Pressed) {
				control++;
				Button4Trigger.pressedScreen4 = false;
				Button8Trigger.pressedScreen8 = false;
				Button8Trigger.buttonCount8 = 0;
				inStatements = false;


				screen.sprite = buttons;
				Button1TextUI.text = "Preferences";
				Button2TextUI.text = "Cash Check";
				Button3TextUI.text = "Balance";
				Button4TextUI.text = "Statements";
				Button5TextUI.text = "Withdraw";
				Button6TextUI.text = "Deposit";
				Button7TextUI.text = "Fast Cash";
				Button8TextUI.text = "Back";
				Message1Text.text = " ";
				Message2Text.text = " ";
				Message3Text.text = " ";
				Message4Text.text = " ";
				Message5Text.text = " ";
				Message6Text.text = " ";
				Message7Text.text = " ";
				MessageEnter.text = " ";
			}
			button8Pressed = false;
			break;
			yield return null;
		}
		control = 0;


		while ((!check8State()) && (inWithdraw)) {
			//Debug.Log ("In Withdraw Loop");

			Button5Trigger.pressedScreen5 = false;

			screen.sprite = buttons;
			Message5Text.text = "Please choose an amount to withdraw then push 'Enter'.";
			Button1TextUI.text = "20";
			Button2TextUI.text = "40";
			Button3TextUI.text = "60";
			Button4TextUI.text = "80";
			Button5TextUI.text = "100";
			Button6TextUI.text = "200";
			Button7TextUI.text = "400";
			Button8TextUI.text = "Back";

			if ((Button1Trigger.pressedScreen1) && (inWithdraw)) {
				Message5Text.text = "20 Euro Withdrawal? (Press Enter)";
				EnterTrigger.withdrawAmount = 20;
				allButtonsBlank ();
				screen.sprite = nobuttons;
			} else if ((Button2Trigger.pressedScreen2) && (inWithdraw)) {
				Message5Text.text = "40 Euro Withdrawal? (Press Enter)";
				EnterTrigger.withdrawAmount = 40;
				allButtonsBlank ();
				screen.sprite = nobuttons;
			} else if ((Button3Trigger.pressedScreen3) && (inWithdraw)) {
				Message5Text.text = "60 Euro Withdrawal? (Press Enter)";
				EnterTrigger.withdrawAmount = 60;
				allButtonsBlank ();
				screen.sprite = nobuttons;
			} else if ((Button4Trigger.pressedScreen4) && (inWithdraw)) {
				Message5Text.text = "80 Euro Withdrawal? (Press Enter)";
				EnterTrigger.withdrawAmount = 80;
				allButtonsBlank ();
				screen.sprite = nobuttons;
			} else if ((Button5Trigger.buttonCount5==2) && (inWithdraw)) {
				Message5Text.text = "100 Euro Withdrawal? (Press Enter)";
				EnterTrigger.withdrawAmount = 100;
				allButtonsBlank ();
				screen.sprite = nobuttons;
			} else if ((Button6Trigger.pressedScreen6) && (inWithdraw)) {
				Message5Text.text = "200 Euro Withdrawal? (Press Enter)";
				EnterTrigger.withdrawAmount = 200;
				allButtonsBlank ();
				screen.sprite = nobuttons;
			} else if ((Button7Trigger.pressedScreen7) && (inWithdraw)) {
				Message5Text.text = "400 Euro Withdrawal? (Press Enter)";
				EnterTrigger.withdrawAmount = 400;
				allButtonsBlank ();
				screen.sprite = nobuttons;
			}

			StartCoroutine(wait48());

			Button8Trigger.pressedScreen8 = false;

			if (button8Pressed) {
				control++;
				Button5Trigger.pressedScreen5 = false;
				Button8Trigger.pressedScreen8 = false;
				Button8Trigger.buttonCount8 = 0;
				inWithdraw = false;

				screen.sprite = buttons;
				Button1TextUI.text = "Preferences";
				Button2TextUI.text = "Cash Check";
				Button3TextUI.text = "Balance";
				Button4TextUI.text = "Statements";
				Button5TextUI.text = "Withdraw";
				Button6TextUI.text = "Deposit";
				Button7TextUI.text = "Fast Cash";
				Button8TextUI.text = "Back";
				Message1Text.text = " ";
				Message2Text.text = " ";
				Message3Text.text = " ";
				Message4Text.text = " ";
				Message5Text.text = " ";
				Message6Text.text = " ";
				Message7Text.text = " ";
				MessageEnter.text = " ";
			}
			button8Pressed = false;
			break;
			yield return null;
		}
		control = 0;


		while ((!check8State()) && (inDeposit)) {
			//Debug.Log ("In Deposit Loop");

			Button6Trigger.pressedScreen6 = false;

			screen.sprite = nobuttons;
			Message6Text.text = "Enter an amount to deposit in multiples of 20 using the keypad then push 'Enter'.";
			allButtonsBlank ();

			if (Button1Trigger.pressedScreen1) {
			} else if (Button2Trigger.pressedScreen2) {
			} else if (Button3Trigger.pressedScreen3) {
			} else if (Button4Trigger.pressedScreen4) {
			} else if (Button5Trigger.pressedScreen5) {
			} else if (Button6Trigger.pressedScreen6) {
			} else if (Button7Trigger.pressedScreen7) {
			}

			StartCoroutine(wait48());

			Button8Trigger.pressedScreen8 = false;

			if (button8Pressed) {
				control++;
				Button6Trigger.pressedScreen6 = false;
				Button8Trigger.pressedScreen8 = false;
				Button8Trigger.buttonCount8 = 0;
				inDeposit = false;

				screen.sprite = buttons;
				Button1TextUI.text = "Preferences";
				Button2TextUI.text = "Cash Check";
				Button3TextUI.text = "Balance";
				Button4TextUI.text = "Statements";
				Button5TextUI.text = "Withdraw";
				Button6TextUI.text = "Deposit";
				Button7TextUI.text = "Fast Cash";
				Button8TextUI.text = "Back";
				Message1Text.text = " ";
				Message2Text.text = " ";
				Message3Text.text = " ";
				Message4Text.text = " ";
				Message5Text.text = " ";
				Message6Text.text = " ";
				Message7Text.text = " ";
				MessageEnter.text = " ";
			}
			button8Pressed = false;
			break;
			yield return null;
		}
		control = 0;


		while ((!check8State()) && (inFastCash)) {
			//Debug.Log ("In Fast Cash Loop");

			Button7Trigger.pressedScreen7 = false;

			screen.sprite = nobuttons;
			Message7Text.text = "Enter an amount to withdraw in multiples of 20 using the keypad then push 'Enter'.";
			allButtonsBlank ();

			if (Button1Trigger.pressedScreen1) {
			} else if (Button2Trigger.pressedScreen2) {
			} else if (Button3Trigger.pressedScreen3) {
			} else if (Button4Trigger.pressedScreen4) {
			} else if (Button5Trigger.pressedScreen5) {
			} else if (Button6Trigger.pressedScreen6) {
			} else if (Button7Trigger.pressedScreen7) {
			} else if ((EnterTrigger.pressedEnter) && (inFastCash)) {
				Message7Text.text = " ";
			}

			StartCoroutine(wait48());

			Button8Trigger.pressedScreen8 = false;

			if (button8Pressed) {
				control++;
				Button7Trigger.pressedScreen7 = false;
				Button8Trigger.pressedScreen8 = false;
				Button8Trigger.buttonCount8 = 0;
				inFastCash = false;

				screen.sprite = buttons;
				Button1TextUI.text = "Preferences";
				Button2TextUI.text = "Cash Check";
				Button3TextUI.text = "Balance";
				Button4TextUI.text = "Statements";
				Button5TextUI.text = "Withdraw";
				Button6TextUI.text = "Deposit";
				Button7TextUI.text = "Fast Cash";
				Button8TextUI.text = "Back";
				Message1Text.text = " ";
				Message2Text.text = " ";
				Message3Text.text = " ";
				Message4Text.text = " ";
				Message5Text.text = " ";
				Message6Text.text = " ";
				Message7Text.text = " ";
				MessageEnter.text = " ";
			}
			button8Pressed = false;
			break;
			yield return null;
		}
		control = 0;

	}

	public void AllTextBlank()
	{
		//Code to set every single message or error text to be " ";
	}
}
