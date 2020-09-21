using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan3 : MonoBehaviour {



	void Start (){
		int c = jumlah (60, 40);
		Debug.Log ("Hasil Jumlah a dan b adalah" + c);
	}
	void Update (){
		
	}
	int jumlah (int a,int b){
		return a + b;
	}

}
