using UnityEngine;

namespace Code.Inner.Factory
{
    public class CircleFactory : MonoBehaviour
    {
        public static GameObject Init(GameObject circle, Vector2 pos)
        {
            return Instantiate(circle, pos, Quaternion.identity);
        }
    }
}