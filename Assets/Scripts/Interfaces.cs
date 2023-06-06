using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interfaces : MonoBehaviour, IExample
{
    public int Level { get; set; }

    public void ApplyDamage(int damage)
    {
        
    }

    public void Drop()
    {
        
    }

    public bool IsAlive()
    {
        return false;
    }
}

interface IExample
{
    void Drop();
    void ApplyDamage(int damage);
    bool IsAlive();
    int Level { get; set; }
}
