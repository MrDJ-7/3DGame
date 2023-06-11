using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Basics : MonoBehaviour
{

    [NonSerialized] public int num = 13;
    public string Word;
    public int[] numbers = new int[3];
    public List<string> words = new List<string>();
    void Start()
    {
        Debug.Log(Word + num);
    }

}
