using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatusBarCtr : MonoBehaviour {
    MainStatusCtr mainStatusCtr;
    GameObject ui_instance,health_inst,job_inst,attr_inst;
    GameObject h_text_ins, j_text_ins, a_text_ins;
    public Slider mainHealthBar; // 메인 화면의 체력 Bar
    public Slider mainJobBar; // 메인 화면의 취업률 Bar
    public Slider mainAttrBar; // 메인 화면의 매력 Bar
    public Text h_text,j_text,a_text;

	// Use this for initialization
	void Start () {
        ui_instance = GameObject.Find("UI");
        mainStatusCtr = ui_instance.GetComponent<MainStatusCtr>();
        health_inst = GameObject.Find("HealthSlider");
        if (health_inst != null)
        {
            mainHealthBar = health_inst.GetComponent<Slider>();
        }
        job_inst = GameObject.Find("JobSlider");
        if (job_inst != null)
        {
            mainJobBar = job_inst.GetComponent<Slider>();
        }
        attr_inst = GameObject.Find("AttrSlider");
        if (attr_inst != null)
        {
            mainAttrBar = attr_inst.GetComponent<Slider>();
        }
        mainHealthBar.minValue = 0;
        mainHealthBar.maxValue = 100;
        mainJobBar.minValue = 0;
        mainJobBar.maxValue = 100;
        mainAttrBar.minValue = 0;
        mainAttrBar.maxValue = 100;
        h_text_ins = GameObject.Find("HealthText");
        h_text = h_text_ins.GetComponent<Text>();
        j_text_ins = GameObject.Find("JobText");
        j_text = j_text_ins.GetComponent<Text>();
        a_text_ins = GameObject.Find("AttrText");
        a_text = a_text_ins.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        mainHealthBar.value = mainStatusCtr.Health;
        mainJobBar.value = mainStatusCtr.Job;
        mainAttrBar.value = mainStatusCtr.Attr;
        h_text.text = mainStatusCtr.Health.ToString();
        j_text.text = mainStatusCtr.Job.ToString();
        a_text.text = mainStatusCtr.Attr.ToString();
    }
}
