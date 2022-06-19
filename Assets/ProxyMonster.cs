using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class ProxyMonster : MonoBehaviour, MonsterAttack
    {
        private RealMonster _realMonster;
        public float Distance;
        public string name = "ProxyMonsterX";

        private void Awake()
        {
            _realMonster = gameObject.AddComponent<RealMonster>();
            Attack(name);
        }

        public void Attack(string name)
        {
            if (Distance <= 10f)
                _realMonster.Attack(name);
            else
                Debug.Log("It is too far to attack for " + name);
        }
    }
}