using System;
using UnityEngine;

namespace _Project.Develop.Runtime.Utils.InputManagement
{
    public interface IPlayerInput : IInput
    {
        InputState<Vector2> Move { get; }
        InputState<Vector2> Look { get; }
        InputState<float> Attack { get; }
        InputState<float> Jump { get; }
        InputState<float> Sprint { get; }
        InputState<float> Interact { get; }
        InputState<float> Crouch { get; }
        InputState<float> Previous { get; }
        InputState<float> Next { get; }
    }
}