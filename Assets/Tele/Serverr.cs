using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Tele
{

    public class Serverr : MonoBehaviour
    {
        private Telepathy.Server server;
        // Start is called before the first frame update
        void Start()
        {
            server = new (1024);

            server.Start(3003);
            
            server.OnData += OnDataRecieved;
            server.OnConnected += (i) => { Debug.Log(i); };
        }

        void OnDataRecieved(int id, ArraySegment<byte> data)
        {
            Debug.Log(id);
        }

        // Update is called once per frame
        void Update()
        {
            server.Tick(100);

        }
    }
}
