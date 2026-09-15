using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class TeleportationActivator : MonoBehaviour
{
    public XRRayInteractor teleportationInteractor;
    public InputActionProperty teleportActivatorAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        teleportationInteractor.gameObject.SetActive(false);

        teleportActivatorAction.action.performed += OnTeleportActivate;
    }

    void OnTeleportActivate(InputAction.CallbackContext context)
    {
        teleportationInteractor.gameObject.SetActive(!teleportationInteractor.gameObject.activeSelf);
    }

    // Update is called once per frame
    void Update()
    {
        if (teleportActivatorAction.action.WasReleasedThisFrame())
        {
            teleportationInteractor.gameObject.SetActive(false);
        }
    }
}
