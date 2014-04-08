using UnityEngine;
using System.Collections;

public class Backspace : MonoBehaviour {
	void OnMouseEnter()
	{
		renderer.material.color = Color.red;
	}
	
	void OnMouseExit()
	{
		renderer.material.color = Color.yellow;
		
	}
	void OnMouseUp()
	{
		if(NamePrint.count<17){
			char[] array = GetComponent<TextMesh>().text.ToCharArray();
			if(NamePrint.count > 0){
				NamePrint.count = NamePrint.count-1;
				NamePrint.characterList[NamePrint.count] = ' ';
			}
		}
	}
}
