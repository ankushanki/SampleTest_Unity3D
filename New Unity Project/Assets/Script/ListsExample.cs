using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class ListsExample : MonoBehaviour {

	List<Student> studentList= new List<Student> ();

	// Use this for initialization
	void Start () 
	{
		studentList.Add(new Student( "Student1" , 12 ));	
		studentList.Add(new Student( "Student2" , 25 ));	
		studentList.Add(new Student( "Student3" , 19 ));
		studentList.Add(new Student( "Student4" , 22 ));
		studentList.Add(new Student( "Student5" , 15 ));	

		studentList.Sort ();

//		print ( "Type"+temp.GetType() );

	}
		
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) {

			foreach (var student in studentList) {
				print (student.name + " has age " + student.age); 
			}
		}
	}
}


public class Student : IComparable<Student>
{
	public string name;
	public int age;

	public Student ( string newName, int newAge )
	{
		name = newName;
		age = newAge;

	}

	public int CompareTo(Student other)
	{
		return age - other.age; 
	}
}