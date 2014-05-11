using UnityEngine;
using System.Collections;

public class rangetest : MonoBehaviour {
	public GameObject test;

	// Use this for initialization
	void Start () {
		test = Instantiate(test,transform.position,Quaternion.identity) as GameObject;

	}
	
	// Update is called once per frame
	void Update () {
		float xx = Input.mousePosition.x;
		float yy = Input.mousePosition.y;
		Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(xx, yy, -400));
		test.transform.position = pos;

	
	}
}
