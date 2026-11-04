using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   private float spawnRangeX = 20;
private float spawnPosZ = 20;

void Update() {
  if (Input.GetKeyDown(KeyCode.S)) {
    // Randomly generate animal index and spawn position
    Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
    0, spawnPosZ);
    int animalIndex = Random.Range(0, animalPrefab.Length);
    Instantiate(animalPrefab[animalIndex], spawnPos,
    animalPrefab[animalIndex].transform.rotation); }}
}
