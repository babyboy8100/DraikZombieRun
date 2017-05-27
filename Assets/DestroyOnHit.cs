using UnityEngine;

public class DestroyOnHit : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
