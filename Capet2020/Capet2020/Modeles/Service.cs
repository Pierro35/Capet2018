using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capet2020.Modeles
{
    class Service
    {
        #region Attributs
        public static ArrayList CollClassService = new ArrayList();

        private int _idService;
        private string _nomService;

        private Collaborateur _leResponsable;
        #endregion

        #region Constructeurs
        public Service(int idService, string nomService, Collaborateur leResponsable)
        {
            IdService = idService;
            NomService = nomService;
            LeResponsable = leResponsable;

            CollClassService.Add(this);
        }
        #endregion

        #region Get/Set
        public int IdService { get => _idService; set => _idService = value; }
        public string NomService { get => _nomService; set => _nomService = value; }
        public Collaborateur LeResponsable { get => _leResponsable; set => _leResponsable = value; }
        #endregion
    }
}
