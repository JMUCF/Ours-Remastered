using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nation : MonoBehaviour
{
    public List<Character> characterList = new List<Character>();
    [SerializeField] private int population;

    public void Awake()
    {
        population = 0;
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
}
