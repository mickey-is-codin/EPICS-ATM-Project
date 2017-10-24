using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ATMControl : MonoBehaviour {

	public HandModel[] leftHands;
	public HandModel[] rightHands;

	private int hand_index_ = 0;

	private int choice;
	private int preferences_choice;
	private int cashcheck_choice;
	private int balance_choice;
	private int statements_choice;
	private int withdraw_choice;
	private int deposit_choice;
	private int fastcash_choice;
	private int choice_main;
	public static bool inPreferencesSwitch = false;
	public static bool inWithdrawSwitch = false;
	public static bool inDepositSwitch = false;
	public static bool inFastCashSwitch = false;
	private bool k;

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

	//NEED A SWITCH STATEMENT FOR EVERY HIERARCHY

	// Use this for initialization
	void Start () {
		//do {
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
	
	// Update is called once per frame
	void Update () {
		
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

		if (Button1Trigger.pressedScreen1) {
			choice = 1;
		} else if (Button2Trigger.pressedScreen2) {
			choice = 2;
		} else if (Button3Trigger.pressedScreen3) {
			choice = 3;
		} else if (Button4Trigger.pressedScreen4) {
			choice = 4;
		} else if (Button5Trigger.pressedScreen5) {
			choice = 5;
		} else if (Button6Trigger.pressedScreen6) {
			choice = 6;
		} else if (Button7Trigger.pressedScreen7) {
			choice = 7;
		} else if (Button8Trigger.pressedScreen8) {
			choice = 8;
		}
		//Debug.Log (choice);


		switch(choice)
		{
		case 1:
			
			Button1Nav ();
			Button8Trigger.pressedScreen8 = false;
			break;
		case 2:
			//cash check
			Button2Nav ();
			Button8Trigger.pressedScreen8 = false;
			break;
		case 3:
			//balance check
			Button3Nav ();
			Button8Trigger.pressedScreen8 = false;
			break;
		case 4:
			//statements
			Button4Nav ();
			Button8Trigger.pressedScreen8 = false;
			break;
		case 5:
			//withdraw
			Button5Nav ();
			Button8Trigger.pressedScreen8 = false;
			break;
		case 6:
			//deposit
			Button6Nav ();
			Button8Trigger.pressedScreen8 = false;
			break;
		case 7:
			//fast cash
			Button7Nav ();
			Button8Trigger.pressedScreen8 = false;
			EnterTrigger.pressedEnter = false;
			break;
		case 8:
		case 0:
			//exit/back
			Button1Trigger.pressedScreen1 = false;
			Button2Trigger.pressedScreen2 = false;
			Button3Trigger.pressedScreen3 = false;
			Button4Trigger.pressedScreen4 = false;
			Button5Trigger.pressedScreen5 = false;
			Button6Trigger.pressedScreen6 = false;
			Button7Trigger.pressedScreen7 = false;
			EnterTrigger.pressedEnter = false;
			break;
		default:
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
			break;
		}

		Button8Trigger.pressedScreen8 = false;
			
	}

	public void Button1Nav()
	{
		//preferences
		Debug.Log("Button1Nav Entered");
		inPreferencesSwitch = true;
		Button1Trigger.pressedScreen1 = false;
		Button2Trigger.pressedScreen2 = false;
		Button3Trigger.pressedScreen3 = false;
		Button4Trigger.pressedScreen4 = false;
		Button5Trigger.pressedScreen5 = false;
		Button6Trigger.pressedScreen6 = false;
		Button7Trigger.pressedScreen7 = false;
		EnterTrigger.pressedEnter = false;

		Button1TextUI.text = "Language";
		Button2TextUI.text = "Hand Model";
		Button3TextUI.text = "Currency Type";
		Button4TextUI.text = "Hearing assistance";
		Button5TextUI.text = "Hand constraint";
		Button6TextUI.text = "Time";
		Button7TextUI.text = "Date";
		Button8TextUI.text = "Back";

		if (Button1Trigger.pressedScreen1) {
			preferences_choice = 1;
		} else if (Button2Trigger.pressedScreen2 == true) {
			preferences_choice = 2;
			prefChoice2 ();
		} else if (Button3Trigger.pressedScreen3) {
			preferences_choice = 3;
		} else if (Button4Trigger.pressedScreen4) {
			preferences_choice = 4;
		} else if (Button5Trigger.pressedScreen5) {
			preferences_choice = 5;
		} else if (Button6Trigger.pressedScreen6) {
			preferences_choice = 6;
		} else if (Button7Trigger.pressedScreen7) {
			preferences_choice = 7;
		} else if (Button8Trigger.pressedScreen8) {
			preferences_choice = 8;
		}
		//Debug.Log ("preferences_choice: " +preferences_choice);

		switch(preferences_choice)
		{
		case 1:
			//language
			break;
		case 2:
			//hand model
			break;
		case 3:
			//currency type
			break;
		case 4:
			//hearing assistance
			break;
		case 5:
			//hand constraint
			break;
		case 6:
			//time
			break;
		case 7:
			//date
			break;
		case 8:
			//back
			break;
		}

		if (Button8Trigger.pressedScreen8 == true) {
			return;
		}
	}

	public void Button2Nav()
	{
		Button1Trigger.pressedScreen1 = false;
		Button2Trigger.pressedScreen2 = false;
		Button3Trigger.pressedScreen3 = false;
		Button4Trigger.pressedScreen4 = false;
		Button5Trigger.pressedScreen5 = false;
		Button6Trigger.pressedScreen6 = false;
		Button7Trigger.pressedScreen7 = false;
		EnterTrigger.pressedEnter = false;

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
			cashcheck_choice = 1;
		} else if (Button2Trigger.pressedScreen2) {
			cashcheck_choice = 2;
		} else if (Button3Trigger.pressedScreen3) {
			cashcheck_choice = 3;
		} else if (Button4Trigger.pressedScreen4) {
			cashcheck_choice = 4;
		} else if (Button5Trigger.pressedScreen5) {
			cashcheck_choice = 5;
		} else if (Button6Trigger.pressedScreen6) {
			cashcheck_choice = 6;
		} else if (Button7Trigger.pressedScreen7) {
			cashcheck_choice = 7;
		} else if (Button8Trigger.pressedScreen8) {
			cashcheck_choice = 8;
		}
		//Debug.Log (cashcheck_choice);

		switch(cashcheck_choice)
		{
		case 1:
			//20
			break;
		case 2:
			//40
			break;
		case 3:
			//60 type
			break;
		case 4:
			//80
			break;
		case 5:
			//100
			break;
		case 6:
			//200
			break;
		case 7:
			//400
			break;
		case 8:
			//back
			break;
		}

		if (Button8Trigger.pressedScreen8 == true) {
			return;
		}
	}

	public void Button3Nav()
	{
		Button1Trigger.pressedScreen1 = false;
		Button2Trigger.pressedScreen2 = false;
		Button3Trigger.pressedScreen3 = false;
		Button4Trigger.pressedScreen4 = false;
		Button5Trigger.pressedScreen5 = false;
		Button6Trigger.pressedScreen6 = false;
		Button7Trigger.pressedScreen7 = false;
		EnterTrigger.pressedEnter = false;

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
			balance_choice = 1;
		} else if (Button2Trigger.pressedScreen2) {
			balance_choice = 2;
		} else if (Button3Trigger.pressedScreen3) {
			balance_choice = 3;
		} else if (Button4Trigger.pressedScreen4) {
			balance_choice = 4;
		} else if (Button5Trigger.pressedScreen5) {
			balance_choice = 5;
		} else if (Button6Trigger.pressedScreen6) {
			balance_choice = 6;
		} else if (Button7Trigger.pressedScreen7) {
			balance_choice = 7;
		} else if (Button8Trigger.pressedScreen8) {
			balance_choice = 8;
		}
		//Debug.Log (balance_choice);

		switch(balance_choice)
		{
		case 1:
			//20
			break;
		case 2:
			//40
			break;
		case 3:
			//60 type
			break;
		case 4:
			//80
			break;
		case 5:
			//100
			break;
		case 6:
			//200
			break;
		case 7:
			//400
			break;
		case 8:
			//back
			break;
		}

		if (Button8Trigger.pressedScreen8 == true) {
			return;
		}
	}

	public void Button4Nav()
	{
		Button1Trigger.pressedScreen1 = false;
		Button2Trigger.pressedScreen2 = false;
		Button3Trigger.pressedScreen3 = false;
		Button4Trigger.pressedScreen4 = false;
		Button5Trigger.pressedScreen5 = false;
		Button6Trigger.pressedScreen6 = false;
		Button7Trigger.pressedScreen7 = false;
		EnterTrigger.pressedEnter = false;

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
			statements_choice = 1;
		} else if (Button2Trigger.pressedScreen2) {
			statements_choice = 2;
		} else if (Button3Trigger.pressedScreen3) {
			statements_choice = 3;
		} else if (Button4Trigger.pressedScreen4) {
			statements_choice = 4;
		} else if (Button5Trigger.pressedScreen5) {
			statements_choice = 5;
		} else if (Button6Trigger.pressedScreen6) {
			statements_choice = 6;
		} else if (Button7Trigger.pressedScreen7) {
			statements_choice = 7;
		} else if (Button8Trigger.pressedScreen8) {
			statements_choice = 8;
		}
		//Debug.Log (statements_choice);

		switch(statements_choice)
		{
		case 1:
			//20
			break;
		case 2:
			//40
			break;
		case 3:
			//60 type
			break;
		case 4:
			//80
			break;
		case 5:
			//100
			break;
		case 6:
			//200
			break;
		case 7:
			//400
			break;
		case 8:
			//back
			break;
		}

		if (Button8Trigger.pressedScreen8 == true) {
			return;
		}
	}

	public void Button5Nav()
	{
		inWithdrawSwitch = true;
		Button1Trigger.pressedScreen1 = false;
		Button2Trigger.pressedScreen2 = false;
		Button3Trigger.pressedScreen3 = false;
		Button4Trigger.pressedScreen4 = false;
		Button5Trigger.pressedScreen5 = false;
		Button6Trigger.pressedScreen6 = false;
		Button7Trigger.pressedScreen7 = false;
		EnterTrigger.pressedEnter = false;

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
			withdraw_choice = 1;
		} else if (Button2Trigger.pressedScreen2) {
			preferences_choice = 2;
		} else if (Button3Trigger.pressedScreen3) {
			withdraw_choice = 3;
		} else if (Button4Trigger.pressedScreen4) {
			withdraw_choice = 4;
		} else if (Button5Trigger.pressedScreen5) {
			withdraw_choice = 5;
		} else if (Button6Trigger.pressedScreen6) {
			withdraw_choice = 6;
		} else if (Button7Trigger.pressedScreen7) {
			withdraw_choice = 7;
		} else if (Button8Trigger.pressedScreen8) {
			withdraw_choice = 8;
		}
		//Debug.Log (withdraw_choice);

		switch(withdraw_choice)
		{
		case 1:
			//20
			break;
		case 2:
			//40
			break;
		case 3:
			//60 type
			break;
		case 4:
			//80
			break;
		case 5:
			//100
			break;
		case 6:
			//200
			break;
		case 7:
			//400
			break;
		case 8:
			//back
			break;
		}

		if (Button8Trigger.pressedScreen8 == true) {
			return;
		}
	}

	public void Button6Nav()
	{
		Button1Trigger.pressedScreen1 = false;
		Button2Trigger.pressedScreen2 = false;
		Button3Trigger.pressedScreen3 = false;
		Button4Trigger.pressedScreen4 = false;
		Button5Trigger.pressedScreen5 = false;
		Button6Trigger.pressedScreen6 = false;
		Button7Trigger.pressedScreen7 = false;
		EnterTrigger.pressedEnter = false;

		inDepositSwitch = true;
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
			deposit_choice = 1;
		} else if (Button2Trigger.pressedScreen2) {
			deposit_choice = 2;
		} else if (Button3Trigger.pressedScreen3) {
			deposit_choice = 3;
		} else if (Button4Trigger.pressedScreen4) {
			deposit_choice = 4;
		} else if (Button5Trigger.pressedScreen5) {
			deposit_choice = 5;
		} else if (Button6Trigger.pressedScreen6) {
			deposit_choice = 6;
		} else if (Button7Trigger.pressedScreen7) {
			deposit_choice = 7;
		} else if (Button8Trigger.pressedScreen8) {
			deposit_choice = 8;
		}
		//Debug.Log (deposit_choice);

		switch(deposit_choice)
		{
		case 1:
			//20
			break;
		case 2:
			//40
			break;
		case 3:
			//60 type
			break;
		case 4:
			//80
			break;
		case 5:
			//100
			break;
		case 6:
			//200
			break;
		case 7:
			//400
			break;
		case 8:
			//back
			break;
		}

		if (Button8Trigger.pressedScreen8 == true) {
			return;
		}
	}

	public void Button7Nav()
	{
		Button1Trigger.pressedScreen1 = false;
		Button2Trigger.pressedScreen2 = false;
		Button3Trigger.pressedScreen3 = false;
		Button4Trigger.pressedScreen4 = false;
		Button5Trigger.pressedScreen5 = false;
		Button6Trigger.pressedScreen6 = false;
		Button7Trigger.pressedScreen7 = false;
		EnterTrigger.pressedEnter = false;

		inFastCashSwitch = true;
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
			fastcash_choice = 1;
		} else if (Button2Trigger.pressedScreen2) {
			fastcash_choice = 2;
		} else if (Button3Trigger.pressedScreen3) {
			fastcash_choice = 3;
		} else if (Button4Trigger.pressedScreen4) {
			fastcash_choice = 4;
		} else if (Button5Trigger.pressedScreen5) {
			fastcash_choice = 5;
		} else if (Button6Trigger.pressedScreen6) {
			fastcash_choice = 6;
		} else if (Button7Trigger.pressedScreen7) {
			fastcash_choice = 7;
		} else if (Button8Trigger.pressedScreen8) {
			fastcash_choice = 8;
		} else if (EnterTrigger.buttonIsPressed == true) {
			fastcash_choice = 9;
		}

		//Debug.Log (fastcash_choice);

		switch(fastcash_choice)
		{
		case 1:
			//20
			break;
		case 2:
			//40
			break;
		case 3:
			//60 type
			break;
		case 4:
			//80
			break;
		case 5:
			//100
			break;
		case 6:
			//200
			break;
		case 7:
			//400
			break;
		case 8:
			//back
			break;
		case 9:
			Message7Text.text = " ";
			break;
		}

		if (Button8Trigger.pressedScreen8 == true) {
			return;
		}
	}

	public void Button8Nav()
	{
		
	}

	public void prefChoice2()
	{
		Debug.Log ("Pushed 2 in Preferences Menu");
		hand_index_ = (hand_index_ + leftHands.Length - 1) % leftHands.Length;
		SetNewHands();
	}

	protected void SetNewHands() {
		HandController controller = GetComponent<HandController>();
		controller.leftGraphicsModel = leftHands[hand_index_];
		controller.rightGraphicsModel = rightHands[hand_index_];
		controller.DestroyAllHands();
	}
}
