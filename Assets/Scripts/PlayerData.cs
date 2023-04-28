using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData{
    public int currentlevel;

    public PlayerData(Question_Generator player)
    {
        currentlevel = player.counter+1;
    }
}
