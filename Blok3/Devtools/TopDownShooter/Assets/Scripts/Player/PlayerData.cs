using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerData : MonoBehaviour
{
    public TextMeshProUGUI coinsText;
    public int coins = 0;

    private void Update()
    {
        coinsText.text = coins.ToString("0") + " Coins";
    }
}