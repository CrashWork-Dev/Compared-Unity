using Code.Client.Item;
using Code.Inner.Logic;
using Code.Inner.ProcessLine;
using UnityEngine;

namespace Code.Client.Sender
{
    public class StateSender : MonoBehaviour
    {
        private Fruit _fruit;
        private RedLine _redLine;

        public void ReceiveSelf(Fruit fruitArg)
        {
            _fruit = fruitArg;
        }

        public void ReceiveSelf(RedLine redLineArg)
        {
            _redLine = redLineArg;
        }

        public void SendCollision(Collision2D other)
        {
            MergeProcessLine.Merge(_fruit, other);
        }

        public void SendRedLine(RedLine redLine)
        {
            EndLogic.EndGame(redLine);
        }
    }
}