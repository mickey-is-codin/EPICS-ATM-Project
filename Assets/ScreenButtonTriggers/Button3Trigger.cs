using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button3Trigger : MonoBehaviour
{
	[SerializeField]
	private Text change3 = null;
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

	public static int buttonCount3 = 0;
	public static bool pressedScreen3 = false;
	public static bool inBalance = false;
	public static bool inCheckingsBalance = false;
	public static bool inSavingsBalance = false;

	public Collider buttonCollider = null;
	public Collider indexTip = null;

	Text text;

	private bool isColliding;

	void OnTriggerEnter (Collider collider)
	{
		if(isColliding) return;
		isColliding = true;

		buttonCount3++;

		if (collider = indexTip)
		{
			buttonCollider.isTrigger = false;
			indexTip.isTrigger = false;

			AudioSource audio = GetComponent<AudioSource> ();
			//audio.volume = Random.Range (0.8f, 1);
			//audio.pitch = Random.Range (0.8f, 1.1f);
			audio.Play ();

			pressedScreen3 = true;
			/*
			if ((Button8Trigger.buttonCount8 == 0) && (Button3Trigger.buttonCount3 == 1) && (Button1Trigger.inPreferences == false) && (Button2Trigger.inCashCheck == false) && (Button4Trigger.inStatements == false) && (Button5Trigger.inWithdraw == false) && (Button6Trigger.inDeposit == false) && (Button7Trigger.inFastCash == false))
			{
				inBalance = true;
				Debug.Log ("In balance triggered");
			}
			else {
				inBalance = false;
			}*/
				

			StartCoroutine (disableButton ());

			buttonCollider.isTrigger = true;
			indexTip.isTrigger = true;



			//Debug.Log ("BUTTON COUNT 3: " + buttonCount3);

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
		//change3.text = mainMenuPrint;
	}

	void Update()
	{
		isColliding = false;

		/*if (Button8Trigger.inMainMenu == true) {
			change3.text = mainMenuPrint;
		}

		if (Button1Trigger.inPreferences == true) {
			//set preferances image;
			change3.text = preferencesPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change3.text = mainMenuPrint;
			}
		}
		//change3.text = mainMenuPrint;

		if (Button2Trigger.inCashCheck == true) {
			//set cash check image;
			change3.text = cashCheckPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change3.text = mainMenuPrint;
			}
		}
		//change3.text = mainMenuPrint;

		if (Button3Trigger.inBalance == true) {
			change3.text = balancePrint;

			if (Button1Trigger.buttonCount1 == 2) {
				custom1.text = "Checkings Balance: 100";
				inCheckingsBalance = true;
			} else if (Button2Trigger.buttonCount2 == 2) {
				custom1.text = "Savings Balance: 200";
				inSavingsBalance = true;
			}

			if (Button8Trigger.buttonCount8 > 0) {
				change3.text = mainMenuPrint;
				custom1.text = " ";
				inCheckingsBalance = false;
				inSavingsBalance = false;
			}
		}
		//change3.text = mainMenuPrint;

		if (Button4Trigger.inStatements == true) {
			change3.text = transactionHistoryPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change3.text = mainMenuPrint;
			}
		}
		//change3.text = mainMenuPrint;

		if (Button5Trigger.inWithdraw == true) {
			Debug.Log ("inWithdraw");
			change3.text = withdrawalPrint;
			if (Button8Trigger.buttonCount8 > 0) {
				Button5Trigger.inWithdraw = false;
				change3.text = mainMenuPrint;
			}
			Button8Trigger.buttonCount8 = 0;
		}

		if (Button6Trigger.inDeposit == true) {
			change3.text = depositPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change3.text = mainMenuPrint;
			}
		}
		//change3.text = mainMenuPrint;

		if (Button7Trigger.inFastCash == true) {
			change3.text = fastCashPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change3.text = mainMenuPrint;
			}
		}
		//change3.text = mainMenuPrint;

		if ((Button1Trigger.inPreferences == false) && (Button2Trigger.inCashCheck == false) && (Button3Trigger.inBalance == false) && (Button4Trigger.inStatements == false) && (Button5Trigger.inWithdraw == false) && (Button6Trigger.inDeposit == false) && (Button7Trigger.inFastCash == false)) {
			change3.text = mainMenuPrint;
		}

		if (Button8Trigger.pressedScreen8 == true) {
			change3.text = mainMenuPrint;
		}


		if (Button8Trigger.buttonCount8 > 1) {
			change3.text = insertCardPrint;
		}*/
	}
}




