using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int hunger;
    public int sleep;
    public enum Jobs {none, farmer, lumberjack};
    public Jobs job;
    public Nation nation;

    void Start()
    {
        hunger = 10;
        sleep = 10;

        // Ensure the nation is set before trying to add the character
        if (nation != null)
        {
            nation.AddCharacter(this);
            nation.JobSelect(this, job);
        }
        else
        {
            Debug.LogWarning("Nation reference is not set in Character.");
        }
    }
}
