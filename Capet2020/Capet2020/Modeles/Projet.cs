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
        #region attributs
        public static ArrayList CollClassProjet = new ArrayList();

        private int _idProjet;
        private string _intituleProjet;
        private DateTime _dateDebutPrevue;
        private DateTime _dateDebutReelle;
        private DateTime _dateFinPrevue;
        private DateTime _dateFinReelle;
        private string _etat;

        private Collaborateur _leResponsable;
        private ArrayList lesLots;
        private Dictionary<Tache, DateTime> lesTachesRestantARealiser;
        #endregion

        #region Constructeurs
        public Projet(int idProjet, string intituleProjet, DateTime dateDebutPrevue, DateTime dateFinPrevue, string etat, Collaborateur leResponsable)
        {
            IdProjet = idProjet;
            IntituleProjet = intituleProjet;
            DateDebutPrevue = dateDebutPrevue;
            DateFinPrevue = dateFinPrevue;
            Etat = etat;
            LesLots = new ArrayList();
            LeResponsable = leResponsable;

            CollClassProjet.Add(this);
        }
        #endregion

        #region get/set
        public int IdProjet { get => _idProjet; set => _idProjet = value; }
        public string IntituleProjet { get => _intituleProjet; set => _intituleProjet = value; }
        public DateTime DateDebutPrevue { get => _dateDebutPrevue; set => _dateDebutPrevue = value; }
        public DateTime DateDebutReelle { get => _dateDebutReelle; set => _dateDebutReelle = value; }
        public DateTime DateFinPrevue { get => _dateFinPrevue; set => _dateFinPrevue = value; }
        public DateTime DateFinReelle { get => _dateFinReelle; set => _dateFinReelle = value; }
        public string Etat { get => _etat; set => _etat = value; }
        public ArrayList LesLots { get => lesLots; set => lesLots = value; }
        public Collaborateur LeResponsable { get => _leResponsable; set => _leResponsable = value; }
        public Dictionary<Tache, DateTime> LesTachesRestantARealiser { get => lesTachesRestantARealiser; set => lesTachesRestantARealiser = value; }
        #endregion

        #region Méthodes
        public float pourcentageAvancement()
        {
            float pourcentage;
            int compteurTerminé = 0;
            int compteur = 0;
            foreach( Lot leLot in this.lesLots)
            {
                foreach( Tache laTache in leLot.LesTaches )
                {
                    if(laTache.Etat == "terminée")
                    {
                        compteurTerminé++;
                    }
                    compteur++;
                }
            }

            pourcentage = compteurTerminé / compteur;
            return pourcentage;
        }
        #endregion
    }
}
