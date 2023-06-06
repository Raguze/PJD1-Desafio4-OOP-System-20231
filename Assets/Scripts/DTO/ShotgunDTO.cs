using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ShotgunDTO", menuName = "DTO/ShotgunDTO")]
[System.Serializable]
public class ShotgunDTO : WeaponDTO
{
    public int Pellets;
    public float Spread;

}

