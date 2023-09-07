using System.Collections.Generic;

namespace PingPongGame.Models
{
    public class PingPong
    {
        public int InputNum { get; set; }
        public List<string> OutputList {get; set;}
         

        // private static List<PingPong> _instances = new List<PingPong> {};

        public PingPong(int inputNumber)
        {
            InputNum = inputNumber;
            
            // public List<string> OutputList = new List<string> {};
            
            for (int i = 1; i <= inputNumber; i++)

            if (i % 3 == 0 && i % 5 == 0)
            {
                OutputList.Add("ping-pong");
            } else if (i % 3 == 0)
            {
                OutputList.Add("ping");
            } else if (i % 5 == 0)
            {
                OutputList.Add("pong");
            } else {
                // OutputList.Add($"{i}");
                OutputList.Add(i.ToString());
            };

          }
      }
  }