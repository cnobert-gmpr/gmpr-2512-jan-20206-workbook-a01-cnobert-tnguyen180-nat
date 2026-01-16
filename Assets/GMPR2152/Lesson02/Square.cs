using System;
using UnityEngine;

namespace GMPR2152.Lesson02
{
    public class Square : MonoBehaviour
    {
        private bool _xReverse, _yReverse;
        private const float _maxSpeed = 0.01f;
        private float _xSpeed, _ySpeed;
        private const float _acceleration = 0.00005f;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _xReverse = true;
            _yReverse = false;
            _xSpeed = _maxSpeed;
            _ySpeed = 0f;
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(_xSpeed, _ySpeed, 0);
            _xSpeed -= _xReverse? _acceleration : -_acceleration;
            if (Math.Abs(_xSpeed) >= _maxSpeed)
            {
                _xReverse = !_xReverse;
            }
            _ySpeed -= _yReverse? _acceleration : -_acceleration;
            if (Math.Abs(_ySpeed) >= _maxSpeed)
            {
                _yReverse = !_yReverse;
            }
        }
    }
}
