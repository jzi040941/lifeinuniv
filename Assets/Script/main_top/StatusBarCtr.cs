using UnityEngine;
using System.Collections;

public class StatusBarCtr : MonoBehaviour {
    MainStatusCtr mainStatusCtr;
    GameObject ui_instance;

	// Use this for initialization
	void Start () {
        ui_instance = GameObject.Find("UI");
        mainStatusCtr = ui_instance.GetComponent<MainStatusCtr>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
