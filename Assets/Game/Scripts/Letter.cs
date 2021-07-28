using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using DG.Tweening;

public class Letter : MonoBehaviour
{
    static Letter RndmSymbol = new Letter();
    private bool right;
    static bool Pass;
    public float Duration;
    public Transform sprite;
    public static int RightPosition;
    public static char RightSymbol;
    static char Letters;
    public static string ToLevel;
    private string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public int Box_Number;
    System.Random Rnd = new System.Random();
    static List<char> UsesLetters = new List<char>();

    void Start()
    {
        GetSymbol(Box_Number, this.gameObject);
    }

    
    void OnMouseUpAsButton()
    {
        if (right)
        {
            Application.LoadLevel(ToLevel);  
        }
        else
        {
            Sequence seq = DOTween.Sequence();
            seq.Append(sprite.DOShakePosition(2.0f, strength: new Vector3(0, 2, 0), vibrato: 5, randomness: 1, snapping: false, fadeOut: true));
        }

    }

    char GetRandomChar()
    {
        var index = Rnd.Next(symbols.Length);
        return symbols[index];
    }

    char GetSymbol(int pos, GameObject Sym)
    {       
        
        do
        {
            Pass = true;
            Letters = RndmSymbol.GetRandomChar();
            foreach (char x in UsesLetters)
            {
                if (Letters == x)
                {
                    Pass = false;
                }
            }
        } while (Pass == false);
        UsesLetters.Add(Letters);
        Sym.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(""+Letters);
        if (pos == RightPosition)
        {
           Sym.GetComponent<Letter>().right = true;
           RightSymbol = Letters;
        }
        return (Letters);
    }
}
