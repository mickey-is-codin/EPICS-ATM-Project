using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ATMInputScript : MonoBehaviour {

	// Use this for initialization
	//Text text;

	[SerializeField]
	private Text show0 = null;
	private Text show1 = null;
	private Text show2 = null;
	private Text show3 = null;
	private Text show4 = null;
	private Text show5 = null;
	private Text show6 = null;
	private Text show7 = null;
	private Text show8 = null;
	private Text show9 = null;

	string num0Print = "0";
	string num1Print = "1";
	string num2Print = "2";
	string num3Print = "3";
	string num4Print = "4";
	string num5Print = "5";
	string num6Print = "6";
	string num7Print = "7";
	string num8Print = "8";
	string num9Print = "9";

	Text text;

	//0 BUTTON CODE
	void Start()
	{
		if (NumButton0Trigger.pressed0 == true) 
		{
			int num0Input = 0;

			show0.text = num0Print;

			Debug.Log (num0Input);
			Debug.Log (num0Print);
			Debug.Log ("Working");
		}
	}



//	void OnTriggerEnter (Collider collider) //Button Pushed????
//	{
//		Debug.Log ("0 Button Pushed");
//		//STORE A 1 VALUE
//		//PRINT A 1 VALUE ON RENDER TEXTURE
//		//imageGO.sprite = Resources.Load<Sprite> ("MenuScreen_Mat");
//
//		//		text = GetComponent <Text> (); 
//		//
//		//int numInput = 0;
//
//		pressed0 = true;
//
//		Debug.Log (pressed0);
//
//		//text.text = numInput;
//
//		if (pressed0 == true)
//		{
//			//public Text show = null;
//
//			int num0Input = 0;
//
//			show0.text = num0Print;
//
//			Debug.Log (num0Input);
//			Debug.Log (num0Print);
//
//			//Text.Text = num0Input;
//		}
//	}
//
//	//1 BUTTON CODE
//
//	void OnTriggerEnter (Collider collider) //Button Pushed????
//	{
//		Debug.Log ("1 Button Pushed");
//		//STORE A 1 VALUE
//		//PRINT A 1 VALUE ON RENDER TEXTURE
//		//imageGO.sprite = Resources.Load<Sprite> ("MenuScreen_Mat");
//
//		//		text = GetComponent <Text> (); 
//		//
//		//int numInput = 0;
//
//		pressed1 = true;
//
//		Debug.Log (pressed1);
//
//		//text.text = numInput;
//
//		if (pressed1 == true)
//		{
//			//public Text show = null;
//
//			int num1Input = 1;
//
//			show1.text = num1Print;
//
//			Debug.Log (num1Input);
//			Debug.Log (num1Print);
//
//			//Text.Text = num0Input;
//		}
//	}
//	//2 BUTTON CODE
//	void OnTriggerEnter (Collider collider) //Button Pushed????
//	{
//		Debug.Log ("2 Button Pushed");
//		//STORE A 1 VALUE
//		//PRINT A 1 VALUE ON RENDER TEXTURE
//		//imageGO.sprite = Resources.Load<Sprite> ("MenuScreen_Mat");
//
//		//		text = GetComponent <Text> (); 
//		//
//		//int numInput = 0;
//
//		pressed2 = true;
//
//		Debug.Log (pressed2);
//
//		//text.text = numInput;
//
//		if (pressed2 == true)
//		{
//			//public Text show = null;
//
//			int num2Input = 2;
//
//			show2.text = num0Print;
//
//			Debug.Log (num2Input);
//			Debug.Log (num2Print);
//
//			//Text.Text = num0Input;
//		}
//	}
//	//3 BUTTON CODE
//	void OnTriggerEnter (Collider collider) //Button Pushed????
//	{
//		Debug.Log ("3 Button Pushed");
//		//STORE A 1 VALUE
//		//PRINT A 1 VALUE ON RENDER TEXTURE
//		//imageGO.sprite = Resources.Load<Sprite> ("MenuScreen_Mat");
//
//		//		text = GetComponent <Text> (); 
//		//
//		//int numInput = 0;
//
//		pressed0 = true;
//
//		Debug.Log (pressed0);
//
//		//text.text = numInput;
//
//		if (pressed0 == true)
//		{
//			//public Text show = null;
//
//			int num0Input = 0;
//
//			show0.text = num0Print;
//
//			Debug.Log (num0Input);
//			Debug.Log (num0Print);
//
//			//Text.Text = num0Input;
//		}
//	}
//	//4 BUTTON CODE
//	void OnTriggerEnter (Collider collider) //Button Pushed????
//	{
//		Debug.Log ("0 Button Pushed");
//		//STORE A 1 VALUE
//		//PRINT A 1 VALUE ON RENDER TEXTURE
//		//imageGO.sprite = Resources.Load<Sprite> ("MenuScreen_Mat");
//
//		//		text = GetComponent <Text> (); 
//		//
//		//int numInput = 0;
//
//		pressed0 = true;
//
//		Debug.Log (pressed0);
//
//		//text.text = numInput;
//
//		if (pressed0 == true)
//		{
//			//public Text show = null;
//
//			int num0Input = 0;
//
//			show0.text = num0Print;
//
//			Debug.Log (num0Input);
//			Debug.Log (num0Print);
//
//			//Text.Text = num0Input;
//		}
//	}
//	//5 BUTTON CODE
//	void OnTriggerEnter (Collider collider) //Button Pushed????
//	{
//		Debug.Log ("0 Button Pushed");
//		//STORE A 1 VALUE
//		//PRINT A 1 VALUE ON RENDER TEXTURE
//		//imageGO.sprite = Resources.Load<Sprite> ("MenuScreen_Mat");
//
//		//		text = GetComponent <Text> (); 
//		//
//		//int numInput = 0;
//
//		pressed0 = true;
//
//		Debug.Log (pressed0);
//
//		//text.text = numInput;
//
//		if (pressed0 == true)
//		{
//			//public Text show = null;
//
//			int num0Input = 0;
//
//			show0.text = num0Print;
//
//			Debug.Log (num0Input);
//			Debug.Log (num0Print);
//
//			//Text.Text = num0Input;
//		}
//	}
//	//6 BUTTON CODE
//	void OnTriggerEnter (Collider collider) //Button Pushed????
//	{
//		Debug.Log ("0 Button Pushed");
//		//STORE A 1 VALUE
//		//PRINT A 1 VALUE ON RENDER TEXTURE
//		//imageGO.sprite = Resources.Load<Sprite> ("MenuScreen_Mat");
//
//		//		text = GetComponent <Text> (); 
//		//
//		//int numInput = 0;
//
//		pressed0 = true;
//
//		Debug.Log (pressed0);
//
//		//text.text = numInput;
//
//		if (pressed0 == true)
//		{
//			//public Text show = null;
//
//			int num0Input = 0;
//
//			show0.text = num0Print;
//
//			Debug.Log (num0Input);
//			Debug.Log (num0Print);
//
//			//Text.Text = num0Input;
//		}
//	}
//	//7 BUTTON CODE
//	void OnTriggerEnter (Collider collider) //Button Pushed????
//	{
//		Debug.Log ("0 Button Pushed");
//		//STORE A 1 VALUE
//		//PRINT A 1 VALUE ON RENDER TEXTURE
//		//imageGO.sprite = Resources.Load<Sprite> ("MenuScreen_Mat");
//
//		//		text = GetComponent <Text> (); 
//		//
//		//int numInput = 0;
//
//		pressed0 = true;
//
//		Debug.Log (pressed0);
//
//		//text.text = numInput;
//
//		if (pressed0 == true)
//		{
//			//public Text show = null;
//
//			int num0Input = 0;
//
//			show0.text = num0Print;
//
//			Debug.Log (num0Input);
//			Debug.Log (num0Print);
//
//			//Text.Text = num0Input;
//		}
//	}
//	//8 BUTTON CODE
//	void OnTriggerEnter (Collider collider) //Button Pushed????
//	{
//		Debug.Log ("0 Button Pushed");
//		//STORE A 1 VALUE
//		//PRINT A 1 VALUE ON RENDER TEXTURE
//		//imageGO.sprite = Resources.Load<Sprite> ("MenuScreen_Mat");
//
//		//		text = GetComponent <Text> (); 
//		//
//		//int numInput = 0;
//
//		pressed0 = true;
//
//		Debug.Log (pressed0);
//
//		//text.text = numInput;
//
//		if (pressed0 == true)
//		{
//			//public Text show = null;
//
//			int num0Input = 0;
//
//			show0.text = num0Print;
//
//			Debug.Log (num0Input);
//			Debug.Log (num0Print);
//
//			//Text.Text = num0Input;
//		}
//	}
//	//9 BUTTON CODE
//	void OnTriggerEnter (Collider collider) //Button Pushed????
//	{
//		Debug.Log ("0 Button Pushed");
//		//STORE A 1 VALUE
//		//PRINT A 1 VALUE ON RENDER TEXTURE
//		//imageGO.sprite = Resources.Load<Sprite> ("MenuScreen_Mat");
//
//		//		text = GetComponent <Text> (); 
//		//
//		//int numInput = 0;
//
//		pressed0 = true;
//
//		Debug.Log (pressed0);
//
//		//text.text = numInput;
//
//		if (pressed0 == true)
//		{
//			//public Text show = null;
//
//			int num0Input = 0;
//
//			show0.text = num0Print;
//
//			Debug.Log (num0Input);
//			Debug.Log (num0Print);
//
//			//Text.Text = num0Input;
//		}
//	}

}
