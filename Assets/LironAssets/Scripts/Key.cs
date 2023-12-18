using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Key : MonoBehaviour
{
public static event Action OnCollected;
public static int total;

void Awake() => total++;

void OnTriggerEnter(Collider other)
{
    if(other.CompareTag("Player"))
    {
        OnCollected?.Invoke();
    }
}
}
