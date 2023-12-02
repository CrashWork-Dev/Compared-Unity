using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace Code.Inner.Factory
{
    //need to be init in scene
    public class RandomIndexFactory : MonoBehaviour
    {
        public GameObject[] circle;
        
        public GameObject Init(Vector2 pos)
        {
            return CircleFactory.Init(circle[Random.Range(0, circle.Length-1)], pos);
        }
    }
}