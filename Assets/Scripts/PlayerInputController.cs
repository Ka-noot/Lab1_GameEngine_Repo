using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    public PlayerAction inputAction;

    //singleton: creating an instance
    public static PlayerInputController controller;

    private void OnEnable()
    {
        inputAction.Enable();
    }

    private void OnDisable()
    {
        inputAction.Disable();
    }

    //start is called before the first frame update
    void Awake()
    {
        //instance
        if (controller == null)
        {
            controller = this;
        }
        inputAction = new PlayerAction();
    }

}
