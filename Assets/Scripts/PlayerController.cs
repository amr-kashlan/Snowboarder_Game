using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    public float torqueAnmount = 40f;
    public float boostSpeed = 30;
    public float baseSpeed = 20;
    public bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            Boost();
        }
    }
    public void DisableControlls()
    {
        canMove = false;
    }
    void RotatePlayer()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(-torqueAnmount);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(torqueAnmount);
        }
    }
    void Boost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }
}
