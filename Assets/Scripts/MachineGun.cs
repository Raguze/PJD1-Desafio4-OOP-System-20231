using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : Weapon
{
    public override WeaponType Type { get { return WeaponType.Machinegun; } }

    protected override void FireWeapon()
    {
        BulletController bullet = Factory.CreateBullet();
        float z = ApplyAccuracy(tf.rotation.eulerAngles.z);
        bullet.SetTransform(BulletRespawn.position, z);
        bullet.SetDTO(weaponDTO);
    }
}
