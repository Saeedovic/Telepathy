using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Tele
{
    public class Clientt : MonoBehaviour
    {
        private Telepathy.Client _client;
        public void Start()
        {
            _client = new(1024);
            _client.Connect("172.16.2.45", 3003);

        }

        public void Update()
        {
            _client.Tick(100);
            if (Input.GetKeyDown(KeyCode.L))
            {
                byte[] message = new byte[] { 255, 95 };
                _client.Send(new ArraySegment<byte>(message));
            }
            
            
        }
    }

}
