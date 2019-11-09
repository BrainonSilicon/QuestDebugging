using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class master : MonoBehaviour
{
    public NewBehaviourScript[] allOrbs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        foreach (NewBehaviourScript orb in allOrbs)
        {
            orb.AssignLeader(this.gameObject);
        }

    }
}
