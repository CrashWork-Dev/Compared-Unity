using UnityEngine;
using UnityEngine.UI;

namespace Code.Client.UI.End
{
    public class End : MonoBehaviour
    {
        private static Text _endText;

        private void Awake()
        {
            _endText = GetComponent<Text>();
        }

        private void Start()
        {
            _endText.gameObject.SetActive(false);
        }

        public static void SetActive(bool trigger)
        {
            _endText.gameObject.SetActive(trigger);
        }
    }
}