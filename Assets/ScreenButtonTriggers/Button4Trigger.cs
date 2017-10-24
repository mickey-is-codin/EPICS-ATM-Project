using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button4Trigger : MonoBehaviour
{
	[SerializeField]
	private Text change4 = null;

	public string mainMenuPrint = "Preferences";
	public string insertCardPrint = " ";
	public string preferencesPrint = "Preferences Button 1";
	public string transactionHistoryPrint = " ";
	public string balancePrint = "Checking";
	public string depositPrint = " ";
	public string withdrawalPrint = "20";
	public string cashCheckPrint = " ";
	public string fastCashPrint = " ";

	public static int buttonCount4 = 0;
	public static bool pressedScreen4 = false;
	public static bool inStatements = false;

	public Collider buttonCollider = null;
	public Collider indexTip = null;

	Text text;

	private bool isColliding;

	void OnTriggerEnter (Collider collider)
	{
		if(isColliding) return;
		isColliding = true;

		buttonCount4++;

		if (collider = indexTip)
		{
			buttonCollider.isTrigger = false;
			indexTip.isTrigger = false;

			AudioSource audio = GetComponent<AudioSource> ();
			//audio.volume = Random.Range (0.8f, 1);
			//audio.pitch = Random.Range (0.8f, 1.1f);
			audio.Play ();

			pressedScreen4 = true;
			/*
			if ((Button8Trigger.buttonCount8 == 0) && (Button4Trigger.buttonCount4 == 1) && (Button1Trigger.inPreferences == false) && (Button2Trigger.inCashCheck == false) && (Button3Trigger.inBalance == false) && (Button5Trigger.inWithdraw == false) && (Button6Trigger.inDeposit == false) && (Button7Trigger.inFastCash == false))
			{
				inStatements = true;
				Debug.Log ("In statements triggered");
			}
			else {
				inStatements = false;
			}*/
				

			StartCoroutine (disableButton ());

			buttonCollider.isTrigger = true;
			indexTip.isTrigger = true;


			//Debug.Log ("BUTTON COUNT 4: " + buttonCount4);

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
		//change4.text = mainMenuPrint;
	}

	void Update()
	{
		isColliding = false;

		/*if (Button8Trigger.inMainMenu == true) {
			change4.text = mainMenuPrint;
		}

		if (Button1Trigger.inPreferences == true) {
			//set preferances image;
			change4.text = preferencesPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change4.text = mainMenuPrint;
			}
		}
		//change4.text = mainMenuPrint;

		if (Button2Trigger.inCashCheck == true) {
			//set cash check image;
			change4.text = cashCheckPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change4.text = mainMenuPrint;
			}
		}
		//change4.text = mainMenuPrint;

		if (Button3Trigger.inBalance == true) {
			change4.text = balancePrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change4.text = mainMenuPrint;
			}
		}
		//change4.text = mainMenuPrint;

		if (Button4Trigger.inStatements == true) {
			change4.text = transactionHistoryPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change4.text = mainMenuPrint;
			}
		}
		//change4.text = mainMenuPrint;

		if (Button5Trigger.inWithdraw == true) {
			Debug.Log ("inWithdraw");
			change4.text = withdrawalPrint;
			if (Button8Trigger.buttonCount8 > 0) {
				Button5Trigger.inWithdraw = false;
				change4.text = mainMenuPrint;
			}
			Button8Trigger.buttonCount8 = 0;
		}

		if (Button6Trigger.inDeposit == true) {
			change4.text = depositPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change4.text = mainMenuPrint;
			}
		}
		//change4.text = mainMenuPrint;

		if (Button7Trigger.inFastCash == true) {
			change4.text = fastCashPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change4.text = mainMenuPrint;
			}
		}
		//change4.text = mainMenuPrint;

		if ((Button1Trigger.inPreferences == false) && (Button2Trigger.inCashCheck == false) && (Button3Trigger.inBalance == false) && (Button4Trigger.inStatements == false) && (Button5Trigger.inWithdraw == false) && (Button6Trigger.inDeposit == false) && (Button7Trigger.inFastCash == false)) {
			change4.text = mainMenuPrint;
		}

		if (Button8Trigger.pressedScreen8 == true) {
			change4.text = mainMenuPrint;
		}

		if (Button8Trigger.buttonCount8 > 1) {
			change4.text = insertCardPrint;
		}*/
	}
}




