using UnityEngine;
using System.Collections;

public class ExplosionWater : MonoBehaviour {
	public GameObject explosion;

	void OnCollisionEnter(Collision collision)
	{
		if(collision.collider.tag == "Mortar")
			{
		//health= health - (health+ increase1*(health/100));
			Instantiate(explosion, collision.contacts[0].point, Quaternion.identity);
			Destroy(collision.collider.gameObject);
		}		}}