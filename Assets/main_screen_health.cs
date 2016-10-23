using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class main_screen_health : MonoBehaviour {
    public RectTransform healthTrans; // 체력바를 Control하는 변수
    private float cachedY;
    private float minXVal,maxXVal; // 체력 최소, 최대 위치
    private int curHealth{
        get { return curHealth; }
        set {
            curHealth = value;
            handle_HealthBar();
        }
    } // 현재 체력
    public int maxHealth; // 최대 체력
    public Text healthText; // 체력 수치 표시
    public Image handleHealth;
    private const int ScaleValue = 10;

	// Use this for initialization
	void Start () {
        cachedY = healthTrans.position.y;
        maxXVal = healthTrans.position.x;
        minXVal = healthTrans.position.x - healthTrans.rect.width;
        curHealth = maxHealth;

        /*
        healthText = gameObject.GetComponent<Text>();

        healthText.fontSize = healthText.fontSize * ScaleValue;

        healthText.transform.localScale = healthText.transform.localScale / ScaleValue;

        healthText.horizontalOverflow = HorizontalWrapMode.Overflow;
        healthText.verticalOverflow = VerticalWrapMode.Overflow;
        */
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void handle_HealthBar(){
        healthText.text = curHealth + "/" + maxHealth; // 현재 체력과 최대 체력 동시 표시

        float curXVal = StatusVal(curHealth,0,maxHealth,minXVal,maxXVal);
        healthTrans.position = new Vector3(curXVal,cachedY);
    }
   
   public static float StatusVal(float x,float inMin,float inMax,float outMin,float outMax){
        return (x - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }
    
}
