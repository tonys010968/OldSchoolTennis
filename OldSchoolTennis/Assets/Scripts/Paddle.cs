using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidBody;
    public float speed = 10.0f;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }
}
