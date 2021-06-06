using System;
using System.Collections.Generic;
using System.Text;

namespace EmpMgtSys.Services
{
    public class ApiServices
    {
        private static ApiServices _ServeicesClientInstance;
        public static ApiServices ServeicesClientInstance 
        {
            get 
            {
                if (_ServeicesClientInstance == null)
                    _ServeicesClientInstance = new ApiServices();
                return _ServeicesClientInstance;
            }
        }
        public ApiServices()
        {
        }
    }
}
