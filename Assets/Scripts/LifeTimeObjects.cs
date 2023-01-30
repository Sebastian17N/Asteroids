using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimeObjects : MonoBehaviour
{
    [SerializeField]
    float Lifetime = 3f;
    void Start()
    {
        Destroy(gameObject, Lifetime);
    }
      
}
