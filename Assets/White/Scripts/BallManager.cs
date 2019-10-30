using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace White {
    public class BallManager : MonoBehaviour
    {
        public GameObject ball;

        bool stopSpawning = false;

        public float killPlane;
        bool isDead = false;

        void Update()
        {
            BallIsDead();

            if (isDead) BallsLeft.LoseBall();
        }

        public void Spawn()
        {
            Instantiate(ball, transform.position, transform.rotation);
            isDead = false;
            stopSpawning = true;
            if (stopSpawning)
            {
                isDead = false;
                CancelInvoke("Spawn");
            }

            if (isDead == true)
            {
                Invoke("Spawn", 5);
            }
        }

        public void BallIsDead()
        {
            if (ball != null && ball.transform.position.z < killPlane)
            {
                isDead = true;
                Destroy(ball);
            }
        }
    }
}