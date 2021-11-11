using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoLinear : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float force;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        rb2d.AddForce(transform.right * force);
    }
}
