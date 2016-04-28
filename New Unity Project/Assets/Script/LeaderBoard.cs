using UnityEngine;
using System.Collections;
using System;

public class LeaderBoard : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
public class UserData: IComparable<UserData>{
	public string name;
	public int score;

	public UserData(string Name, int Scores)
	{
		name = Name;
		score = Scores;
	}

	public int CompareTo(UserData other)
	{
		return other.score - score; 
	}
}

//public class PlayerPref {
//	const string userString = "UserData";
//
//	public void SaveScores( UserData userData )
//	{
//		string json = JsonUtility.ToJson (userData);
//		PlayerPrefs.SetString (userString, json);
//	}
//
//	public void LoadScores(){
//		UserData userData= new UserData();
//		string json = PlayerPrefs.GetString(userString);
//		userData = JsonUtility.FromJson<UserData> (json);
//	}
//	
//}

