using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour {
    Ads reklam;
    public float health = 4f;
    public GameObject deathPrefab;
    public static int EnemyAlive=0;
    private void Start()
    {
        
        EnemyAlive++;
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.relativeVelocity.magnitude>health)
        {
            
            Die();
        }
        
    }

    void Die()
    {
        Instantiate(deathPrefab, transform.position, Quaternion.identity);
        EnemyAlive--;
        if (EnemyAlive<=0)
        {
            ball.atilanTop = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        Destroy(gameObject);
    }
}
