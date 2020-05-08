using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRedo : MonoBehaviour
{

    public Transform target;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, target.localPosition, (speed * Time.deltaTime));
        if (Vector3.Distance(transform.localPosition, target.localPosition) < .001f)
        {
            target.localPosition *= -1.0f;
        }

    }
}
