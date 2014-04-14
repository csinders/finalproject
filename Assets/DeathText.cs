using UnityEngine;
using System.Collections;

public class DeathText : MonoBehaviour {
	public string textToShow;

void OnTriggerEnter () {
		GameObject.Find("/AlertText").GetComponent<GUIText>().text = textToShow;
	}
}