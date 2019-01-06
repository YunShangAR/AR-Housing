using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Housing/House")]
public class House : ScriptableObject
{
    public string address1;
    public string address2;
    public float price;
    public int bedroomCount;
    public int bathroomCount;
    public float squareMeter;
    public Salesman salesman;
    public int roamSceneIndex = -1;
}
