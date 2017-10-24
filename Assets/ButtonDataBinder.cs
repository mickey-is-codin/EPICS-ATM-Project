using UnityEngine;
using LMWidgets;

public class ButtonDataBinder : DataBinderToggle {
	bool toggle = false;

	override public bool GetCurrentData() {
		return toggle;
	}

	override protected void setDataModel(bool value) {
		toggle = value;
	}
}