using UnityEngine;

public class SpawnManagerXX : MonoBehaviour
{

    public GameObject[] enemies;
    public GameObject powerUp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        InvokeRepeating("SpawnRandomEnemy", 2, 5);
        InvokeRepeating("SpawnPowerUp", 2, 5);
    }

    void SpawnRandomEnemy()
    {
        float randomX = Random.Range(-4, 4);
        int randomEnemy = Random.Range(0, 3);
        Instantiate(enemies[randomEnemy], new Vector3(randomX, 1, 5), enemies[randomEnemy].gameObject.transform.rotation);    
    }

    void SpawnPowerUp()
    {
        float randomX = Random.Range(-4, 4);
        float randomZ = Random.Range(-6, 2);
        Instantiate(powerUp, new Vector3(randomX, 0.2f, randomZ), powerUp.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {    
    }


}
