using UnityEngine;
using System.Collections;

public class AIGameState : MonoBehaviour {

	private GameObject AI;
	
	private AISpawnController AISpawnCTRL;
	
	private GameObject randAISpawn;
	
	void Awake()
	{
		AI = GameObject.FindWithTag("AI");
		AISpawnCTRL = GameObject.FindGameObjectWithTag("AISpawnCTRL").GetComponent<AISpawnController>();
	}
	
	void Start () 
	{
		int randNum = 0;
		randAISpawn = AISpawnCTRL.GetRandomAISpawn(randNum);
		
		SpawnAI();
	}
	
	void SpawnAI()
	{
		AI.transform.position = randAISpawn.transform.position;
		//Debug.Log("AI have spawned at " + randAISpawn.name);
	}
}
