using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMove : MonoBehaviour
{
    private NavMeshAgent agent;
    private Character character;
    private Tile targetTile;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        character = GetComponent<Character>();

        StartCoroutine(WaitForJobAssignment());
    }

    void Update()
    {
        // If there's a target tile, move towards it
        if (targetTile != null)
        {
            agent.SetDestination(targetTile.transform.position);
        }
    }

    IEnumerator WaitForJobAssignment()
    {
        // Wait until the job is no longer 'none'
        while (character.job == Character.Jobs.none)
        {
            yield return null; // wait for the next frame
        }

        // Once the job is assigned, set the target tile
        SetTargetTile();
    }

    void SetTargetTile()
    {
        // Find all tiles in the scene
        Tile[] tiles = FindObjectsOfType<Tile>();

        Debug.Log("Number of tiles found: " + tiles.Length);

        // Based on the character's job, choose the target tile type
        //THIS NEEDS TO BE CHANGED TO LOOK FOR AN UNASSIGNED TILE AND CHANGE THE TYPE BASED ON WHAT THE CHARACTER IS
        Tile.TileType targetType = Tile.TileType.none;

        switch (character.job)
        {
            case Character.Jobs.farmer:
                Debug.Log("im a farmer");
                targetType = Tile.TileType.farmland;
                break;
            case Character.Jobs.lumberjack:
                Debug.Log("im a lumberjack");
                targetType = Tile.TileType.forest;
                break;
        }

        Debug.Log("Looking for tile of type: " + targetType);

        // Find the closest tile of the correct type
        float closestDistance = Mathf.Infinity;
        foreach (Tile tile in tiles)
        {
            if (tile.type == targetType && tile.owner == null)
            {
                float distance = Vector3.Distance(transform.position, tile.transform.position);
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    targetTile = tile;
                    tile.owner = character;
                }
            }
        }

        if (targetTile == null)
        {
            Debug.LogWarning("No valid tile found for the character's job.");
        }
    }
}
