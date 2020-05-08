using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite : MonoBehaviour
{
    public Transform target;
    public float RotationSpeed = 100f;
    public float OrbitDegrees = 1f;
    private Vector3 randomDirection;
    private void Start()
    {
        randomDirection = ChangeRotation();
    }

    void Update()
    {
        transform.Rotate(randomDirection, RotationSpeed * Time.deltaTime);
        transform.RotateAround(target.position, Vector3.up, OrbitDegrees);
    }

    Vector3 ChangeRotation()
    {
        return new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
    }
}