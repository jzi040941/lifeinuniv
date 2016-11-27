using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndingClose : MonoBehaviour {
    public GameObject obj;
    GameObject ui_instance;
    MainStatusCtr mainStatusCtr;
    GradeCtr gr_check;

	// Use this for initialization
	void Start () {
        ui_instance = GameObject.Find("UI");
        mainStatusCtr = ui_instance.GetComponent<MainStatusCtr>();
        gr_check = ui_instance.GetComponent<GradeCtr>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ending_close()
    {
        obj.SetActive(false);
        restart_Init();
    }

    public void restart_Init()
    {
        mainStatusCtr.Health = 100;
        mainStatusCtr.Job = 50;
        mainStatusCtr.Attr = 50;
        mainStatusCtr.Week = 1;
        mainStatusCtr.Semester = 1;
        mainStatusCtr.Act = 3;
        mainStatusCtr.Year = 1;
        mainStatusCtr.ClassRate = 0;
        mainStatusCtr.LibRate = 0;
        for (int i = 0; i < 8; i++)
        {
            mainStatusCtr.sc_sem[i] = -1;
        }
    }
}
