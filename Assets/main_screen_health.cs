using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class main_screen_health : MonoBehaviour {
    public RectTransform healthTrans;
    private float cachedY;
    private float minXVal,maxXVal;
    private int curHealth{
        get { return curHealth; }
        set {
            curHealth = value;
            handle_HealthBar();
        }
    }
    public int maxHealth;
    public Text healthText;
    public Image handleHealth;

	// Use this for initialization
	void Start () {
        cachedY = healthTrans.position.y;
        maxXVal = healthTrans.position.x;
        minXVal = healthTrans.position.x - healthTrans.rect.width;
        curHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void handle_HealthBar(){
        healthText.text = curHealth + "/" + maxHealth;

        float curXVal = main_screen_job.StatusVal(curHealth,0,maxHealth,minXVal,maxXVal);
        healthTrans.position = new Vector3(curXVal,cachedY);
    }
    /*
    private float StatusVal(float x,float inMin,float inMax,float outMin,float outMax){
        return (x - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }
    */
}
