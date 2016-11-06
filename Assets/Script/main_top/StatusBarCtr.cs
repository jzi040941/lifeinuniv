using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatusBarCtr : MonoBehaviour {
    MainStatusCtr mainStatusCtr;
    GameObject ui_instance;
    public Slider healthBarSlider, jobBarSlider, attrBarSlider; // Status Bar 3개를 Control하는 Bar
    
	// Use this for initialization
	void Start () {
        ui_instance = GameObject.Find("UI");
        mainStatusCtr = ui_instance.GetComponent<MainStatusCtr>();
        //healthBarSlider = GameObject.Find("UI/StatusBarPanel/HealthUI/HealthSlider").GetComponent<Slider>();
        //jobBarSlider = GameObject.Find("JobSlider").GetComponent<Slider>();
        //attrBarSlider = GameObject.Find("AttrSlider").GetComponent<Slider>();
    }

	// Update is called once per frame
	void Update () {
        healthBarSlider.value = mainStatusCtr.Health;
        //jobBarSlider.value = mainStatusCtr.Job;
        //attrBarSlider.value = mainStatusCtr.Attr;
	}
}
