using UnityEngine;
using System.Collections;

public class Barrel : MonoBehaviour {
	public GameObject explosion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision){
		if(collision.collider.gameObject.layer == LayerMask.NameToLayer("Enemy"))
		{
			//health= health - (health+ increase1*(health/100));
			Instantiate(explosion, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}
}
