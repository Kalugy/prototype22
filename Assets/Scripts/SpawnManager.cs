using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    public GameObject[] animalPrefabsL;
    public GameObject[] animalPrefabsR;

    private float spawnRangeX = 10;
    private float spawnPosZ = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private float startDelay = 2f;
    private float startInterval = 3f;
    
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, startInterval);
        InvokeRepeating("SpawnRandomAnimalL", startDelay, startInterval);
        InvokeRepeating("SpawnRandomAnimalR", startDelay, startInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    SpawnRandomAnimal();
        //}

        
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalL()
    {
        float spawnZ = Random.Range(12, 0);
        Vector3 spawnPos = new Vector3(20, 0, spawnZ);

        int animalIndex = Random.Range(0, animalPrefabsL.Length);
        Instantiate(animalPrefabsL[animalIndex], spawnPos, Quaternion.Euler(0, 270, 0));
    }

    void SpawnRandomAnimalR()
    {
        float spawnZ = Random.Range(12, 0);
        Vector3 spawnPos = new Vector3(-20, 0, spawnZ);

        int animalIndex = Random.Range(0, animalPrefabsR.Length);
        Instantiate(animalPrefabsR[animalIndex], spawnPos, Quaternion.Euler(0, 90, 0));
    }

    

}
