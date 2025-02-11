using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ExitButton : MonoBehaviour, IPointerClickHandler
{
	[field: SerializeField] GameObject BreakButton { get; set; }
	private GameObject Menu { get; set; }
	private All_Objects Objects { get; set; }
	private PointerEventData EventData { get; set; }

	public void Start()
	{
		Objects = Camera.main.GetComponent<All_Objects>();
		Menu = GameObject.FindGameObjectWithTag("Menu");
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		BreakButton.GetComponent<Break_Button>().OnPointerClick(eventData);
		Objects.AllUnActive();
		Menu.SetActive(true);
	}
}
