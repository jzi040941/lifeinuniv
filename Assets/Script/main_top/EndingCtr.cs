using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndingCtr : MonoBehaviour {
    public GameObject healthZeroPopup,stonePopup,failPopup,drunkenPopup;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update () {

	}

    public void Ending_Check(MainStatusCtr mainStatusCtr)
    {
        if (mainStatusCtr.Health <= 0)
        {
            mainStatusCtr.Health = 0;
            healthZeroPopup.SetActive(!healthZeroPopup.activeSelf);
        }
        /*
        else if (mainStatusCtr.Health <= 20)
        {
            int rand = (int)Random.Range(0.0f, 100.0f);
            if (rand < 21 - mainStatusCtr.Health)
            {
                drunken_ins.SetActive(!drunken_ins.activeSelf);
                restart_Init();
            }
        }
        */
    }
}
