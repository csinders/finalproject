using UnityEngine;
using System.Collections;

public class onStartGUI : MonoBehaviour {
	
	public Texture aTexture;
	public Texture bTexture;
	
	public float fadeOutSpeed = 5.0f;
	public float fadeInSpeed = 0.00000000001f;
	
	private float alpha = 1.0f;
	private int fadeDir = -1;
	private Color thisColor;
	
	public bool turnOffGui = false;
	
	public bool showLastGui = false;
	
	void OnGUI() {
		 //Debug.Log("oie");
		 if(!turnOffGui) {
         	GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), aTexture, ScaleMode.ScaleToFit, true, 0); 
		 }
		 else if(alpha > 0 && !showLastGui){
			alpha += fadeDir * fadeOutSpeed * Time.deltaTime;
			alpha = Mathf.Clamp01(alpha);
			
			thisColor = GUI.color;
			thisColor.a = alpha;
			GUI.color = thisColor;
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), aTexture, ScaleMode.ScaleToFit, true, 0);
		}
		//Debug.Log(alpha);
		if(showLastGui) {
			
			alpha += fadeInSpeed * Time.deltaTime;
			alpha = Mathf.Clamp01(alpha);
			
			thisColor = GUI.color;
			thisColor.a = alpha;
			GUI.color = thisColor;
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), bTexture, ScaleMode.StretchToFill, true, 0);
		}
    }
}
