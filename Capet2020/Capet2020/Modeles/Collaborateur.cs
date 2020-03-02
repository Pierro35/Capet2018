using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capet2020.Modeles
{
    class Collaborateur
    {
        #region Attributs
        public static ArrayList CollClassCollaborateur = new ArrayList();

        private int _idCollaborateur;
        private int _nomCollaborateur;

        private Service _leService;
        #endregion

        #region Constructeurs
        public Collaborateur(int idCollaborateur, int nomCollaborateur, Service leService)
        {
            IdCollaborateur = idCollaborateur;
            NomCollaborateur = nomCollaborateur;
            LeService = leService;

            CollClassCollaborateur.Add(this);
        }
        #endregion

        #region Get/Set
        public int IdCollaborateur { get => _idCollaborateur; set => _idCollaborateur = value; }
        public int NomCollaborateur { get => _nomCollaborateur; set => _nomCollaborateur = value; }
        public Service LeService { get => _leService; set => _leService = value; }
        #endregion

    }
}
