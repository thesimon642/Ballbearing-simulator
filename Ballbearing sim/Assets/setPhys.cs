using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setPhys : MonoBehaviour
{
    [SerializeField]
    private Transform ball;
    [SerializeField]
    private Rigidbody2D ballbody;
    [SerializeField]
    private SpriteRenderer colourRend;

    private void Awake()
    {
        ball.localScale = new Vector2(GameController.size,GameController.size);
        ballbody.drag = GameController.count;
        ball.position = new Vector3(ball.position.x,ball.position.y,0);
        ballbody.velocity = new Vector2(0,0.1f*GameController.subCount);
        ball.localScale = new Vector2(GameController.size,GameController.size);

        switch (GameController.ballcolour)
        {
            case 0:
                break;

            case 1:
                colourRend.color = Color.red;
                break;

            case 2:
                colourRend.color = Color.blue;
                break;

            case 3:
                colourRend.color = Color.green;
                break;

            case 4:
                colourRend.color = new Color(GameController.myRandom[0], GameController.myRandom[1], GameController.myRandom[2]);
                break;
        }
    }
    private void Update()
    {
        if (ball.position.y < -10)
        {
            Destroy(this.gameObject);
        }
    }
}
