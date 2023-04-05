using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI 
{
    public class Composite : IComponent
    {
    List<IComponent> components = new List<IComponent>();
    //List<CustomBurger> returnList = new List<CustomBurger>();

        public void addBurgerParts(IComponent component)
        {
            components.Add(component);
        }
        //    public void addBurgerParts(IComponent component, IComponent IComponent2)
        // {
        //     components.Add(component);
        // }

        //     public void addBurgerParts(IComponent component, IComponent IComponent2,
        //     IComponent IComponent3)
        // {
        //     components.Add(component);
        // }

        //     public void addBurgerParts(IComponent component, IComponent IComponent2,
        //     IComponent IComponent3, IComponent IComponent4)
        // {
        //     components.Add(component);
        // }

        //     public void addBurgerParts(IComponent component, IComponent IComponent2,
        //     IComponent IComponent3, IComponent IComponent4, IComponent IComponent5)
        // {
        //     components.Add(component);
        // }


        public void removeBurgerParts(IComponent component)
        {
            components.Remove(component);
        }

        public string getBurgerPart()
        {
            string part = null;
            
            for(int i =0; i < components.Count;i++)

            {  // returnList.Add(new CustomBurger{parts=components.ElementAt(i).getBurgerPart()});
                 part += components.ElementAt(i).getBurgerPart();
            }


            return part;


        }

        
    }
}