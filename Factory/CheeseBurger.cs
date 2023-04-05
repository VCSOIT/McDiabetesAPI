using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BurgerAPI.Models;

namespace BurgerAPI
{

    public class CheeseBurger : IBurger
    {
        
    
      
        public string getBun()
        {
            using(var _context  = new McDiabetesContext())
            {
            
              string bunValue = (from bun in _context.Burgers
                       where bun.Bun=="Wheat"
                       select bun.Bun).SingleOrDefault();
                       System.Console.WriteLine(bunValue+ "VALUE");
          

           // System.Console.WriteLine(bun);
        
            return bunValue;
            }
        }

        public string getPatty()
        {
           using(var _context  = new McDiabetesContext())
            {
             
          
             //ar  patty = _context.Burgers.Where(b=> b.Bun.Contains("Beef"));
            
            
             string pattyValue = (from patty in _context.Burgers
                       where patty.Patty=="Beef"
                       select patty.Patty).SingleOrDefault();
                       System.Console.WriteLine(pattyValue+ "VALUE");
            
            
            return pattyValue;
            }
        }

        public string getCheese()
        {
            return "cheese";
        }
    }

}