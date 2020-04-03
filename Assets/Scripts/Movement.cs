using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D _rig = null;

    private Vector2 _move = Vector2.zero;
    public void SetMove(Vector2 move) => _move = move;
    private Vector2 _aim = Vector2.zero;
    public void SetAim(Vector2 aim) => _aim = aim;

    [SerializeField] private float _speed;

    // Start is called before the first frame update
    void Start()
    {
        _rig = GetComponent<Rigidbody2D>(); 
    }

    private void FixedUpdate()
    {
        // apply speed
        _rig.velocity = _move * _speed;

        // look in aim direction
        transform.up = _aim;
    }
}
