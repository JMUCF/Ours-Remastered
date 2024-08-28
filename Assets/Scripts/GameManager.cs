using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Nation Nation;
    public List<Character> characterList;

    // Start is called before the first frame update
    void Start()
    {
        characterList = Nation.characterList;
        HungerControl();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HungerControl()
    {
        Debug.Log("in hunger control");
        for(int i = 0; i < characterList.Count; i++)
        {
            Debug.Log(i);
            characterList[i].hunger--;
        }
    }
}
