﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEjercicio_12
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool retorno = false;
            if (c == 'S')
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
