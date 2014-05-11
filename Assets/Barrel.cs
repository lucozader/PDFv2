using UnityEngine;
using System.Collections;

public class Barrel : MonoBehaviour {
	public GameObject explosion;
	public int pedistal;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision){
		if(collision.collider.gameObject.layer == LayerMask.NameToLayer("Enemy"))
		{
			GameObject[] pro = GameObject.FindGameObjectsWithTag("Miner");
			for(int i = 0;i<pro.Length;i++){
				if(pro[i].GetComponent<MineAI>().pedistal == pedistal){
					pro[i].GetComponent<MineAI>().refire = true;
					Debug.Log("refire");
					Instantiate(explosion, transform.position, Quaternion.identity);
					Destroy(gameObject);
				}
			}
			//health= health - (health+ increase1*(health/100));

		}
	}
}
