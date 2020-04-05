using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputAllocator : MonoBehaviour
{
    [SerializeField] private Movement _playerMovement = null;
    [SerializeField] private Shoot _shoot = null;

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
        _map.Gamepad.ShoulderR.performed += Button => Shoot();
        _map.Gamepad.ShoulderL.performed += Button => SwitchFunction();
        _map.Gamepad.DUP.performed += Button => IncreaseY(1);
        _map.Gamepad.DDown.performed += Button => IncreaseY(-1);
        _map.Gamepad.DR.performed += Button => IncreaseX(1);
        _map.Gamepad.DL.performed += Button => IncreaseX(-1);
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

    void Shoot()
    {
        _shoot.StartShot(_aimAxis);
    }

    void SwitchFunction()
    {
        _shoot.SetFunction();
    }

    void IncreaseX(int posOrNeg)
    {

    }

    void IncreaseY(int posOrNeg)
    {

    }
}
