using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
    private Animator animator;
    private Vector3 lastPosition;
    private bool isRight = true;

    void Start()
    {
        animator = GetComponent<Animator>();
        lastPosition = transform.position;
    }

    void Update()
    {
        Vector2 velocity = lastPosition - transform.position;

        // Check to see which direction I am moving in and flip accordingly
        if(velocity.x > 0 && isRight)
        {
            Flip();
        }
        else if (velocity.x < 0 && !isRight)
        {
            Flip();
        }

        animator.SetFloat("Speed", Mathf.Abs(velocity.x));

        Debug.Log(velocity.x);

        lastPosition = transform.position;
    }

    private void Flip()
    {
        isRight = !isRight;

        Vector3 temp = transform.localScale;
        temp.x *= -1;
        transform.localScale = temp;
    }
}
