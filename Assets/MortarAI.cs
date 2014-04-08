using UnityEngine;
using System.Collections;

public class MortarAI : MonoBehaviour
{float lobAmount = 1;
	public GameObject explosion;

	// Use this for initialization
	void Start () {
	
	}

	void Update(){

	//	Vector3 verticalForce = new Vector3(0,-2,0);
		//gameObject.rigidbody.AddForce(verticalForce,ForceMode.VelocityChange);

	}
	
	// Update is called once per frame
	void OnCollisionEnter(Collision collision){
		if(collision.collider.tag=="Sea")
		{
		Instantiate(explosion, collision.contacts[0].point, Quaternion.identity);

			Destroy(gameObject);}
	
	}
	


}
