/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// A collection of accounts and regions.
    /// </summary>
    public partial class AccountAggregationSource
    {
        private List<string> _accountIds = new List<string>();
        private bool? _allAwsRegions;
        private List<string> _awsRegions = new List<string>();

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The 12-digit account ID of the account being aggregated. 
        /// </para>
        /// </summary>
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && this._accountIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AllAwsRegions. 
        /// <para>
        /// If true, aggreagate existing AWS Config regions and future regions.
        /// </para>
        /// </summary>
        public bool AllAwsRegions
        {
            get { return this._allAwsRegions.GetValueOrDefault(); }
            set { this._allAwsRegions = value; }
        }

        // Check to see if AllAwsRegions property is set
        internal bool IsSetAllAwsRegions()
        {
            return this._allAwsRegions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AwsRegions. 
        /// <para>
        /// The source regions being aggregated.
        /// </para>
        /// </summary>
        public List<string> AwsRegions
        {
            get { return this._awsRegions; }
            set { this._awsRegions = value; }
        }

        // Check to see if AwsRegions property is set
        internal bool IsSetAwsRegions()
        {
            return this._awsRegions != null && this._awsRegions.Count > 0; 
        }

    }
}