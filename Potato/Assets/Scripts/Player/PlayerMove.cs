using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    private Rigidbody2D rb;
    public LayerMask groundCheck;
    Vector2 velocity;
    public GameObject GameSystem;
    private bool sP;
    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        sP = GameObject.FindWithTag("System").GetComponent<GameSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector2(moveSpeed * transform.position.x, velocity.y);

        if (sP == false)
        {
            if (Physics2D.Raycast(transform.position, Vector2.down, 0.6f, groundCheck))
            {
                // Get the player's current position
                Vector2 pos = transform.position;

                // Move the player to the right
                pos.x += moveSpeed * Time.deltaTime;

                // Update the player's position
                transform.position = pos;
            }
            else
            {

            }
        }
        Debug.DrawRay(transform.position, Vector2.down * 0.6f);
    }
}
