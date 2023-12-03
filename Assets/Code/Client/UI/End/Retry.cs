using Code.Inner.Sender;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Client.UI.End
{
    public class Retry : MonoBehaviour
    {
        private bool _isRetry;

        private void FixedUpdate()
        {
            RetryGame(_isRetry);
        }

        public static void RetryGame(bool retry)
        {
            if (!retry) return;
            ScoreSender.Set(0);
            SceneManager.LoadScene("Gaming");
        }
    }
}