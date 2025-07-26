using UnityEngine;

public class MoveOnAxis : MonoBehaviour
{
    public float speed;

    void Update()
    {
        Vector3 movement = new Vector3(1f, 0f, 0f) * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
