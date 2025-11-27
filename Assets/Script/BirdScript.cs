using UnityEngine;


public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidboyd;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    void Start()
    {
        
    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& birdIsAlive)
        {
            myRigidboyd.linearVelocity = Vector2.up * flapStrength;
        }

        if(transform.position.y<-12 || transform.position.x<-19.50)
        {
            logic.gameOver();
            birdIsAlive = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdIsAlive) 
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }

}
