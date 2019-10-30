using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace White
{
    public class BallsLeft : MonoBehaviour
    {
        public static int ballsLeft = 2;
        Text text;

        void Start()
        {
            text = GetComponent<Text>();
        }
        
        void Update()
        {
            text.text = "Balls Left: " + ballsLeft;
        }

        public static void LoseBall()
        {
            ballsLeft--;
            if (ballsLeft < 0) ballsLeft = 0;
        }
    }
}