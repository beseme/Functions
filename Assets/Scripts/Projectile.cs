using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float xVal = 0;
    public void setX(int val) => xVal = val;

    private float yVal = 0;
    public void setY(int val) => yVal = val;

    //for parabola
    [SerializeField] private float _parableWidth;
    [SerializeField] private float _parableHeight;

    //for cubic
    [SerializeField] private float _cubicWidth;
    [SerializeField] private float _cubicSpeed;

    //for sine
    [SerializeField] private float _frequency = 0;
    [SerializeField] private float _amplitude = 0;
    private float x = 0;
    private float _speed = 0;
    private float _timeReset = 0;
    public void SetSpeed(float speed) => _speed = speed;
    private Vector2 _sineWave = Vector2.zero;
    private Vector2 _parabola = Vector2.zero;

    Rigidbody2D _rig = null;

    private enum Function
    {
        line,
        parable,
        cubic,
        sine
    }

    private Function _currentFunction;

    private int _functionIndex = 0;


    // Unity Events
    private void Awake()
    {
        _rig = GetComponent<Rigidbody2D>();
        _currentFunction = Function.sine;
    }

    private void Start()
    {
        _sineWave = transform.right;
        _parabola = Vector2.up;
        _timeReset = Time.fixedTime;

        if (_currentFunction == Function.parable)
        {
            _parableWidth = xVal;
            _parableHeight = yVal;
        }
        else if (_currentFunction == Function.cubic)
        {
            _cubicWidth = xVal;
            _cubicSpeed = yVal;
        }
        else if (_currentFunction == Function.sine)
        {
            _amplitude = xVal;
            _frequency = yVal;
        }
    }

    private void FixedUpdate()
    {
        if( _currentFunction == Function.parable)
        {
            _parableHeight -= (Time.fixedTime - _timeReset);
            Vector2 xAxis = transform.right * _parableWidth;
            Vector2 yAxis = transform.up * _parableHeight;
            _rig.velocity = xAxis + yAxis;
        }
        else if(_currentFunction == Function.cubic)
        {
            x = Mathf.Pow((Time.fixedTime - _timeReset - _cubicSpeed), 2);
            Vector2 xAxis = transform.right * _cubicWidth;
            Vector2 yAxis = transform.up * x;
            _rig.velocity = xAxis + yAxis;
        }
        else if(_currentFunction == Function.sine)
        {
            x = (Mathf.PI/2 + Time.fixedTime - _timeReset) * _frequency;
            transform.up += (Vector3) _sineWave * Mathf.Sin(x) * _amplitude;
            _rig.velocity = transform.up * _speed;
        }        
    }

    // Custom Events
    public void SetFunction(int index)
    {
        _functionIndex = index;
        if (_functionIndex >= 4) _functionIndex = 0;

        if (_functionIndex == 0)
            _currentFunction = Function.line;
        else if (_functionIndex == 1)
            _currentFunction = Function.parable;
        else if (_functionIndex == 2)
            _currentFunction = Function.cubic;
        else if (_functionIndex == 3)
            _currentFunction = Function.sine;
        else
            _functionIndex = 0;
    }
}
