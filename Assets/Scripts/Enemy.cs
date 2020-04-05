using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform _target = null;

    private RaycastHit2D _scanner = new RaycastHit2D();

    private void Update()
    {
        _scanner = Physics2D.Raycast(transform.position, transform.up, Mathf.Infinity, LayerMask.GetMask("Player"));
        if (_scanner) { }
    }

    private void FixedUpdate()
    {
        transform.up = _target.position - transform.position;
    }
}
