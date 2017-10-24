using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button1Trigger : MonoBehaviour
{
	[SerializeField]
	private Text change1 = null;

	public string mainMenuPrint = "Preferences";
	public string insertCardPrint = " ";
	public string preferencesPrint = "Settings";
	public string transactionHistoryPrint = " ";
	public string balancePrint = "Checking";
	public string depositPrint = " ";
	public string withdrawalPrint = "20";
	public string cashCheckPrint = " ";
	public string fastCashPrint = " ";

	public static int buttonCount1 = 0;
	public static bool pressedScreen1 = false;
	public static bool inPreferences = false;

	public Collider buttonCollider = null;
	public Collider indexTip = null;

	Text text;

	private bool isColliding;

	void OnTriggerEnter (Collider collider)
	{
		if(isColliding) return;
		isColliding = true;

		buttonCount1++;

		if (collider = indexTip) {
			buttonCollider.isTrigger = false;
			indexTip.isTrigger = false;

			AudioSource audio = GetComponent<AudioSource> ();
			//audio.volume = Random.Range (0.8f, 1);
			//audio.pitch = Random.Range (0.8f, 1.1f);
			audio.Play ();

			pressedScreen1 = true;

			/*if ((Button8Trigger.buttonCount8 == 0) && (Button1Trigger.buttonCount1 == 1) && (Button2Trigger.inCashCheck == false) && (Button3Trigger.inBalance == false) && (Button4Trigger.inStatements == false) && (Button5Trigger.inWithdraw == false) && (Button6Trigger.inDeposit == false) && (Button7Trigger.inFastCash == false))
			{
				inPreferences = true;
				Debug.Log ("In preferences triggered");
			}
			else {
				inPreferences = false;
			}*/


			StartCoroutine (disableButton ());

			buttonCollider.isTrigger = true;
			indexTip.isTrigger = true;

				
			Debug.Log ("BUTTON COUNT 1: " + buttonCount1);
			Debug.Log ("PRESSED SCREEN 1: " + pressedScreen1);

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
		//change1.text = mainMenuPrint;
	}

	void Update()
	{
		isColliding = false;

		//USE WHILE LOOP TO CONTROL INWITHDRAW VARIABLE ONLY

//		if (Button8Trigger.inMainMenu == true) {
//			change1.text = mainMenuPrint;
//		}
//
//		if (Button1Trigger.inPreferences == true) {
//			//set preferances image;
//			while (Button8Trigger.buttonCount8 < 1) {
//				change1.text = preferencesPrint;
//			}
//			change1.text = mainMenuPrint;
//
//			/*if (Button8Trigger.pressedScreen8 == true) {
//				change1.text = mainMenuPrint;
//				Button1Trigger.inPreferences = false;
//			}*/
//		}
//		//change1.text = mainMenuPrint;
//
//		if (Button2Trigger.inCashCheck == true) {
//			//set cash check image;
//			change1.text = cashCheckPrint;
//
//			if (Button8Trigger.pressedScreen8 == true) {
//				change1.text = mainMenuPrint;
//			}
//		}
//		//change1.text = mainMenuPrint;
//
//		if (Button3Trigger.inBalance == true) {
//			change1.text = balancePrint;
//
//			if (Button3Trigger.inCheckingsBalance == true) {
//				change1.text = " ";
//			} else if (Button3Trigger.inSavingsBalance == true) {
//				change1.text = " ";
//			}
//
//			if (Button8Trigger.pressedScreen8 == true) {
//				change1.text = mainMenuPrint;
//			}
//		}
//		//change1.text = mainMenuPrint;
//
//		if (Button4Trigger.inStatements == true) {
//			change1.text = transactionHistoryPrint;
//
//			if (Button8Trigger.pressedScreen8 == true) {
//				change1.text = mainMenuPrint;
//			}
//		}
//		//change1.text = mainMenuPrint;
//
//		if (Button5Trigger.inWithdraw == true) {
//			Debug.Log ("inWithdraw");
//			change1.text = withdrawalPrint;
//			if (Button8Trigger.pressedScreen8 == true) {
//				Button5Trigger.inWithdraw = false;
//				change1.text = mainMenuPrint;
//			}
//			Button8Trigger.buttonCount8 = 0;
//		}
//
//		if (Button6Trigger.inDeposit == true) {
//			change1.text = depositPrint;
//
//			if (Button8Trigger.pressedScreen8 == true) {
//				change1.text = mainMenuPrint;
//			}
//		}
//		//change1.text = mainMenuPrint;
//
//		if (Button7Trigger.inFastCash == true) {
//			change1.text = fastCashPrint;
//
//			if (Button8Trigger.pressedScreen8 == true) {
//				change1.text = mainMenuPrint;
//			}
//		}
//		//change1.text = mainMenuPrint;
//
//		if ((Button1Trigger.inPreferences == false) && (Button2Trigger.inCashCheck == false) && (Button3Trigger.inBalance == false) && (Button4Trigger.inStatements == false) && (Button5Trigger.inWithdraw == false) && (Button6Trigger.inDeposit == false) && (Button7Trigger.inFastCash == false)) {
//			change1.text = mainMenuPrint;
//		}
//
//		if (Button8Trigger.pressedScreen8 == true) {
//			change1.text = mainMenuPrint;
//		}
//
//
//		if (Button8Trigger.buttonCount8 > 0) {
//			change1.text = insertCardPrint;
//		}
	}
}




