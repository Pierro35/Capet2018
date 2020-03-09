using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capet2020.Modeles
{
    class Tache
    {
        #region Attribut 
        public static ArrayList CollClassTache = new ArrayList();
        private ArrayList lesCollaborateurs;

        private int _idTache;
        private string _intituleTache;
        private DateTime _dateDebutPrevue;
        private DateTime _dateDebitRelle;
        private int _dureePrevue;
        private int _dureeRelle;
        private string _etat;
        #endregion

        #region Constructeur
        public Tache(int idTache, string intituleTache, DateTime dateDebutPrevue, int dureePrevue, string etat)
        {
            IdTache = idTache;
            IntituleTache = intituleTache;
            DateDebutPrevue = dateDebutPrevue;
            DureePrevue = dureePrevue;
            Etat = etat;
            this.lesCollaborateurs = new ArrayList();
        }
        #endregion

        #region Getter / Setter 
        public int IdTache { get => _idTache; set => _idTache = value; }
        public string IntituleTache { get => _intituleTache; set => _intituleTache = value; }
        public DateTime DateDebutPrevue { get => _dateDebutPrevue; set => _dateDebutPrevue = value; }
        public DateTime DateDebitRelle { get => _dateDebitRelle; set => _dateDebitRelle = value; }
        public int DureePrevue { get => _dureePrevue; set => _dureePrevue = value; }
        public int DureeRelle { get => _dureeRelle; set => _dureeRelle = value; }
        public string Etat { get => _etat; set => _etat = value; }
        #endregion

        #region Méthodes
        public void ajouterDateDebutRelle(DateTime dateDebutRelle)
        {
            this.DateDebutPrevue = dateDebutRelle;
        }

        public void ajouterDureeRelle(int dureeRelle)
        {
            this.DureeRelle = dureeRelle;
        }
        #endregion
    }
}
