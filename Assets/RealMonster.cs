using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class RealMonster : MonoBehaviour, MonsterAttack
{
    public void Attack(string name)
    {
        Debug.Log(name + " Jumped and Attacked the Main Character!");
    }
}
