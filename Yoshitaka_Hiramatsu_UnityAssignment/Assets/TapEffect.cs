using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapEffect : MonoBehaviour {

	[SerializeField, Header("タップエフェクト")]
	private ParticleSystem _tapEffect = null;

	[SerializeField, Header("パーティクル用カメラ")]
	private Camera _particleCamera = null;


	// Update is called once per frame
	void Update () {
		// Returns true while left click is being pressed
		if (Input.GetMouseButtonDown(0)) {
			_tapEffect.transform.position = _particleCamera.ScreenToWorldPoint (Input.mousePosition + _particleCamera.transform.forward * 10);
			_tapEffect.Emit (1); // Emits 1 particle immediately
		}
	}
}
