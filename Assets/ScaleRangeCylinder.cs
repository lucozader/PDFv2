using UnityEngine;
using System.Collections;

public class ScaleRangeCylinder : MonoBehaviour {
	public static float radius;
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		radius = StoreRange.rangee;
		Vector3 victor = new Vector3(radius,10,radius);

		transform.localScale = victor;
	}
}
