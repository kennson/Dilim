using UnityEngine;
using System.Collections;

public class PlayerSpawnController : MonoBehaviour 
{
public GameObject[] playerSpawnArray;
private int randNum;
	
	void Awake()
	{
		playerSpawnArray = GameObject.FindGameObjectsWithTag("BidaSpawn");
	}
	
	public GameObject GetRandomPlayerSpawn(int randNum)
	{
		randNum = Random.Range(0, (playerSpawnArray.Length));
		
		if (playerSpawnArray.Length > 0)
		{
			return playerSpawnArray[randNum];
		}
		else
		{
			return null;
		}
	}
}
