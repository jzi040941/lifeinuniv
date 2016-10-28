using UnityEngine;
using System.Collections;

public class Closing_pannel : MonoBehaviour
{
    void Start()
    {
        Invoke("Closing", 3);
    }

    void Closing()
    {
        gameObject.SetActive(false);
        GameObject.Find("activity_Panel").SetActive(false);
    } 
}