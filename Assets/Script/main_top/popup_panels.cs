using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class popup_panels : MonoBehaviour {
	//MainStatusCtr mainStatusCtr; 
	//GameObject ui_instance;

	public GameObject[] inactive;

	public GameObject[] main_panels;
	// Use this for initialization
	void Start () {
		//ui_instance = GameObject.Find ("UI");
		//mainStatusCtr = ui_instance.GetComponent<MainStatusCtr> ();
		//main_panels = GameObject.FindGameObjectsWithTag ("main_top_panel");


		inactive = GameObject.FindGameObjectsWithTag ("uninteratible");

		/*
		Button btn = inactive [0].GetComponent<Button> ();
		btn.interactable = false;
		*/


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	bool[] check(){
		bool[] panelsIsActive = new bool[3];
		int i = 0;
		foreach(GameObject obj in main_panels){
			panelsIsActive [i] = obj.activeSelf;
			i += 1;
		}
		return panelsIsActive;
	}

	public void panelopen(int num){
		//int num = 0;
		main_panels [num].SetActive (!main_panels [num].activeSelf);

		for (int i = 0; i < main_panels.Length; i++) {
			if (i == num){

				foreach(GameObject a in inactive){
					Button btn = a.GetComponent<Button> ();
					btn.interactable = !main_panels [num].activeSelf;
				}
				continue;
			}
			main_panels [i].SetActive (false);
		}
	}
}
