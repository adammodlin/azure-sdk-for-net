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
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network.Models
{
    /// <summary>
    /// Response for PutSubnet Api service call
    /// </summary>
    public partial class SubnetPutResponse : UpdateOperationResponse
    {
        private Subnet _subnet;
        
        /// <summary>
        /// Optional. Gets the subnet in a virtual network
        /// </summary>
        public Subnet Subnet
        {
            get { return this._subnet; }
            set { this._subnet = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SubnetPutResponse class.
        /// </summary>
        public SubnetPutResponse()
        {
        }
    }
}