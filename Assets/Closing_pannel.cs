using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Closing_pannel : MonoBehaviour
{
    MainStatusCtr mainStatusCtr;
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
        
    }

    void changetosecond()
    {
        myImageComponent.sprite = second;
    }

    void changetofirst()
    {
        myImageComponent.sprite = first;
    }

    public void invokereset()
    {
        Invoke("changetosecond", 0.5f);
        Invoke("changetofirst", 1.0f);
        Invoke("changetosecond", 1.5f);
        Invoke("changetofirst", 2.0f);
        Invoke("changetosecond", 2.5f);

        Invoke("Closing", 3);
    }

    void exam_open()
    {
        //GameObject.Find("examp_panel").SetActive(false);\
        GameObject.Find("UI").transform.FindChild("exam_panel").gameObject.SetActive(true);
    }

    void exam_close()
    {
        //GameObject.Find("examp_panel").SetActive(false);\
        GameObject.Find("UI").transform.FindChild("exam_panel").gameObject.SetActive(false);
    }

    void vaca_open()
    {
        //GameObject.Find("examp_panel").SetActive(false);\
        GameObject.Find("UI").transform.FindChild("vaca_panel").gameObject.SetActive(true);
    }

    void vaca_close()
    {
        //GameObject.Find("examp_panel").SetActive(false);\
        GameObject.Find("UI").transform.FindChild("vaca_panel").gameObject.SetActive(false);
    }

    void Closing()
    {
        
        GameObject.Find("activity_Panel").SetActive(false);

        mainStatusCtr.Act = mainStatusCtr.Act - 1;
        //      Debug.Log("remain " + mainStatusCtr.Act + "Act");


		this.chanagestatus (gameObject.name);
			
        foreach (GameObject a in inactive){
			Button btn = a.GetComponent<Button> ();
			btn.interactable = true;
		}
		gameObject.SetActive(false);
		myImageComponent.sprite = first;

        //시험중 패널 뜨게 ()안에 조건
        if ( ((mainStatusCtr.Week  == 5) || ((mainStatusCtr.Week == 1) && (mainStatusCtr.Semester != 1))) && mainStatusCtr.Act == 3)
        {
            Invoke("exam_open", 0.1f);
            Invoke("exam_close", 3.1f);
            //GameObject.Find("UI").transform.FindChild("exam_panel").gameObject.SetActive(mainStatusCtr.Week==2);
        }

        //방학중 패널 뜨게 ()안에 조건
        if ( ( (mainStatusCtr.Week == 1) && (mainStatusCtr.Semester != 1) ) && mainStatusCtr.Act == 3)
        {
            Invoke("vaca_open", 3.2f);
            Invoke("vaca_close", 6.2f);
            //GameObject.Find("UI").transform.FindChild("exam_panel").gameObject.SetActive(mainStatusCtr.Week==2);
        }
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