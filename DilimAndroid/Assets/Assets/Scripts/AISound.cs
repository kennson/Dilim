using UnityEngine;
using System.Collections;

public class AISound : MonoBehaviour {

	public GameObject player;
	public AudioClip[] scareSound;

	void OnTriggerEnter(Collider other)
	{
		if(other.collider.tag == player.tag) 
		{
			audio.clip = scareSound[Random.Range(0,scareSound.Length)];
			audio.volume = 1.0f;
			audio.Play();
		}
	}	
}