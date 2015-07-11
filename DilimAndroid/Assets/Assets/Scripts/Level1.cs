using UnityEngine;
using System.Collections;

public class Level1 : MonoBehaviour {

	void OnTriggerEnter () {
		Application.LoadLevel("Dilim");
	}
}
