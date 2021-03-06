using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAInputAdapter : IInput
{
    private readonly ShipMediator _shipMediator;
    private int _currentDirectionX;

    public IAInputAdapter(ShipMediator shipMediator)
    {
        _shipMediator = shipMediator;
        _currentDirectionX = 1;
    }

    public Vector2 GetDirection()
    {
        var viewportPoint = Camera.main.WorldToViewportPoint(_shipMediator.transform.position);
        if (viewportPoint.x < 0.05f || viewportPoint.x > 0.95f)
        {
            _currentDirectionX *= -1;
        }
        
        return new Vector2(_currentDirectionX, 0.0f);
    }

    public bool IsFireActionPressed()
    {
        return Random.Range(0, 100) < 20;
    }
}