using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        private brake Braketype;
        private Engine PowerEngine;
        private MediaPlayer mediaplayer;

       public  Car() 
        { 
        this.Braketype = new Brakes();
        this.PowerEngine = new Engines();
        this.mediaplayer = new CDPlayer();
        }
        public void Start()
        {
            this.PowerEngine.Start();
        }
        public void Stop()
        { 
            this.PowerEngine.Stop();
        }
        public void StartMusic() { 
        this.mediaplayer.Start();
        }
        public void StopMusic()
        {
            this.mediaplayer.Stop();
        }
        public void BrakingSystem() 
        { 
            this.Braketype.BrakingSystem();
        
        }

    }
}
