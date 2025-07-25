using UnityEngine;

public class MoveOnXAxis : MonoBehaviour
{
    public float speed; // Movement speed

    void Update()
    {
        // Create movement vector on X axis only
        Vector3 movement = new Vector3(0f, 0f, 1f) * speed * Time.deltaTime;

        // Apply movement
        transform.Translate(movement);
    }
}
