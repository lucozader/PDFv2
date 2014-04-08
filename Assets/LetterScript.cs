using UnityEngine;
using System.Collections;

public class LetterScript : MonoBehaviour {

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
		if(NamePrint.count<16){
		char[] array = GetComponent<TextMesh>().text.ToCharArray();
		NamePrint.characterList[NamePrint.count] = array[0];
		NamePrint.count = NamePrint.count+1;
		}
	}
}