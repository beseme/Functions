using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _shot = null;
    [SerializeField] private float _speed = 0;

    private float xVal = 0;
    public void setX(int val) => xVal += val;

    private float yVal = 0;
    public void setY(int val) => yVal += val;

    private enum Function
    {
        line,
        parable,
        cubic,
        sine
    }

    private Function _currentFunction;

    private int _functionIndex = 0;

    public void SetFunction()
    {
        _functionIndex++;
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

    public void StartShot(Vector2 direction)
    {
        GameObject shot = Instantiate(_shot, this.transform.position, transform.rotation);
        //shot.transform.up = direction;
        shot.GetComponent<Rigidbody2D>().velocity = direction.normalized * _speed;
        shot.GetComponent<Projectile>().SetSpeed(_speed);
        shot.GetComponent<Projectile>().SetFunction(_functionIndex);
    }
}
