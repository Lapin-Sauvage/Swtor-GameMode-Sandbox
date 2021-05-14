using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_de_Vie
{
    class VieSystem
    {

        private float health = 100.000f;

        
        public VieSystem()
        {

            DeadSystem();

        }

        

        public void DeadSystem()
        {

            if (health == 0 || health < 0)
            {
                // affichage HTML
                // évent Respawn
            }
           
        }

        

    }
}
