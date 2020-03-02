using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capet2020.Modeles
{
    class Projet
    {
        public static ArrayList CollClassProjet = new ArrayList();
        private int idProjet;
        private string intituleProjet;
        private DateTime dateDebutPrevue;
        private DateTime dateDebutReelle;
        private DateTime dateFinPrevue;
        private DateTime dateFinReelle;
        private string etat;
        //private Responsable leResponsable;
        private ArrayList lesLots;
        //private Dictionary<DateTime, Tache> lesTachesRestantARealiser;
    }
}
