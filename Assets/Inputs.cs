using JetBrains.Annotations;
using UnityEngine;

public class Inputs
{
    private static PlayerControls _actions;
    private static PlayerController _owner;


    public static void BindNewPlayer(PlayerController player)
    {
        _owner = player;
    }
    public static void Init(PlayerController player)
    {
        _actions = new PlayerControls();
        _actions.Player.Look.performed += ctx => _owner.setLook(ctx.ReadValue<Vector2>());
        _actions.Player.Movement.performed += ctx => _owner.MoveTo(ctx.ReadValue<Vector2>());
    }

}
