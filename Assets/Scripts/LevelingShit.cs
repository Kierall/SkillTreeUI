﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelingShit : MonoBehaviour
{
    public Text level;
    public int levelNumber = 0;
    
    public PlayerInfo leeevd;
    // Use this for initialization
    void Start()
    {

        level.text = "Level: " + leeevd.level;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            leeevd.Exp += 10;
        }
 
    }
}
