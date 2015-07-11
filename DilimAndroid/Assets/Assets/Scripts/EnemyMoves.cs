using UnityEngine;
using System.Collections;

public class EnemyMoves : MonoBehaviour {

	public Transform player;
	public int moveSpeed;
	public int minDist;
	public int maxDist;

	void Update () {
		transform.LookAt(player);
		
		if(Vector3.Distance(transform.position, player.position) >= minDist)
		{
			transform.position += transform.forward * moveSpeed * Time.deltaTime;
			
			if(Vector3.Distance(transform.position, player.position) <= maxDist)
			{
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}
}



