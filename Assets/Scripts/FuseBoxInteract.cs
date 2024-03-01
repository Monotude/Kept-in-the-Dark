using UnityEngine;

public class FuseBoxInteract : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject fuse;
    [SerializeField] private int fuseBoxNumber;

    public void Interact()
    {
        if (ObjectiveManager.Instance.Objective.PowerFuseBox(fuseBoxNumber))
        {
            fuse.SetActive(true);
        }
    }
}
