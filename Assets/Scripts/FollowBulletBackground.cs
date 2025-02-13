using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBulletBackground : MonoBehaviour
{
	private GameObject Bullet { get; set; }
	private float StartZPosition { get; set; }


	public void Start()
	{
		Bullet = GameObject.FindGameObjectWithTag("Bullet");

		StartZPosition = transform.position.z;
	}

	public void FixedUpdate()
	{
		transform.position = new Vector3(transform.position.x, transform.position.y, Bullet.transform.position.z + StartZPosition);
	}
}
