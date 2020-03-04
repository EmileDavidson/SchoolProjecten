using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float health;
    public float starthealth;

    public void TakeDemage(float value)
    {
        health -= value;
    }

    public void updatebars(Image Healthbar)
    {
        float healthratio = health / starthealth;
        Healthbar.rectTransform.localScale = new Vector3(healthratio, 1, 1);
    }
}