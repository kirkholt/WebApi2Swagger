using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2Swagger.Models
{
    /// <summary>
    /// Valideringsfejl
    /// </summary>
    public class ValidationError
    {
        /// <summary>
        /// Feltet som fejlen tilhører.
        /// Hvis felt er tomt, så generelfejl
        /// </summary>
        public string FieldName { get; set; }
        /// <summary>
        /// Fejlbeskrivelse
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}