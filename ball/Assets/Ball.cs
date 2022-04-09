using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] private GameObject slider;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 direction = Vector2.zero;
        direction.x = Random.RandomRange(-1f, 1f);
        if (collision.gameObject.CompareTag("Slider"))
        {
            direction.y = 1;
            rb.AddForce(direction.normalized * force * Time.deltaTime, ForceMode2D.Impulse);
        }
         if(collision.gameObject.CompareTag("Wall"))
        {
            direction.y = 1f;
            rb.AddForce(direction.normalized * force * Time.deltaTime, ForceMode2D.Impulse);
        }
        if (collision.gameObject.CompareTag("CorrectPoint")) 
        {
            Destroy(collision.gameObject);
            direction.y = -1f;
            rb.AddForce(direction.normalized * force/4 * Time.deltaTime, ForceMode2D.Impulse);
        }
    }
}
