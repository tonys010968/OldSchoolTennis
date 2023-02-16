using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;


    private void FixedUpdate()
    {
        //Computer paddle tracks the position of the ball.
        //If the ball is above the paddle, move up.  If below, move down.

        //If the ball is moving toward the paddle...
        if (this.ball.velocity.x > 0.0f)
        {
            if (this.ball.position.y > this.transform.position.y)
            {
                _rigidBody.AddForce(Vector2.up * this.speed);
            } else if (this.ball.position.y < this.transform.position.y)
            {
                _rigidBody.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            //If the ball is moving away from the paddle...
            if (this.transform.position.y > 0.0f)
            {
                _rigidBody.AddForce(Vector2.down * this.speed);
            } else if (this.transform.position.y < 0.0f)
            {
                _rigidBody.AddForce(Vector2.up * this.speed);
            }
        }
    }

}
