using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatform : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        Vector2 direction = Vector2.right * hor;
        rb.velocity = new Vector2(direction.x*speed, rb.velocity.y);

        animator.SetFloat("hor", Mathf.Abs(hor));

        if (hor > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (hor < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
