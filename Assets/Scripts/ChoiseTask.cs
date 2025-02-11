using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChoiseTask : MonoBehaviour, IPointerClickHandler
{
	[field: SerializeField] private string TaskNumber { get; set; }
    private All_Objects Objects { get; set; }

	public void Start()
	{
		Objects = Camera.main.GetComponent<All_Objects>();
	}


	public void OnPointerClick(PointerEventData eventData)
	{
        if (TaskNumber == "1")
        {
			Objects.ActiveFirst();
        }

		if (TaskNumber == "2")
		{
			Objects.ActiveSecond();
		}

		if (TaskNumber == "3")
		{
			Objects.ActiveThird();
		}

		if (TaskNumber == "4.1")
		{
			Objects.ActiveFourthOne();
		}

		if (TaskNumber == "4.2")
		{
			Objects.ActiveFourthTwo();
		}

		if (TaskNumber == "4.3")
		{
			Objects.ActiveFourthThree();
		}

		if (TaskNumber == "5.1")
		{
			Objects.ActiveFifthOne();
		}

		if (TaskNumber == "5.2")
		{
			Objects.ActiveFifthTwo();
		}

		if (TaskNumber == "5.3")
		{
			Objects.ActiveFifthThree();
		}

		GameObject.FindGameObjectWithTag("Menu").SetActive(false);
    }
}
