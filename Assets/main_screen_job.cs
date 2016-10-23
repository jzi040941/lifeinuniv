using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class main_screen_job : MonoBehaviour {
    public RectTransform jobTrans;
    private float cachedY, minXVal, maxXVal;
    public int curJob
    {
        get { return curJob; }
        set{
            curJob = value;

        }
    }
    public int maxJob;
    public Text jobText;
    public Image HandleJob;

	// Use this for initialization
	void Start () {
        cachedY = jobTrans.position.y;
        minXVal = jobTrans.position.x;
        maxXVal = jobTrans.position.x - jobTrans.rect.width;
        curJob = maxJob;
	}

    // Update is called once per frame
    void Update () {
	
	}

    private void handle_JobBar()
    {
        jobText.text = curJob + "/" + maxJob;

        float curXVal = StatusVal(curJob, 0, maxJob, minXVal, maxXVal);
        jobTrans.position = new Vector3(curXVal, cachedY);
    }

    public static float StatusVal(float x, float inMin, float inMax, float outMin, float outMax)
    {
        return (x - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }
}
