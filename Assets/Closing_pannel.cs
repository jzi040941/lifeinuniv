﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Closing_pannel : MonoBehaviour
{
    MainStatusCtr mainStatusCtr;
    GameObject ui_instance;


    public GameObject[] inactive;
    void Start()
    {
		inactive = GameObject.FindGameObjectsWithTag ("uninteratible");

        ui_instance = GameObject.Find("UI");
        mainStatusCtr = ui_instance.GetComponent<MainStatusCtr>();
    }

    public void invokereset()
    {
        Invoke("Closing", 3);
    }

    void Closing()
    {
        gameObject.SetActive(false);
        GameObject.Find("activity_Panel").SetActive(false);

        mainStatusCtr.Act = mainStatusCtr.Act - 1;
//        Debug.Log("remain " + mainStatusCtr.Act + " Act");

		foreach(GameObject a in inactive){
			Button btn = a.GetComponent<Button> ();
			btn.interactable = true;
		}
    } 
}