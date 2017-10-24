using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IrelandTripATMControl : MonoBehaviour {

	//NEED TO FIGURE OUT WHETHER TO PUT THIS SCRIPT IN THE MANAGER OR JUST ON A BUTTON. IF IT'S IN A MANAGER GAME OBJECT I'LL HAVE TO ADD THE 8 SCREEN BUTTON COLLIDER SO THAT WE CAN DETECT COLLISIONS
	//AS OF NOW IT IS ON THE 8 SCREEN BUTTON

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

	private bool check8State()
	{
		if (Button8Trigger.pressedScreen8) {
			return button8Pressed == true;
		} else {
			return false;
		}
	}

	IEnumerator wait48()
	{
		yield return new WaitUntil (check8State);
	}
		
		
	void checkTree()
	{
		if ((Button1Trigger.pressedScreen1) && (Button1Trigger.buttonCount1 == 1)) {
			inPreferences = true;
			Debug.Log ("In Preferences Bool");
		} else if ((Button2Trigger.pressedScreen2) && (Button2Trigger.buttonCount2 == 1)) {
			inCashCheck = true;
			Debug.Log ("In Cash Check Bool");
		} else if ((Button3Trigger.pressedScreen3) && (Button3Trigger.buttonCount3 == 1)) {
			inBalance = true;
			Debug.Log ("In Balance Bool");
		} else if ((Button4Trigger.pressedScreen4) && (Button4Trigger.buttonCount4 == 1)) {
			inStatements = true;
			Debug.Log ("In Statements Bool");
		} else if ((Button5Trigger.pressedScreen5) && (Button5Trigger.buttonCount5 == 1)) {
			inWithdraw = true;
			Debug.Log ("In Withdraw Bool");
		} else if ((Button6Trigger.pressedScreen6) && (Button6Trigger.buttonCount6 == 1)) {
			inDeposit = true;
			Debug.Log ("In Deposit Bool");
		} else if ((Button7Trigger.pressedScreen7) && (Button7Trigger.buttonCount7 == 1)) {
			inFastCash = true;
			Debug.Log ("In Fast Cash Bool");
		} else if (Button8Trigger.pressedScreen8) {
			inPreferences = false;
			inCashCheck = false;
			inBalance = false;
			inStatements = false;
			inWithdraw = false;
			inDeposit = false;
			inFastCash = false;

			leave = true;

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

		Looping ();
		return;
	}

	void Looping()
	{
		//Debug.Log ("In Looping");
		while ((inPreferences) && (control < 1)) {
			Debug.Log ("In Preferences Loop");

			Button1Trigger.pressedScreen1 = false;

			Button1TextUI.text = "Language";
			Button2TextUI.text = "Hand Model";
			Button3TextUI.text = "Currency Type";
			Button4TextUI.text = "Hearing assistance";
			Button5TextUI.text = "Hand constraint";
			Button6TextUI.text = "Time";
			Button7TextUI.text = "Date";
			Button8TextUI.text = "Back";

			if (Button1Trigger.pressedScreen1) {
				Message1Text.text = "You've pushed preferences 1!";
			} else if (Button2Trigger.pressedScreen2) {
			} else if (Button3Trigger.pressedScreen3) {
			} else if (Button4Trigger.pressedScreen4) {
			} else if (Button5Trigger.pressedScreen5) {
			} else if (Button6Trigger.pressedScreen6) {
			} else if (Button7Trigger.pressedScreen7) {
			}
				
			if (button8Pressed) {
				control++;
				Button1Trigger.pressedScreen1 = false;
				inPreferences = false;

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
		}
		control = 0;

	
		while ((inCashCheck) && (control < 1)) {
			Debug.Log ("In Check Loop");

			Button2Trigger.pressedScreen2 = false;

			Message2Text.text = "Insert check now";
			Button1TextUI.text = " ";
			Button2TextUI.text = " ";
			Button3TextUI.text = " ";
			Button4TextUI.text = " ";
			Button5TextUI.text = " ";
			Button6TextUI.text = " ";
			Button7TextUI.text = " ";
			Button8TextUI.text = "Back";

			if (Button1Trigger.pressedScreen1) {
			} else if (Button2Trigger.pressedScreen2) {
			} else if (Button3Trigger.pressedScreen3) {
			} else if (Button4Trigger.pressedScreen4) {
			} else if (Button5Trigger.pressedScreen5) {
			} else if (Button6Trigger.pressedScreen6) {
			} else if (Button7Trigger.pressedScreen7) {
			}

			if (button8Pressed) {
				control++;
				Button2Trigger.pressedScreen2 = false;
				inCashCheck = false;

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
		}
		control = 0;


		while ((inBalance) && (control < 1)) {
			Debug.Log ("In Balance Loop");

			Button3Trigger.pressedScreen3 = false;

			Message3Text.text = "Your balance is: 500";
			Button1TextUI.text = " ";
			Button2TextUI.text = " ";
			Button3TextUI.text = " ";
			Button4TextUI.text = " ";
			Button5TextUI.text = " ";
			Button6TextUI.text = " ";
			Button7TextUI.text = " ";
			Button8TextUI.text = "Back";

			if (Button1Trigger.pressedScreen1) {
			} else if (Button2Trigger.pressedScreen2) {
			} else if (Button3Trigger.pressedScreen3) {
			} else if (Button4Trigger.pressedScreen4) {
			} else if (Button5Trigger.pressedScreen5) {
			} else if (Button6Trigger.pressedScreen6) {
			} else if (Button7Trigger.pressedScreen7) {
			}

			if (button8Pressed) {
				control++;
				Button3Trigger.pressedScreen3 = false;
				inBalance = false;

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
		}
		control = 0;


		while ((inStatements) && (control < 1)) {
			Debug.Log ("In History Loop");

			Button4Trigger.pressedScreen4 = false;

			Message4Text.text = "Transactions made this session: ";
			Button1TextUI.text = " ";
			Button2TextUI.text = " ";
			Button3TextUI.text = " ";
			Button4TextUI.text = " ";
			Button5TextUI.text = " ";
			Button6TextUI.text = " ";
			Button7TextUI.text = " ";
			Button8TextUI.text = "Back";

			if (Button1Trigger.pressedScreen1) {
			} else if (Button2Trigger.pressedScreen2) {
			} else if (Button3Trigger.pressedScreen3) {
			} else if (Button4Trigger.pressedScreen4) {
			} else if (Button5Trigger.pressedScreen5) {
			} else if (Button6Trigger.pressedScreen6) {
			} else if (Button7Trigger.pressedScreen7) {
			}

			if (button8Pressed) {
				control++;
				Button4Trigger.pressedScreen4 = false;
				inStatements = false;

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
		}
		control = 0;


		while ((inWithdraw) && (control < 1)) {
			Debug.Log ("In Withdraw Loop");

			Button5Trigger.pressedScreen5 = false;

			Message5Text.text = "Please choose an amount to withdraw then push 'Enter'.";
			Button1TextUI.text = "20";
			Button2TextUI.text = "40";
			Button3TextUI.text = "60";
			Button4TextUI.text = "80";
			Button5TextUI.text = "100";
			Button6TextUI.text = "200";
			Button7TextUI.text = "400";
			Button8TextUI.text = "Back";

			if (Button1Trigger.pressedScreen1) {
			} else if (Button2Trigger.pressedScreen2) {
			} else if (Button3Trigger.pressedScreen3) {
			} else if (Button4Trigger.pressedScreen4) {
			} else if (Button5Trigger.pressedScreen5) {
			} else if (Button6Trigger.pressedScreen6) {
			} else if (Button7Trigger.pressedScreen7) {
			}

			StartCoroutine(wait48());

			if (button8Pressed) {
				control++;
				Button5Trigger.pressedScreen5 = false;
				inWithdraw = false;

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
		}
		control = 0;


		while ((inDeposit) && (control < 1)) {
			Debug.Log ("In Deposit Loop");

			Button6Trigger.pressedScreen6 = false;

			Message6Text.text = "Enter an amount to deposit in multiples of 20 using the keypad then push 'Enter'.";
			Button1TextUI.text = " ";
			Button2TextUI.text = " ";
			Button3TextUI.text = " ";
			Button4TextUI.text = " ";
			Button5TextUI.text = " ";
			Button6TextUI.text = " ";
			Button7TextUI.text = " ";
			Button8TextUI.text = "Back";

			if (Button1Trigger.pressedScreen1) {
			} else if (Button2Trigger.pressedScreen2) {
			} else if (Button3Trigger.pressedScreen3) {
			} else if (Button4Trigger.pressedScreen4) {
			} else if (Button5Trigger.pressedScreen5) {
			} else if (Button6Trigger.pressedScreen6) {
			} else if (Button7Trigger.pressedScreen7) {
			}

			if (button8Pressed) {
				control++;
				Button6Trigger.pressedScreen6 = false;
				inDeposit = false;

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
		}
		control = 0;


		while ((inFastCash) && (control < 1)) {
			Debug.Log ("In Fast Cash Loop");

			Button7Trigger.pressedScreen7 = false;

			Message7Text.text = "Enter an amount to withdraw in multiples of 20 using the keypad then push 'Enter'.";
			Button1TextUI.text = " ";
			Button2TextUI.text = " ";
			Button3TextUI.text = " ";
			Button4TextUI.text = " ";
			Button5TextUI.text = " ";
			Button6TextUI.text = " ";
			Button7TextUI.text = " ";
			Button8TextUI.text = "Back";

			if (Button1Trigger.pressedScreen1) {
			} else if (Button2Trigger.pressedScreen2) {
			} else if (Button3Trigger.pressedScreen3) {
			} else if (Button4Trigger.pressedScreen4) {
			} else if (Button5Trigger.pressedScreen5) {
			} else if (Button6Trigger.pressedScreen6) {
			} else if (Button7Trigger.pressedScreen7) {
			}

			if (button8Pressed) {
				control++;
				Button7Trigger.pressedScreen7 = false;
				inFastCash = false;

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
		}
		control = 0;

		return;

	}
}
