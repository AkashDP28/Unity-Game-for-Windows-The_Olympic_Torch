using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchScript : MonoBehaviour
{
    private Rigidbody2D MyBody;
    public float Speed;
    public GameObject Fire;
    public Transform ShootPoint;
    private void Awake()
    {
        MyBody = GetComponent<Rigidbody2D>();
        Speed = 2f;
    }

    private void FixedUpdate()
    {
        if (!FireScript.GameOver)
        {
            Movement();
        }
       
    }

    private void Update()
    {
        Shoot();
        Vector2 temp = transform.position;
        temp.x = Mathf.Clamp(temp.x, -8.3f, 8.3f);
        transform.position = temp;
    }
    void Movement()
    {
        float h = Input.GetAxisRaw("Horizontal");
      //  float v = Input.GetAxisRaw("Vertical");
        if (h > 0)
        {
            MyBody.velocity = new Vector2(Speed, MyBody.velocity.y);
        }
        else if (h < 0)
        {
            MyBody.velocity = new Vector2(-Speed, MyBody.velocity.y);
        }

    /*    else if (v > 0)
        {
            MyBody.velocity = new Vector2(MyBody.velocity.x, Speed);
        }
        else if (v < 0)
        {
            MyBody.velocity = new Vector2(MyBody.velocity.x, -Speed);
        }*/
        else
        {
            MyBody.velocity = new Vector2(0, 0);
        }
    }
    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Fire, ShootPoint.position, Quaternion.identity);
        }
    }
}
