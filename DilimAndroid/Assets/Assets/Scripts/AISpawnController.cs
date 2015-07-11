using UnityEngine;
using System.Collections;

public class AISpawnController : MonoBehaviour {

	public GameObject[] AISpawnArray;
	private int randNum;
	
	void Awake()
	{
		AISpawnArray = GameObject.FindGameObjectsWithTag("AISpawn");
	}
	
	public GameObject GetRandomAISpawn(int randNum)
	{
		randNum = Random.Range(0, (AISpawnArray.Length));
		
		if (AISpawnArray.Length > 0)
		{
			return AISpawnArray[randNum];
		}
		else
		{
			return null;
		}
	}
}
