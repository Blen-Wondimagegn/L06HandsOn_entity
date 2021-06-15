namespace AliensEntityFramework.Models
{
    public class Alien {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public int Arms { get; set; }
        public int Heads { get; set; }
        public int Legs { get; set; }
   public enum Planets{
         Mercury, 
         Venus, 
         Earth, 
         Mars, 
         WhatOnceWas, 
         Jupiter, 
         Saturn, 
         Neptune, 
         Uranus,
         TheUnappreciatedPluto
     }
    }
}