using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int HP;
    public int startHealth;

    public void TakeDemage(int value)
    {
        HP -= value;
    }
}