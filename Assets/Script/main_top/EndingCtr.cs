using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndingCtr : MonoBehaviour {
    MainStatusCtr mainStatusCtr;
    GameObject ui_instance;
    GameObject healthZeroPopup,stonePopup,failPopup,drunkenPopup;

    // Use this for initialization
    void Start()
    {
        ui_instance = GameObject.Find("UI");
        mainStatusCtr = ui_instance.GetComponent<MainStatusCtr>();
        healthZeroPopup = GameObject.Find("Ending_HealthZero");
        stonePopup = GameObject.Find("Ending_LibraryStone");
        failPopup = GameObject.Find("Ending_GradFail");
        drunkenPopup = GameObject.Find("Ending_Drunken");
    }

    // Update is called once per frame
    void Update () {

	}

    void restart_Init(){
        mainStatusCtr.Health = 100;
        mainStatusCtr.Job = 50;
        mainStatusCtr.Attr = 50;
        mainStatusCtr.Week = 1;
        mainStatusCtr.Semester = 1;
        mainStatusCtr.Act = 3;
        mainStatusCtr.Year = 1;
    }
}
