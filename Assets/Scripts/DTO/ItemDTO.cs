using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemDTO", menuName = "DTO/ItemDTO")]
[System.Serializable]
public class ItemDTO : ScriptableObject
{
    public string Name;
}
