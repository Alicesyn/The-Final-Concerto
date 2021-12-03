using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpriteGlow
{
    public class glowAnimation : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("SwitchGlowBrightness", 0, 0.07f);
        }

        // Update is called once per frame
        void SwitchGlowBrightness()
        {
            gameObject.GetComponent<SpriteGlowEffect>().GlowBrightness = Random.Range(1, 10);
        }
    }
}

