using StarterAssets;
using UnityEngine;

public class LadderController : MonoBehaviour
{
    public Transform topExitPoint;
    private ThirdPersonController controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            controller = other.GetComponentInChildren<ThirdPersonController>();

            if (controller != null)
            {
                controller.ladderForward = transform;
                controller.ladderTopExitPoint = topExitPoint;
                controller.canClimb = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            controller = other.GetComponentInChildren<ThirdPersonController>();

            if (controller != null)
            {
                controller.canClimb = false;
                controller.StopClimbing();
            }
        }
    }
}