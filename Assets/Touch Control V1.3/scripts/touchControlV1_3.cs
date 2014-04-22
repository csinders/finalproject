//	Touch Control V1.3 (Unity & Unity Pro)
//	Developer: Ananda Gupta
//	Copyright©2014, Ananda GUpta
//	http://anandagupta.com
//	info@anandagupta.com

using UnityEngine;
using System.Collections;

public class touchControlV1_3 : MonoBehaviour 
{	
	// public variables
	public float VSwipeZone = 50;
	public float HSwipeZone = 50;
	public float minSwipeDistance = 20;
	public float maxSwipeTime = 2;
	public float doubleTapTime = 0.2f;
	public float longTapTime = 0.5f;
	public GUIText displayText;
	
	//private variables
	private float startTime;
	private Vector2 touchPos;
	private bool tapping;
	private float lastTap;
	private bool multiTouch;

	// Use this for initialization
	void Start () 
	{
		displayText.text = "No touch detected";
		multiTouch = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (multiTouch)
		{
			if (Input.touchCount == 0)
			{
				multiTouch = false;
			}
			else
			{
				
			}
		}
		else
		{
			if (Input.touchCount==1)
			{
				Touch touch = Input.touches[0];
				switch(touch.phase)
				{
				case TouchPhase.Began:
					touchPos = touch.position;
					startTime = Time.time;
				break;
				case TouchPhase.Ended:
					float swipeTime = Time.time - startTime;
					float swipeDist = (touch.position - touchPos).magnitude;
					if ((Mathf.Abs(touch.position.x - touchPos.x))<VSwipeZone && (swipeTime<maxSwipeTime) && (swipeDist>minSwipeDistance) && Mathf.Sign(touch.position.y - touchPos.y)>0 && Mathf.Sign(touch.position.x - touchPos.x) < 1.5f && Mathf.Sign(touch.position.x - touchPos.x) > -1.5f)
					{
						print ("Its a UP swipe");
						displayText.text = "Its a UP swipe";
						// put your player control code here
						demoPlayer.ThrustPower = 200;
						demoPlayer.sideThrustPower = 0;
					}
					else if ((Mathf.Abs(touch.position.x - touchPos.x))<VSwipeZone && (swipeTime<maxSwipeTime) && (swipeDist>minSwipeDistance) && Mathf.Sign(touch.position.y - touchPos.y)<0 && Mathf.Sign(touch.position.x - touchPos.x) < 1.5f && Mathf.Sign(touch.position.x - touchPos.x) > -1.5f)
					{
						print ("Its a DOWN swipe");
						displayText.text = "Its a DOWN swipe";
						// put your player control code here
						demoPlayer.ThrustPower = -200;
						demoPlayer.sideThrustPower = 0;
					}
					else if ((Mathf.Abs(touch.position.y - touchPos.y))<HSwipeZone && (swipeTime<maxSwipeTime) && (swipeDist>minSwipeDistance) && Mathf.Sign(touch.position.x - touchPos.x)<0 && Mathf.Sign(touch.position.y - touchPos.y) < 1.5f && Mathf.Sign(touch.position.y - touchPos.y) > -1.5f)
					{
						print ("Its a LEFT SWIPE");
						displayText.text = "Its a LEFT swipe";
						// put your player control code here
						demoPlayer.sideThrustPower = -200;
						demoPlayer.ThrustPower = 0;
					}
					else if ((Mathf.Abs(touch.position.y - touchPos.y))<HSwipeZone && (swipeTime<maxSwipeTime) && (swipeDist>minSwipeDistance) && Mathf.Sign(touch.position.x - touchPos.x)>0 && Mathf.Sign(touch.position.y - touchPos.y) < 1.5f && Mathf.Sign(touch.position.y - touchPos.y) > -1.5f)
					{
						print ("Its a RIGHT SWIPE");
						displayText.text = "Its a RIGHT swipe";
						// put your player control code here
						demoPlayer.sideThrustPower = 200;
						demoPlayer.ThrustPower = 0;
					}
					else if (swipeTime > longTapTime)
					{
						print ("LONG TAP");
						displayText.text = "Its a LONG TAP";
						// put your player control code here
						demoPlayer.ThrustPower = demoPlayer.ThrustPower/4;
						demoPlayer.sideThrustPower = demoPlayer.sideThrustPower/4;
						tapping = false;
					}
					else if (!tapping)
					{
						tapping = true;
						StartCoroutine(SingleTap());
					}
					if ((Time.time - lastTap) < doubleTapTime)
					{
						demoPlayer.ThrustPower = 0;
						print ("DOUBLE TAP");
						displayText.text = "Its a DOUBLE TAP";
						// put your player control code here
						tapping = false;
					}
					lastTap = Time.time;
				break;
				}
			}
		}
		if(Input.touchCount == 2)
		{
			Touch touch = Input.touches[0];
			switch(touch.phase)
			{
			case TouchPhase.Ended:
				multiTouch = true;
				print ("2 FINGERS TOUCH");
				displayText.text = "Its a 2 FINGERS TOUCH";
				// Put your code here for 2 Fingers Touch
			break;
			}
		}
		if(Input.touchCount > 2)
		{
			Touch touch = Input.touches[0];
			switch(touch.phase)
			{
			case TouchPhase.Ended:
				multiTouch = true;
				print ("3 FINGERS TOUCH");
				displayText.text = "Its a 3 FINGERS TOUCH";
				// Put your code here for 3 Fingers Touch
			break;
			}
		}
	}
	IEnumerator SingleTap()
	{
		yield return new WaitForSeconds(doubleTapTime);
		if (tapping)
		{
			print ("SINGLE TAP");
			displayText.text = "Its a SINGLE TAP";
			// put your player control code here
			demoPlayer.sideThrustPower = 0;
			tapping = false;
		}
	}
}
