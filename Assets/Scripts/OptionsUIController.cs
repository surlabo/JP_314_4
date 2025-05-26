using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;


public class OptionsUIController : MonoBehaviour
{
    [SerializeField] private Toggle myToggle;
    [SerializeField] private Slider mySlider;
    [SerializeField] private TMP_Dropdown myDropdown;

    List<String> myList = new List<string>();

    void Start()
    {
        myToggle.onValueChanged.AddListener(OnMyToggleClick);
        mySlider.onValueChanged.AddListener(OnSlide);

        mySlider.minValue = 10;
        mySlider.maxValue = 100;

        myDropdown.onValueChanged.AddListener(OnMyDropDownChanged);
    }

    private void OnMyDropDownChanged(int arg0)
    {
        Debug.Log(myDropdown.options[arg0].text);
    }

    private void OnSlide(float arg0)
    {
        Debug.Log(arg0);
    }

    private void OnMyToggleClick(bool value)
    {
        Debug.Log(value);
    }

   
}

public class MyClass
{
    public string name;
    public string description;
    public int age;
}
