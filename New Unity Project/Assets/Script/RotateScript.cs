using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour 
{
	#region
	[SerializeField]
	bool isRotating= false;
	#endregion

	public delegate void MyDelegate(float Float); 
	public MyDelegate myDelegate;

	void Start()
	{
//		print ("3 In Oder");
		myDelegate = Rotate;
	}

	void OnMouseDown()
	{
		myDelegate (180f);
	}

	void OnMouseUp()
	{
//		print ("MouseUp");
		myDelegate (1f);
	}

	/* do it in method*/

	void Rotate( float angle )
	{
		if ( isRotating )
		{
//			print ("rotation pending");
			return;
		}

		StartCoroutine(RotateTowardsRight(angle));
	}
		
		
	IEnumerator RotateTowardsRight(float Angle)
	{
		isRotating = true;

		bool isDone = false;
		while (!isDone) 
		{
			float degrees = 180 * Time.deltaTime;

//			if (!isFacingUp) 
//			{
//				degrees = -degrees;
//
//			}

			transform.Rotate (new Vector3 (0, degrees, 0));

			if (180 < transform.eulerAngles.y) 
			{
				transform.Rotate (new Vector3 (0, -degrees, 0));

				isDone = true;

			}

			yield return null;
		}

//		print ("IsDone = " + Angle);
		isRotating = false;
	}

//	IEnumerator RotateTowardsLeft(float Angle)
//	{
//		print ("Coroutine called with " + Angle);
//		isRotating = true;
//
//		while (transform.rotation.eulerAngles.y > Angle) 
//		{
//			float target= 180 * Time.deltaTime;
//			this.transform.Rotate (transform.localRotation.x, -target, 0); 
//			yield return null;
//		}
//		print ("IsDone = " + Angle);
//		isRotating = false;
//	}
}
