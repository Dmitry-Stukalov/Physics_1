using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartButton : MonoBehaviour, IPointerClickHandler
{
	private TextMeshProUGUI Button { get; set; }
	private Bullet Bullet { get; set; }
	private bool IsStart { get; set; }

	public void Start()
	{
		IsStart = false;

		Button = GetComponentInChildren<TextMeshProUGUI>();
		Button.text = "Старт";
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		if (!IsStart)
		{
			Bullet = GameObject.FindGameObjectWithTag("Bullet").GetComponent<Bullet>();
			Bullet.IsMoving = true;
			IsStart = true;

			Button.text = "Пауза";
		}
		else
		{
			Bullet.IsMoving = false;
			IsStart = false;

			Button.text = "Продолжить";

			//Bullet.ChangeRotation();
		}
	}

	public void ResetData()
	{
		Button.text = "Старт";
		IsStart = false;
	}
}
