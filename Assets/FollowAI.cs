using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAI : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform player;

    private bool isFacingRight = true;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.fixedDeltaTime);

        bool isPlayerRight = transform.position.x < player.position.x;
        Flip(isPlayerRight);
    }

    private void Flip(bool isPlayerRight)
    {
        if((isFacingRight && !isPlayerRight) || (!isFacingRight && isPlayerRight))
        {
            isFacingRight = !isFacingRight;
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
    }
}
