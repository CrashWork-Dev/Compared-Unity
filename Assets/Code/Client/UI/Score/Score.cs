using Code.Inner.Sender;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Client.UI.Score
{
    public class Score : MonoBehaviour
    {
        private Text _scoreText;

        private void Awake()
        {
            _scoreText = GetComponent<Text>();
        }

        private void FixedUpdate()
        {
            _scoreText.text = ScoreSender.Get().ToString();
        }
    }
}