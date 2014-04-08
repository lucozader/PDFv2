using UnityEngine;
using System.Collections;

public class TextFixRotation : MonoBehaviour {
	public static float timer;
	public static bool death;

	//public TextMesh p_3dText_health;


	// Use this for initialization
	void Start () {
		timer = 3;
		transform.Rotate(90,0,0);
		death = false;
	}
	
	// Update is called once per frame
	void Update () {
		TextMesh tm = GetComponentInChildren<TextMesh>();

		if(timer <3 && timer > 2){

			
			tm.text = new string('3',1);
		;


		}
		if(timer <2 && timer > 1){

			tm.text = new string('2',1);

		}
		if(timer <1 && timer > 0){
	
			tm.text = new string('1',1);

		}
		if(timer < 0){
			tm.text = new string('0',1);

		}
		if(timer < -1){
			Destroy(gameObject);
		}
		timer = timer-1*Time.deltaTime;

		if(death == true){
			Destroy (gameObject);
		}

	
	}
}
