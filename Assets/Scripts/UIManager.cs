using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private int x = 0;
    public void SetX(int x) => this.x += x;

    private int y = 0;
    public void SetY(int y) => this.y += y;

    private int _functionIndex = 0;

    [SerializeField] private Text _uiText = null;
    [SerializeField] private Text _functionText = null;

    private void Start()
    {
        _functionText.text = "LINE";
    }

    private void Update()
    {
        _uiText.text = "x = " + x.ToString() + "\n" + "y = " + y.ToString();
    }

    public void SetFunction()
    {
        _functionIndex++;
        if (_functionIndex >= 4) _functionIndex = 0;

        if (_functionIndex == 0)
            _functionText.text = "LINE";
        else if (_functionIndex == 1)
            _functionText.text = "PARABLE";
        else if (_functionIndex == 2)
            _functionText.text = "CUBIC";
        else if (_functionIndex == 3)
            _functionText.text = "SINE";
        else
            _functionIndex = 0;
    }
}
