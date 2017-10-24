using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyLerp : MonoBehaviour {

	public Transform startMarker;
	public Transform endMarker;

	public float movementSpeed = 0.1f;
	public float moneyDist = 4.0f;

	//public Vector3 startPosition;
	//public Vector3 endPosition;

	private float startTime;
	private float journeyLength;

	// Use this for initialization
	void Start () {
		startTime = Time.time;

		//startPosition = transform.position;
		//endPosition = transform.position + Vector3.back * moneyDist;

		journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
	}
	
	// Update is called once per frame
	void Update () {

		if ((EnterTrigger.pressedEnter == true) && ((EnterTrigger.withdrawAmount % 20) == 0) && (EnterTrigger.withdrawAmount <= 500))
		{
			float distCovered = (Time.time - startTime) * movementSpeed;
			float fracJourney = distCovered / journeyLength;

			//Debug.Log ("In output condition");
			//startPosition = transform.position;
			//endPosition = transform.position + Vector3.back * moneyDist;
			transform.position = Vector3.Lerp (startMarker.position,endMarker.position, fracJourney);
		}
	}
}
