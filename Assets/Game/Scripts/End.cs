using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class End : MonoBehaviour
{
    public string Action;

    void Start()
    {


    }
    void OnMouseUpAsButton()
    {
        switch (Action)
        {
            case "home":
                Application.LoadLevel("Main");
                break;
            case "Restart":
                Application.LoadLevel("Level easy");
                break;
        }
    }
}
