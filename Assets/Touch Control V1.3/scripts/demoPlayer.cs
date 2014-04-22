using UnityEngine;
using System.Collections;

public class demoPlayer : MonoBehaviour {

    // public variables

    public static float ThrustPower;
	public static float sideThrustPower;

    //private cariables

    private Transform PlayerTransform;

	// Use this for initialization
	void Start () 
    {
        PlayerTransform = transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        rigidbody.AddForce(PlayerTransform.forward * ThrustPower * Time.smoothDeltaTime, ForceMode.Acceleration);
		rigidbody.AddForce(PlayerTransform.right * sideThrustPower * Time.smoothDeltaTime, ForceMode.Acceleration);
		
		
		if ((PlayerTransform.position.x > 8.5) || (PlayerTransform.position.x < -8.5))
		{
			PlayerTransform.position = new Vector3 (-PlayerTransform.position.x, 1, PlayerTransform.position.z);
		}
		
		if ((PlayerTransform.position.z > 5.53) || (PlayerTransform.position.z < -5.53))
		{
			PlayerTransform.position = new Vector3 (PlayerTransform.position.x, 1, -PlayerTransform.position.z);
		}
	}
}
