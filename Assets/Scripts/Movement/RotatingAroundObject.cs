using UnityEngine;

public class RotatingAroundObject : MonoBehaviour
{
    public Transform objectToRotateAround;
    public float speed;

    private void Update()
    {
       transform.RotateAround(objectToRotateAround.position, Vector3.forward, speed * Time.deltaTime);
    }
}
