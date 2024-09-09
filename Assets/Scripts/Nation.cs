using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nation : MonoBehaviour
{
    public List<Character> characterList = new List<Character>();
    private int population;
    private int farmerCount;
    private int lumberjackCount;

    public void Awake()
    {
        population = 0;
        farmerCount = 0;
        lumberjackCount = 0;
        characterList.Clear();
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
        Debug.Log(farmerCount / population);
        if(farmerCount <= 1)
        {
            Debug.Log("in farmer part");
            character.job = Character.Jobs.farmer;
            farmerCount++;
            Debug.Log(farmerCount);
        }
        else
        {
            Debug.Log("in lumberjack part part");
            character.job = Character.Jobs.lumberjack;
            lumberjackCount++;
            Debug.Log(lumberjackCount);
        }
    }

    void OnDisable()
{
    population = 0;
    farmerCount = 0;
    lumberjackCount = 0;
    characterList.Clear();
}

}
