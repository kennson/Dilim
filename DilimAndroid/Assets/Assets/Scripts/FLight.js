#pragma strict

var flashlightLightSource : Light;
var lightOn : boolean = true;
var lightDrain : float = 0.1;
private static var batteryLife : float = 0.0;
var maxBatteryLife : float = 5.0;

private static var batteryPower : float = 5;

var barDisplay : float = 0;
var pos : Vector2 = new Vector2(20,40);
var size : Vector2 = new Vector2(60,20);
var progressBarEmpty : Texture2D;
var progressBarFull : Texture2D;

var soundTurnOn : AudioClip;
var soundTurnOff : AudioClip;


function Start()
{
	batteryLife = maxBatteryLife;
	flashlightLightSource = GetComponent(Light);
}


static function AlterEnergy (amount : int)
{
	batteryLife = Mathf.Clamp(batteryLife+batteryPower, 0, 100);

}



function Update()
{

	if(lightOn && batteryLife >= 0)
	{
		batteryLife -= Time.deltaTime * lightDrain;
	}
		if(lightOn && batteryLife <= 5.0)
	{
		flashlightLightSource.light.intensity = 2.0;
	}
		if(lightOn && batteryLife <= 3.5)
	{
		flashlightLightSource.light.intensity = 1.5;
	}
	if(lightOn && batteryLife <= 2.0)
	{
		flashlightLightSource.light.intensity = 1.0;
	}
		if(lightOn && batteryLife <= 1.0)
	{
		flashlightLightSource.light.intensity = .5;
	}
			if(lightOn && batteryLife <= 0)
	{
		flashlightLightSource.light.intensity = 0;
		Application.LoadLevel(Application.loadedLevel);
	}
	

	barDisplay = batteryLife;
	
	if(batteryLife <= 0)
	{
		batteryLife = 0;
		lightOn = false;
	}
	
	if(Input.GetKeyUp(KeyCode.F))
	{
		toggleFlashlight();
		toggleFlashlightSFX();
		
		if(lightOn)
		{
			lightOn = false;
		}
		else if (!lightOn && batteryLife >= 0)
		{
			lightOn = true;
		}
	}
}
	
function OnGUI()
{
 
    GUI.BeginGroup (new Rect (pos.x, pos.y, size.x, size.y));
        GUI.Box (Rect (0,0, size.x, size.y),progressBarEmpty);
 
        GUI.BeginGroup (new Rect (0, 0, size.x * barDisplay, size.y));
            GUI.Box (Rect (0,0, size.x, size.y),progressBarFull);
        GUI.EndGroup ();
 
    GUI.EndGroup ();
 
} 
 	
function toggleFlashlight()
{
	if(lightOn)
	{
		flashlightLightSource.enabled = false;
	}
	else
	{
		flashlightLightSource.enabled = true;
	}
}
function toggleFlashlightSFX()
{
	if(flashlightLightSource.enabled)
	{
		audio.clip = soundTurnOn;
	}
	else
	{
		audio.clip = soundTurnOff;
	}
	audio.Play();
	
}

	@script RequireComponent(AudioSource)
	