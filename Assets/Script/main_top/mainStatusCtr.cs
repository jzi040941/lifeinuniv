﻿using UnityEngine;
using System.Collections;

public class MainStatusCtr : MonoBehaviour{
	private int health= 0;
	private int job;
	private int attr;
	private int money;
	private int act;
	private int week;	
	private int sem;
	private bool isTest;
	private int year;
	public int Health{
		get{ return health; }
		set{ health = value; }
	} 
	public int Job{
		get{ return job; }
		set{ job = value;}
	}
	public int Attr{
		get{ return attr;}
		set{ attr = value;}
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
			//if(act == 4)

		}
	}
	public int Week{
		get{
			return week;
		}
		set{
			week = value;
		}
	}
	public int Semester{        
		get{ return sem; }
		set{ sem = value; }
	}
	public int IsTest{
		get{ return health; }
		set{ health = value; }
	} 
	public int Year{
		get{ return year; }
		set{ year = value; }
	} 


	void Update(){

	}
}
