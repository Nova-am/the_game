using UnityEngine;
using UnityEngine.InputSystem;

public class Body : MonoBehaviour{

    private Rigidbody2D body;

    private void Awake(){
        body = GetComponent<Rigidbody2D>();

    } 

    private void FixedUpdate(){
        bool up = Keyboard.current.upArrowKey.isPressed;
        bool left = Keyboard.current.leftArrowKey.isPressed;
        bool right = Keyboard.current.rightArrowKey.isPressed;
        if (Keyboard.current.upArrowKey.isPressed){
            body.AddForce(new Vector2(0, 1));
        }
        if (left){
            body.AddForce(new Vector2(-1, 0));
        }
        if (right){
            body.AddForce(new Vector2(1, 0));
        }
    }
}