using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button8Trigger : MonoBehaviour
{
	//public Image imageGO;

	[SerializeField]
	private Text change8 = null;

	public string mainMenuPrint = "Exit";
	public string insertCardPrint = "Push here to start";
	public string preferencesPrint = "Back";
	public string transactionHistoryPrint = "Back";
	public string balancePrint = "Back";
	public string depositPrint = "Back";
	public string withdrawalPrint = "Back";
	public string cashCheckPrint = "Back";
	public string fastCashPrint = "Back";

	public static bool pressedScreen8 = false;
	public static int buttonCount8 = 0;
	public static bool inMainMenu = true;

	public Collider buttonCollider = null;
	public Collider indexTip = null;

	Text text;

	private bool isColliding;

	void OnTriggerEnter (Collider collider) //Button Pushed????
	{
		if(isColliding) return;
		isColliding = true;

		if (collider = indexTip)
		{
			buttonCount8++;

			Button1Trigger.buttonCount1 = 0;
			Button2Trigger.buttonCount2 = 0;
			Button3Trigger.buttonCount3 = 0;
			Button4Trigger.buttonCount4 = 0;
			Button5Trigger.buttonCount5 = 0;
			Button6Trigger.buttonCount6 = 0;
			Button7Trigger.buttonCount7 = 0;

			inMainMenu = true;

			pressedScreen8 = true;
			Debug.Log("pressedScreen8: " +pressedScreen8);

			buttonCollider.isTrigger = false;
			indexTip.isTrigger = false;

			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();

			StartCoroutine (disableButton ());

			buttonCollider.isTrigger = true;
			indexTip.isTrigger = true;
	
			//pressedScreen8 = false;

			Debug.Log ("BUTTON COUNT 8: " + buttonCount8);
			Debug.Log ("Pressing Object: " + collider);
		
		}
			
	}
		
	void OnTriggerExit(Collider collider)
	{
		isColliding = false;
		pressedScreen8 = false;
		return;
	}
		
	//Deactivate Button

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

	void Update()
	{
		isColliding = false;

		/*if ((Button1Trigger.buttonCount1 == 0) && (Button2Trigger.buttonCount2 == 0) && (Button3Trigger.buttonCount3 == 0) && (Button4Trigger.buttonCount4 == 0) && (Button5Trigger.buttonCount5 == 0) && (Button6Trigger.buttonCount6 == 0) && (Button7Trigger.buttonCount7 == 0))
		{
			inMainMenu = true;
		}
		if (Button8Trigger.pressedScreen8 == true) 
		{
			inMainMenu = true;
		}
		if (inMainMenu == true) {
			Button1Trigger.buttonCount1 = 0;
			Button2Trigger.buttonCount2 = 0;
			Button3Trigger.buttonCount3 = 0;
			Button4Trigger.buttonCount4 = 0;
			Button5Trigger.buttonCount5 = 0;
			Button6Trigger.buttonCount6 = 0;
			Button7Trigger.buttonCount7 = 0;
		}



		buttonCollider.isTrigger = true;
		indexTip.isTrigger = true;

		change8.text = insertCardPrint;

		if (Button8Trigger.buttonCount8 == 0) {
			change8.text = mainMenuPrint;
		}

		if (Button8Trigger.buttonCount8 > 1) {
			Button8Trigger.buttonCount8 = 0;
		}*/
	}
}

