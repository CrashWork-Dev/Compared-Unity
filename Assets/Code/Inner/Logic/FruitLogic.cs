using System;
using Code.Client.Item;
using Code.Inner.Factory;
using UnityEngine;

namespace Code.Inner.Logic
{
    public class FruitLogic : MonoBehaviour
    {
        public RandomIndexFactory randomIndexFactory;
        public Fruit fruit;
        public double lastTimeStamp;

        private void Awake()
        {
            randomIndexFactory = GameObject.FindWithTag("Factory").GetComponent<RandomIndexFactory>();
        }

        public Fruit FruitSpawn()
        {
            return randomIndexFactory.Init(transform.position).GetComponent<Fruit>();
        }

        public void SpawnFruit()
        {
            fruit = FruitSpawn();
            fruit.SetSimulated(false);
        }

        public void ActiveFruit(bool isPressed, Vector2 pos)
        {
            if (!isPressed) return;
            if (new TimeSpan(DateTime.Now.Ticks).TotalMilliseconds - lastTimeStamp < 1000)
            {
                return;
            }

            lastTimeStamp = new TimeSpan(DateTime.Now.Ticks).TotalMilliseconds;
            var transform1 = fruit.transform;
            var posOfFruit = transform1.position;
            posOfFruit.x = pos.x;
            transform1.position = posOfFruit;
            fruit.SetSimulated(true);

            Invoke(nameof(SpawnFruit), 0.5f);
        }
    }
}