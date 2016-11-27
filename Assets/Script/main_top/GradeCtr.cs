using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GradeCtr : MonoBehaviour {
    MainStatusCtr mainStatusCtr;
    GameObject ui_instance;
    public Text[] grade;
    public Text cgpa;
    float cgpa_sc;

	// Use this for initialization
	void Start () {
        ui_instance = GameObject.Find("UI");
        mainStatusCtr = ui_instance.GetComponent<MainStatusCtr>();
        cgpa_sc = 0;
        for (int i=0;i<8;i++)
        {
            if (mainStatusCtr.sc_sem[i] != -1)
            {
                cgpa_sc += mainStatusCtr.sc_sem[i];
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        for (int i=0;i<8;i++)
        {
            if (mainStatusCtr.sc_sem[i] == -1)
            {
                grade[i].text = "N/A";
            }
            else
            {
                grade[i].text = mainStatusCtr.sc_sem[i].ToString();
            }
        }
        if (cgpa_sc == 0)
        {
            cgpa.text = "N/A";
        }
        else
        {
            cgpa.text = cgpa_sc.ToString();
        }
	}
}
