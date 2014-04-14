using UnityEngine;
using System.Collections;

public class skyInterpolate : MonoBehaviour {
    public Material material1;
    public Material material2;
    
	public float duration = 1.0F;
    
	void Start() {
        this.gameObject.renderer.material = material1;
    }
    
	void Update() {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
		//Debug.Log (lerp);
        this.gameObject.renderer.material.Lerp(material1, material2, lerp);
    }
}