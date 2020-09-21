using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan1 : MonoBehaviour {

	void FixedUpdate () {
		Debug.Log ("Waktu untuk FixedUpdate :" + Time.deltaTime);
	}
	void Update () {
		Debug.Log ("Waktu untuk Update :" + Time.deltaTime);
	}
	void LateUpdate () {
		Debug.Log ("Waktu untuk LateUpdate :" + Time.deltaTime);
	}
}
