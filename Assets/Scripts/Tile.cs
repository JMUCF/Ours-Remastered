using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public enum TileType {none, farmland, forest};
    public TileType type;
    public Character owner;
}
