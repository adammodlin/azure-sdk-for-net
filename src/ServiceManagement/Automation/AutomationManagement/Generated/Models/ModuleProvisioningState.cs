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
using System.Linq;

namespace Microsoft.WindowsAzure.Management.Automation.Models
{
    /// <summary>
    /// Provisioning state of the module operation.
    /// </summary>
    public enum ModuleProvisioningState
    {
        Created = 0,
        
        Creating = 1,
        
        StartingImportModuleRunbook = 2,
        
        RunningImportModuleRunbook = 3,
        
        ContentRetrieved = 4,
        
        ContentDownloaded = 5,
        
        ContentValidated = 6,
        
        ConnectionTypeImported = 7,
        
        ContentStored = 8,
        
        ModuleDataStored = 9,
        
        ActivitiesStored = 10,
        
        ModuleImportRunbookComplete = 11,
        
        Succeeded = 12,
        
        Failed = 13,
        
        Cancelled = 14,
    }
}
