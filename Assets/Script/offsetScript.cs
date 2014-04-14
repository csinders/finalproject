using UnityEngine;
using System.Collections;

public class offsetScript : MonoBehaviour {

	public float scrollSpeed = 0.5F;
    void Update() {
        float offset = Time.time * scrollSpeed;
        renderer.material.mainTextureOffset = new Vector2(-offset, 0);
    }
}
