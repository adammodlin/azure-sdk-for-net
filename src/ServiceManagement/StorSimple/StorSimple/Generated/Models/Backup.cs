// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    /// <summary>
    /// Represents BackupSetInfo object
    /// </summary>
    public partial class Backup : CisBaseObject
    {
        private BackupJobCreationType _backupJobCreationType;
        
        /// <summary>
        /// Required. Method by which backup was created
        /// </summary>
        public BackupJobCreationType BackupJobCreationType
        {
            get { return this._backupJobCreationType; }
            set { this._backupJobCreationType = value; }
        }
        
        private DateTime _createdOn;
        
        /// <summary>
        /// Required. Creation date for the backupSet
        /// </summary>
        public DateTime CreatedOn
        {
            get { return this._createdOn; }
            set { this._createdOn = value; }
        }
        
        private long _sizeInBytes;
        
        /// <summary>
        /// Required. Size of the backupset in bytes
        /// </summary>
        public long SizeInBytes
        {
            get { return this._sizeInBytes; }
            set { this._sizeInBytes = value; }
        }
        
        private IList<Snapshot> _snapshots;
        
        /// <summary>
        /// Required. List of snapshots for the backup
        /// </summary>
        public IList<Snapshot> Snapshots
        {
            get { return this._snapshots; }
            set { this._snapshots = value; }
        }
        
        private string _sSMHostName;
        
        /// <summary>
        /// Required. SSMHostName
        /// </summary>
        public string SSMHostName
        {
            get { return this._sSMHostName; }
            set { this._sSMHostName = value; }
        }
        
        private BackupType _type;
        
        /// <summary>
        /// Required. Type of backup taken
        /// </summary>
        public BackupType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Backup class.
        /// </summary>
        public Backup()
        {
            this.Snapshots = new List<Snapshot>();
        }
    }
}
