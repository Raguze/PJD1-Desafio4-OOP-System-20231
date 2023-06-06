using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public override WeaponType Type 
    { 
        get
        {
            return WeaponType.Pistol;
        }
    }
}
