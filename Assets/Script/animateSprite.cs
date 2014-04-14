using UnityEngine;
using System.Collections;

public class animateSprite {
	private long count = 0;
	public void aniSprite (GameObject character, int columnSize, int rowSize, int colFrameStart, int rowFrameStart, int totalFrames, int framesPerSecond)
	{
		float index = Time.time * framesPerSecond;													
		index = index % totalFrames;																	
		
		Vector2 size = new Vector2 ( 1.0f / columnSize, 1.0f / rowSize);											
		
		int u = (int) index % columnSize;																		// u gets current x coordinate from column size
		int v = (int) index / columnSize;																		// v gets current y coordinate by dividing by column size
		count = count + 10;
		Vector2 offset = new Vector2 ((u + colFrameStart) * size.x,(1.0f - size.y) - (v + rowFrameStart) * size.y); // offset equals column and row
		character.renderer.material.mainTextureOffset = offset;													// texture offset for diffuse map
		character.renderer.material.mainTextureScale  = size;														// texture scale  for diffuse map
		
		//renderer.material.SetTextureOffset ("_BumpMap", offset);										// texture offset for bump (normal map)
		//renderer.material.SetTextureScale  ("_BumpMap", size);											// texture scale  for bump (normal map) 
	}
	
}
