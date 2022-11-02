using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Class", menuName = "Class")]
public class PlayerClass : ScriptableObject
{
    public new string name;
    public string description;

    public int playerHealth;
    public Sprite artwork;

}
