using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Leap;

public class DataTracking : MonoBehaviour {

	public GameObject cubePrefab;

	public HandController hc;

	public Text lblRightHandPosition;
	public Text lblRightHandPitch;
	public Text lblRightHandRoll;
	public Text lblRightHandYaw;
	public Text lblRightHandGrab;
	public Text lblRightHandPinch;
	public Text lblRightHandCount;

	public Text lblLeftHandPosition;
	public Text lblLeftHandPitch;
	public Text lblLeftHandRoll;
	public Text lblLeftHandYaw;
	public Text lblLeftHandGrab;
	public Text lblLeftHandPinch;
	public Text lblLeftHandCount;

	public Text lblGestures;
	public Text lblGesturesDraw;
	public Text lblIndexMiddleAngle;
	public Text lblIndexThumbAngle;
	public Text lblSpockIndex;

	public Text lblMaxGrab;

	static float[] rightPitchArray;
	static float[] rightRollArray;
	static float[] rightYawArray;

	public List<int> rightGrabDynArray;

	static float[] rightPinchArray;
	static float[] rightFingerCountArray;

	static float[] leftPitchArray;
	static float[] leftRollArray;
	static float[] leftYawArray;

	static float[] leftGrabArray;
	static float[] leftPinchArray;
	static float[] leftFingerCountArray; //exxample

	public static int maxGrabStrength;

	void Start () {
		hc.GetLeapController ().EnableGesture (Gesture.GestureType.TYPECIRCLE);
		hc.GetLeapController ().EnableGesture (Gesture.GestureType.TYPESCREENTAP);
		hc.GetLeapController ().EnableGesture (Gesture.GestureType.TYPESWIPE);
		hc.GetLeapController ().EnableGesture (Gesture.GestureType.TYPEKEYTAP);

		rightGrabDynArray = new List<int> ();
	}

	Frame currentFrame;

	private GameObject cube = null;

	/*IEnumerator spiderManGesturing()
	{
		foreach (var h in hc.GetFrame().Hands)
		{
			Finger thumb = h.Fingers [0];
			Finger index = h.Fingers [1];
			Finger middle = h.Fingers [2];
			Finger ring = h.Fingers [3];
			Finger pinky = h.Fingers [4];

			while ((index.IsExtended) && (pinky.IsExtended) && (thumb.IsExtended) && (middle.IsExtended == false) && (ring.IsExtended == false)) {
				lblGestures.text = "Gesture: Spider-Man!";
				if (this.cube == null) {
					this.cube = GameObject.Instantiate (this.cubePrefab, this.cubePrefab.transform.position, this.cubePrefab.transform.rotation) as GameObject;
				}
				yield return null;
			}
		}
		yield return null;
	}*/

	public int findMaxGrab(List<int> grabs)
	{
		maxGrabStrength = grabs [0];

		for(int lcv = 0; lcv<grabs.Count; lcv++)
		{
			if (grabs [lcv] > maxGrabStrength) {
				maxGrabStrength = grabs [lcv];
				lblMaxGrab.text = string.Format ("Max Grab: {0}", maxGrabStrength);
				HighScores.AddNewHighscore ("Mickey", maxGrabStrength);
				//print (maxGrabStrength);
			}
		}

		return(maxGrabStrength);
	}

	void Update () {

		this.currentFrame = hc.GetFrame ();
		GestureList gestures = this.currentFrame.Gestures ();

		foreach (Gesture g in gestures) {
			//Debug.Log (g.Type);

			if (g.Type == Gesture.GestureType.TYPECIRCLE) {
				lblGesturesDraw.text = "Gesture: Circle";
			}

			if (g.Type == Gesture.GestureType.TYPESWIPE) {
				lblGesturesDraw.text = "Gesture: Swipe";
			}

			if (g.Type == Gesture.GestureType.TYPESCREENTAP) {
				lblGesturesDraw.text = "Gesture: Screen Tap";
			}

			if (g.Type == Gesture.GestureType.TYPEKEYTAP) {
				lblGesturesDraw.text = "Gesture: Key Tap";
			}
		}

		foreach (var h in hc.GetFrame().Hands) {
			if (h.IsRight) {

				int extendedFingers = 0;
				for (int f = 0; f < h.Fingers.Count; f++) {
					Finger digit = h.Fingers [f];
					if (digit.IsExtended) {
						extendedFingers++;
					}
				}

				float grabMult = h.GrabStrength * 100;

				int grabInt = (int)grabMult;
					
				rightGrabDynArray.Add (grabInt);

				findMaxGrab (rightGrabDynArray);

				Finger thumb = h.Fingers [0];
				Finger index = h.Fingers [1];
				Finger middle = h.Fingers [2];
				Finger ring = h.Fingers [3];
				Finger pinky = h.Fingers [4];

				float index_Mid_Angle;
				float index_Thumb_Angle;
				float mid_Ring_Angle;
				float ring_Pinky_Angle;

				Leap.Vector thumbDir = thumb.Direction;
				Leap.Vector indexDir = index.Direction;
				Leap.Vector middleDir = middle.Direction;
				Leap.Vector ringDir = ring.Direction;
				Leap.Vector pinkyDir = pinky.Direction;

				Vector3 unityThumbDir = thumbDir.ToUnity (false);
				Vector3 unityIndexDir = indexDir.ToUnity (false);
				Vector3 unityMiddleDir = middleDir.ToUnity (false);
				Vector3 unityRingDir = ringDir.ToUnity (false);
				Vector3 unityPinkyDir = pinkyDir.ToUnity (false);

				var dotProduct1 = Vector3.Dot (unityIndexDir, unityThumbDir);
				var dotProduct2 = Vector3.Dot (unityIndexDir, unityMiddleDir);
				var dotProduct3 = Vector3.Dot (unityMiddleDir, unityRingDir);
				var dotProduct4 = Vector3.Dot (unityRingDir, unityPinkyDir);

				index_Thumb_Angle = (Mathf.Acos (dotProduct1)) * (180.0f / Mathf.PI);
				index_Mid_Angle = (Mathf.Acos (dotProduct2)) * (180.0f/Mathf.PI);
				mid_Ring_Angle = (Mathf.Acos (dotProduct3)) * (180.0f / Mathf.PI);
				ring_Pinky_Angle = (Mathf.Acos (dotProduct4)) * (180.0f / Mathf.PI);

				float spockIndex = Mathf.Clamp((mid_Ring_Angle / 90.0f * 30.0f * 10.0f), 0.0f, 100.0f); 

				lblIndexMiddleAngle.text = string.Format("Index and Middle Angle: {0}", index_Mid_Angle);
				lblIndexThumbAngle.text = string.Format ("Thumb and Index Angle: {0}", index_Thumb_Angle);
				lblSpockIndex.text = string.Format("Spock Index: {0}", spockIndex);

				if ((index.IsExtended) && (pinky.IsExtended) && (thumb.IsExtended) && (middle.IsExtended == false) && (ring.IsExtended == false)) {
					lblGestures.text = "Hand Shape: Spider-Man!";

					//StartCoroutine (spiderManGesturing ());

					//if (this.cube == null) {
						//this.cube = GameObject.Instantiate (this.cubePrefab, this.cubePrefab.transform.position, this.cubePrefab.transform.rotation) as GameObject;
					//}
				}

				if ((index.IsExtended) && (thumb.IsExtended) && (middle.IsExtended) && (ring.IsExtended) && (pinky.IsExtended) && (index_Mid_Angle < 15.0) && (mid_Ring_Angle > 15.0)) {
					lblGestures.text = "Hand Shape: Spock";
				}
					

				if ((index.IsExtended == false) && (middle.IsExtended) && (ring.IsExtended == false) && (pinky.IsExtended == false)) {
					lblGestures.text = "Hand Shape: $#%!";
				}

				if ((thumb.IsExtended) && (index.IsExtended == false) && (middle.IsExtended == false) && (ring.IsExtended == false) && (pinky.IsExtended)) {
					lblGestures.text = "Hand Shape: Shaka Brah!";
				}

				if ((thumb.IsExtended) && (index.IsExtended == false) && (middle.IsExtended == false) && (ring.IsExtended == false) && (pinky.IsExtended == false))
				{
					lblGestures.text = "Hand Shape: Thumbs Up";
				}

				if ((thumb.IsExtended == false) && (index.IsExtended == false) && (middle.IsExtended) && (ring.IsExtended) && (pinky.IsExtended))
				{
					lblGestures.text = "Hand Shape: A-OK!";
				}

				if ((thumb.IsExtended == false) && (index.IsExtended) && (middle.IsExtended) && (ring.IsExtended == false) && (pinky.IsExtended))
				{
					lblGestures.text = "Hand Shape: ";
				}

				if ((thumb.IsExtended == false) && (index.IsExtended) && (middle.IsExtended) && (ring.IsExtended == false) && (pinky.IsExtended == false)) {
					lblGestures.text = "Hand Shape: Peace!";
				}

				if ((thumb.IsExtended == false) && (index.IsExtended) && (middle.IsExtended == false) && (ring.IsExtended == false) && (pinky.IsExtended == false)) {
					lblGestures.text = "Hand Shape: Number One";
				}

				if ((thumb.IsExtended) && (index.IsExtended) && (middle.IsExtended == false) && (ring.IsExtended == false) && (pinky.IsExtended == false)) {
					lblGestures.text = "Hand Shape: Bang Bang!";
				}

				this.lblRightHandPosition.text = string.Format ("Right Hand Position: {0}", h.PalmPosition.ToUnity ());
				this.lblRightHandPitch.text = string.Format ("Right Hand Pitch: {0}", h.Direction.Pitch * 180/3.14);
				this.lblRightHandRoll.text = string.Format ("Right Hand Roll: {0}", h.Direction.Roll * 180/3.14);
				this.lblRightHandYaw.text = string.Format ("Right Hand Yaw: {0}", h.Direction.Yaw * 180/3.14);
				this.lblRightHandGrab.text = string.Format ("Right Grab Strength: {0}", h.GrabStrength);
				this.lblRightHandPinch.text = string.Format ("Right Pinch Strength: {0}", h.PinchStrength);
				this.lblRightHandCount.text = string.Format ("Right Finger Count: {0}", extendedFingers);

				foreach (var f in h.Fingers) {
					if (f.Type () == Finger.FingerType.TYPE_INDEX) {
						Leap.Vector position = f.TipPosition;
						Vector3 unityPosition = position.ToUnityScaled (false);
						Vector3 worldPosition = hc.transform.TransformPoint (unityPosition);
					}
				}
			}

			if (h.IsLeft) {

				int extendedFingers = 0;
				for (int f = 0; f < h.Fingers.Count; f++) {
					Finger digit = h.Fingers [f];
					if (digit.IsExtended) {
						extendedFingers++;
					}
				}

				this.lblLeftHandPosition.text = string.Format ("Left Hand Position: {0}", h.PalmPosition.ToUnity ());
				this.lblLeftHandPitch.text = string.Format ("Left Hand Pitch: {0}", h.Direction.Pitch * 180/3.14);
				this.lblLeftHandRoll.text = string.Format ("Left Hand Roll: {0}", h.Direction.Roll * 180/3.14);
				this.lblLeftHandYaw.text = string.Format ("Left Hand Yaw: {0}", h.Direction.Yaw * 180/3.14);
				this.lblLeftHandGrab.text = string.Format ("Left Grab Strength: {0}", h.GrabStrength);
				this.lblLeftHandPinch.text = string.Format ("Left Pinch Strength: {0}", h.PinchStrength);
				this.lblLeftHandCount.text = string.Format ("Left Finger Count: {0}", extendedFingers);

				foreach (var f in h.Fingers) {
					if (f.Type () == Finger.FingerType.TYPE_INDEX) {
						Leap.Vector position = f.TipPosition;
						Vector3 unityPosition = position.ToUnityScaled (false);
						Vector3 worldPosition = hc.transform.TransformPoint (unityPosition);
					}
				}
			}
		}
	}
}
