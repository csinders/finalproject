using UnityEngine;
using System.Collections;

public class Color_change : MonoBehaviour {


	public float color_alpha; 
	public float color_fade; 

	public float interval = 3.0f; 

	public float timer; 

	// Use this for initialization
	void Start () {
		timer += interval; // the timer is equal to the time int eh future 

		color_alpha = 0; 
	}
	
	// Update is called once per frame
	void Update () {
		Color color;
		color = guiText.color;
		color.a = color_alpha; 
		guiText.color = color;
		color_alpha += 0.008f; 

		if (Time.time >= timer); {
			timer = Time.time + interval; 
		}

	
	}
}
