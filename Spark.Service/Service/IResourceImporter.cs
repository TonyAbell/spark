﻿/* 
 * Copyright (c) 2014, Furore (info@furore.com) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.github.com/furore-fhir/spark/master/LICENSE
 */

using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spark.Service
{
    public interface IResourceImporter
    {
        void QueueNewResourceEntry(Uri id, Resource resource);
        void QueueNewResourceEntry(string collection, string id, Resource resource);
        void QueueNewDeletedEntry(string collection, string id);
        void QueueNewEntry(BundleEntry entry);
        IEnumerable<BundleEntry> ImportQueued();
    }
}
