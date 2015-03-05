using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(AudioSource))]
public class UnityOSCListener : MonoBehaviour  {

	public AudioClip horn_honk;
	public AudioClip lock_sound;

	public AudioClip song1;
	public AudioClip song2;
	public AudioClip song3;

	public void OSCMessageReceived(OSC.NET.OSCMessage message){	
		string address = message.Address;
		//ArrayList args = message.Values;

		Debug.Log("received a message: " + address);

		// BEEP BEEP
		if (address == "/horn") {
			Debug.Log ("honking the horn");
			audio.PlayOneShot(horn_honk, 0.7F);
		}

		// LOCK / UNLOCK
		if (address == "/unlock") {
			Debug.Log ("unlocking the car");
			audio.PlayOneShot(lock_sound, 0.7F);
		}

		if (address == "/lock") {
			Debug.Log ("locking the car");
			audio.PlayOneShot(lock_sound, 0.7F);
		}

		// HEADLIGHTS CONTROL
		if (address == "/headlights-on-true") {
			Debug.Log ("headlights on");
			GameObject.Find ("Light").light.intensity = 1.2f;
		}

		if (address == "/headlights-on-false") {
			Debug.Log ("headlights off");
			GameObject.Find ("Light").light.intensity = 0.2f;
		}

		// ghetto but works for now
		string[] parseString = address.Split('-');
		if (parseString[0] == "/headlights_intensity") {
			Debug.Log ("light value: " + parseString[1]);
			GameObject.Find ("Light").light.intensity = float.Parse(parseString[1]);
		}

		if (parseString [0] == "/song") {
			Debug.Log ("song value: " + parseString[1]);

			int songNumber = int.Parse(parseString[1]);
			if (songNumber == 1) {
				audio.Stop();
				audio.PlayOneShot(song1, 0.7f);
			}

			if (songNumber == 2){
				audio.Stop();
				audio.PlayOneShot(song2, 0.7f);
			}

			if (songNumber == 3) {
				audio.Stop();
				audio.PlayOneShot(song3, 0.7f);
			}

			if (songNumber == 4) {
				audio.Stop();
			}
			//GameObject.Find ("Radio").light.intensity = float.Parse(parseIntensity[1]);
		}



	}
}
