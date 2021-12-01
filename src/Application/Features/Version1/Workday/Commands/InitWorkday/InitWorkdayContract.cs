﻿using MediatR;
using Presentismo.Application.Common.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentismo.Application.Features.Version1.Workday.Commands.InitWorkday
{
    public abstract class InitWorkdayContract
    {
        public class InitCommand : Command, IRequest<ApiResponse<InitResponse>>
        {
            public DataInit data { get; set; }
        }

        public class DataInit
        {
            public string usuario { get; set; }
            public string hora { get; set; }
            public int idLugarTrabajo { get; set; }
            public int idTipoHora { get; set; }
        }

        public class InitResponse
        {
            public string usuario { get; set; }
            public int idRegsitro { get; set; }
            public DateTime inicio { get; set; }
            public string tipoHora { get; set; }
            public string horas { get; set; }


        }
    }
}
