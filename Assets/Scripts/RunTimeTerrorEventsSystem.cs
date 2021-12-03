using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MoreMountains.CorgiEngine
{


    public class RunTimeTerrorEventsSystem : MonoBehaviour
    {
        public GameObject gmObj;
        public GameObject boss;
        public int points;
        public int pointThreshold = 50;
        private GameManager gm;

        private bool bossConditionMet = false;
        // Start is called before the first frame update
        void Start()
        {
            gm = gmObj.GetComponent<GameManager>();
        }

        // Update is called once per frame
        void Update()
        {
            points = gm.Points;
            if (points >= pointThreshold)
            {
                boss.SetActive(true);
                Debug.Log(bossConditionMet);
                gameObject.SetActive(false);
                // SceneManager.LoadScene("GameOver");
            }
        }
    }

}