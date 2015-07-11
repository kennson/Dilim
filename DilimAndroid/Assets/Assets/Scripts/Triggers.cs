using UnityEngine;
using System.Collections;

public class Triggers : MonoBehaviour {

	public GameObject scare;
	public bool played = false;
	public bool trig = false;
	public AudioClip scareSound;

	void Start () {
		trig = false;
		scare.renderer.enabled = false;
	}

	void Update () {
		if(trig == true)
		{
			scare.renderer.enabled = true;
			RemoveOvertime();
			MakeHimScream();
		}
	}

	void OnTriggerEnter (Collider other)
	{
		trig = true;
	}

	IEnumerator RemoveOvertime()
	{
		yield return new WaitForSeconds (0.8f);
		scare.renderer.enabled = false;
		Destroy(this.gameObject);
	}
	
	void MakeHimScream()
	{
		if(!played)
		{
			played = true;
			audio.PlayOneShot(scareSound);
		}
	}
}




