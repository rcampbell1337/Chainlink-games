using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameSettings : MonoBehaviour
{

    public static string playerNamestr;
    public TextMeshProUGUI playerName;
    // Start is called before the first frame update
    void Start()
    {
        playerName.text = playerNamestr;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
