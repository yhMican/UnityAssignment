using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeControl : MonoBehaviour {

	public GameObject CubeInfo;  // Stores Canvas which is a child of the Cube object
	// Use this for initialization
	void Start () {
		CubeInfo.SetActive (false);
	}
	public void OnUserAction () {
		//Debug.Log ("OnUserAction");
		if (!CubeInfo.activeSelf) {
			CubeInfo.SetActive (true);
		} else {
			CubeInfo.SetActive (false);
		}

	}
}
