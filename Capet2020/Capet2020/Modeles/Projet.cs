﻿using System;
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
        private Dictionary<DateTime, Tache> lesTachesRestantARealiser;
        #endregion

        #region Constructeurs
        public Projet(int idProjet, string intituleProjet, DateTime dateDebutPrevue, DateTime dateDebutReelle, DateTime dateFinPrevue, DateTime dateFinReelle, string etat, Collaborateur leResponsable)
        {
            IdProjet = idProjet;
            IntituleProjet = intituleProjet;
            DateDebutPrevue = dateDebutPrevue;
            DateDebutReelle = dateDebutReelle;
            DateFinPrevue = dateFinPrevue;
            DateFinReelle = dateFinReelle;
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
        #endregion

        #region Méthodes
        public int pourcentageAvancement()
        {
            int pourcentage;

            foreach( Lot leLot in lesLots)
            {
                foreach( Tache laTache in leLot.LesTaches
                    )

                { }
            }
            return pourcentage;
        }
        #endregion
    }
}
