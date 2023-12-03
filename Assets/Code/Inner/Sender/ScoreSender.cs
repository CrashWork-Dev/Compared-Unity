using UnityEngine;

namespace Code.Inner.Sender
{
    public class ScoreSender : MonoBehaviour
    {
        private static int _score;

        public static void StoreScore(int scoreArg)
        {
            _score += scoreArg;
        }

        public static int Get()
        {
            return _score;
        }
        public static void Set(int score)
        {
            _score = score;
        }
    }
}