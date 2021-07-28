#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;

public class Main : MonoBehaviour
{
    public string Action;
    void Start()
    {
        
    }
    void OnMouseUpAsButton()
    {
        Application.LoadLevel("Level Easy");
    }
}
#endif