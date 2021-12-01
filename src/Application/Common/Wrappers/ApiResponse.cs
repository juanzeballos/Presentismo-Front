﻿namespace Presentismo.Application.Common.Wrappers
{
    public class ApiResponse<T>
    {
        public string usuario { get; set; }
        public string fecha { get; set; }
        public string messageid { get; set; }
        public T data { get; set; }
        public string message { get; set; }
        public string code { get; set; }
    }
}
