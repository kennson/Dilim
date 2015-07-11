using UnityEngine;
using System.Collections;

public class FlashLight : MonoBehaviour {

	public Light flashLightSource;

	void Start () {
		flashLightSource = GetComponent<Light>();
	}

}
