using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prova.Model;

namespace Prova.Repository
{
    class BaseRepository
    {
        private BancodeDadosEntities _DataModel;
        public BancodeDadosEntities DataModel
        {
            get
            {
                if (_DataModel == null)
                {
                    _DataModel = new BancodeDadosEntities();
                }
                return _DataModel;
            }
        }
    }
}
