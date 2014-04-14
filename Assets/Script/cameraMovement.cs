 using UnityEngine;
 using System.Collections;

 public class cameraMovement : MonoBehaviour {

 	public float speed = 10.0f;
 	public float MAX_STEP = 7;
 	public int totalIncrements = 9;

 	public float forwardSpeed = 0.05f; 

 	public float minForwardSpeed = 0.01f;
 	public float maxForwardSpeed = 0.05f;


 	public GameObject fog;

 	private Transform cameraTransform;

 	private bool MOVE_IN_Z = false;
 	private bool MOVE_IN_X_LEFT = true;
 	private bool MOVE_IN_X_RIGHT = true;

 	private int stateCount = 0;

 	private bool playSoundOnce = false;

 	private float targetZ;

 	public GameObject trafficSound;
 	public GameObject birdSound;


	// Use this for initialization
 	void Start () {
 		cameraTransform = this.gameObject.transform;
 		targetZ = this.gameObject.transform.position.z;
 	}

	// Update is called once per frame
 	void Update () {

 		Vector3 movement = Vector3.zero;
 		// if(!this.gameObject.GetComponent<onStartGUI>().showLastGui){

 		if (Mathf.Abs(targetZ - transform.position.z) < MAX_STEP / 2.0f) {
 			if (Input.GetKey("up")) {
 				targetZ += MAX_STEP;
 				// if(!this.gameObject.GetComponent<onStartGUI>().turnOffGui){
 				// 	this.gameObject.GetComponent<onStartGUI>().turnOffGui = true;
 				// }





 			}
 			if (Input.GetKey("down") && targetZ > -11) {
 				targetZ -= MAX_STEP;

 				// if(!this.gameObject.GetComponent<onStartGUI>().turnOffGui){
 				// 	this.gameObject.GetComponent<onStartGUI>().turnOffGui = true;
 				// }
 			}
 		}

 			if (Input.GetKey("left") && MOVE_IN_X_LEFT){
 				movement.x--;
 			}
 			if (Input.GetKey("right") && MOVE_IN_X_RIGHT){
 				movement.x++;
 			}

 			if(Input.GetKeyDown("left")){
 				Debug.Log("in");
 				audio.Play();

 				if(!this.gameObject.GetComponent<onStartGUI>().turnOffGui){
 					this.gameObject.GetComponent<onStartGUI>().turnOffGui = true;
 				}
 			}
 			if(Input.GetKeyDown("right")){
 				audio.Play();

 				if(!this.gameObject.GetComponent<onStartGUI>().turnOffGui){
 					this.gameObject.GetComponent<onStartGUI>().turnOffGui = true;
 				}
 			}
 			if(Input.GetKeyUp("left") && !Input.GetKey("right")){
 				audio.Pause();
 			}
 			if(Input.GetKeyUp("right") && !Input.GetKey("left")){
 				audio.Pause();
 			}

 			// forward/backwards motion
 			var target = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, targetZ);
 			transform.position = Vector3.Lerp(this.gameObject.transform.position, target, forwardSpeed);

 			// horizontal motion
 			transform.Translate(movement * speed * Time.deltaTime, Space.Self);

 			fog.transform.position = cameraTransform.position + new Vector3(0, 0, 3 * MAX_STEP);
 		// }
 	}

	// void OnTriggerEnter(Collider other) {
 //        if(other.gameObject.tag == "allowMovement") {
	// 		MOVE_IN_Z = false;
	// 	}
	// 	else if(other.gameObject.tag == "stopSideMovementLeft") {
	// 		MOVE_IN_X_LEFT = false;
	// 	}
	// 	else if(other.gameObject.tag == "stopSideMovementRight") {
	// 		Debug.Log("trigger");
	// 		MOVE_IN_X_RIGHT = false;
	// 	}
 //    }

	// void OnTriggerExit(Collider other) {
 //        if(other.gameObject.tag == "allowMovement") {
	// 		MOVE_IN_Z = true;
	// 	}
	// 	else if(other.gameObject.tag == "stopSideMovementLeft") {
	// 		MOVE_IN_X_LEFT = true;
	// 	}
	// 	else if(other.gameObject.tag == "stopSideMovementRight") {
	// 		Debug.Log("trigger exit");
	// 		MOVE_IN_X_RIGHT = true;
	// 	}
 //    }

 	void moveForward() {
 		Debug.Log("forward");
 		stateCount++;
 		Debug.Log(stateCount);
 		if(stateCount == totalIncrements) {
 			this.gameObject.GetComponent<onStartGUI>().showLastGui = true;
 		}

 		if(stateCount >= totalIncrements -3 &&  !playSoundOnce){
 			Debug.Log("traffic sound started");
 			trafficSound.audio.Play();
 			playSoundOnce = true;
 		}

 		if(stateCount == totalIncrements -1) {
 			trafficSound.audio.volume = 1;
 			birdSound.audio.volume = 0;
 		}
 	}

 	void moveBackward() {
 		Debug.Log("backward");
 		stateCount--;
 		if(stateCount < totalIncrements - 3 && playSoundOnce){
 			Debug.Log("traffic sound stopped");
 			trafficSound.audio.Stop();
 			playSoundOnce = false;
 		}
 		if(stateCount == totalIncrements -2 || stateCount == totalIncrements -3) {
 			trafficSound.audio.volume = 0.25f;
 		}

 	}

 	void OnTriggerEnter(Collider other){
 		if (other.tag == "clue"){
 			forwardSpeed = minForwardSpeed; 
 		}
 		
 	}

 	void OnTriggerExit(Collider other){
 		if (other.tag == "clue"){
 			forwardSpeed = maxForwardSpeed;
 		}
 		
 	}
 }

