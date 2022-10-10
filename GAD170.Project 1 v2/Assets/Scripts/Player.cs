using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string name = "xX_Destroyer2008_Xx";
    public int health = 100;
    public int armor = 10;
    public int attack = 20;
    public float rangeOfAttack = 1f;
    public float speedOfAttack = 0.3f;
    public float chanceToMiss = 0.25f;

    private void Start()
    {
        print("Hello, Creator!");
        print("My health is " + health);
        print("My armor is " + armor + " and my damage is " + attack);
        print("My range of an attack is " + rangeOfAttack);
        print("My attack speed is " + speedOfAttack);
        print("I can miss with a " + chanceToMiss + " chance!");
    }
}
