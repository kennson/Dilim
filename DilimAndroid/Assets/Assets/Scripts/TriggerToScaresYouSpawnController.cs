using UnityEngine;
using System.Collections;

public class TriggerToScaresYouSpawnController : MonoBehaviour {

	public GameObject[] triggerToScaresYouSpawnArray;
	private int randNum;
	
	void Awake()
	{
		triggerToScaresYouSpawnArray = GameObject.FindGameObjectsWithTag("TriggerToScaresYouSpawn");
	}
	
	public GameObject GetRandomTriggerToScaresYouSpawn(int randNum)
	{
		randNum = Random.Range(0, (triggerToScaresYouSpawnArray.Length));
		
		if (triggerToScaresYouSpawnArray.Length > 0)
		{
			return triggerToScaresYouSpawnArray[randNum];
		}
		else
		{
			return null;
		}
	}
}
