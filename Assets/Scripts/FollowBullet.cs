using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBullet : MonoBehaviour
{
	private GameObject Bullet { get; set; }
	private Vector3 StartPosition { get; set; }


	public void Start()
	{
		Bullet = GameObject.FindGameObjectWithTag("Bullet");

		StartPosition = transform.position;
	}

	public void FixedUpdate()
	{
		transform.position = Bullet.transform.position + StartPosition;
	}
}
