using System;
using System.Collections.Generic;

namespace DemoCode
{
    public class PlayerCharacter
    {
        public PlayerCharacter()
        {
            Name = GenerateName();
            IsNoob = true;
            CreateStartingWeapon();
        }

        private void CreateStartingWeapon()
        {
            // todo 
        }

        public int Health { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public bool IsNoob { get; set; }
        public List<string> Weapons { get; set; }


        private string GenerateName()
        {
            var names = new[]
            {
                "Danieth",
                "Derick",
                "Shalnorr",
                "G'Toth'lop",
                "Boldrakteethtop"
            };

            return names[new Random().Next(0, names.Length)];
        }
    }
}
