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

        private int _idLot;
        private DateTime _dateDebutPrevue;
        private DateTime _dateDebutReele;
        private DateTime _dateFinPrevue;
        private DateTime _dateFinReelle;
        private string _etat;

        private ArrayList lesTaches;
        private Projet leProjet;
        #endregion




    }
}
