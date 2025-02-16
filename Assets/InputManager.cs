using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    public UnityEvent OnSpacePressed = new UnityEvent();

    private void Update()
    {
        // Check if the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke();
        }

        // Initialize input vector
        Vector2 input = Vector2.zero;

        // Check if the A key is pressed
        if (Input.GetKey(KeyCode.A))
        {
            input += Vector2.left;
        }

        // Check if the D key is pressed
        if (Input.GetKey(KeyCode.D))
        {
            input += Vector2.right;
        }

        // Invoke the OnMove event with the input vector
        OnMove?.Invoke(input);
    }
}