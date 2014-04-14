using UnityEngine;
using System.Collections;

public class RussianCamp : MonoBehaviour {

	public string textToShow;

void OnTriggerEnter () {
		GameObject.Find("/AlertText").GetComponent<GUIText>().text = textToShow;
	}
}
