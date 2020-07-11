using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmForge.Api.Confguration
{
    public class SwaggerSettings
    {
        /// <summary>
        /// The title of the project, displayed on the swagger page
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The description of the project, displayed on the swagger page
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The Terms of service for the project, displayed on the swagger page
        /// </summary>
        public string TermsOfService { get; set; }

        /// <summary>
        /// The point of contact's name, displayed on the swagger page
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// The point of contact's email, displayed on the swagger page
        /// </summary>
        public string ContactEmail { get; set; }

        /// <summary>
        /// The point of contact's website, displayed on the swagger page
        /// </summary>
        public string ContactURL { get; set; }

        /// <summary>
        /// The project's license, displayed on the swagger page
        /// </summary>
        public string LicenseName { get; set; }

        /// <summary>
        /// The project's license url, displayed on the swagger page
        /// </summary>
        public string LicenseURL { get; set; }
    }
}
