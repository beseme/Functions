using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _shot = null;
    [SerializeField] private float _speed = 0;

    private enum Function
    {
        line,
        parable,
        sine
    }

    private Function _currentFunction;

    private int _functionIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetFunction()
    {
        _functionIndex++;
        if (_functionIndex >= 3) _functionIndex = 0;

        if (_functionIndex == 0)
            _currentFunction = Function.line;
        else if (_functionIndex == 1)
            _currentFunction = Function.parable;
        else if (_functionIndex == 2)
            _currentFunction = Function.sine;
        else
            _functionIndex = 0;
    }

    public void StartShot(Vector2 direction)
    {
        Instantiate(_shot, this.transform);
        _shot.transform.up = direction;
        _shot.GetComponent<Rigidbody2D>().velocity = direction.normalized * _speed;
    }
}
