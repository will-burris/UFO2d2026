using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed = 270.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0.0f, 0.0f, speed) * Time.deltaTime);
    }
}

//End of MonobehaviorScript.Spin.cs