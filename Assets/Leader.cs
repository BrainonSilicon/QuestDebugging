using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leader : MonoBehaviour
{

    public Follower[] allFollowers;
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
        Debug.Log("Trigger");

        if(other.gameObject.tag == "Player")
        {

            this.transform.SetParent(other.gameObject.transform);

            foreach (Follower orb in allFollowers)
            {
                orb.AssignLeader(this.gameObject);
            }
        }

        if(other.gameObject.tag == "Orb")
        {
            Destroy(other.gameObject);
        }

    }
}
