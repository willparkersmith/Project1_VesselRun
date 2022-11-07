using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Rungame : MonoBehaviour
{
    public static Rungame Instance;

    void Start()
    {
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }
}
