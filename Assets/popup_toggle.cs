using UnityEngine;
//using UnityEditor;
using System.Collections;


public class popup_toggle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Example() {
	//print ("a");
       gameObject.SetActive(!gameObject.activeSelf);
    }
}
