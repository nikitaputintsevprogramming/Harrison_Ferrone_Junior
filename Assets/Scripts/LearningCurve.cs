using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
     

    void Start()
    {
        Character hero = new Character();
        hero.PrintStatsInfo();

        Character herione = new Character("Agatcha");
        herione.PrintStatsInfo();

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        huntingBow.PrintWeaponInfo();
    }

    void Update()
    {

    }

}