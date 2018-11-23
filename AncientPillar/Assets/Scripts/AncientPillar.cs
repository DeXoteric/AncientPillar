using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AncientPillar
{
    public class AncientPillar : MonoBehaviour
    {

        [SerializeField] private Transform spawnPoint;

        // Offensive stats
        private float damage;
        private float attackSpeed;

        // Defensive stats
        private float health;
        private float healthRegen;
    }
}
