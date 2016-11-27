using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class change_panel : MonoBehaviour {
    MainStatusCtr mainStatusCtr;
    GameObject ui_instance;
    Image myImageComponent;
    Sprite first;
    public Sprite second;


    // Use this for initialization
    void Start () {

        myImageComponent = GetComponent<Image>();
        first = myImageComponent.sprite;

        ui_instance = GameObject.Find("UI");
        mainStatusCtr = ui_instance.GetComponent<MainStatusCtr>();
    }


    void changetosecond()
    {
        myImageComponent.sprite = second;
    }

    void changetofirst()
    {
        myImageComponent.sprite = first;
    }

    public void invokereset()
    {
        Invoke("changetosecond", 0.5f);
        Invoke("changetofirst", 1.0f);
        Invoke("changetosecond", 1.5f);
        Invoke("changetofirst", 2.0f);
        Invoke("changetosecond", 2.5f);

        Invoke("Closing2", 3);
    }

    void exam_open()
    {
        //GameObject.Find("examp_panel").SetActive(false);\
        GameObject.Find("UI").transform.FindChild("exam_panel").gameObject.SetActive(true);
    }

    void exam_close()
    {
        //GameObject.Find("examp_panel").SetActive(false);\
        GameObject.Find("UI").transform.FindChild("exam_panel").gameObject.SetActive(false);
    }

    void vaca_open()
    {
        //GameObject.Find("examp_panel").SetActive(false);\
        GameObject.Find("UI").transform.FindChild("vaca_panel").gameObject.SetActive(true);
    }

    void vaca_close()
    {
        //GameObject.Find("examp_panel").SetActive(false);\
        GameObject.Find("UI").transform.FindChild("vaca_panel").gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Closing2() {
        gameObject.SetActive(false);
        myImageComponent.sprite = first;

        //?�험�? ?�널 ?�게 ()?�에 조건
        if (((mainStatusCtr.Week == 5) || ((mainStatusCtr.Week == 1) && (mainStatusCtr.Semester != 1))) && mainStatusCtr.Act == 3)
        {
            Invoke("exam_open", 0.1f);
            Invoke("exam_close", 3.1f);
            //GameObject.Find("UI").transform.FindChild("exam_panel").gameObject.SetActive(mainStatusCtr.Week==2);
        }

        //방학�? ?�널 ?�게 ()?�에 조건
        if (((mainStatusCtr.Week == 1) && (mainStatusCtr.Semester != 1)) && mainStatusCtr.Act == 3)
        {
            Invoke("vaca_open", 3.2f);
            Invoke("vaca_close", 6.2f);
            //GameObject.Find("UI").transform.FindChild("exam_panel").gameObject.SetActive(mainStatusCtr.Week==2);
        }
    }
}
