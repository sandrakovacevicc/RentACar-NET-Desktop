﻿using RentACar.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.SystemOperations
{
    public class SOObrisiVozilo : SystemOperationBase
    {
        public Vozilo vozilo;
        protected override void ExecuteConcreteOperation()
        {
            repository.Delete(vozilo, $"RegistracioniBroj = '{vozilo.RegistracioniBroj}'");
        }
    }
}
