using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour {

	void OnTriggerEnter () {
		Application.LoadLevel(Application.loadedLevel);
	}
}
