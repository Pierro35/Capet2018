using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capet2020.Modeles
{
    class Lot
    {
        #region Atribut
        public static ArrayList CollClassLot = new ArrayList();
        private ArrayList lesTaches;

        private int _idLot;
        private DateTime _dateDebutPrevue;
        private DateTime _dateDebutReele;
        private DateTime _dateFinPrevue;
        private DateTime _dateFinReelle;
        private string _etat;

        private Projet leProjet;
        #endregion

        #region Getter / Setter
        public int IdLot { get => _idLot; set => _idLot = value; }
        public DateTime DateDebutPrevue { get => _dateDebutPrevue; set => _dateDebutPrevue = value; }
        public DateTime DateDebutReele { get => _dateDebutReele; set => _dateDebutReele = value; }
        public DateTime DateFinPrevue { get => _dateFinPrevue; set => _dateFinPrevue = value; }
        public DateTime DateFinReelle { get => _dateFinReelle; set => _dateFinReelle = value; }
        public string Etat { get => _etat; set => _etat = value; }
        internal Projet LeProjet { get => leProjet; set => leProjet = value; }
        public ArrayList LesTaches { get => lesTaches; set => lesTaches = value; }
        #endregion

        #region Constructeur
        public Lot(int idLot, DateTime dateDebutPrevue, DateTime dateDebutReele, DateTime dateFinPrevue, DateTime dateFinReelle, string etat, Projet leProjet, ArrayList lesTaches)
        {
            IdLot = idLot;
            DateDebutPrevue = dateDebutPrevue;
            DateDebutReele = dateDebutReele;
            DateFinPrevue = dateFinPrevue;
            DateFinReelle = dateFinReelle;
            Etat = etat;
            this.LeProjet = leProjet;
            this.LesTaches = new ArrayList();
            this.LesTaches = lesTaches;
        }

        #endregion

        #region Methode
        public void donneNbTachesTerminees()
        {
            foreach (var item in collection)
            {

            }
        }

        #endregion



    }
}
