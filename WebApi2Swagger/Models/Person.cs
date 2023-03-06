namespace WebApi2Swagger.Models
{
    /// <summary>
    /// Menneske
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Unikt Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Fulde navn
        /// </summary>
        public string Navn { get; set; }

        /// <summary>
        /// Han eller hunkøn
        /// </summary>
        public Koen Koen { get; set; }


    }
}