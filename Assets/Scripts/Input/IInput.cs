using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInput
{
    public Vector2 GetDirection();

    public bool IsFireActionPressed();
}
