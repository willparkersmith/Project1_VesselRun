using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vessel : MonoBehaviour
{
    public KeyCode left;
    public KeyCode right;
    public float VesselMoveSpeed = 10.0f;
    public Rigidbody2D rb;
    public Vector2 movment;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            movment = new Vector2(VesselMoveSpeed * -1 * Time.deltaTime, 0);
        }
        else if (Input.GetKey(right))
        {
            movment = new Vector2(VesselMoveSpeed * Time.deltaTime, 0);
        }
    }

    private void FixedUpdate()
    {
        moveVessel(movment);
    }
    void moveVessel(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * VesselMoveSpeed * Time.deltaTime));
    }

}
