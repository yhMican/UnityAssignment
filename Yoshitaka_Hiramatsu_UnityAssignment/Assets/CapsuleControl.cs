using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine ("MoveRotateExpand");
	}

	IEnumerator MoveRotateExpand () {
		yield return new WaitForSeconds (1.0f);
		for (int f = 0; f < 100; f++) {
			transform.position += Vector3.right * 2.0f * Time.deltaTime;
			yield return null;
		}
		for (int f = 0; f < 180; f++) {
			transform.Rotate (new Vector3 (0, 0, 2));
			yield return null;
		}
		for (int f = 0; f < 25; f++) {
			transform.localScale += new Vector3 (0.02f, 0.02f, 0.02f);
			yield return null;
		}
	}
}
