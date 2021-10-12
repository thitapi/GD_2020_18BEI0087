
using UnityEngine;

public class collision_script : MonoBehaviour
{
    void OnCollisionEnter(Collision other) {
        Debug.Log(other.collider.name);
    }
}
