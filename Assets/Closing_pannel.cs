using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Closing_pannel : MonoBehaviour
{
    MainStatusCtr mainStatusCtr;
    EndingCtr end_check;
    GameObject ui_instance;
    Image myImageComponent;

    bool library_flag = false;
    bool drunken_flag = false;
	public GameObject[] inactive;
    void Start()
    {
		inactive = GameObject.FindGameObjectsWithTag ("uninteratible");

        ui_instance = GameObject.Find("UI");
       // Debug.Log("hello" + ui_instance.name);
        mainStatusCtr = ui_instance.GetComponent<MainStatusCtr>();

        end_check = ui_instance.GetComponent<EndingCtr>();
        
    }
    public void invoke()
    {
        Invoke("Closing", 3.0f);
    }
 
    public void Closing()
    {


        GameObject.Find("activity_Panel").SetActive(false);

        mainStatusCtr.Act = mainStatusCtr.Act - 1;


		this.chanagestatus (gameObject.name);

		end_check.ending_check();
        drunken_flag = false; library_flag = false;

        foreach (GameObject a in inactive){
			Button btn = a.GetComponent<Button> ();
			btn.interactable = true;
		}

        gameObject.SetActive(false);

    }

	void chanagestatus(string name){
		if (name == "Class_Panel")
		{
			mainStatusCtr.Health -= Random.Range(5,15);
			mainStatusCtr.Job = mainStatusCtr.Job + Random.Range(5,15);
            mainStatusCtr.ClassRate++;
		}

		if (name == "Study_Panel")
		{
			mainStatusCtr.Health -= Random.Range (5, 15);
			mainStatusCtr.Job += Random.Range (3, 8);
			mainStatusCtr.Attr += Random.Range (3, 8);
			mainStatusCtr.Money -= Random.Range (30, 101);
            library_flag = true;
            mainStatusCtr.LibRate++;
		}

		if (name == "Drinking_Panel")
		{
			mainStatusCtr.Health -= Random.Range (15, 31);
			mainStatusCtr.Money -= Random.Range (200, 401);
            drunken_flag = true;
		}

		if (name == "Part-time_Panel")
		{
			mainStatusCtr.Health -= Random.Range (10, 21);
			mainStatusCtr.Money += Random.Range (100, 301);
		}
	}


}