using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterUI : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        //TextMeshProUGUI PlayerName = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = PlayerPrefs.GetString("PlayerName");

        Debug.Log(textMeshPro.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
