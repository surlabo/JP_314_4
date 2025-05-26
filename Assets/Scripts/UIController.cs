using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Button startBtn;
    [SerializeField] private Button optionBtn;

    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject optionPanel;

    private void Start()
    {
        startBtn.onClick.AddListener(OnStartBtnClick);
        optionBtn.onClick.AddListener(OnOptionBtnClick);


    }

    private void OnStartBtnClick()
    {
        SceneManager.LoadScene(0);
    }

    private void OnOptionBtnClick()
    {
        startPanel.SetActive(false);
        optionPanel.SetActive(true);
    }

}
