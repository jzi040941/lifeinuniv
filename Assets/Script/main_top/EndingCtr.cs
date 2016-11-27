using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndingCtr : MonoBehaviour {
    MainStatusCtr mainStatusCtr;
    GameObject ui_instance;
    public GameObject h_zero_ins,stone_ins,fail_ins,drunken_ins;

    // Use this for initialization
    void Start()
    {
        ui_instance = GameObject.Find("UI");
        mainStatusCtr = ui_instance.GetComponent<MainStatusCtr>();
        //stonePopup = GameObject.Find("Ending_LibraryStone");
        //failPopup = GameObject.Find("Ending_GradFail");
        //drunkenPopup = GameObject.Find("Ending_Drunken");
    }

    // Update is called once per frame
    void Update () {
        /*
        if (mainStatusCtr.Health == 0)
        {
            h_zero_ins.SetActive(!h_zero_ins.activeSelf);
            restart_Init();
        } // 과로사 엔딩
        else if (mainStatusCtr.Health <= 20)
        {
            int rand = (int)Random.Range(0.0f, 100.0f);
            if (rand < 21 - mainStatusCtr.Health)
            {
                drunken_ins.SetActive(!drunken_ins.activeSelf);
                restart_Init();
            }
        }
        */
    }

    public void ending_check() {
        if (mainStatusCtr.Health == 0)
        {
            h_zero_ins.SetActive(!h_zero_ins.activeSelf);
            restart_Init();
        } // 과로사 엔딩
        else if (mainStatusCtr.Health <= 20)
        {
            int rand = (int)Random.Range(0.0f, 100.0f);
            if (rand < 21 - mainStatusCtr.Health)
            {
                drunken_ins.SetActive(!drunken_ins.activeSelf);
                restart_Init();
            }
        }
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
