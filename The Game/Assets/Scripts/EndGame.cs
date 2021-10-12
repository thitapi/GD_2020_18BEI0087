
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public Rigidbody rb;
    
    void FixedUpdate() {
        if (rb.position.y < -1f)
		{
			FindObjectOfType<Game_Over>().EndGame();
		}    
    }
}
