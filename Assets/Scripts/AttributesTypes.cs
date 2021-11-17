using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AttributesTypes : MonoBehaviour
{
    [SerializeField]    // Expose it to the editor
    int score;

    [HideInInspector]   // Hide the information (opposite)
    public float distance;

    [Range (0,100)] //Limits the values
    public int health;
}
