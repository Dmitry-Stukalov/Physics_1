using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Break_Button : MonoBehaviour, IPointerClickHandler
{
	[field: SerializeField] GameObject StartButton { get; set; }
	private Bullet Bullet { get; set; }

	public void Start()
	{
		Bullet = GameObject.FindGameObjectWithTag("Bullet").GetComponent<Bullet>();
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		StartButton.GetComponent<StartButton>().ResetData();
		Bullet.ResetData();
	}
}
