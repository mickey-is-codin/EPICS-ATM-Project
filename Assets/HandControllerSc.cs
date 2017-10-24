using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Leap;

public class HandControllerSc : MonoBehaviour {
	public GameObject cubePrefab;

	public HandController handcont;

	private HandModel hm;

	public Text lblNoDeviceDetected;
	public Text lblLeftHandPosition;
	public Text lblLeftHandRotation;

	public Text lblRightHandPosition;

	public Text lblRightHandPitch;
	public Text lblRightHandRoll;
	public Text lblRightHandYaw;

	public Text lblRightHandGrab;
	public Text lblRightHandPinch;
	public Text lblRightHandCount;

	public Color c;
	public static Color selectedColor;
	public bool selectable = false;

	// Use this for initialization
	void Start () {
		handcont.GetLeapController ().EnableGesture (Gesture.GestureType.TYPECIRCLE);
		handcont.GetLeapController ().EnableGesture (Gesture.GestureType.TYPESCREENTAP);
		handcont.GetLeapController ().EnableGesture (Gesture.GestureType.TYPESWIPE);
	}

	private GameObject cube = null;

	Frame currentFrame;

	Frame lastFrame = null;
	Frame thisFrame = null;

	long difference = 0;

	void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.transform.parent.name.Equals ("index")) {
			if (this.selectable) {
				HandControllerSc.selectedColor = this.c;
				this.transform.Rotate (Vector3.up, 33);
				return;
			}

			transform.gameObject.GetComponent<Renderer> ().material.color = HandControllerSc.selectedColor;
		}
	}

	void Update () {
		this.currentFrame = handcont.GetFrame ();
		GestureList gestures = this.currentFrame.Gestures ();

		foreach (Gesture g in gestures) {
			Debug.Log (g.Type);

			if (g.Type == Gesture.GestureType.TYPECIRCLE) {
				if (this.cube == null) {
					this.cube = GameObject.Instantiate (this.cubePrefab, this.cubePrefab.transform.position, this.cubePrefab.transform.rotation) as GameObject;
				}
			}

			if (g.Type == Gesture.GestureType.TYPESWIPE) {
				if (this.cube != null) {
					Destroy (this.cube);
					this.cube = null;
				}
			}
		}

		foreach (var h in handcont.GetFrame().Hands) {
			if (h.IsRight) {
				//Debug.Log ("Right Hand Detected in Frame");
				//Debug.Log ("Right Hand Position: {0}" + h.PalmPosition.ToUnity ());
				//Debug.Log("Right Hand Pitch: {0}" + h.Direction.Pitch);

				int extendedFingers = 0;
				for (int f = 0; f < h.Fingers.Count; f++) {
					Finger digit = h.Fingers [f];
					if (digit.IsExtended) {
						extendedFingers++;
					}
				}

				this.lblRightHandPosition.text = string.Format ("Hand Position: {0}", h.PalmPosition.ToUnity ());
				this.lblRightHandPitch.text = string.Format ("Hand Pitch: {0}", h.Direction.Pitch * 180/3.14);
				this.lblRightHandRoll.text = string.Format ("Hand Roll: {0}", h.Direction.Roll * 180/3.14);
				this.lblRightHandYaw.text = string.Format ("Hand Yaw: {0}", h.Direction.Yaw * 180/3.14);
				this.lblRightHandGrab.text = string.Format ("Grab Strength: {0}", h.GrabStrength);
				this.lblRightHandPinch.text = string.Format ("Pinch Strength: {0}", h.PinchStrength);
				this.lblRightHandCount.text = string.Format ("Finger Count: {0}", extendedFingers);

				if (this.cube != null)
					this.cube.transform.rotation = Quaternion.Euler (h.Direction.Pitch, h.Direction.Yaw, h.Direction.Roll);

				foreach (var f in h.Fingers) {
					if (f.Type () == Finger.FingerType.TYPE_INDEX) {
						Leap.Vector position = f.TipPosition;
						Vector3 unityPosition = position.ToUnityScaled (false);
						Vector3 worldPosition = handcont.transform.TransformPoint (unityPosition);
					}
				}
			}

			if (h.IsLeft) {
				Debug.Log ("Left Hand Detected in Frame");
				this.lblLeftHandPosition.text = string.Format ("Left Hand Position: {0}", h.PalmPosition.ToUnity ());
				this.lblLeftHandRotation.text = string.Format ("Left Hand Rotation: <{0},{1},{2}>", h.Direction.Pitch, h.Direction.Yaw, h.Direction.Roll);

				if (this.cube != null)
					this.cube.transform.rotation = Quaternion.Euler (h.Direction.Pitch, h.Direction.Yaw, h.Direction.Roll);
			}
		}
	}
}
