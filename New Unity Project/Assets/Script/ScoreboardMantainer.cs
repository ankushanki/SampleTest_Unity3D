using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ScoreboardMantainer : MonoBehaviour {

	const string nameString= "LeaderBoardName";
	const string scoreString= "LeaderBoardScores";
	const int MaxCount = 10;

	[SerializeField]
	private string UserName;
	[SerializeField]
	private int highScores;
	bool addNew= true;

	private List<UserData> LeadersList = new List<UserData> ();

	void Start()
	{

		GetScores ();
	}

	void OnGUI()
	{
		if (GUI.Button(new Rect(Screen.width/2,Screen.height/2,100,50), "Save Score"))
		{
			UserData userdata = new UserData (UserName, highScores);

			RemoveRegisteredUser (userdata);

			if (addNew) {
				LeadersList.Add (userdata);
			}
			addNew = true;

			SaveScores ();
		}
		if (GUI.Button(new Rect(Screen.width/2-120,Screen.height/2,100,50), "Print Score list"))
		{
			for(int i= 0; i< LeadersList.Count; i++)
			{ 
				int rank = i + 1;
				Debug.Log("# "+ rank +"  "+ LeadersList[i].name + " scores - " + LeadersList[i].score);
			}
		}

		if (GUI.Button (new Rect (Screen.width/2-30, Screen.height/3, 50, 50), "Reset"))
		{
			PlayerPrefs.DeleteAll ();
			LeadersList.Clear();
		}
	}

	void RemoveRegisteredUser(UserData userdata)
	{
		for (int i = 0; i < LeadersList.Count; i++) 
		{
			if (LeadersList [i].name == userdata.name) 
			{
				if (LeadersList [i].score < userdata.score) {
					LeadersList.RemoveAt (i);

					Debug.Log (userdata.name + " is already there, Hence removing ");
				} 
				else 
				{
					addNew = false;
				}
			}
				
		}
	
	}

	void SaveScores()
	{
		Sort ();

		for (int i = 0; i < LeadersList.Count; i++) {
			if (LeadersList.Count >= MaxCount) 
			{
				LeadersList.RemoveAt(LeadersList.Count-1);
			}
			UserData userdata= LeadersList.ElementAt(i);
			PlayerPrefs.SetString (nameString + i, userdata.name);
			PlayerPrefs.SetInt (scoreString + i, userdata.score);
		}


	}

	void Sort(){
	
		LeadersList.Sort( (a,b)=> b.score.CompareTo(a.score));
	}

	void GetScores()
	{
		for (int i = 0; i < MaxCount; i++) {
			

			UserData userdata= new UserData(PlayerPrefs.GetString (nameString + i),
				PlayerPrefs.GetInt (scoreString + i));
			
			if (PlayerPrefs.GetString (nameString + i) != "") 
			{				
				LeadersList.Add (userdata);
			}
		}

	}
}
