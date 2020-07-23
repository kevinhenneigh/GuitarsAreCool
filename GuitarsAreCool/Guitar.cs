﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarsAreCool
{
    /// <summary>
    /// Represents a single guitar
    /// </summary>
    public class Guitar
    {
        /// <summary>
        /// Unique identifier for each individual guitar
        /// Serial Number
        /// </summary>
        public char SerialId { get; set; }

        /// <summary>
        /// The make of the guitar
        /// Example: Gibson
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// The model of the guitar
        /// Example: Les Paul Standard
        /// </summary>
        public string Style { get; set; }

        /// <summary>
        /// The guitar type 
        /// Example: Acoustic Six-String
        /// </summary>
        public string Type { get; set; }

    }
}
