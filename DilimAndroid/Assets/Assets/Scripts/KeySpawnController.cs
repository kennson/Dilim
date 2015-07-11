using UnityEngine;
using System.Collections;

public class KeySpawnController : MonoBehaviour {

	public GameObject[] keySpawnArray;
	private int randNum;
	
	void Awake()
	{
		keySpawnArray = GameObject.FindGameObjectsWithTag("KeySpawn");
	}
	
	public GameObject GetRandomKeySpawn(int randNum)
	{
		randNum = Random.Range(0, (keySpawnArray.Length));
		
		if (keySpawnArray.Length > 0)
		{
			return keySpawnArray[randNum];
		}
		else
		{
			return null;
		}
	}
}
