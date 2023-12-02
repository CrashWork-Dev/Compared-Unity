using Code.Client.Item;
using Code.Inner.ProcessLine;
using UnityEngine;

namespace Code.Client.Sender
{
    public class StateSender : MonoBehaviour
    {
        private Fruit _fruit;

        public void ReceiveSelf(Fruit fruitArg)
        {
            _fruit = fruitArg;
        }

        public void SendCollision(Collision2D other)
        {
            MergeProcessLine.Merge(_fruit, other);
        }
    }
}
