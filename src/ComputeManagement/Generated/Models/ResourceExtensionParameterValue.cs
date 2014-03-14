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

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Required. Specifies the key, value, and type of the parameter.
    /// </summary>
    public partial class ResourceExtensionParameterValue
    {
        private string _key;
        
        /// <summary>
        /// Key
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Optional. Public | Private. If this value is set to Private, the
        /// parameter will not be returned by Get Deployment. You can only
        /// specify one public parameter and one private parameter for a
        /// maximum of two parameters.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        private string _value;
        
        /// <summary>
        /// Value
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ResourceExtensionParameterValue
        /// class.
        /// </summary>
        public ResourceExtensionParameterValue()
        {
        }
    }
}
