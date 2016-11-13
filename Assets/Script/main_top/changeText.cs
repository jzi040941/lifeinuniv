using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class changeText : MonoBehaviour {
	MainStatusCtr mainStatusCtr;
	GameObject ui_instance;
	private Text Text_ref;
	// Use this for initialization
	void Start () {
		ui_instance = GameObject.Find("UI");
		mainStatusCtr = ui_instance.GetComponent<MainStatusCtr> ();
	}
	
	// Update is called once per frame
	void Update () {
		Text hello = GetComponent<Text> ();
		hello.text = mainStatusCtr.Semester + "학기" + mainStatusCtr.Week + "주";
	}
}
