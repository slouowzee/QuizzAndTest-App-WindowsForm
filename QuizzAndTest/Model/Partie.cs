using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzAndTest.Model
{
    internal class Partie
    {
        public int score;
        public int difficulte;
        public int nbQuestion;
        public List <Question> listeQuestion = new List<Question>();
        public int numBonneReponse;
        public int numQuestion;

        public Partie(List<Question> listeQuestion)
        {
            this.score = 0;
            this.difficulte = 0;
            this.numQuestion = 0;
            this.numBonneReponse = 0;
            this.nbQuestion = listeQuestion.Count();
        }
    }
}
