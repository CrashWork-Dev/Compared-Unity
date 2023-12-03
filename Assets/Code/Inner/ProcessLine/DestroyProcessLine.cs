using UnityEngine;

namespace Code.Inner.ProcessLine
{
    public class DestroyProcessLine : MonoBehaviour
    {
        public static void Destroy(GameObject self, GameObject other)
        {
            Destroy(self);
            Destroy(other);
        }
    }
}