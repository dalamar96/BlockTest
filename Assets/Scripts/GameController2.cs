using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController2 : MonoBehaviour {

	private Text scoreTextObject;
	public static int scoreValue;
	public static int shotsFired;
	// Use this for initialization
	void Start () {
		scoreTextObject = GetComponent<Text>();
		scoreValue = 0;
		shotsFired = 0;
	}
	
	// Update is called once per frame
	void Update () {
		scoreTextObject.text = "Score: " + scoreValue.ToString ();
		scoreTextObject.text += "\n";
		scoreTextObject.text += "Shots: " + shotsFired.ToString ();
	}
}
