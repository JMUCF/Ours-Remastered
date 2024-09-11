using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int hunger;
    public int sleep;
    public enum Jobs {none, farmer, lumberjack};
    public Jobs job;
    private Nation nation;

    void Start()
    {
        hunger = 10;
        sleep = 10;
        nation = FindObjectOfType<Nation>();
        nation.AddCharacter(this);
        nation.JobSelect(this, job);
    }
}

public class Farmer : MonoBehaviour
{

}
