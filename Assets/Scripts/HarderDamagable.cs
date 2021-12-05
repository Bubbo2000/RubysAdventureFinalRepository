using UnityEngine;


public class HarderDamagable : MonoBehaviour 
{
    void OnTriggerStay2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            
            controller.ChangeHealth(-2);
        }
    }
}
