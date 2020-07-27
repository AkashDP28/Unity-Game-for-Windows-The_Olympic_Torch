using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    private Rigidbody2D MyBody;
    float Speed;
    public static bool GameOver;
    
    private void Awake()
    {
        MyBody = GetComponent<Rigidbody2D>();
        Speed = 7f;
    }
    private void Start()
    {
        MyBody.velocity = new Vector2(0f, Speed);
        StartCoroutine("DestroyFire");
    }

    private void FixedUpdate()
    {
      //  MyBody.velocity = new Vector2(0f, Speed);
    }

    IEnumerator DestroyFire()
    {
        yield return new WaitForSeconds(1.4f);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ObsO")
        {
            Debug.Log("A");
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Ocircle")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Debug.Log("B");
            //   LoosePanel.SetActive(true);
            GameOver = true;
        }
    }
}
