using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class changeText : MonoBehaviour {
	MainStatusCtr mainStatusCtr;
	GameObject ui_instance;
	private Text textref;
	// Use this for initialization
	void Start () {
		ui_instance = GameObject.Find("UI");
		mainStatusCtr = ui_instance.GetComponent<MainStatusCtr> ();
	}
	
	// Update is called once per frame
	void Update () {
		Text hello = GetComponent<Text> ();
		hello.text = mainStatusCtr.Health.ToString ();
	}
}
