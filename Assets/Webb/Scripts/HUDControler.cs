﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 namespace webb{ };
public class HUDControler : MonoBehaviour
{
    // Start is called before the first frame update
    public Image progressBar;
    float xp = 0;
    float xpMax = 350;
   public Text textScore;
    static int score = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = $"XP:{(int)score}";
        if (Input.GetButton("Plunger"))
        {
            xp += 200 * Time.deltaTime;
            float p = xp / xpMax;
           
            
        } 
        progressBar.fillAmount = xp / xpMax;
        if (Input.GetButtonUp("Plunger"))
        {
            ClearXpValue();
        }
    }
    public void ClearXpValue()
    {
        xp = 0;
    }
}
