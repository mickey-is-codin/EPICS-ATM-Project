using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DisableButtons : MonoBehaviour {

	public static Collider num0Trigger = null;
	public static Collider num1Trigger = null;
	public static Collider num2Trigger = null;
	public static Collider num3Trigger = null;
	public static Collider num4Trigger = null;
	public static Collider num5Trigger = null;
	public static Collider num6Trigger = null;
	public static Collider num7Trigger = null;
	public static Collider num8Trigger = null;
	public static Collider num9Trigger = null;

	public static void disableFx()
	{
		num0Trigger.enabled = false;
		num1Trigger.enabled = false;
		num2Trigger.enabled = false;
		num3Trigger.enabled = false;
		num4Trigger.enabled = false;
		num5Trigger.enabled = false;
		num6Trigger.enabled = false;
		num7Trigger.enabled = false;
		num8Trigger.enabled = false;
		num9Trigger.enabled = false;

		//StartCoroutine(delayTiming());

		num0Trigger.enabled = true;
		num1Trigger.enabled = true;
		num2Trigger.enabled = true;
		num3Trigger.enabled = true;
		num4Trigger.enabled = true;
		num5Trigger.enabled = true;
		num6Trigger.enabled = true;
		num7Trigger.enabled = true;
		num8Trigger.enabled = true;
		num9Trigger.enabled = true;
	}

	public static IEnumerator delayTiming()
	{
		yield return new WaitForSeconds (3);
	}

}
