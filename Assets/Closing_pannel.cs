using UnityEngine;
using System.Collections;

public class Closing_pannel : MonoBehaviour
{
	void Start ()
    {
        InvokeRepeating("Closing", 3, 3);
	}
	
    void Closing()
    {
        gameObject.SetActive(false);
    } 
    
}