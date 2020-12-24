using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractableExample : XRGrabInteractable
{
    // Variables

    protected override void Awake()
    {
        base.Awake();
    }

    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        base.ProcessInteractable(updatePhase);

        // If the object is held

        // During Update
    }

    private void UpdateMesh()
    {
        // We need to make sure we are using an action-based controller

        // Now that we know we have the right controller, get the value of the activate (trigger-pull)

        // Apply that value to the object
    }

    private bool IsControllerActionBased(out ActionBasedController controller)
    {
        controller = null;

        // Needs to at least by a Base Controller Interactor

        // Make sure that Controller is Action-Based

        // Return a bool so we don't need this null-check else where
        return false;
    }

    private float GetActionValue(InputActionProperty inputAction)
    {
        // Read the float value, this can be a more advanced function with generics
        return 0.0f;
    }

    private void ApplyGradient(float value)
    {

    }

    private void ApplyScale(float value)
    {

    }
}
