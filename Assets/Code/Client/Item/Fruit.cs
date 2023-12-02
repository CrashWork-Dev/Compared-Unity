using System;
using UnityEngine;
using Code.Client.Sender;
namespace Code.Client.Item
{
    public class Fruit : MonoBehaviour
    {
        public static bool IsTouchedRedLine = false;
        public static bool Half = false;
        [SerializeField] private GameObject self;
        [SerializeField] public GameObject next;
        private Rigidbody2D _rb;
        private StateSender _stateSender;
        private void Awake()
        {
            _stateSender = GameObject.FindWithTag("Sender").GetComponent<StateSender>();
            _rb = GetComponent<Rigidbody2D>();
        }
        
        public void SetSimulated(bool flag)
        {
            _rb.simulated = flag;
        }
        
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.name != gameObject.name) return;
            _stateSender.ReceiveSelf(this);
            _stateSender.SendCollision(other);
        }
    }
}