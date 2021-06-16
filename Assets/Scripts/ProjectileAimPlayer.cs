using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileAimPlayer : MonoBehaviour
{
	Rigidbody2D rb;

	Player target;
	Vector2 moveDirection;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		target = FindObjectOfType<Player>();
        if (target != null)
        {
			moveDirection = (target.transform.position - transform.position).normalized;
			rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
		}
	}
}
