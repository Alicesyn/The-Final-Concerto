using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoreMountains.CorgiEngine
{
    public class ReflectProjectile : MonoBehaviour
    {
        private Vector3 direction;
        private Vector3 reflectedDirection;
        public GameObject source;

        private Health health;
        public bool hasReflected = false;
        // Start is called before the first frame update
        void Start()
        {
            gameObject.SetActive(true);
            if (source != null)
            {
                health = gameObject.GetComponent<Health>();
                direction = transform.TransformPoint(source.gameObject.transform.position) - transform.position;
                reflectedDirection = transform.InverseTransformDirection(direction);
            }
        }

        // Update is called once per frame
        void Update()
        {
            // trigger on player interaction, we assume player has attacked the projectile
            if (health.CurrentHealth < health.InitialHealth)
            {
                gameObject.GetComponent<PathedProjectile>().enabled = false;
                hasReflected = true;

            }
            if (hasReflected && source != null)
            {
                float speed = source.GetComponentInChildren<PathedProjectileSpawner>().Speed;
                transform.position += transform.right * Time.deltaTime * speed;
            }
        }
    }
}