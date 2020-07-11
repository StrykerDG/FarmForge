using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmForge.Api.Confguration
{
    public class ApiSettings
    {
        /// <summary>
        /// Major version of the api
        /// </summary>
        public int MajorVersion { get; set; }

        /// <summary>
        /// Minor version of the api
        /// </summary>
        public int MinorVersion { get; set; }

        /// <summary>
        /// Collection of Swagger-related document settings
        /// </summary>
        public SwaggerSettings SwaggerSettings { get; set; }

        /// <summary>
        /// Dictionary of strings used for making external connections
        /// </summary>
        public Dictionary<string, string> ConnectionStrings { get; set; }
    }
}
