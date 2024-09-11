using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int hunger;
    public int sleep;
    public enum Jobs {none, farmer, lumberjack};
    public Jobs job;
    public Tile tile;
    private Nation nation;

    void Start()
    {
        hunger = 10;
        sleep = 10;
        nation = FindObjectOfType<Nation>();
        nation.AddCharacter(this);
        nation.JobSelect(this, job);
        AssignJobClass();
    }

    void AssignJobClass()
    {
        switch(job)
        {
            case Jobs.farmer:
                Farmer farmer = gameObject.AddComponent<Farmer>();
                break;
            case Jobs.lumberjack:
                Lumberjack lumberjack = gameObject.AddComponent<Lumberjack>();
                break;
        }
    }
}

public class Farmer : MonoBehaviour
{
    private Nation nation;
    void Start()
    {
        nation = FindObjectOfType<Nation>();
        StartCoroutine("farm");
    }

    IEnumerator farm()
    {
        while(true)
        {
            yield return new WaitForSeconds(5f);
            nation.wheat ++;
        }
    }
}

public class Lumberjack : MonoBehaviour
{
    private Nation nation;
    void Start()
    {
        nation = FindObjectOfType<Nation>();
        StartCoroutine("farm");
    }

    IEnumerator farm()
    {
        while(true)
        {
            yield return new WaitForSeconds(5f);
            nation.wood ++;
        }
    }
}