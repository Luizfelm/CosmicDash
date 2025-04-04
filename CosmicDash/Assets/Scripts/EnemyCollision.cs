using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollision : MonoBehaviour
{
    private ScoreSystem scoreSystem;

    private void Start()
    {
        scoreSystem = GameObject.Find("Grade").GetComponent<ScoreSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(2);
        }
        else if (other.CompareTag("Bullet"))
        {
            scoreSystem.AddPoints(100);
            Destroy(other.gameObject);
            Destroy(gameObject);
        } 
        else if (other.CompareTag("End"))
        {
            scoreSystem.RemoveLife(1);

            Destroy(gameObject);

            if(scoreSystem.lifes == 0)
            {
                SceneManager.LoadScene(2);
            }
        }
        

        
    }

}
