using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.User
{
    public class GlobalServiceModel
    {
        public GlobalServiceModel()
        {
            ServiceResponse = ServiceResponseEnum.Ok;
        }

        /// <summary>
        /// Type of service response
        /// </summary>
        public ServiceResponseEnum ServiceResponse { get; set; }

        /// <summary>
        /// Message for invalid behave.
        /// </summary>
        public string Message { get; set; }


        public static GlobalServiceModel Fail(string msg)
        {
            return new GlobalServiceModel { Message = msg, ServiceResponse = ServiceResponseEnum.Failed };
        }

        public static GlobalServiceModel Ok()
        {
            return new GlobalServiceModel { Message = string.Empty, ServiceResponse = ServiceResponseEnum.Ok };
        }
    }
    public class GlobalServiceModel<T>
    {
        public GlobalServiceModel()
        {
            ServiceResponse = ServiceResponseEnum.Ok;
        }
        /// <summary>
        /// Type of service response
        /// </summary>
        public ServiceResponseEnum ServiceResponse { get; set; }

        /// <summary>
        /// Message for invalid behave.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Generic response for service
        /// </summary>
        public T Response { get; set; }
    }

    public enum ServiceResponseEnum
    {
        Ok = 200,
        Failed = 400,
        Exception = 500,
        NotFound = 404,
        NotImplemented = 501
    }
}
