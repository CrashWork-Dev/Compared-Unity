using Code.Client.Getter;
using Code.Inner.Logic;
using UnityEngine;

namespace Code
{
    public class Main : MonoBehaviour
    {
        private MouseGetter _mouseGetter;
        private Vector2 _pos;
        private double _lastTimeStamp;
        private FruitLogic _fruitLogic;

        private void Awake()
        {
            _mouseGetter = gameObject.AddComponent<MouseGetter>();
            _fruitLogic = GameObject.FindWithTag("Logic").GetComponent<FruitLogic>();
        }

        private void Start()
        {
            _fruitLogic.fruit = _fruitLogic.FruitSpawn();
            _fruitLogic.fruit.SetSimulated(false);
        }

        private void Update()
        {
            _pos = _mouseGetter.Get();
            _fruitLogic.ActiveFruit(_mouseGetter.isPressed, _pos);
        }
    }
}