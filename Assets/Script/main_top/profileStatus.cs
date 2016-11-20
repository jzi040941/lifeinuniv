using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class profileStatus : MonoBehaviour {
    MainStatusCtr mainStatusCtr;
    GameObject ui_instance,health_p_inst,job_p_inst,attr_p_inst;
    public Slider profileHealthBar; // 메인 화면의 체력 Bar
    public Slider profileJobBar; // 메인 화면의 취업률 Bar
    public Slider profileAttrBar; // 메인 화면의 매력 Bar

    // Use this for initialization
    void Start () {
        ui_instance = GameObject.Find("UI");
        mainStatusCtr = ui_instance.GetComponent<MainStatusCtr>();
        health_p_inst = GameObject.Find("HealthSlider(profile)");
        if (health_p_inst != null)
        {
            profileHealthBar = health_p_inst.GetComponent<Slider>();
        }
        job_p_inst = GameObject.Find("JobSlider(profile)");
        if (job_p_inst != null)
        {
            profileJobBar = job_p_inst.GetComponent<Slider>();
        }
        attr_p_inst = GameObject.Find("AttrSlider(profile)");
        if (attr_p_inst != null)
        {
            profileAttrBar = attr_p_inst.GetComponent<Slider>();
        }
        profileHealthBar.minValue = 0;
        profileHealthBar.maxValue = 100;
        profileJobBar.minValue = 0;
        profileJobBar.maxValue = 100;
        profileAttrBar.minValue = 0;
        profileAttrBar.maxValue = 100;
    }
	
	// Update is called once per frame
	void Update () {
        profileHealthBar.value = mainStatusCtr.Health;
        profileJobBar.value = mainStatusCtr.Job;
        profileAttrBar.value = mainStatusCtr.Attr;
    }
}
