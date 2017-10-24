using UnityEngine;
using System.Collections;
using LMWidgets;

public class ButtonDemoActionExample : MonoBehaviour {

  public ButtonDemo SimpleButton; 

	// Use this for initialization
	void Start () {
    SimpleButton.StartHandler += OnSimpleButtonAction;

	}
  
  private void OnSimpleButtonAction (object sender, LMWidgets.EventArg<bool> arg) {
    UnityEngine.Debug.Log ("Firing the ButtonDemo Example Button");
	UnityEngine.Debug.LogWarning("Warning fuck");
	UnityEngine.Debug.LogError ("Error Fuck");
	print ("Fuck you, fuck this, fuck that, fuck them");
  }
	

}
