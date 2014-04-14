// columnSize      - number of frames across (horizontal)
// rowSize         - number of frames down (vertical)
// colFrameStart   - where frame starts (remember 0 is first number in counting)
// rowFrameStart   - where frame starts (remember 0 is first number in counting)
// totalFrames     - number of frames in the animation (count regular)
// framesPerSecond - how fast do you want it to play through (Standard: 12 - 30 fps)

function aniSprite (columnSize, rowSize, colFrameStart, rowFrameStart, totalFrames, framesPerSecond)
{
	var index : int = Time.time * framesPerSecond;													
	index = index % totalFrames;																	
	
	var size = Vector2 ( 1.0 / columnSize, 1.0 / rowSize);											
	
	var u = index % columnSize;																		// u gets current x coordinate from column size
	var v = index / columnSize;																		// v gets current y coordinate by dividing by column size
	
	var offset = Vector2 ((u + colFrameStart) * size.x,(1.0 - size.y) - (v + rowFrameStart) * size.y); // offset equals column and row
	
	renderer.material.mainTextureOffset = offset;													// texture offset for diffuse map
	renderer.material.mainTextureScale  = size;														// texture scale  for diffuse map
	
	renderer.material.SetTextureOffset ("_BumpMap", offset);										// texture offset for bump (normal map)
	renderer.material.SetTextureScale  ("_BumpMap", size);											// texture scale  for bump (normal map) 
}
