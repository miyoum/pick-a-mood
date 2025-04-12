using Microsoft.AspNetCore.Http.HttpResults;
using pickamood.Models;

namespace pickamood.Services
{
    public class MoodManager
    {
        private MoodData[] moods;

        public MoodManager() 
        {
            moods = new MoodData[]
            {
                new MoodData(
                    "Happy",
                    new string[] {"Oh, trop contente de l'apprendre ! Profite de cette belle énergie !",
                    "Génial ! Rien de mieux que de se sentir bien. J’espère que tu vas vivre des moments top aujourd’hui !",
                    "C’est super ça ! Garde ce sourire, il illumine tout autour de toi !","Trop bien ! Quand ça va bien, on en profite à fond, hein ?",
                    "Trop chouette ! Ça se sent que la journée commence sous de bons auspices !"},
                    new Activites[]
                    {
                        new Activites("Prendre un moment pour exprimer ta gratitude", "Écris trois choses pour lesquelles tu es reconnaissante aujourd'hui."),
                        new Activites("Faire quelque chose de créatif", "Peins, écris, ou prends des photos. Laisse ton humeur joyeuse se refléter dans ton art."),
                        new Activites("Partage un moment avec quelqu’un que tu apprécies", "Passe du temps avec tes proches ou amis pour célébrer ta bonne humeur."),
                        new Activites("Fais une activité physique", "Allez courir ou faire du yoga pour canaliser ton énergie positive."),
                        new Activites("Préparer un repas spécial", "Cuisiner un plat que tu aimes peut être une belle façon de profiter de l’instant."),
                    }
                    ),
                new MoodData(
                    "Angry",
                    new string[] {"Oof, tu es en colère... C’est pas facile, mais prends un moment pour respirer, ça va aller.",
                    "Je te sens frustrée... Essaie de prendre une pause, ça pourrait apaiser un peu cette tension.",
                    "Ça doit vraiment t’agacer. Mais tu sais, parfois une petite pause peut tout changer.",
                    "Courage, ça passe toujours. Rappelle-toi que tu as le contrôle sur ta paix intérieure.",
                    "Pas facile, je comprends. Si tu veux en parler, je suis là pour écouter.",},
                    new Activites[]
                    {
                        new Activites("Prendre une pause et respirer profondément","Inspire lentement pendant cinq secondes, retiens ton souffle, puis expire lentement. Répète jusqu’à ce que tu te sentes plus calme."),
                        new Activites("Écrire un journal","Écris ce qui te rend en colère. Cela t’aidera à libérer les émotions négatives."),
                        new Activites("Faire de l’exercice physique intense"," Cours, frappe dans un sac de frappe, ou fais de la musculation pour relâcher la tension accumulée."),
                        new Activites("Écouter de la musique apaisante "," Choisis des morceaux qui t’aident à te détendre et à apaiser ta colère."),
                        new Activites("Parler à un ami ou à un proche "," Exprimer ce que tu ressens à une personne de confiance peut t’aider à alléger ton esprit."),
                    }
                    ),
                new MoodData(
                    "Tired",
                    new string[] {"Tu es épuisée ? Repose-toi, ton corps en a besoin. Un peu de repos fait des merveilles.",
                    "La fatigue, ça nous arrive à tous... Laisse-toi un moment de répit pour recharger tes batteries.",
                    "Tu as donné beaucoup aujourd’hui, c’est normal de se sentir fatigué. Un petit break te fera du bien.",
                    "On a tous besoin de souffler parfois. Prends le temps de te reposer, tu reviendras encore plus forte !",
                    "Écoute ton corps. Un peu de repos maintenant, et tu seras prête pour attaquer de plus belle !",
                    },
                    new Activites[]
                    {
                        new Activites("Faire une sieste réparatrice "," Un petit somme de 20-30 minutes peut te redonner de l’énergie."),
                        new Activites("Étirements doux ou yoga ","Un enchaînement de mouvements doux pour détendre tes muscles et ton corps."),
                        new Activites("Prendre un bain relaxant "," Fais couler de l’eau chaude, et ajoute des huiles essentielles pour te détendre."),
                        new Activites("Lire un livre léger "," Choisis une lecture agréable et sans effort pour te détendre et t'évader."),
                        new Activites("Écouter un podcast ou de la musique relaxante "," Laisse-toi emporter par des sons apaisants pour te reposer mentalement."),
                    }
                    ),
                new MoodData(
                    "Sad",
                    new string[] {"Désolée que tu te sentes comme ça... Prends ton temps, ça ira mieux bientôt.",
                    "C’est pas facile... mais chaque jour est une nouvelle chance. Sois douce avec toi-même.",
                    "Je sais que ça peut être dur parfois. Mais même les journées tristes finissent par s’éclaircir.",
                    "Tu n'es pas seule dans ce moment. Si tu as besoin de parler ou juste de te changer les idées, je suis là.",
                    "Parfois, la tristesse a besoin de temps, mais elle finit par passer. Sois patiente avec toi-même.",
                    },
                    new Activites[]
                    {
                        new Activites("Faire une promenade en plein air "," La nature a un effet apaisant et peut aider à changer d’état d’esprit."),
                        new Activites("Écrire une lettre (même si tu ne l'envoies pas) "," Exprime tes émotions et prends du recul par rapport à ta tristesse."),
                        new Activites("Regarder un film réconfortant "," Choisis un film ou une série qui te fait sourire ou te réchauffe le cœur."),
                        new Activites("Pratiquer la méditation "," Quelques minutes de méditation peuvent t’aider à te recentrer et à calmer ton esprit."),
                        new Activites("Faire une activité manuelle "," Cuisiner, dessiner ou bricoler. Ces tâches peuvent t’apporter une sensation de calme et de satisfaction."),
                    }
                    ),
                new MoodData(
                    "Disgusted",
                    new string[] {"Ah, je sens que ça te dégoûte... Essaie de ne pas laisser ça gâcher ton humeur.",
                    "C’est pas agréable, mais tu sais, ça passe. Laisse aller ce qui te dégoûte, il y a mieux à vivre !",
                    "C’est pas cool, mais laisse ça derrière toi. Ce qui te dégoûte n'a pas de place dans ton esprit.",
                    "C’est pas facile de se débarrasser de ça, mais parfois il vaut mieux tourner la page et aller de l’avant.",
                    "Je comprends, ça peut vraiment déranger. Mais garde à l’esprit que tu as le pouvoir de laisser ça derrière toi.",},
                    new Activites[]
                    {
                        new Activites("Changer de perspective "," Prends un moment pour réfléchir à la situation et essayer de voir les choses sous un angle plus positif."),
                        new Activites("Faire un nettoyage rapide de ton espace "," Parfois, ranger ou organiser un peu peut apporter un sentiment de contrôle et de satisfaction."),
                        new Activites("Exprimer tes sentiments (via l'écriture ou la parole) "," Libère-toi de cette émotion en en parlant ou en écrivant ce que tu ressens."),
                        new Activites("Faire une activité relaxante "," Méditation, respiration profonde ou relaxation musculaire progressive pour réduire le stress et le dégoût."),
                        new Activites("Regarder une vidéo humoristique "," Regarder des vidéos qui te font rire peut alléger ton humeur et éloigner le dégoût."),
                    }
                    ),
            };


        }
        public string GetRandomCitation(string mood)
        {
            //Equals(mood, StringComparison.OrdinalIgnoreCase) comparaison quelconque, sans prendre en considération la casse
            var moodItem = moods.FirstOrDefault(m => m.Mood.Equals(mood, StringComparison.OrdinalIgnoreCase));
            if (moodItem == null || moodItem.Citations.Length == 0)
                return null;
            Random rand = new Random();
            int index = rand.Next(0, moodItem.Citations.Length);
            return moodItem.Citations[index];
        }

        public Activites?[] GetListeActivites(string mood)
        {
            var moodItem = moods.FirstOrDefault(m => m.Mood.Equals(mood, StringComparison.OrdinalIgnoreCase));
            if (moodItem == null || moodItem.Activities.Length == 0)
                return null;
            return moodItem?.Activities;
        }
    }
}
