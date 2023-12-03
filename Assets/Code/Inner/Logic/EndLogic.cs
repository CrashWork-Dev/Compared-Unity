using Code.Client.Item;
using Code.Client.UI.End;
using UnityEngine;

namespace Code.Inner.Logic
{
    public class EndLogic : MonoBehaviour
    {
        public static void EndGame(RedLine redLine)
        {
            if (redLine.touchSec++ == 10)
            {
                End.SetActive(true);
            }
        }
    }
}