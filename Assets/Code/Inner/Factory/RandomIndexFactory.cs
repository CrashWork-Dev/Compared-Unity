using UnityEngine;
using Random = UnityEngine.Random;

namespace Code.Inner.Factory
{
    public class RandomIndexFactory : MonoBehaviour
    {
        public GameObject[] circle;

        public GameObject Init(Vector2 pos)
        {
            return CircleFactory.Init(circle[Random.Range(0, circle.Length - 1)], pos);
        }
    }
}