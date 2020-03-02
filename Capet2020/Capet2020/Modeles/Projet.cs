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

        private Responsable leResponsable;
        private ArrayList lesLots;
        private Dictionary<DateTime, Tache> lesTachesRestantARealiser;
        #endregion

        #region Constructeurs
        public Projet(int idProjet, string intituleProjet, DateTime dateDebutPrevue, DateTime dateDebutReelle, DateTime dateFinPrevue, DateTime dateFinReelle, string etat, Responsable leResponsable)
        {
            _idProjet = idProjet;
            _intituleProjet = intituleProjet;
            _dateDebutPrevue = dateDebutPrevue;
            _dateDebutReelle = dateDebutReelle;
            _dateFinPrevue = dateFinPrevue;
            _dateFinReelle = dateFinReelle;
            _etat = etat;
            lesLots = new ArrayList();
            leResponsable = leResponsable;

            CollClassProjet.Add(this);
        }
        #endregion

    }
}
