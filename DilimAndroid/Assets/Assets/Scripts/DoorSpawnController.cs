using UnityEngine;
using System.Collections;

public class DoorSpawnController : MonoBehaviour {

	public GameObject[] doorSpawnArray;
	private int randNum;
	
	void Awake()
	{
		doorSpawnArray = GameObject.FindGameObjectsWithTag("DoorSpawn");
	}
	
	public GameObject GetRandomDoorSpawn(int randNum)
	{
		randNum = Random.Range(0, (doorSpawnArray.Length));
		
		if (doorSpawnArray.Length > 0)
		{
			return doorSpawnArray[randNum];
		}
		else
		{
			return null;
		}
	}
}
