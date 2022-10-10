using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    public Rigidbody2D rBody;
    public int moveSpeed;
    private float direction;

    public bool onGround;
    public Transform detectGround;
    public LayerMask whatsGround;
    public int extraJump = 1;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        onGround = Physics2D.OverlapCircle(detectGround.position, 0.2f, whatsGround);
        if(Input.GetButtonDown("Jump") && onGround == true)
        {
            rBody.velocity = Vector2.up * 12; 
        }
        if(Input.GetButtonDown("Jump") && onGround == false && extraJump >0)
        {
            rBody.velocity = Vector2.up * 12;
            extraJump --;
        }
        if(onGround)
        {
            extraJump = 1;
        }

        direction = Input.GetAxis("Horizontal");
        rBody.velocity = new Vector2(direction * moveSpeed, rBody.velocity.y);
    }
}
