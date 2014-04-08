using UnityEngine;
using System.Collections;

public class BulletRangeDestroy : MonoBehaviour {
	public float range;
	float distanceTravelled;
	Vector3 startPosition;
	// Use this for initialization
	void Start () {
		distanceTravelled = 0;
		startPosition = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		distanceTravelled = Vector3.Distance(transform.position,startPosition);
		if(distanceTravelled > range){
			Destroy (gameObject);
		}
	}
}
