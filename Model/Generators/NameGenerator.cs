using System;
using System.Text;

namespace PlariumTestGame.Model.Entities.CoreEntities
{
    /// <summary>
    /// the generator class is used to
    /// generate the names of asteroids and planets
    /// according to satellite names and random names
    /// </summary>
    public static class NameGenerator       
    {
        /// <summary>
        /// available characters for generating the asteroid name
        /// </summary>
        private static readonly string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        /// <summary>
        /// available satellite names to generate asteroid name
        /// </summary>
        private static readonly string[] satellites = {"Moon","Phobos", "Deimos","Io", "Europa", "Ganymede", "Callisto",
                                             "Mimas", "Enceladus", "Taphia", "Dione", "Rhea", "Titan","Helen","Iapetus",
                                             "Miranda", "Ariel", "Umbriel", "Titania","Oberon","Triton", "Proteus", "Nereid",
                                              "Naiad", "Thalassa", "Despina", "Larissa", "Galatea" };

        /// <summary>
        /// method for generating a name based 
        /// on the type of object (planet \ asteroid)
        /// </summary>
        /// <param name="obj">object to generate the name</param>
        /// <returns>generated object name</returns>
        public static string GenerateName(object obj)
        {
            Random random = new Random();

             if (obj is Asteroid)
            {
                StringBuilder bld = new StringBuilder();
                for (int i = 0; i < 8; i++)
                {
                    bld.Append(chars.ToCharArray().GetValue(random.Next(0, maxValue: chars.ToCharArray().Length)));
                }
                return bld.ToString();
            }

            else if (obj is Planet)
            {
                return satellites[random.Next(satellites.Length)];
            }
            
            return "";
        }
    }
}
