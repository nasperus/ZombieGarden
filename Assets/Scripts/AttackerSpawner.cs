using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    public bool spawn = true;
    [SerializeField] GameObject attacker;
    [SerializeField] int minSpawnDelay, maxSpawnDelay;

    IEnumerator Start()
    {

        while (spawn)
        {

            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();


        }

    }


    private void SpawnAttacker()
    {
        Instantiate(attacker, transform.position, transform.rotation);
    }



}
