using Code.Client.Sender;
using UnityEngine;

namespace Code.Client.Item
{
    public class RedLine : MonoBehaviour
    {
        private StateSender _stateSender;
        public int touchSec;

        private void Awake()
        {
            _stateSender = GameObject.FindWithTag("Sender").GetComponent<StateSender>();
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            _stateSender.SendRedLine(this);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            touchSec = 0;
        }
    }
}