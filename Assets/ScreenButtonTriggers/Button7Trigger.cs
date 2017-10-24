using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button7Trigger : MonoBehaviour
{
	[SerializeField]
	private Text change7 = null;
	public Text custom1 = null;

	public string mainMenuPrint = "Preferences";
	public string insertCardPrint = " ";
	public string preferencesPrint = "Preferences Button 1";
	public string transactionHistoryPrint = " ";
	public string balancePrint = "Checking";
	public string depositPrint = " ";
	public string withdrawalPrint = "20";
	public string cashCheckPrint = " ";
	public string fastCashPrint = " ";
	public string customFastPrint = "Please enter an amount to withdraw in multiples of 20";

	public static int buttonCount7 = 0;
	public static bool pressedScreen7 = false;
	public static bool inFastCash = false;

	public Collider buttonCollider = null;
	public Collider indexTip = null;

	Text text;

	private bool isColliding;

	void OnTriggerEnter (Collider collider)
	{
		if(isColliding) return;
		isColliding = true;

		buttonCount7++;

		if (collider = indexTip)
		{
			buttonCollider.isTrigger = false;
			indexTip.isTrigger = false;

			AudioSource audio = GetComponent<AudioSource> ();
			//audio.volume = Random.Range (0.8f, 1);
			//audio.pitch = Random.Range (0.8f, 1.1f);
			audio.Play ();

			pressedScreen7 = true;
			/*
			if ((Button8Trigger.buttonCount8 == 0) && (Button7Trigger.buttonCount7 == 1) && (Button1Trigger.inPreferences == false) && (Button2Trigger.inCashCheck == false) && (Button3Trigger.inBalance == false) && (Button4Trigger.inStatements == false) && (Button5Trigger.inWithdraw == false) && (Button6Trigger.inDeposit == false))
			{
				inFastCash = true;
				Debug.Log ("In fast cash triggered");
			}
			else {
				inFastCash = false;
			}*/
				
			StartCoroutine (disableButton ());

			buttonCollider.isTrigger = true;
			indexTip.isTrigger = true;

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
		//change7.text = mainMenuPrint;
	}

	void Update()
	{
		isColliding = false;

		/*if (Button8Trigger.inMainMenu == true) {
			change7.text = mainMenuPrint;
		}

		if (Button1Trigger.inPreferences == true) {
			//set preferances image;
			change7.text = preferencesPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change7.text = mainMenuPrint;
			}
		}
		//change7.text = mainMenuPrint;

		if (Button2Trigger.inCashCheck == true) {
			//set cash check image;
			change7.text = cashCheckPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change7.text = mainMenuPrint;
			}
		}
		//change7.text = mainMenuPrint;

		if (Button3Trigger.inBalance == true) {
			change7.text = balancePrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change7.text = mainMenuPrint;
			}
		}
		//change7.text = mainMenuPrint;

		if (Button4Trigger.inStatements == true) {
			change7.text = transactionHistoryPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				Button4Trigger.inStatements = false;
			}
		}
		//change7.text = mainMenuPrint;

		if (Button5Trigger.inWithdraw == true) {
			Debug.Log ("inWithdraw");
			change7.text = withdrawalPrint;
			if (Button8Trigger.buttonCount8 > 0) {
				Button5Trigger.inWithdraw = false;
				change7.text = mainMenuPrint;
			}
			Button8Trigger.buttonCount8 = 0;
		}

		if (Button6Trigger.inDeposit == true) {
			change7.text = depositPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change7.text = mainMenuPrint;
			}
		}
		//change7.text = mainMenuPrint;

		if (Button7Trigger.inFastCash == true) {
			change7.text = fastCashPrint;
			custom1.text = customFastPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change7.text = mainMenuPrint;
				custom1.text = " ";
			}
		}
		//change7.text = mainMenuPrint;

		if ((Button1Trigger.inPreferences == false) && (Button2Trigger.inCashCheck == false) && (Button3Trigger.inBalance == false) && (Button4Trigger.inStatements == false) && (Button5Trigger.inWithdraw == false) && (Button6Trigger.inDeposit == false) && (Button7Trigger.inFastCash == false)) {
			change7.text = mainMenuPrint;
		}

		if (Button8Trigger.pressedScreen8 == true) {
			change7.text = mainMenuPrint;
		}


		if (Button8Trigger.buttonCount8 > 1) {
			change7.text = insertCardPrint;
		}*/
	}
}




