using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starsbackground : MonoBehaviour
{


    void Update()
    {
        transform.position = transform.position + new Vector3(-0.03f, 0.009f, 0.0f) * Time.deltaTime;
    }
}
