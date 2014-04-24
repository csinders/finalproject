using UnityEngine;
using System.Collections;

public class Color_change : MonoBehaviour {


	public float color_alpha; 
	public float color_fade; 

	public float startTime; 

	// Use this for initialization
	void Start () {
		 

		color_alpha = 0; 

		startTime += Time.time; 
	}
	
	// Update is called once per frame
	void Update () {
		if (startTime < Time.time) {

			Color color;
			color = guiText.color;
			color.a = color_alpha; 
			guiText.color = color;
			color_alpha += 0.003f; 
		
	
		}
	}
}
