using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button5Trigger : MonoBehaviour
{
	//public Image imageGO;
	[SerializeField]
	public Text change5 = null;
	public Text custom1 = null;

	public string mainMenuPrint = "Button 5 Menu Option";
	public string insertCardPrint = " ";
	public string preferencesPrint = "Preferences Button 1";
	public string transactionHistoryPrint = " ";
	public string balancePrint = " ";
	public string depositPrint = " ";
	public string withdrawalPrint = "100";
	public string cashCheckPrint = " ";
	public string fastCashPrint = " ";
	public string customAmountPrint = "Please choose amount to withdraw and then push 'Enter' on keypad.";

	public static int buttonCount5 = 0;
	public static bool pressedScreen5 = false;

	public Collider buttonCollider = null;
	public Collider indexTip = null;

	Text text; 

	private bool isColliding;

	public static bool inWithdraw = false;

	void OnTriggerEnter (Collider collider) //Button Pushed????
	{
		if(isColliding) return;
		isColliding = true;

		buttonCount5++;

		if (collider = indexTip)
		{
			//buttonCollider.enabled = false;
			buttonCollider.isTrigger = false;
			indexTip.isTrigger = false;

			AudioSource audio = GetComponent<AudioSource> ();
			//audio.volume = Random.Range (0.8f, 1);
			//audio.pitch = Random.Range (0.8f, 1.1f);
			audio.Play ();

			pressedScreen5 = true;

			/*
			if ((Button8Trigger.buttonCount8 == 0) && (Button5Trigger.buttonCount5 == 1) && (Button1Trigger.inPreferences == false) && (Button2Trigger.inCashCheck == false) && (Button3Trigger.inBalance == false) && (Button4Trigger.inStatements == false) && (Button6Trigger.inDeposit == false) && (Button7Trigger.inFastCash == false))
			{
				inWithdraw = true;
				Debug.Log ("In withdraw triggered");
			}
			else {
				inWithdraw = false;
			}
				*/

			StartCoroutine (disableButton ());

			//buttonCollider.enabled = true;
			buttonCollider.isTrigger = true;
			indexTip.isTrigger = true;
				
			Debug.Log ("5 Button Pushed");
			Debug.Log ("5 Bool State: " + pressedScreen5);
		}
	}

	void OnTriggerExit(Collider collider)
	{
		isColliding = false;
		return;
	}

	IEnumerator disableButton ()
	{
		//yield return new WaitForSeconds (waitTime);
		//Debug.Log ("In Loop");
		var buttonLag = 1;

		var endTime = (Time.time + buttonLag);

		while(Time.time < endTime)
		{
			buttonCollider.isTrigger = false;
			//buttonCollider.enabled = false;
			indexTip.isTrigger = false;

			//Debug.Log ("In Loop");

			//Debug.Log ("Time in loop: " + Time.time);
			yield return null;
		}
	}

	void Start()
	{
		//change5.text = mainMenuPrint;
		//Button5Trigger.inWithdraw = false;
	}

	void Update()
	{
		isColliding = false;

		/*if (Button8Trigger.inMainMenu == true) {
			change5.text = mainMenuPrint;
		}

		if (Button1Trigger.inPreferences == true)
		{
			change5.text = preferencesPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change5.text = mainMenuPrint;
			}
		}
		//change5.text = mainMenuPrint;

		if (Button2Trigger.inCashCheck == true)
		{
			change5.text = cashCheckPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change5.text = mainMenuPrint;
			}
		}
		//change5.text = mainMenuPrint;

		if (Button3Trigger.inBalance == true)
		{
			change5.text = balancePrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change5.text = mainMenuPrint;
			}
		}
		//change5.text = mainMenuPrint;

		if (Button4Trigger.inStatements == true)
		{
			change5.text = transactionHistoryPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change5.text = mainMenuPrint;
			}
		}
		//change5.text = mainMenuPrint;

		if (Button5Trigger.inWithdraw == true) {
			Debug.Log ("In withdraw hierarchy");
			change5.text = withdrawalPrint;
			custom1.text = customAmountPrint;
			if (Button8Trigger.buttonCount8 > 0) {
				Debug.Log ("Leaving withdraw hierarchy");
				change5.text = mainMenuPrint;
				custom1.text = " ";
			}
			Button8Trigger.buttonCount8 = 0;
		}


		if (Button6Trigger.inDeposit == true) {
			change5.text = depositPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change5.text = mainMenuPrint;
			}
		}
		//change5.text = mainMenuPrint;

		if (Button7Trigger.inFastCash == true) {
			change5.text = fastCashPrint;

			if (Button8Trigger.buttonCount8 > 0) {
				change5.text = mainMenuPrint;
			}
		}
		//change5.text = mainMenuPrint;

		if ((Button1Trigger.inPreferences == false) && (Button2Trigger.inCashCheck == false) && (Button3Trigger.inBalance == false) && (Button4Trigger.inStatements == false) && (Button5Trigger.inWithdraw == false) && (Button6Trigger.inDeposit == false) && (Button7Trigger.inFastCash == false)) {
			change5.text = mainMenuPrint;
		}

		if (Button8Trigger.pressedScreen8 == true) {
			change5.text = mainMenuPrint;
		}


		if (Button8Trigger.buttonCount8 > 1) {
			change5.text = insertCardPrint;
		}*/
	}
		
}

