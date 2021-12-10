using System;
using System.Text;

namespace PlariumTestGame.Model.Entities.CoreEntities
{
    public class NameGenerator
    {
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private readonly string[] satellites = {"Moon","Phobos", "Deimos","Io", "Europa", "Ganymede", "Callisto",
                                             "Mimas", "Enceladus", "Taphia", "Dione", "Rhea", "Titan","Helen","Iapetus",
                                             "Miranda", "Ariel", "Umbriel", "Titania","Oberon","Triton", "Proteus", "Nereid",
                                              "Naiad", "Thalassa", "Despina", "Larissa", "Galatea" };

        public string GenerateName(object obj)
        {
            Random random = new Random();

            if (obj is Planet)
            {
                return satellites[random.Next(satellites.Length)];
            }
            else if (obj is Asteroid)
            {
                StringBuilder bld = new StringBuilder();
                for (int i = 0; i < 8; i++)
                {
                    _ = bld.Append(chars.ToCharArray().GetValue(random.Next(0, maxValue: chars.ToCharArray().Length)));
                }
                return bld.ToString();
            }
            return "";
        }
        public NameGenerator() { }
    }
}
