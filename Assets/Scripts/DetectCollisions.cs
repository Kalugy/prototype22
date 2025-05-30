using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    private PlayerController playerController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        //Destroy(other.gameObject);
        playerController.score += 1;
        Debug.Log("Score: " + playerController.score);
        other.GetComponent<AnimalHunger>().FeedAnimal(1);
    }
}
