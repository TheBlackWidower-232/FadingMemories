using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskInteractGameObject : MonoBehaviour, IInteractable
{
    public GameObject player;

    public void Interact(GameObject param)
    {
        TaskManager taskM = player.GetComponent<TaskManager>();
        taskM.GlobalTaskInteract(this.gameObject);
    }
}
