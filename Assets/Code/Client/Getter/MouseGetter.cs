using UnityEngine;
using UnityEngine.InputSystem;

namespace Code.Client.Getter
{
    public class MouseGetter : MonoBehaviour
    {
        public Vector2 pos;
        private Mouse _mouse;
        private Camera _camera;
        public bool isPressed;
        private void Start()
        {
            _camera = Camera.main;
        }

        private void Awake()
        {
            _mouse=Mouse.current;
        }

        private void Update()
        {
            pos = _camera.ScreenToWorldPoint(_mouse.position.ReadValue());
            isPressed = _mouse.leftButton.isPressed;
        }

        public Vector3 Get()
        {
            return pos;
        }
    }
}