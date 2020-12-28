using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Models
{

    /// <summary>
    /// Represents the department
    /// </summary>
    public class Department
    {

        /// <summary>
        /// Represents unique department ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Represents the unique department name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents any extra details about the department
        /// </summary>
        public string Details { get; set; }

    }

}
