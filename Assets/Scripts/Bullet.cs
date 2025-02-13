using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	private Vector3 targetDirection { get; set; }
	private float rotationSpeed { get; set; } = 10f;
	public float Xo {  get; set; }
	public float X { get; set; }
	public float Yo { get; set; }
	public float Y { get; set; }
	public float Zo { get; set; }
	public float Z { get; set; }
	public float S { get; set; }
	public float Vxo { get; set; }
	public float Vyo { get; set; }
	public float Vzo { get; set; }
	public float T { get; set; }
	public float A { get; set; }
	public bool IsMoving { get; set; }

	public event Action OnResetData;


	public void Start()
	{
		targetDirection = transform.position.normalized;
		ResetData();
	}

	public void ResetData()
	{
		transform.position = new Vector3(0, 0, 0);
		transform.rotation = Quaternion.Euler(-90, 180, 0);

		Xo = 0;
		X = 0;
		Yo = 0;
		Y = 0;
		Zo = 0;
		Z = 0;
		S = 0;
		Vxo = 0;
		Vyo = 0;
		Vzo = 0;
		T = 0;
		A = 0;

		IsMoving = false;

		OnResetData?.Invoke();
	}

	public void ChangeVariableValue(string axis, float value)
	{
		switch (axis)
		{
			case "Xo":
				Xo = value; 
				break;

			case "X":
				X = value;
				break;

			case "Yo":
				Yo = value;
				break;

			case "Y":
				Y = value;
				break;

			case "Zo":
				Zo = value;
				break;

			case "Z":
				Z = value;
				break;

			case "Vxo":
				Vxo = value;
				break;

			case "Vyo":
				Vyo = value;
				break;

			case "Vzo":
				Vzo = value;
				break;

			case "A":
				A = value;
				break;
		}

		gameObject.transform.position = new Vector3(Xo, Y, Z);
	}

	public float GetVariableValue(string axis)
	{
		switch (axis)
		{
			case "X":
				return X;

			case "Y":
				return Y;

			case "Z":
				return Z;

			case "T":
				return T;

			case "S":
				return S;

			case "A":
				return A;
		}

		return 0;
	}

	public void FixedUpdate()
	{
		if (IsMoving)
		{
			T += Time.deltaTime;
			if (A == 0)
			{
				X = Xo + Vxo * T;
				Y = Yo + Vyo * T;
				Z = Zo + Vzo * T;
				S = Math.Abs(T * Convert.ToSingle(Math.Sqrt(Vxo * Vxo + Vyo * Vyo + Vzo * Vzo)));
			}
			else
			{
				if (Vzo != 0)
				{
					X = Xo + Vxo * T + ((A * T * T) / 2);
					Y = Yo + Vyo * T + ((A * T * T) / 2);
					Z = Zo + Vzo * T + ((A * T * T) / 2);
					S = Convert.ToSingle(Math.Sqrt(Math.Pow(Vxo * T + A * T * T / 2, 2) + Math.Pow(Vyo * T + A * T * T / 2, 2) + Math.Pow(Vzo * T + A * T * T / 2, 2)));
				}
				else if (Vyo != 0)
				{
					X = Xo + Vxo * T + ((A * T * T) / 2);
					Y = Yo + Vyo * T + ((A * T * T) / 2);
					S = Convert.ToSingle(Math.Sqrt(Math.Pow(Vxo * T + A * T * T / 2, 2) + Math.Pow(Vyo * T + A * T * T / 2, 2)));
				}
				else
				{
					X = Xo + Vxo * T + ((A * T * T) / 2);
					S = Convert.ToSingle(Math.Sqrt(Math.Pow(Vxo * T + A * T * T / 2, 2)));
				}
			}

			targetDirection = new Vector3(X, Y, Z);

			if (targetDirection != Vector3.zero)
			{
				Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up) * Quaternion.Euler(0, 90, 0);
				transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
			}

			gameObject.transform.position = new Vector3(X, Y, Z);
		}
	}
}
