using UnityEngine;
using System.Collections;

public class moveParticles : MonoBehaviour {
	
	public float MOVEMENT = 5.0f;
	
	public GameObject mainCamera;
	
	private float initialCameraX;
	private float lastPositionX;
	
	// Use this for initialization
	void Start () {
		//iTween.MoveBy(this.gameObject, iTween.Hash("x", MOVEMENT, "easeType", "easeInOutSine", "loopType", "pingPong"));
		initialCameraX = mainCamera.transform.position.x; 
		lastPositionX = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		float moveDistanceX = mainCamera.transform.position.x - initialCameraX - lastPositionX;
		//Debug.Log(moveDistanceX);
		Vector3 temp = new Vector3(this.gameObject.transform.position.x + moveDistanceX, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
		this.gameObject.transform.position = temp;
		
		lastPositionX = mainCamera.transform.position.x;
	}
}
