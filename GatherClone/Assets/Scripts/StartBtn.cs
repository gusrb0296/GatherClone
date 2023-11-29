using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    public TMP_InputField PlayerNameInput;
    private string _playerName = null;

    private void Awake()
    {
        
    }

    private void Update()
    {
        _playerName = PlayerNameInput.text;
    }

    public void InputName()
    {
        _playerName = PlayerNameInput.text;
        PlayerPrefs.SetString("PlayerName", _playerName);
        
        Debug.Log(_playerName);
    }


    public void GameStart()
    {
        Debug.Log(_playerName);
        if (_playerName.Length > 0)
        {
            SceneManager.LoadScene("MainScene");
            InputName();
        }
        
    }
}
