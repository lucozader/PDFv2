using UnityEngine;
using System.Collections;

public class PlaySoundsAfterDestroy : MonoBehaviour {
	public AudioClip MoneySound;
	public static bool MoneySoundOnce;
	// Use this for initialization
	void Start () {
		MoneySoundOnce = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(MoneySoundOnce == true){
			audio.PlayOneShot(MoneySound);
			MoneySoundOnce = false;}
	}
}
