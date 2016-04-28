using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class tuts2 : MonoBehaviour {
//
//	// Use this for initialization
	void Start () 
	{
		object a = 10;
		print ("Sum is = " + Sum<float>(2.3f, 5.5f));
	}

////		Tuts tuts = new Tuts ();
////		List<Student> NO = new List<Student> ();
////		NO.Add(new Student("Name",90));
////		NO.Add (new Student ("John", 80));
//////		Debug.Log(tuts.Sum<int> (4, 6));
////		foreach (Student stu in NO) {
////			print(stu.name+"has got"+ stu.marks);
////		}
//	
	// Update is called once per frame
	void Update () {
	
	}

	public float Sum<T>(T a, T b) 
//	where T:int
{
		string  dyA = a.ToString();
		string  dyB = b.ToString();

		float sum = float.Parse (dyA) + float.Parse (dyB);

		return sum;
 }
}
