using UnityEngine;
using System.Collections;
using System;

public class RotateAround : MonoBehaviour {

	public enum RotateAxis {
		XAxis,
		YAxis,
		ZAxis
	}

	//　回転軸をどこにするか
	public RotateAxis rotateAxis;
	//　回転スピード
	public float rotateSpeed;
	//　基準点
	public Transform basePosition;

	// Update is called once per frame
	void Update () {
		Vector3 axis = Vector3.zero;

		if (rotateAxis == RotateAxis.XAxis) {
			axis = Vector3.right;
		} else if (rotateAxis == RotateAxis.YAxis) {
			axis = Vector3.up;
		} else if (rotateAxis == RotateAxis.ZAxis) {
			axis = Vector3.forward;
		}

		//　回転処理
		float rotation = Time.deltaTime * rotateSpeed;

		transform.RotateAround (basePosition.position, axis, rotation);

	}
}