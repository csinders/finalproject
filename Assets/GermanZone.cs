﻿using UnityEngine;
using System.Collections;

public class GermanZone : MonoBehaviour {
public string textToShow;

void OnTriggerEnter () {
		GameObject.Find("/AlertText").GetComponent<GUIText>().text = textToShow;
	}
}
