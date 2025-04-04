using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float speed = 5.0f;   

    //Move the enemy in the x axis
    private void FixedUpdate()
    {        
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
