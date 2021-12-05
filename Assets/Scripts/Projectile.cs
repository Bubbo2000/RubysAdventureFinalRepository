using UnityEngine;
using UnityEngine.UI;



public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d;  
    
    
    
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if(transform.position.magnitude > 1000.0f)
            Destroy(gameObject);
    }

    
    public void Launch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        
        Enemy e = other.collider.GetComponent<Enemy>();
        HardEnemyController he = other.collider.GetComponent<HardEnemyController>();

        if (e != null)
        {
            e.Fix();
          
        }
        if (he != null)
        {
            he.Fix();
          
        }
        
        
        Destroy(gameObject);
    }
}
