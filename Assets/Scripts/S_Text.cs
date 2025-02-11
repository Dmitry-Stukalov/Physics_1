using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S_Text : MonoBehaviour
{
	private Bullet Bullet { get; set; }
	[field: SerializeField] private string Axis {  get; set; }
	public TMP_InputField TextField { get; set; }


	public void Start()
	{
		Bullet = GameObject.FindGameObjectWithTag("Bullet").GetComponent<Bullet>();
		Bullet.OnResetData += ResetData;

		TextField = GetComponent<TMP_InputField>();
		TextField.onEndEdit.AddListener(ChangeText);
	}

	public void ResetData()
	{
		TextField.text = "0";
	}

	public void ChangeText(string newtext)
	{
		if (newtext != null) Bullet.ChangeVariableValue(Axis, Convert.ToSingle(newtext));
	}
}