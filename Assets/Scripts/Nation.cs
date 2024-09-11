using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nation : MonoBehaviour
{
    public List<Character> characterList = new List<Character>();
    private int population;
    private int farmerCount;
    public int wheat;
    private int lumberjackCount;
    public int wood;

    public void Awake()
    {
        population = 0;
        farmerCount = 0;
        wheat = 0;
        lumberjackCount = 0;
    }

    // Method to add a character to the list
    public void AddCharacter(Character character)
    {
        if (!characterList.Contains(character))
        {
            characterList.Add(character);
            population++;
        }
    }

    public void JobSelect(Character character, Character.Jobs jobs)
    {
        if(farmerCount <= 1)
        {
            character.job = Character.Jobs.farmer;
            farmerCount++;
        }
        else
        {
            character.job = Character.Jobs.lumberjack;
            lumberjackCount++;
        }
    }
}
