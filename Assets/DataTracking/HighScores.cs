using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScores : MonoBehaviour {
	const string privateCode = "GNb5RHXy90WMdmbrIduH0QOfsLXj8zM02XLCNW5-C9TA";
	const string publicCode = "59383692758d15034467322a";
	const string webURL = "http://dreamlo.com/lb/";

	public HighScore[] highscoresList;
	static HighScores instance;
	DisplayHighscores highscoreDisplay;

	void Awake()
	{
		highscoreDisplay = GetComponent<DisplayHighscores> ();
		instance = this;
	}	

	public static void AddNewHighscore(string username, int score)
	{
		instance.StartCoroutine (instance.UploadNewHighScore (username, score));
	}

	IEnumerator UploadNewHighScore(string username, int score)
	{
		WWW www = new WWW (webURL + privateCode + "/add/" + WWW.EscapeURL (username) + "/" + score);
		yield return www;

		if (string.IsNullOrEmpty (www.error)) {
			//print ("Upload Successful");
			DownloadHighscores ();
		} else {
			print ("Error Uploading" + www.error);
		}
	}

	public void DownloadHighscores()
	{
		StartCoroutine ("DownloadNewHighScoresFromDataBase");
	}

	IEnumerator DownloadNewHighScoresFromDataBase()
	{
		WWW www = new WWW (webURL + publicCode + "/pipe/");
		yield return www;

		if (string.IsNullOrEmpty (www.error)) {
			FormatHighScores (www.text);
			highscoreDisplay.OnHighscoresDownloaded (highscoresList);
		} else {
			print ("Error Downloading" + www.error);
		}
	}

	void FormatHighScores(string textStream)
	{
		string[] entries = textStream.Split (new char[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
		highscoresList = new HighScore[entries.Length];

		for (int i = 0; i < entries.Length; i++) {
			string[] entryInfo = entries [i].Split (new char[] {'|'});
			string username = entryInfo [0];
			int score = int.Parse(entryInfo [1]);
			highscoresList [i] = new HighScore (username, score);
			print (highscoresList [i].username + ": " + highscoresList [i].score);
		}
	}
}

public struct HighScore {
	public string username;
	public int score;

	public HighScore(string _username, int _score)
	{
		username = _username;
		score = _score;
	}
}
