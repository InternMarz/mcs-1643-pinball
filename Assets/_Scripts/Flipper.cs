using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public KeyCode keyToPress;
    private HingeJoint hinge;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyToPress))
        {
            hinge.useSpring = false;
            hinge.useMotor = true;
        }else
        {
            hinge.useMotor = false;
            hinge.useSpring = true;

        }
    }
}
