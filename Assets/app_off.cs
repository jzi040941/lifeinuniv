using UnityEngine;
using System.Collections;
using System.IO;

public class app_off : MonoBehaviour {
    MainStatusCtr mainStatusCtr;
    GameObject ui_instance;
    StreamWriter sw = null;
    // Use this for initialization
    void Start () {
	    ui_instance = GameObject.Find("UI");
        mainStatusCtr = ui_instance.GetComponent<MainStatusCtr>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("escape")){
            sw = new StreamWriter("last_status.txt", false);
            sw.Write(mainStatusCtr.Health.ToString()+" ");
            sw.Write(mainStatusCtr.Job.ToString()+" ");
            sw.Write(mainStatusCtr.Attr.ToString()+" ");
            sw.Write(mainStatusCtr.Money.ToString()+" ");
            sw.Write(mainStatusCtr.Week.ToString()+" ");
            sw.Write(mainStatusCtr.Semester.ToString()+" ");
            sw.Write(mainStatusCtr.Act.ToString()+" ");
            sw.Write(mainStatusCtr.Year.ToString());
            sw.Close();
            Application.Quit();
        }
	}
}
