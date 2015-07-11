using UnityEngine;
using System.Collections;

public class DoorGameState : MonoBehaviour {

	private GameObject door;
	
	private DoorSpawnController doorSpawnCTRL;
	
	private GameObject randDoorSpawn;
	
	void Awake()
	{
		door = GameObject.FindWithTag("Door");
		doorSpawnCTRL = GameObject.FindGameObjectWithTag("DoorSpawnCTRL").GetComponent<DoorSpawnController>();
	}
	
	void Start () 
	{
		int randNum = 0;
		randDoorSpawn = doorSpawnCTRL.GetRandomDoorSpawn(randNum);
		
		SpawnDoor();
	}
	
	void SpawnDoor()
	{
		door.transform.position = randDoorSpawn.transform.position;
		//Debug.Log("Door have spawned at " + randDoorSpawn.name);
	}
}
