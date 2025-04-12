using System;

namespace pickamood.Models
{
    public class MoodData
    {
       public string Mood { get; set; }
       public string[] Citations { get; set; }   //Parce que chaque mood a 5 citations 
        public Activites[] Activities { get; set; }


        public MoodData(string mood, string[] citations, Activites[] activities)
        {
            Mood = mood;
            Citations = citations;
            Activities = activities;
        }
        /*
         Et oui, dans ce cas précis, la meilleure pratique est de mettre la méthode GetRandomCitation() dans la classe Interactions, parce qu’elle :
        Travaille directement avec les données internes (Citations),
        Rend l’objet autonome pour gérer ses propres règles de comportement,
        Suit un principe fondamental de la programmation orientée objet : "les données et le comportement qui leur est lié doivent vivre ensemble."
        Donc oui, c’est best practice car :
        La classe devient plus lisible et cohérente.
        */

        public string GetRandomCitation()
        {
            Random rand = new Random();
            int index = rand.Next(0, Citations.Length);
            return Citations[index];
        }

        //public string[] GetListeActivites()
        //{
        //    return Activities;
        //}
    }
}
