using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class All_Objects : MonoBehaviour
{
	private List<GameObject> First;
	private List<GameObject> Second;
	private List<GameObject> Third;
	private List<GameObject> FourthOne;
	private List<GameObject> FourthTwo;
	private List<GameObject> FourthThree;
	private List<GameObject> FifthOne;
	private List<GameObject> FifthTwo;
	private List<GameObject> FifthThree;

	public void Start()
	{
		First = new List<GameObject>();
		Second = new List<GameObject>();
		Third = new List<GameObject>();
		FourthOne = new List<GameObject>();
		FourthTwo = new List<GameObject>();
		FourthThree = new List<GameObject>();
		FifthOne = new List<GameObject>();
		FifthTwo = new List<GameObject>();
		FifthThree = new List<GameObject>();

		AllUnActive();
	}
	
	public void AllUnActive()
	{
		foreach (var objects in GameObject.FindGameObjectsWithTag("1"))
		{
			First.Add(objects);
			objects.SetActive(false);
		}

		foreach (var objects in GameObject.FindGameObjectsWithTag("2"))
		{
			Second.Add(objects);
			objects.SetActive(false);
		}

		foreach (var objects in GameObject.FindGameObjectsWithTag("3"))
		{
			Third.Add(objects);
			objects.SetActive(false);
		}

		foreach (var objects in GameObject.FindGameObjectsWithTag("4.1"))
		{
			FourthOne.Add(objects);
			objects.SetActive(false);
		}

		foreach (var objects in GameObject.FindGameObjectsWithTag("4.2"))
		{
			FourthTwo.Add(objects);
			objects.SetActive(false);
		}

		foreach (var objects in GameObject.FindGameObjectsWithTag("4.3"))
		{
			FourthThree.Add(objects);
			objects.SetActive(false);
		}

		foreach (var objects in GameObject.FindGameObjectsWithTag("5.1"))
		{
			FifthOne.Add(objects);
			objects.SetActive(false);
		}

		foreach (var objects in GameObject.FindGameObjectsWithTag("5.2"))
		{
			FifthTwo.Add(objects);
			objects.SetActive(false);
		}

		foreach (var objects in GameObject.FindGameObjectsWithTag("5.3"))
		{
			FifthThree.Add(objects);
			objects.SetActive(false);
		}
	}

	public void ActiveFirst()
	{
		foreach (var objects in First)
		{
			objects.SetActive(true);
		}
	}

	public void ActiveSecond()
	{
		ActiveFirst();

		foreach (var objects in Second)
		{
			objects.SetActive(true);
		}
	}

	public void ActiveThird()
	{
		ActiveSecond();

		foreach (var objects in Third)
		{
			objects.SetActive(true);
		}
	}

	public void ActiveFourthOne()
	{
		ActiveFirst();

		foreach (var objects in FourthOne)
		{
			objects.SetActive(true);
		}
	}
	public void ActiveFourthTwo()
	{
		ActiveFourthOne();
		ActiveSecond();

		foreach (var objects in FourthTwo)
		{
			objects.SetActive(true);
		}
	}
	public void ActiveFourthThree()
	{
		ActiveFourthTwo();
		ActiveThird();

		foreach (var objects in FourthThree)
		{
			objects.SetActive(true);
		}
	}
	public void ActiveFifthOne()
	{
		ActiveFourthOne();

		foreach (var objects in FifthOne)
		{
			objects.SetActive(true);
		}
	}
	public void ActiveFifthTwo()
	{
		ActiveFourthTwo();
		ActiveFifthOne();

		foreach (var objects in FifthTwo)
		{
			objects.SetActive(true);
		}
	}
	public void ActiveFifthThree()
	{
		ActiveFourthThree();
		ActiveFifthTwo();

		foreach (var objects in FifthThree)
		{
			objects.SetActive(true);
		}
	}
}
