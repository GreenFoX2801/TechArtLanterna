using UnityEngine;
using UnityEngine.InputSystem;

public class Lanterna : MonoBehaviour
{
    public Light lanterna;
    private bool setActive;

    private void Start()
    {
        setActive = true; // Ensure the light starts in the correct state
    }

    private void Update()
    {
        lanterna.enabled = setActive;

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            setActive = !setActive; // Toggle the state
        }
    }
}
