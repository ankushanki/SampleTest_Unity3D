using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class TimeZoneTest : MonoBehaviour {

	Dictionary<string, Student> StudentDict = new Dictionary<string, Student>();

	// Use this for initialization
	void Start () {

//		foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
//			if(z.StandardName== "GMT" )
//				print(z.Id);
		
//		TimeZoneInfo timezone = TimeZoneInfo.FindSystemTimeZoneById("Asia/Kolkata");
//		DateTime targetTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId (System.DateTime.Now, "Asia/Kolkata", "Europe/London");
//		Debug.Log (targetTime );

		print("Current time at London: " + ConvertTimeFrom(DateTime.UtcNow).ToString("hh:mm:ss"));// 21/3/2013 
	}

	public DateTime ConvertTimeFrom(DateTime from) {
		//find TimeZoneInfo of PST
		TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("Europe/London");

		//Convert time from Local to PST
		return TimeZoneInfo.ConvertTime(from, TimeZoneInfo.Utc, tzi);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
