﻿// Licensed under the Apache 2.0 License. See LICENSE.txt in the project root for more information.

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ElasticLinq.Request
{
    /// <summary>
    /// Allows highting of search results to be specified for one or more fields.
    /// </summary>
    public class Highlight
    {
        private readonly List<string> fields = new List<string>();

        internal void AddFields(params string[] newFields)
        {
            fields.AddRange(newFields);
        }

        public string PreTag { get; set; }
        public string PostTag { get; set; }

        public ReadOnlyCollection<string> Fields
        {
            get { return fields.AsReadOnly(); }
        }
    }
}