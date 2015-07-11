﻿var buttonInRange;
var buttonActivated;
var batterySound : AudioClip;
private static var batteryPower : float = 10;

public var guiSkin : GUISkin;

private var hasPlayed = false;

function OnTriggerEnter (c : Collider)
{
	buttonInRange = true;

}
function OnTriggerExit (c : Collider)
{
	buttonInRange = false;

}
function OnGUI ()
{
	if(buttonInRange == true)
	{
		GUI.skin = guiSkin;
		GUI.Label (Rect (Screen.width/2-50, Screen.height/2-55, 120, 50), "O - Battery");
	
	}

}
function Update ()
{
	if (buttonInRange == true)
	{
			if(!hasPlayed)
			{
				AudioSource.PlayClipAtPoint(batterySound, transform.position);
				FLight.AlterEnergy(batteryPower);
				Destroy(gameObject);
				hasPlayed = true;
			
			}
	
	}

}