using UnityEngine;
using System.Collections;

public class popup_panels : MonoBehaviour {


	public GameObject[] main_panels;
	// Use this for initialization
	void Start () {
		//main_panels = GameObject.FindGameObjectsWithTag ("main_top_panel");
		for (int i = 0; i < main_panels.Length; i++) {
			Debug.Log ("panel" + i);	
		}
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
			if (i == num)
				continue;
			main_panels [i].SetActive (false);
		}
	}
}
