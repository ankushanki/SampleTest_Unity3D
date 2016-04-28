using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
	[SerializeField]
	private GameObject firstPanel;
	[SerializeField]
	private GameObject secondPanel;
	[SerializeField]
	private float speed= 180f;

	bool isRightFace = true;

	bool isFacingUp = true;

	bool isRotating= false;
	// Use this for initialization
	void Start () {
		secondPanel.gameObject.SetActive (false);
//		if (isRotating) {
//			return;
//		}
	}
	
	// Update is called once per frame
	void Update () {
		
		secondPanel.SetActive (!isRightFace);
		firstPanel.SetActive (isRightFace);

	}
	void OnMouseDown()
	{
		print ("MouseDown");

		if( isRotating )
		{
			return;
		}

		StartCoroutine (RotateNintyDeg());
	}

	IEnumerator RotateNintyDeg()
	{
		print ("Coroutine called");
		isRotating = true;
		bool isDone = false;
		while (!isDone) 
		{
			float degrees = speed * Time.deltaTime;

			if (!isFacingUp) 
			{
				degrees = -degrees;

			}

			transform.Rotate (new Vector3 (0, degrees, 0));

			if (180 < transform.eulerAngles.y) 
			{
				transform.Rotate (new Vector3 (0, -degrees, 0));

				isDone = true;

			}
			if (90 > transform.eulerAngles.y) 
			{
				isRightFace = true;
			}
			if (90 < transform.eulerAngles.y) 
			{
				isRightFace = false;
			}

			yield return null;
		}
		isFacingUp = !isFacingUp;

		isRotating = false;
		print ("end Coroutine");
	}
	
}
