using System;
using UnityEngine;

namespace _Project.Develop.Runtime.Utils.InputManagement
{
    public interface IUIInput : IInput
    {
        InputState<Vector2> Point { get; }
        InputState<Vector2> Navigate { get; }
        InputState<float> Click { get; }
        InputState<float> RightClick { get; }
        InputState<float> MiddleClick { get; }
        InputState<Vector2> ScrollWheel { get; }
    }
}