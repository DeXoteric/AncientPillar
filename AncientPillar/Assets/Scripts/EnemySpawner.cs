using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AncientPillar
{
    public class EnemySpawner : MonoBehaviour
    {

        [SerializeField] private Transform centralPoint;
        [SerializeField] private float initialSpawnDelay;

        [Header("Enemies")]
        [SerializeField] private GameObject enemyPrefab;

        private int phase = 1; // +1 every 10 waves
        private int wave = 1;

        



        private void Start()
        {
            StartCoroutine(SpawnEnemies());
        }


        IEnumerator  SpawnEnemies()
        {
            
            
            ActivateNextPhase();
            wave += 1;
            Debug.Log(wave + " - " + phase);
            yield return new WaitForSeconds(initialSpawnDelay);
            StartCoroutine(SpawnEnemies());
        }

        

        private void ActivateNextPhase()
        {
            
            if (wave % 10 == 0)
            {
                phase += 1;
            }
        }
    }
}
