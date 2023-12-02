using UnityEngine;
using Code.Inner.Factory;
using Code.Client.Item;

namespace Code.Inner.ProcessLine
{
    public class MergeProcessLine : MonoBehaviour
    {
        public static void Merge(Fruit self, Collision2D collision2D)
        {
            if (self.next == null) return;
            if (!Fruit.Half)
            {
                Fruit.Half = true;
            }
            else
            {
                var newPosition = (collision2D.gameObject.transform.position + self.transform.position) / 2;
                DestroyProcessLine.Destroy(self.gameObject, collision2D.gameObject);
                CircleFactory.Init(self.next, newPosition);
                Fruit.Half = false;
            }
        }
    }
}