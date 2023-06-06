using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponDTO", menuName = "DTO/WeaponDTO")]
[System.Serializable]
public class WeaponDTO : ItemDTO
{
    public WeaponType Type;
    public FireMode Mode;
    public int Damage;
    public int AmmoMax;
    public float FireRate;
    public float ReloadSpeed;
    public float Accuracy;
    public float Distance;
    public float BulletSpeed;
    public float Weight;
    
}
