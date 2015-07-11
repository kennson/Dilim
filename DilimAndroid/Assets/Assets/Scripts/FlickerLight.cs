using UnityEngine;
using System.Collections;

public class FlickerLight : MonoBehaviour {

	public float flickerSpeed;
	private float randomizer;

	void Update(){
		Flicker ();
	}

	IEnumerator Flicker () {
		while (true) {
			if (randomizer == 0) {
				light.enabled = true;
			}
			else light.enabled = false;
			randomizer = Random.Range (0.0f, 1.1f);
			yield return new WaitForSeconds (flickerSpeed);
		}
	}
}

