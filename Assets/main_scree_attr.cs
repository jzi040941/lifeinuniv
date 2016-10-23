using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class main_scree_attr : MonoBehaviour {
    public RectTransform attrTrans;
    private float cachedY,minXVal,maxXVal;
    private int curAttr
    {
        get { return curAttr; }
        set{
            curAttr = value;
        }
    }
    public int maxAttr;
    public Text AttrText;
    public Image handleAttr;

    // Use this for initialization
    void Start () {
        cachedY = attrTrans.position.y;
        maxXVal = attrTrans.position.x;
        minXVal = attrTrans.position.x - attrTrans.rect.width;
        curAttr = maxAttr;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void handle_AttrBar()
    {
        AttrText.text = curAttr + "/" + maxAttr;

        float curXVal = main_screen_job.StatusVal(curAttr, 0, maxAttr, minXVal, maxXVal);
        attrTrans.position = new Vector3(curXVal, cachedY);
    }
    /*
    private float StatusVal(float x, float inMin, float inMax, float outMin, float outMax)
    {
        return (x - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }
    */
}
