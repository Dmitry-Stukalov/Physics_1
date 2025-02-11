using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResultText : MonoBehaviour
{
	[field: SerializeField] private string Axis { get; set; }
	private Bullet Bullet { get; set; }
	public TextMeshProUGUI TextField { get; set; }

	public void Start()
	{
		Bullet = GameObject.FindGameObjectWithTag("Bullet").GetComponent<Bullet>();
		Bullet.OnResetData += ResetData;

		TextField = GetComponent<TextMeshProUGUI>();
	}

	public void ResetData()
	{
		TextField.text = "0";
	}

	public void FixedUpdate()
	{
		if (Bullet.IsMoving) TextField.text = Math.Round(Bullet.GetVariableValue(Axis), 2).ToString();
	}
}
