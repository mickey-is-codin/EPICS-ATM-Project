using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnterTrigger : MonoBehaviour
{
	[SerializeField]
	private Text show = null;
	public Text errorDisplay = null;
	public Text waitMessage = null;

	public static bool pressedEnter;

	public Collider buttonCollider = null;

	public Collider indexTip = null;

	public static bool buttonIsPressed = false;

	public static int withdrawAmount = 9999;

	public float movementSpeed = 1.0f;

	public float moneyDist = 4.0f;

	public Vector3 startPosition;

	public Vector3 endPosition;

	private float startTime;

	public Text Message6 = null;
	public Text Message7 = null;

	public Collider trigger0 = null;
	public Collider trigger1 = null;
	public Collider trigger2 = null;
	public Collider trigger3 = null;
	public Collider trigger4 = null;
	public Collider trigger5 = null;
	public Collider trigger6 = null;
	public Collider trigger7 = null;
	public Collider trigger8 = null;
	public Collider trigger9 = null;

	Text text;

	private GameObject dollarBill;

	void Start()
	{
		buttonCollider.enabled = false;
		buttonCollider.isTrigger = false;

		StartCoroutine (wait3Sec ());

		buttonCollider.enabled = true;
		buttonCollider.isTrigger = true;
	}

	IEnumerator wait3Sec()
	{
		yield return new WaitForSeconds (3);
	}

	void OnTriggerEnter (Collider collider) //Button Pushed????
	{
		StartCoroutine (disableButton ());

		pressedEnter = true;

		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play ();

		//Debug.Log (pressed9);
		if ((IrelandTripATMControl.inWithdraw) || (IrelandTripATMControl.inFastCash) || (IrelandTripATMControl.inDeposit)) {
			if (pressedEnter == true) {
				//buttonCollider.isTrigger = true;
				//indexTip.isTrigger = true;

				pressedEnter = true;
				withdrawAmount = int.Parse (show.text);
				Debug.Log ("Withdraw Amount = " + withdrawAmount);
				show.text = "Please Wait";

				//MOVE DOLLAR BILLS OUT FUNCTION --(-3 to -7 position)
				if (((withdrawAmount % 20) != 0) && (IrelandTripATMControl.inWithdraw)) {
					show.text = " ";
					Message6.text = " ";
					Message7.text = " ";
					errorDisplay.text = "Please input the amount in multiples of 20.";
				} else if ((withdrawAmount > 500) && (IrelandTripATMControl.inWithdraw)) {
					show.text = " ";
					Message6.text = " ";
					Message7.text = " ";
					errorDisplay.text = "Insufficient funds";
				} else if ((withdrawAmount % 20 == 0) && (withdrawAmount < 500)) {
					Debug.Log ("Is Multiple of 20");

					StartCoroutine (ChangeLevel ());

					return;
				}
			}

			return;
		}
		else
		{
			return;
		}
	}

	void Update()
	{
		float distCovered = (Time.time - startTime) * movementSpeed;
		float fracJourney = distCovered / moneyDist;

		if ((pressedEnter == true) && ((withdrawAmount % 20) == 0) && (withdrawAmount <= 500) && ((IrelandTripATMControl.inWithdraw) || (IrelandTripATMControl.inDeposit) || (IrelandTripATMControl.inFastCash)))
		{
			Debug.Log ("In output condition");
			dollarBill = GameObject.Find ("Money");
			startPosition = dollarBill.transform.position;
			endPosition = dollarBill.transform.position + Vector3.back * moneyDist;
			dollarBill.transform.position = Vector3.Lerp (startPosition, endPosition, fracJourney);
			StartCoroutine (ChangeLevel ());
		}
	}

	void OnTriggerExit(Collider collider)
	{
		buttonIsPressed = false;
		Debug.Log ("buttonIsPressed:" + buttonIsPressed);
		return;
	}

	IEnumerator ChangeLevel()
	{
		float fadeTime = GameObject.Find("PathFollower").GetComponent<Fade>().BeginFade(1);
		yield return new WaitForSeconds (fadeTime);
	}

	IEnumerator disableButton ()
	{
		trigger0.enabled = false;
		trigger1.enabled = false;
		trigger2.enabled = false;
		trigger3.enabled = false;
		trigger4.enabled = false;
		trigger5.enabled = false;
		trigger6.enabled = false;
		trigger7.enabled = false;
		trigger8.enabled = false;
		trigger9.enabled = false;

		trigger0.isTrigger = false;
		trigger1.isTrigger = false;
		trigger2.isTrigger = false;
		trigger3.isTrigger = false;
		trigger4.isTrigger = false;
		trigger5.isTrigger = false;
		trigger6.isTrigger = false;
		trigger7.isTrigger = false;
		trigger8.isTrigger = false;
		trigger9.isTrigger = false;

		yield return new WaitForSeconds (3);

		trigger0.enabled = true;
		trigger1.enabled = true;
		trigger2.enabled = true;
		trigger3.enabled = true;
		trigger4.enabled = true;
		trigger5.enabled = true;
		trigger6.enabled = true;
		trigger7.enabled = true;
		trigger8.enabled = true;
		trigger9.enabled = true;

		trigger0.isTrigger = true;
		trigger1.isTrigger = true;
		trigger2.isTrigger = true;
		trigger3.isTrigger = true;
		trigger4.isTrigger = true;
		trigger5.isTrigger = true;
		trigger6.isTrigger = true;
		trigger7.isTrigger = true;
		trigger8.isTrigger = true;
		trigger9.isTrigger = true;
	}

}


