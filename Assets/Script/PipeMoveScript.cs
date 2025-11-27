using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float deadZone=-45;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position+=Vector3.left*moveSpeed*Time.deltaTime;

        if (transform.position.x < deadZone)
            Destroy(gameObject);
    }
}
