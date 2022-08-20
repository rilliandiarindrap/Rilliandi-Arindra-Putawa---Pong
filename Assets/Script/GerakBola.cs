using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakBola : MonoBehaviour
{
    public Vector2 speed;

    private Rigidbody2D rig;
    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    // Update is called once per frame
}
