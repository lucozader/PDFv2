using UnityEngine;
using System.Collections;

public class cannontest : MonoBehaviour {
	int fall = 0;
	public GameObject smallExplosion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x,70,transform.position.z+fall*Time.deltaTime);
		fall = fall -10;
		if(transform.position.z<1770){
			GameObject explosion = Instantiate(smallExplosion, transform.position,Quaternion.identity) as GameObject;
			Destroy (gameObject);}
	}
}
