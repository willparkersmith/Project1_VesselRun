using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D rb2d;
    public Vector2 Movment;

    void Start()
    {
        transform.position = new Vector2(Random.Range(-6, 6), Random.Range(5, 7));
        rb2d = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Movment = new Vector2(0, Speed * -1 * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        moveRock(Movment);
    }
    void moveRock(Vector2 direction)
    {
        rb2d.velocity = direction * Speed;
    }
    //reff chapter 9, 7. movment/collision
}
