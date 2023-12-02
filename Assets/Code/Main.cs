using System;
using Code.Client.Getter;
using Code.Client.Item;
using Code.Inner.Factory;
using UnityEngine;

namespace Code
{
    public class Main : MonoBehaviour
    {
        private Fruit _fruit;
        private MouseGetter _mouseGetter;
        private Vector2 _pos;
        private RandomIndexFactory _randomIndexFactory;
        private Fruit _fruit1;
        private double _lastTimeStamp;
        
        private void Awake()
        {
            _mouseGetter = gameObject.AddComponent<MouseGetter>();
            _randomIndexFactory = GameObject.FindWithTag("Factory").GetComponent<RandomIndexFactory>();
        }
        private void Start()
        {
            _fruit = FruitSpawn();
            _fruit.SetSimulated(false);
            
        }
        private void Update()
        {
            _pos = _mouseGetter.Get();
            ActiveFruit(_mouseGetter.isPressed);
        }
        
        private Fruit FruitSpawn()
        {
            return _randomIndexFactory.Init(transform.position).GetComponent<Fruit>();
        }

        private void SpawnFruit()
        {
            _fruit = FruitSpawn();
            _fruit.SetSimulated(false);
        }
        private void ActiveFruit(bool isPressed)
        {
            if (!isPressed) return;
            if (new TimeSpan(DateTime.Now.Ticks).TotalMilliseconds - _lastTimeStamp < 1000)
            {
                return;
            }
            _lastTimeStamp = new TimeSpan(DateTime.Now.Ticks).TotalMilliseconds;
            _fruit.SetSimulated(true);
            Invoke(nameof(SpawnFruit),0.5f);
        }
    }
}