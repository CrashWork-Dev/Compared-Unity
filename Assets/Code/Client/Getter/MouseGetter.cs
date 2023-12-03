using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

namespace Code.Client.Getter
{
    public class MouseGetter : MonoBehaviour
    {
        public Vector2 pos;
        private Mouse _mouse;
        private Touchscreen _touch;
        private Camera _camera;
        public bool isPressed;
        private TouchControl _touchControl;

        private void Start()
        {
            _camera = Camera.main;
        }

        private void Awake()
        {
            //_touch = Touchscreen.current;
            _mouse = Mouse.current;
        }
        //todo 触屏设备适配
        private void Update()
        {
            // if (_touch != null)
            // {
            //     _touchControl = _touch.touches[0];
            //     pos = _camera.ScreenToWorldPoint(_touchControl.position.ReadValue());
            //     isPressed = _touchControl.press.wasPressedThisFrame;
            // }
            // else
            // {
            //     pos = _camera.ScreenToWorldPoint(_mouse.position.ReadValue());
            //     isPressed = _mouse.leftButton.isPressed;
            // }
            pos = _camera.ScreenToWorldPoint(_mouse.position.ReadValue());
            isPressed = _mouse.leftButton.isPressed;
        }

        public Vector3 Get()
        {
            return pos;
        }
    }
}