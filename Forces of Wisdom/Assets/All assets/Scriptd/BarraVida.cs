using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BarraVida : MonoBehaviour
{
  
    public RectTransform HealthBar;
    public int CurrentHealth = 100;
    Collider2D BolaCol;
    
    public void Start()
    {
       
    }
    public void Damage(int value)
    {
        CurrentHealth -= value;
        if (CurrentHealth <= 0)
        {
            Destroy(this);
            CurrentHealth = 0;
        }
        HealthBar.sizeDelta = new Vector2(CurrentHealth, HealthBar.sizeDelta.y);
    }


}
