using UnityEngine;
using System.Collections;

public class KeyGameState : MonoBehaviour {

	private GameObject key;
	
	private KeySpawnController keySpawnCTRL;
	
	private GameObject randKeySpawn;
	
	void Awake()
	{
		key = GameObject.FindWithTag("Key");
		keySpawnCTRL = GameObject.FindGameObjectWithTag("KeySpawnCTRL").GetComponent<KeySpawnController>();
	}
	
	void Start () 
	{
		int randNum = 0;
		randKeySpawn = keySpawnCTRL.GetRandomKeySpawn(randNum);
		
		SpawnKey();
	}
	
	void SpawnKey()
	{
		key.transform.position = randKeySpawn.transform.position;
		//Debug.Log("Key have spawned at " + randKeySpawn.name);
	}
}
