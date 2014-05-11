using UnityEngine;
using System.Collections;

public class MineBulletAI : MonoBehaviour {
	Vector3 test = new Vector3();

	Vector3 start = new Vector3();
	public GameObject barrel;
	public int pedistal;
	public int direction;
	// Use this for initialization
	void Start () {
		start = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(direction == 1){
			test = new Vector3(0,0,500);}
		if(direction == 0){
			test = new Vector3(0,0,-500);}
		if(direction == 2){
			test = new Vector3(-500,0,0);}
		if(direction == 3){
			test = new Vector3(500,0,0);}
		transform.position = transform.position+test*Time.deltaTime;
		Vector3 end = transform.position - start;
		if(end.magnitude >400){
		GameObject barrel1 = Instantiate(barrel, transform.position, Quaternion.identity)as GameObject;
			barrel1.GetComponent<Barrel>().pedistal = pedistal;

			Vector3 height = new Vector3();
			height.x = barrel1.transform.position.x;
			height.y = -350;
			height.z = barrel1.transform.position.z;

			barrel1.transform.position = height;
			Destroy(gameObject);
		}
	}
}
