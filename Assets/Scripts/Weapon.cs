using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType { None, Pistol, Shotgun, Machinegun, Sniper, RocketLauncher }
public enum FireMode { None, Semi, Auto }
public class Weapon : Item
{
    public const float MAX_ANGLE_ACCURACY = 10f;

    public int Damage { get; set; }
    public int AmmoMax { get; set; }
    public float FireRate { get; set; }
    public float ReloadSpeed { get; set; }
    public float Accuracy { get; set; }
    public float Distance { get; set; }
    public float BulletSpeed { get; set; }
    public float Weight { get; set; }

    public int Ammo { get; protected set; }
    public float ReloadDuration { get; protected set; }

    public float FireRateTime { get; protected set; }

    [SerializeField]
    public virtual WeaponType Type { get; set; }

    [SerializeField]
    public FireMode Mode { get; protected set; }

    [SerializeField]
    protected WeaponDTO weaponDTO;

    [SerializeField]
    protected Transform BulletRespawn;

    protected Transform tf;

    public bool CanFire
    { 
        get
        {
            return (
                Ammo > 0
                && ReloadDuration <= 0
                && FireRateTime >= FireRate
            );
        } 
    }

    public virtual void SetDTO(WeaponDTO dto)
    {
        weaponDTO = dto;

        Accuracy = weaponDTO.Accuracy;
        AmmoMax = weaponDTO.AmmoMax;
        BulletSpeed = weaponDTO.BulletSpeed;
        Damage = weaponDTO.Damage;
        Distance = weaponDTO.Distance;
        FireRate = weaponDTO.FireRate;
        Name = weaponDTO.Name;
        ReloadSpeed = weaponDTO.ReloadSpeed;
        Weight = weaponDTO.Weight;
        Type = weaponDTO.Type;
        Mode = weaponDTO.Mode;

        // Other params
        Ammo = AmmoMax;
    }

    private void Awake()
    {
        tf = GetComponent<Transform>();

        BulletRespawn = transform.Find("BulletRespawn");


        if(weaponDTO != null)
        {
            SetDTO(weaponDTO);
        }


    }

    private void Update()
    {
        FireRateTime += Time.deltaTime;

        if(ReloadDuration > 0)
        {
            ReloadDuration -= Time.deltaTime;
            if(ReloadDuration <= 0)
            {
                Ammo = AmmoMax;
            }
        }


    }

    public virtual void Fire()
    {
        if(CanFire)
        {
            FireWeapon();
            FireRateTime = 0f;
            Ammo--;
        }
    }

    protected virtual void FireWeapon()
    {
        BulletController bullet = Factory.CreateBullet();
        float z = ApplyAccuracy(tf.rotation.eulerAngles.z);
        bullet.SetTransform(BulletRespawn.position, z);
        bullet.SetDTO(weaponDTO);

    }

    protected virtual float ApplyAccuracy(float angleZ)
    {
        float weaponAngleAccuracy = MAX_ANGLE_ACCURACY * (1f - Mathf.Clamp01(Accuracy));
        angleZ += Random.Range(-weaponAngleAccuracy, weaponAngleAccuracy);
        Debug.Log($"{weaponAngleAccuracy} {angleZ}");
        return angleZ;
    }

    public virtual void Reload()
    {
        ReloadDuration = ReloadSpeed;
    }
}
