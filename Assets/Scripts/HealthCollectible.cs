using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HealthCollectible : MonoBehaviour
{
   public AudioClip collectedClip;

   public GameObject pickupParticlePrefab; 
    
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        
        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
                GameObject pickupParticleOject = Instantiate(pickupParticlePrefab, transform.position, Quaternion.identity);
                //particleSystem = pickupParticleOject.GetComponent<ParticleSystem>();
                //particleSystem.Start(); 
            
                controller.PlaySound(collectedClip);
            }
        
        }
    }
}
