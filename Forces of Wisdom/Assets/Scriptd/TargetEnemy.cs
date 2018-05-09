using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetEnemy : MonoBehaviour {

    public List<Transform> objectius;
    public Transform selectedTarget;
<<<<<<< Updated upstream
    private RendEnemic rendEnemic;
    private Transform myTransform;
    public GameObject PrefabOrc;
    private bool FocusOgro;

=======
    private Transform myTransform;
>>>>>>> Stashed changes
    // Use this for initialization
    void Start () {
        objectius = new List<Transform>();
        AfegirEnemics();
        myTransform = transform;
<<<<<<< Updated upstream
        rendEnemic = GetComponent<RendEnemic>();
        FocusOgro = true;

    }
=======
        
	}
>>>>>>> Stashed changes
	
    public void AfegirEnemics()
    {
        GameObject[] go = GameObject.FindGameObjectsWithTag("Enemic");

        selectedTarget = null;
        foreach (GameObject enemic in go)
            AfegirObjectiu(enemic.transform);
    }

    public void AfegirObjectiu(Transform enemic)
    {
        objectius.Add(enemic);
    }

    private void TargetEnemic()
    {
        if (selectedTarget == null)
        {
            TargetsPerDist();
            selectedTarget = objectius[0];
        }
        else
        {
            int index = objectius.IndexOf(selectedTarget);
            if (index < objectius.Count - 1)
            {
                index++;
            }
            else
            {
                index = 0;
            }
            selectedTarget = objectius[index];
<<<<<<< Updated upstream
            SelecTarget();
        }
    }

    void SelecTarget()
    {
        Transform result = gameObject.transform.Find("ogro");
            if (result == selectedTarget)
            {
            Debug.Log("Found Ogro");
            FocusOgro = false;
            }
            else
            {
                Debug.Log("Did not find sphere3");
            }

    }

 
=======
        }
    }
>>>>>>> Stashed changes
    void TargetsPerDist()
    {
        objectius.Sort(delegate(Transform t1, Transform t2) {
                  return Vector3.Distance(t1.position, myTransform.position).CompareTo(Vector3.Distance(t2.position, myTransform.position));
            });
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            TargetEnemic();
        }
		
	}
}
