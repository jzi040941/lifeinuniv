using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class mainchar_ani : MonoBehaviour {
    Image myImageComponent;
    Sprite first;
    public Sprite second;

    // Use this for initialization
    void Start () {
        myImageComponent = GetComponent<Image>();
        first = myImageComponent.sprite;
    }
	
    void changemainchar_1()
    {
        myImageComponent.sprite = second;
    }

    void changemainchar_2()
    {
        myImageComponent.sprite = first;
    }

    // Update is called once per frame
    void Update () {
        InvokeRepeating("changemainchar_1", 0.7f, 1.4f);
        InvokeRepeating("changemainchar_2", 1.4f, 1.4f);
    }
}
