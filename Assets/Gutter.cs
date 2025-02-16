using UnityEngine;

public class Gutter : MonoBehaviour
{
    private void OnTriggerEnter(Collider triggeredBody)
    {
        // Get the Rigidbody component from the triggered object
        Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();
        
        // Store the magnitude of the current velocity
        float velocityMagnitude = ballRigidBody.velocity.magnitude;
        
        // Stop the ball's current movement
        ballRigidBody.velocity = Vector3.zero;
        ballRigidBody.angularVelocity = Vector3.zero;
        
        // Apply force to the ball in the forward direction with the stored velocity magnitude
        ballRigidBody.AddForce(transform.forward * velocityMagnitude, ForceMode.VelocityChange);
    }
}