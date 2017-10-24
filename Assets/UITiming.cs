using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITiming : MonoBehaviour {

	public Text welcomeText = null;

	public Image FoV = null;

	public AudioClip voiceIntro = null;

	public string message1 = "Welcome! This is a virtual ATM Scene.";
	public string message2 = "As you are walking towards the ATM feel free to move your hands above the Leap Motion.";
	public string message3 = "If you cannot see hands appear on your computer try to move the leap motion brick directly under your hands or wipe the black surface with a dry cloth.";
	public string message4 = "As you approach the ATM familiarize yourself with the machine and follow the instructions that appear on the ATM screen.";
	public string message5 = "You can do a variety of activities so feel free to start when you are ready.";
	public string message6 = "Push the right or left arrow key at any time to change your hand model";

	public static float waitTime;

	private IEnumerator routine;

	// Use this for initialization
	IEnumerator Start () {
		AudioSource audio = GetComponent<AudioSource> ();
		audio.enabled = false;

		FoV.enabled = true;
		yield return new WaitForSeconds (5.0f);
		FoV.enabled = false;

		audio.enabled = true;
		audio.Play ();

		welcomeText.text = message1;
		yield return new WaitForSeconds (3.0f);

		welcomeText.text = message2;
		yield return new WaitForSeconds (5.0f);

		welcomeText.text = message3;
		yield return new WaitForSeconds (10.0f);

		welcomeText.text = message4;
		yield return new WaitForSeconds (8.0f);

		welcomeText.text = message5;
		yield return new WaitForSeconds (6.0f);

		welcomeText.text = message6;
		yield return new WaitForSeconds (3.0f);

	}


}
