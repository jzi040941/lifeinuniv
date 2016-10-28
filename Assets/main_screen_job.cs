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
    public int maxJob = 100;
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

        float curXVal = main_screen_health.StatusVal(curJob, 0, maxJob, minXVal, maxXVal);
        jobTrans.position = new Vector3(curXVal, cachedY);
    }
    
}
