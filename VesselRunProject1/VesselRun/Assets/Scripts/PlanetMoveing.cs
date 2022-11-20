using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMoveing : MonoBehaviour
{
    void Update()
    {
        transform.position = transform.position + new Vector3(0.0f, -0.6f, 0.0f) * Time.deltaTime;
    }
}
