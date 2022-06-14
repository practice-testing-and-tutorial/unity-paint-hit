using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintHit.Core
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private MeshRenderer _meshRenderer;

        [SerializeField] private Rigidbody _rigidbody;

        [SerializeField] private Color _color;

        [SerializeField] private float _speed;

        public Color Color
        {
            get => _color;
            set
            {
                _color = value;
                _meshRenderer.material.color = _color;
            }
        }

        public float Speed => _speed;

        public void Throw()
        {
            _rigidbody.AddForce(Vector3.up * _speed, ForceMode.Impulse);
        }
    }
}
