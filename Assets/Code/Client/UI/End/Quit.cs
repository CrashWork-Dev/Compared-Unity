using UnityEngine;

namespace Code.Client.UI.End
{
    public class Quit : MonoBehaviour
    {
        private bool _isQuit;

        private void FixedUpdate()
        {
            QuitGame(_isQuit);
        }

        public static void QuitGame(bool qt)
        {
            if (qt) Application.Quit();
        }
    }
}