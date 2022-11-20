using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    public float radius = 5.0F;
    public float power = 10.0F;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.position = transform.position + new Vector3(0.0f, -1.5f, 0.0f) * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //on collision with an instance of lazer, this object will detonate
        if (collision.gameObject.name == "Lazer(Clone)")
        {
            Explode();
            Destroy(this.gameObject);
            Debug.Log("PowerUp Hit");
        }
    }


   private void Explode()
    {
        // Applies an explosion force to all nearby rigidbodies
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);

        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null && hit.tag == "Asteroid")
                rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
            //if (!hit && hit.collider.tag == "Asteroid")
        }
    }
}
