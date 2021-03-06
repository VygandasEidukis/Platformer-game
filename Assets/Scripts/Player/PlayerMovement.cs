﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PhysicsObject, IPlayerMovement
{
    [Header("Movement")]
    [SerializeField] private float _horizontalAcceleration;
    [SerializeField] private float _maxHorizontalSpeed;
    [SerializeField] private float _maxVerticalSpeed;
    [SerializeField] private Rigidbody2D _rigidBody;
    [SerializeField] private float _maxFallSpeed;

    private Vector3 _velocity = Vector3.zero;

    private void Update()
    {
        SpeedLimiter();
    }

    public void HorizontalMovement(float input)
    {

        // Move the character by finding the target velocity
        Vector3 targetVelocity = new Vector2(input * _maxHorizontalSpeed, _rigidBody.velocity.y);

        // And then smoothing it out and applying it to the character
        _rigidBody.velocity = Vector3.SmoothDamp(_rigidBody.velocity, targetVelocity, ref _velocity, _horizontalAcceleration);
        
    }

    public void Jump()
    {
        if(isGrounded)
        {
            _rigidBody.velocity = new Vector2(_rigidBody.velocity.x, 0);
            _rigidBody.AddForce(new Vector2(0f, _maxVerticalSpeed));
        }
    }

    private void SpeedLimiter()
    {
        if(isGrounded)
            _rigidBody.velocity = new Vector2(_rigidBody.velocity.x, 0);

        if (_rigidBody.velocity.y < -_maxFallSpeed)
            _rigidBody.velocity = new Vector2(_rigidBody.velocity.x, -_maxFallSpeed);
    }
}
