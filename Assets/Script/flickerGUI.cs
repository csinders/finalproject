using UnityEngine;
using System.Collections;

public class flickerGUI : MonoBehaviour {
  public float startTime = 60.0f;
  public float endTime = 90.0f;
	public float alpha = 1.0f;
  public float flickerAlpha = 0.9f;
	public Texture2D fadeOutTexture;
  public AudioSource heartbeat;
	
	//For flicker
	private float minFlickerSpeed = 0.1f;
	private float maxFlickerSpeed = 1.0f;
	private Texture2D ag;
	private Rect rect;
	
	private float waitTime = 0.0f;
	private float currentTime = 0.0f;
	private Color thisColor;
	
	// float FlickerAlpha() {
 //    return Mathf.Clamp01((Time.fixedTime - startTime) / (endTime - startTime));
 //  }
    
	void OnGUI() {
    if (Time.fixedTime > startTime) {
  		if(waitTime <= currentTime) {
  			if((float)thisColor.a != alpha) {
  				thisColor = GUI.color;
  				thisColor.a = alpha;
          heartbeat.volume = alpha;
  			}
  			else {
  				thisColor = GUI.color;
  				thisColor.a = flickerAlpha;	
  			}
  			waitTime = Random.Range(minFlickerSpeed, maxFlickerSpeed);
  			currentTime = 0.0f;
  		}
  		else {
  			currentTime += Time.deltaTime;
  		}
  		
  		GUI.color = thisColor;
  		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);
    }
	}
}
