using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button6Trigger : MonoBehaviour
{
	[SerializeField]
	private Text change6 = null;
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
	public string depositCustomPrint = "Please insert the deposit in multiples of 20.";

	public static int buttonCount6 = 0;
	public static bool pressedScreen6 = false;
	public static bool inDeposit = false;

	public Collider buttonCollider = null;
	public Collider indexTip = null;
	private GameObject depositImage;

	Text text;

	private bool isColliding;

	void OnTriggerEnter (Collider collider)
	{
		if(isColliding) return;
		isColliding = true;

		buttonCount6++;

		if (collider = indexTip)
		{
			buttonCollider.isTrigger = false;
			indexTip.isTrigger = false;

			AudioSource audio = GetComponent<AudioSource> ();
			//audio.volume = Random.Range (0.8f, 1);
			//audio.pitch = Random.Range (0.8f, 1.1f);
			audio.Play ();

			pressedScreen6 = true;
			/*
			if ((Button8Trigger.buttonCount8 == 0) && (Button6Trigger.buttonCount6 == 1) && (Button1Trigger.inPreferences == false) && (Button2Trigger.inCashCheck == false) && (Button3Trigger.inBalance == false) && (Button4Trigger.inStatements == false) && (Button5Trigger.inWithdraw == false) && (Button7Trigger.inFastCash == false))
			{
				inDeposit = true;
				Debug.Log ("In deposit triggered");
			}
			else {
				inDeposit = false;
			}*/

			StartCoroutine (disableButton ());

			buttonCollider.isTrigger = true;
			indexTip.isTrigger = true;

				
			//Debug.Log ("BUTTON COUNT 6: " + buttonCount6);

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
		//change6.text = mainMenuPrint;
	}

	void Update()
	{
		isColliding = false;

		/*if (Button8Trigger.inMainMenu == true) {
			change6.text = mainMenuPrint;
		}

		if (Button1Trigger.inPreferences == true) {
			//set preferances image;
			change6.text = preferencesPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change6.text = mainMenuPrint;
			}
		}
		//change6.text = mainMenuPrint;

		if (Button2Trigger.inCashCheck == true) {
			//set cash check image;
			change6.text = cashCheckPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change6.text = mainMenuPrint;
			}
		}
		//change6.text = mainMenuPrint;

		if (Button3Trigger.inBalance == true) {
			change6.text = balancePrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change6.text = mainMenuPrint;
			}
		}
		//change6.text = mainMenuPrint;

		if (Button4Trigger.inStatements == true) {
			change6.text = transactionHistoryPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change6.text = mainMenuPrint;
			}
		}
		//change6.text = mainMenuPrint;

		if (Button5Trigger.inWithdraw == true) {
			Debug.Log ("inWithdraw");
			change6.text = withdrawalPrint;
			if (Button8Trigger.buttonCount8 > 0) {
				Button5Trigger.inWithdraw = false;
				change6.text = mainMenuPrint;
			}
			Button8Trigger.buttonCount8 = 0;
		}

		if (Button6Trigger.inDeposit == true) {
			change6.text = depositPrint;
			custom1.text = depositCustomPrint;
			if (Button8Trigger.buttonCount8 > 0) {
				change6.text = mainMenuPrint;
				custom1.text = " ";
			}
		}
		//change6.text = mainMenuPrint;

		if (Button7Trigger.inFastCash == true) {
			change6.text = fastCashPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change6.text = mainMenuPrint;
			}
		}
		//change6.text = mainMenuPrint;

		if ((Button1Trigger.inPreferences == false) && (Button2Trigger.inCashCheck == false) && (Button3Trigger.inBalance == false) && (Button4Trigger.inStatements == false) && (Button5Trigger.inWithdraw == false) && (Button6Trigger.inDeposit == false) && (Button7Trigger.inFastCash == false)) {
			change6.text = mainMenuPrint;
		}

		if (Button8Trigger.pressedScreen8 == true) {
			change6.text = mainMenuPrint;
		}
			

		if (Button8Trigger.buttonCount8 > 1) {
			change6.text = insertCardPrint;
		}*/
	}
}
	