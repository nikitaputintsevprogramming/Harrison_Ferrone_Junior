using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    void Start()
    {
        Character hero = new Character();
        Character hero2 = hero;
        hero2.name = "Sir Krane the Brave";

        hero.PrintStatsInfo();
        hero2.PrintStatsInfo();
        //hero2.Reset();

        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = huntingBow;
        warBow.name = "war Bow";
        warBow.damage = 145;

        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();

        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();
    }

    void Update()
    {

    }

}