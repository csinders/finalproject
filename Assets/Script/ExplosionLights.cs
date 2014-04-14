using UnityEngine;
using System.Collections;

public class ExplosionLights : MonoBehaviour {

  public Color dark = Color.black;
  public Color bright = Color.red;

  public float[] explosionTimes;
  public float fadeRate = 0.2f;

  private int explosionIndex = 0;

  void Update() {
    if (explosionIndex < explosionTimes.Length && explosionTimes[explosionIndex] < Time.fixedTime) {
      explosionIndex += 1;
      camera.backgroundColor = bright;
    } else {
      camera.backgroundColor = Color.Lerp(camera.backgroundColor, dark, fadeRate);
    }
  }
}
