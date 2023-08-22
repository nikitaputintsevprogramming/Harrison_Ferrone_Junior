using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintWeaponInfo()
    {
        Debug.LogFormat("Weapon: {0} - {1} DMG", name, damage);
    }
}

public class Character
{
    public string name;
    public int exp = 0;

    public Character()
    {
        name = "No name";
    }

    public Character(string name)
    {
        this.name = name;
    }

    public virtual void PrintStatsInfo()
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", name, exp);
    }

    private void Reset()
    {
        name = "Not assigned";
        exp = 0;
    }
}
