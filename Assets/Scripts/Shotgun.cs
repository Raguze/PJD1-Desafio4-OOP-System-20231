using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    public int Pellets { get; set; }
    public float Spread { get; set; }

    public override WeaponType Type 
    {
        get
        {
            return WeaponType.Shotgun;
        } 
    }

    public override void SetDTO(WeaponDTO wdto)
    {
        base.SetDTO(wdto);

        ShotgunDTO dto = wdto as ShotgunDTO;
        if(dto != null)
        {
            Pellets = dto.Pellets;
            Spread = dto.Spread;
        }
    }

    protected override void FireWeapon()
    {
        BulletController bullet;
        float rotationZ = tf.rotation.eulerAngles.z;
        float halfAngle = Spread / 2;
        float pelletAngle = Spread / (Pellets - 1);
        for (int i = 0; i < Pellets; i++)
        {
            bullet = Factory.CreateBullet();
            float rotZ = (rotationZ - halfAngle) + pelletAngle * i;
            bullet.SetTransform(BulletRespawn.position, rotZ);
            bullet.SetDTO(weaponDTO);
        }
    }
}
