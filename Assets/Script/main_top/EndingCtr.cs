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
       
    }

    public void ending_check(MainStatusCtr mainStatusCtr,bool library,bool drunken) {
        if (mainStatusCtr.Health == 0)
        {
            h_zero_ins.SetActive(!h_zero_ins.activeSelf);
        } // ê³¼ë¡œ?? ?”ë”©
        else if (mainStatusCtr.Health <= 20)
        {
            int rand = (int)Random.Range(0.0f, 100.0f);
            if (rand < 10) {
                if (library == true)
                {
                    stone_ins.SetActive(!stone_ins.activeSelf);
                } // ?”ì„
                if (drunken == true)
                {
                    drunken_ins.SetActive(!drunken_ins.activeSelf);
                } // ?‘ì—­??
            }
        }
    }

    public bool ending_fail_check(MainStatusCtr mainStatusCtr)
    {
        int r_num = (int)Random.Range(0.0f, 100.0f);
        if (mainStatusCtr.ClassRate >= 4){
            if (mainStatusCtr.LibRate <= 2 && r_num < 5) {
                fail_ins.SetActive(!fail_ins.activeSelf);
                return true;
            }
            else {
                mainStatusCtr.sc_sem[mainStatusCtr.Semester - 1] = Random.Range(2.2f,4.2f);
            }
        }
        else if (mainStatusCtr.ClassRate > 2) {
            if (mainStatusCtr.LibRate <= 3 && r_num < 10) {
                fail_ins.SetActive(!fail_ins.activeSelf);
                return true;
            }
            else
            {
                mainStatusCtr.sc_sem[mainStatusCtr.Semester - 1] = Random.Range(2.2f, 4.2f);
            }
        }
        else if (mainStatusCtr.ClassRate <= 2){
            return true;
        }
        return false;
    }

    public void restart_Init(MainStatusCtr mainStatusCtr){
        mainStatusCtr.Health = 100;
        mainStatusCtr.Job = 50;
        mainStatusCtr.Attr = 50;
        mainStatusCtr.Week = 1;
        mainStatusCtr.Semester = 1;
        mainStatusCtr.Act = 3;
        mainStatusCtr.Year = 1;
        mainStatusCtr.ClassRate = 0;
        mainStatusCtr.LibRate = 0;
        for (int i = 0; i < 8;i++)
        {
            mainStatusCtr.sc_sem[i] = -1;
        }
		mainStatusCtr.Money = 0;
    }

	public void restart_Init(){
		mainStatusCtr.Health = 100;
		mainStatusCtr.Job = 50;
		mainStatusCtr.Attr = 50;
		mainStatusCtr.Week = 1;
		mainStatusCtr.Semester = 1;
		mainStatusCtr.Act = 3;
		mainStatusCtr.Year = 1;
		for (int i = 0; i < 8;i++)
        {
            mainStatusCtr.sc_sem[i] = -1;
        }
	}
}
