using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Closing_pannel : MonoBehaviour
{
    MainStatusCtr mainStatusCtr;
    EndingCtr end_check;
    GameObject ui_instance;
	Image myImageComponent;
	Sprite first;
	public Sprite second;

    public GameObject[] inactive;
    void Start()
    {
		inactive = GameObject.FindGameObjectsWithTag ("uninteratible");
		myImageComponent = GetComponent<Image>(); 
		first = myImageComponent.sprite;

        ui_instance = GameObject.Find("UI");
        mainStatusCtr = ui_instance.GetComponent<MainStatusCtr>();
        end_check = ui_instance.GetComponent<EndingCtr>();
    }

	void changetosecond(){
		myImageComponent.sprite = second;
	}
    public void invokereset()
    {
		Invoke ("changetosecond", 1.5f);
        Invoke("Closing", 3);
    }

    void Closing()
    {
        
        GameObject.Find("activity_Panel").SetActive(false);

        mainStatusCtr.Act = mainStatusCtr.Act - 1;
        //      Debug.Log("remain " + mainStatusCtr.Act + "Act");


		this.chanagestatus (gameObject.name);

        end_check.Ending_Check(mainStatusCtr);

        foreach (GameObject a in inactive){
			Button btn = a.GetComponent<Button> ();
			btn.interactable = true;
		}
		gameObject.SetActive(false);
		myImageComponent.sprite = first;
    }

	void chanagestatus(string name){
		if (name == "Class_Panel")
		{
			mainStatusCtr.Health -= Random.Range(5,15);
			mainStatusCtr.Job = mainStatusCtr.Job + Random.Range(5,15);
		}

		if (name == "Study_Panel")
		{
			mainStatusCtr.Health -= Random.Range (5, 15);
			mainStatusCtr.Job += Random.Range (3, 8);
			mainStatusCtr.Attr += Random.Range (3, 8);
			mainStatusCtr.Money -= Random.Range (30, 101);
		}

		if (name == "Drinking_Panel")
		{
			mainStatusCtr.Health -= Random.Range (15, 31);
			mainStatusCtr.Money -= Random.Range (200, 401);
		}

		if (name == "Part-time_Panel")
		{
			mainStatusCtr.Health -= Random.Range (10, 21);
			mainStatusCtr.Money += Random.Range (100, 301);
		}
	}
}