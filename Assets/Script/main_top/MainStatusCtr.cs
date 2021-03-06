﻿using UnityEngine;
using System;
using System.Collections;
using System.IO;

public class MainStatusCtr : MonoBehaviour{
    GameObject obj;
    EndingCtr end_check;
	private int health= 0;
	private int job;
	private int attr;
	private int money;
	private int act;
	private int week= 1;
	private int sem;
	private bool isTest;
	private int year = 1;
    private int class_rate = 0;
    private int lib_rate = 0;
	private int max_job = 800;
	private int max_attr = 800;
    public float[] sc_sem = new float[8] { -1,-1,-1,-1,-1,-1,-1,-1};

	public int Max_job {
		get{ return max_job; }
	}
	public int Max_attr {
		get{ return max_attr; }
	}
	public int Health{
		get{ return health; }
		set{ health = value; if (health > 100) health = 100; }
	} 
	public int Job{
		get{ return job; }
		set{ job = value; if (job > max_job) job = max_job; }
	}
	public int Attr{
		get{ return attr;}
		set{ attr = value; if (attr > max_attr) attr = max_attr; }
	}
	public int Money{
		get{
			return money;
		}
		set{
			money = value;
		}
	}
	public int Act {
		get { return act; }
		set { 
			act = value;
			if (act == 0) {
				act = 3;
				Week += 1;
				health += 30;
			}
		}
	}
	public int Week{
		get{
			return week;
		}
		set{
			week = value;
            if (week == 4)
            {
                week = 5;
            }
			if (week == 8) {
				week = 1;
                end_check.ending_fail_check(this);
				Semester += 1;
			}
		}
	}
	public int Semester{        
		get{ return sem; }
		set{ sem = value;
			if (sem == 9) {
				sem = 1;
				//Year += 1;
			}
		}
	}
	public int IsTest{
		get{ return health; }
		set{ health = value; }
	} 
	public int Year{
		get{ return year; }
		set{ year = value; }
	}
    public int ClassRate{
        get { return class_rate; }
        set { class_rate = value; }
    }
    public int LibRate{
        get { return lib_rate; }
        set { lib_rate = value; }
    }
	private string str_init;
	private string[] val;

	void Start(){
		int val_in;
        float sc_in;
        obj = GameObject.Find("UI");
        end_check = obj.GetComponent<EndingCtr>();
		try
		{
            //StreamReader sc = new StreamReader("last_status.txt");
			System.IO.StreamReader sc = System.IO.File.OpenText(Application.persistentDataPath + "/last_status.txt");

			str_init = sc.ReadLine();
			val = str_init.Split(' ');
			for (int i=0;i<val.Length;i++) {
				val_in = Int32.Parse(val[i]);

				switch (i) {
				case 0: Health = val_in; break;
				case 1: Job = val_in; break;
				case 2: Attr = val_in; break;
				case 3: Money = val_in; break;
				case 4: Week = val_in; break;
				case 5: Semester = val_in; break;
				case 6: Act = val_in; break;
				case 7: Year = val_in; break;
                case 8: ClassRate = val_in; break;
                case 9: LibRate = val_in; break;
				}
			}
            str_init = sc.ReadLine();
            val = str_init.Split(' ');
            for (int i=0;i<8;i++)
            {
                sc_in = float.Parse(val[i]);
                sc_sem[i] = sc_in;
            }
			sc.Close();
		}
		//catch (System.IO.FileNotFoundException)
        catch (Exception)
        {
			EndingCtr temp = GameObject.Find ("UI").GetComponent<EndingCtr> ();
			temp.restart_Init (this);
		}
		//sc = new StreamReader("last_status.txt");
		//sc = new StreamReader(Application.persistentDataPath + "/last_status.txt");

			
	}


	void Update(){

	}
}
