using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {

	public void SwitchToBlocks()
	{
		SceneManager.LoadScene ("LotsOfBlocks");
	}

	public void SwitchToPIN()
	{
		SceneManager.LoadScene ("PINEnter");
	}

	public void SwitchToWave()
	{
		SceneManager.LoadScene ("CubeWave");
	}

	public void SwitchToFlower()
	{
		SceneManager.LoadScene ("FlowerAndRobot");
	}

	public void SwitchToData()
	{
		SceneManager.LoadScene ("Data Tracker");
	}
}
