using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelGenerator : MonoBehaviour {
	public List<GameObject> Secondlayer;
	public List<GameObject> Thirdlayer;
	public List<GameObject> Fouthlayer;

	List<GameObject> activeElements = new List<GameObject> ();
	// different layer move in different speed.
	public float scrollSpeed = 2;
	float scrollBackg;
	float scrollMiddle;
	float scrollForg;

		
	// Use this for initialization
	void Start () {


		scrollForg = scrollSpeed * 4;
		scrollMiddle = scrollSpeed * 8;
		scrollBackg = scrollSpeed * 12;

		GenerateSecondlayer (1);




		
	}
	
	// Update is called once per frame
	void Update () 
	{
		

		
	}
	void scrolllevel()
	{
		for (int i = 0; i < activeElements.Count; i++) 
		{
			switch (activeElements [i].tag) 
			{
			case "Secondlayer":
				activeElements [i].transform.position = Vector2.left * scrollBackg * Time.deltaTime;
					break;
			case "Thirdlayer":
				activeElements [i].transform.position = Vector2.left * scrollMiddle * Time.deltaTime;
				break;
			case "Fouthlayer":
				activeElements [i].transform.position = Vector2.left * scrollForg * Time.deltaTime;
				break;

			}
		}
	}
	void GenerateSecondlayer(int x)
	{
		int n = Random.Range (0, Secondlayer.Count);
		GameObject go = Secondlayer [n];
		Secondlayer.Remove (go);
		activeElements.Add (go);
	}
}


