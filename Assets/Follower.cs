using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public GameObject leader;
    public bool following;
    public float scale = 0.005f;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void AssignLeader(GameObject lead)
    {
        leader = lead;
        following = true;
    }

    public void UnAssign()
    {
        leader = null;
        following = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (following)
        {
            Vector3 target = leader.transform.position;
            Vector3 direction = target - this.transform.position;
            Vector3 unitDirection = direction.normalized;
            Vector3 step = unitDirection * scale;
            this.GetComponent<Rigidbody>().velocity = step;

            //this.transform.position += step;
        }
    }
}
