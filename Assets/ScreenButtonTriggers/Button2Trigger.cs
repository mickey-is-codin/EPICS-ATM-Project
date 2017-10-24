using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button2Trigger : MonoBehaviour
{
	[SerializeField]
	private Text change2 = null;
	public Text custom1 = null;

	public string mainMenuPrint = "Preferences";
	public string insertCardPrint = " ";
	public string preferencesPrint = "";
	public string transactionHistoryPrint = " ";
	public string balancePrint = "Checking";
	public string depositPrint = " ";
	public string withdrawalPrint = "20";
	public string cashCheckPrint = " ";
	public string fastCashPrint = " ";
	public string customCheckPrint = "Please insert check into machine to the right of keypad.";

	public static int buttonCount2 = 0;
	public static bool pressedScreen2 = false;
	public static bool inCashCheck = false;

	public Collider buttonCollider = null;
	public Collider indexTip = null;

	Text text;

	private bool isColliding;

	void OnTriggerEnter (Collider collider)
	{
		if(isColliding) return;
		isColliding = true;

		buttonCount2++;

		if (collider = indexTip)
		{
			buttonCollider.isTrigger = false;
			indexTip.isTrigger = false;

			AudioSource audio = GetComponent<AudioSource> ();
			//audio.volume = Random.Range (0.8f, 1);
			//audio.pitch = Random.Range (0.8f, 1.1f);
			audio.Play ();

			pressedScreen2 = true;
			/*
			if ((Button8Trigger.buttonCount8 == 0) && (Button2Trigger.buttonCount2 == 1) && (Button1Trigger.inPreferences == false) && (Button3Trigger.inBalance == false) && (Button4Trigger.inStatements == false) && (Button5Trigger.inWithdraw == false) && (Button6Trigger.inDeposit == false) && (Button7Trigger.inFastCash == false))
			{
				inCashCheck = true;
				Debug.Log ("In cash check triggered");
			}
			else {
				inCashCheck = false;
			}*/
				

			StartCoroutine (disableButton ());

			buttonCollider.isTrigger = true;
			indexTip.isTrigger = true;



			//Debug.Log ("BUTTON COUNT 2: " + buttonCount2);

		}

	}

	void OnTriggerExit(Collider collider)
	{
		isColliding = false;
		return;
	}

	IEnumerator disableButton ()
	{
		var buttonLag = 1;

		var endTime = (Time.time + buttonLag);

		while(Time.time < endTime)
		{
			buttonCollider.isTrigger = false;
			indexTip.isTrigger = false;

			yield return null;
		}
	}

	void Start()
	{
		//change2.text = mainMenuPrint;
	}

	void Update()
	{
		isColliding = false;

		/*if (Button8Trigger.inMainMenu == true) {
			change2.text = mainMenuPrint;
		}*/

		/*if (Button1Trigger.inPreferences == true) {
			//set preferances image;
			change2.text = preferencesPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change2.text = mainMenuPrint;
			}
		}
		//change1.text = mainMenuPrint;

		if (Button2Trigger.inCashCheck == true) {
			//set cash check image;
			change2.text = cashCheckPrint;
			custom1.text = customCheckPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change2.text = mainMenuPrint;
				custom1.text = " ";
			}
		}
		//change1.text = mainMenuPrint;

		if (Button3Trigger.inBalance == true) {
			change2.text = balancePrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change2.text = mainMenuPrint;
			}
		}
		//change1.text = mainMenuPrint;

		if (Button4Trigger.inStatements == true) {
			change2.text = transactionHistoryPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change2.text = mainMenuPrint;
			}
		}
		//change1.text = mainMenuPrint;

		if (Button5Trigger.inWithdraw == true) {
			Debug.Log ("inWithdraw");
			change2.text = withdrawalPrint;
			if (Button8Trigger.buttonCount8 > 0) {
				Button5Trigger.inWithdraw = false;
				change2.text = mainMenuPrint;
			}
			Button8Trigger.buttonCount8 = 0;
		}

		if (Button6Trigger.inDeposit == true) {
			change2.text = depositPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change2.text = mainMenuPrint;
			}
		}
		//change1.text = mainMenuPrint;

		if (Button7Trigger.inFastCash == true) {
			change2.text = fastCashPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change2.text = mainMenuPrint;
			}
		}
		//change1.text = mainMenuPrint;

		if ((Button1Trigger.inPreferences == false) && (Button2Trigger.inCashCheck == false) && (Button3Trigger.inBalance == false) && (Button4Trigger.inStatements == false) && (Button5Trigger.inWithdraw == false) && (Button6Trigger.inDeposit == false) && (Button7Trigger.inFastCash == false)) {
			change2.text = mainMenuPrint;
		}

		if (Button8Trigger.pressedScreen8 == true) {
			change2.text = mainMenuPrint;
		}
			

		if (Button8Trigger.buttonCount8 > 1) {
			change2.text = insertCardPrint;
		}*/
	}
}




