using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    [SerializeField] private Sprite on, off;
    [SerializeField] private Image target;
    private Toggle _toggle;
    
    private void Start()
    {
        _toggle = GetComponent<Toggle>();
        _toggle.isOn = GlobalFunctions.Inverted == -1; // 1 = normal, -1 = inverted
        SwitchToggle();
    }
    
    public void SwitchToggle()
    {
        target.sprite = _toggle.isOn ? on : off;
    }

    public void InvertInput()
    {
        GlobalFunctions.InvertInput(_toggle.isOn);
    }
}
