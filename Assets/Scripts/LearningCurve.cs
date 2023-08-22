using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
     

    void Start()
    {
        Character hero = new Character();
        Character hero2 = hero;
        hero2.name = "Richard";
        hero.PrintStatsInfo();
        hero2.PrintStatsInfo();
        //hero2.Reset();

        Character herione = new Character("Agatcha");
        herione.PrintStatsInfo();

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = huntingBow;

        huntingBow.PrintWeaponInfo();
        warBow.PrintWeaponInfo();

        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();
    }

    void Update()
    {

    }

}