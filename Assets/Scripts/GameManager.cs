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
        //StartCoroutine("HungerCoroutine");
    }

    private IEnumerator HungerCoroutine()
    {
        yield return new WaitForSeconds(4);
        LowerHunger();
    }

    void LowerHunger()
    {
        Debug.Log("in hunger control");
        for(int i = 0; i < characterList.Count; i++)
        {
            characterList[i].hunger--;
        }
    }
}
