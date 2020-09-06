using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MyFruit : MonoBehaviour
{
    private List<string> fruitNames = new List<string>();
    [SerializeField] private Text fruitText;

    private string spriteNames = "apple";

    private SpriteRenderer SpriteR;
    private Sprite[] sprites;
    
    void Start()
    {
        fruitText = GetComponent<Text>();
        
        fruitNames.Add("Apple");
        fruitNames.Add("Orange");
        fruitNames.Add("Carrot");
        fruitNames.Add("Strawberry");
        fruitNames.Add("Banana");
        
        UpdateText();
        SpriteR = gameObject.GetComponent<SpriteRenderer>();
        sprites = Resources.LoadAll<Sprite>(spriteNames);
    }

    void UpdateText()
    {
        fruitText.text = "";
        
        foreach (var fruit in fruitNames)
        {
            fruitText.text += "\n" + fruit;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (fruitNames.Count <= 0) return;
            
            string fruitName = fruitNames[0];
            
            fruitNames.RemoveAt(0);
            UpdateText();
        }
    }
}
