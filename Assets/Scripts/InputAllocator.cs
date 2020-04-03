using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputAllocator : MonoBehaviour
{
    [SerializeField] private Movement _playerMovement = null;

    private Inputmapping _map;

    private Vector2 _moveAxis = Vector2.zero;
    private Vector2 _aimAxis = Vector2.zero;

    private void Awake()
    {
        _map = new Inputmapping();

        _map.Gamepad.StickL.performed += Stick => _moveAxis = Stick.ReadValue<Vector2>();
        _map.Gamepad.StickL.canceled += Stick => _moveAxis = Vector2.zero;

        _map.Gamepad.StickR.performed += Stick => _aimAxis = Stick.ReadValue<Vector2>();
        //_map.Gamepad.StickR.canceled += Stick => _aimAxis = Vector2.zero;
    }

    private void OnEnable()
    {
        _map.Enable();
    }
    private void OnDisable()
    {
        _map.Disable();
    }

    private void Update()
    {
        _playerMovement.SetAim(_aimAxis);
        _playerMovement.SetMove(_moveAxis);
    }
}
