using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField] private float health;
    void Start()
    {
        health = 0;
    }

    void Update()
    {
        Debug.Log(health);
    }
}
