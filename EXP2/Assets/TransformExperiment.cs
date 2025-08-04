using UnityEngine;

public class TransformExperiment : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()

    {

        // Initial position, rotation, and scale of the cube

        Vector3 initialPosition = new Vector3(0f, 1f, 0f);

        Quaternion initialRotation = Quaternion.identity;

        Vector3 initialScale = new Vector3(1f, 1f, 1f);

        Debug.Log("Initial Position: " + initialPosition);
        Debug.Log("Initial Rotation: " + initialRotation);
        Debug.Log("Initial Scale: " + initialScale);

        // Apply the initial transformations to the cube

        transform.position = initialPosition;

        transform.rotation = initialRotation;

        transform.localScale = initialScale;

        // Perform linear transformations

        PerformLinearTransformations();

    }

    void PerformLinearTransformations()

    {

        // Translate the cube along the x-axis

        transform.Translate(Vector3.right * 2f, Space.World);
        transform.Rotate(Vector3.up, 45f, Space.World);
        transform.localScale = new Vector3(2f, 2f, 2f);


        Debug.Log("After Transformation: ");
        Debug.Log("position: " + transform.position);
        Debug.Log("rotation: " + transform.rotation);
        Debug.Log("scale: " + transform.localScale);

    }

}
