using UnityEngine;
using System.Collections;

public class Tuts : MonoBehaviour {
	private int number;
	public int value1;
	public int Number{
		get{ 
			return number;
		}
		set{ 
			if (value > -5 && value < 5) {
				number = value;
			} else
				number = 3;
		}
	}

	void Start()
	{
		print ("2 In Oder");
		Number = value1;
//		print (Number);

	}



	}


