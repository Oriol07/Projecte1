using UnityEngine;
using UnityEngine.UI;
using System.Collections;

<<<<<<< Updated upstream
public class BarraVida : MonoBehaviour
{
  
    public Scrollbar HealthBar;
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
        HealthBar.size = CurrentHealth / 100f;
    }


=======
public class BarraVida : MonoBehaviour {

	public Scrollbar HealthBar;
	public float Health = 100;

	public void Damage(float value)
	{
		Health -= value;
		HealthBar.size = Health / 100f;
	}

>>>>>>> Stashed changes
}
