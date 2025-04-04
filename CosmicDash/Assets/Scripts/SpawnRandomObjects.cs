using UnityEngine;

public class SpawnRandomObjects : MonoBehaviour
{
    public GameObject enemy;
    public int speed = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObjects", 0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }    

    public void SpawnObjects()
    {        
        Instantiate(enemy, new Vector3(0, 0.5f, Random.Range(-3.5f, 3.5f)), Quaternion.identity);
    }

   
}
