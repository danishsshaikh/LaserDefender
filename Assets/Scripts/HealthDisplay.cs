﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    Text healthText;
    Player player;
    //GameSession gameSession;

    private void Start()
    {
        healthText = GetComponent<Text>();
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        healthText.text = player.GetHealth().ToString();
        //Debug.Log(healthText.text);
    }
}
