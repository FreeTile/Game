using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Level_Generation : MonoBehaviour
{
    private int RightPosition;
    public int BoxCount;
    System.Random ran = new System.Random();

    void Start()
    {
        RightPosition = ran.Next(1, BoxCount);    
    }


    void Update()
    {
        
    }

   
}
 

