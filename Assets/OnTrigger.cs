using UnityEngine;
using System.Collections;

public class OnTrigger : MonoBehaviour {
	public string textToShow;

	void OnTriggerEnter () {
		GameObject.Find("/AlertText").GetComponent<GUIText>().text = textToShow;
	}

	void OnTriggerExit () {
		GameObject.Find("/AlertText").GetComponent<GUIText>().text = "";
	}
}
