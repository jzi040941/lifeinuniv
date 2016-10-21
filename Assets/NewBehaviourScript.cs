using UnityEngine;
using System.Collections;

#pragma strict

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.Portrait;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

 
	public void LoadScene () {
		Application.LoadLevel ("main_screen");
	}
}