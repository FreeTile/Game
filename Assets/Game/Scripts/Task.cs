using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task : MonoBehaviour
{
    public int BoxCount;
    public string ToLevel;
    System.Random Rnd = new System.Random();

    private void Awake()
    {
       Letter.RightPosition = Rnd.Next(1, BoxCount+1);
       Letter.ToLevel = ToLevel;
    }
    private void Update()
    {
        GameObject Text = this.gameObject;
        Text.GetComponent<Text>().text = ("Find " + Letter.RightSymbol);
    }
}
