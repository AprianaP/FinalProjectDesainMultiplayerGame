using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour {
    
    Rigidbody2D rb;

    float dirX;

    [SerializeField]
    float movespeed = 5f, jumpforce = 500f;

    bool facingright = true;

    Vector3 localscale;
    public Rigidbody2D bullet;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

        localscale = transform.localScale;
	}

    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal");

        if (CrossPlatformInputManager.GetButtonDown("Jump"))
            Jump();

        //if (CrossPlatformInputManager.GetButtonDown("Fire"))
            //Fire();
    }

    void FixedUpdate()
    { }

    void CheckFacingWhere()
    {
        if (dirX > 0)
            facingright = true;
        else if (dirX < 0)
            facingright = false;
        if (((facingright) && (localscale.x < 0)) || ((facingright) && (localscale.x > 0)))
            localscale.x *= -1;
        transform.localScale = localscale;
    }
    
    void Jump()
    {
        if (rb.velocity.y == 0)
            rb.AddForce(Vector2.up * jumpforce);
    }
}
