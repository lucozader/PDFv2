using UnityEngine;
using System.Collections;

public class MineBulletAI : MonoBehaviour {
	Vector3 start = new Vector3();
	public GameObject barrel;

	// Use this for initialization
	void Start () {
		start = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 end = transform.position - start;
		if(end.magnitude >400){
		GameObject barrel1 = Instantiate(barrel, transform.position, Quaternion.identity)as GameObject;
			Vector3 height = new Vector3();
			height.x = barrel1.transform.position.x;
			height.y = 20;
			height.z = barrel1.transform.position.z;

			barrel1.transform.position = height;
			Destroy(gameObject);
		}
	}
}
