using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Closing_pannel : MonoBehaviour
{
	public GameObject[] inactive;
    void Start()
    {
            //Invoke("Closing", 3);
		inactive = GameObject.FindGameObjectsWithTag ("uninteratible");
    }

    void Closing()
    {
        gameObject.SetActive(false);
        GameObject.Find("activity_Panel").SetActive(false);

		foreach(GameObject a in inactive){
			Button btn = a.GetComponent<Button> ();
			btn.interactable = true;
		}

    } 

    public void invokereset()
    {
        Invoke("Closing", 3);
    } 
}