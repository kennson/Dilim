using UnityEngine;
using System.Collections;

public class TriggerToScaresYouGameState : MonoBehaviour {

	private GameObject triggerToScaresYou;
	
	private TriggerToScaresYouSpawnController triggerToScaresYouSpawnCTRL;
	
	private GameObject randTriggerToScaresYouSpawn;
	
	void Awake()
	{
		triggerToScaresYou = GameObject.FindWithTag("TriggerToScareYou");
		triggerToScaresYouSpawnCTRL = GameObject.FindGameObjectWithTag("TriggerToScaresYouSpawnCTRL").GetComponent<TriggerToScaresYouSpawnController>();
	}
	
	void Start () 
	{
		int randNum = 0;
		randTriggerToScaresYouSpawn = triggerToScaresYouSpawnCTRL.GetRandomTriggerToScaresYouSpawn(randNum);
		
		SpawnTriggerToScaresYou();
	}
	
	void SpawnTriggerToScaresYou()
	{
		triggerToScaresYou.transform.position = randTriggerToScaresYouSpawn.transform.position;
		Debug.Log("Trigger have spawned at " + randTriggerToScaresYouSpawn.name);
	}
}
