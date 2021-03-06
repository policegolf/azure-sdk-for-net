// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The policy used for monitoring the application upgrade
    /// </summary>
    public partial class RollingUpgradeMonitoringPolicy
    {
        /// <summary>
        /// Initializes a new instance of the RollingUpgradeMonitoringPolicy
        /// class.
        /// </summary>
        public RollingUpgradeMonitoringPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RollingUpgradeMonitoringPolicy
        /// class.
        /// </summary>
        /// <param name="healthCheckWaitDuration">The amount of time to wait
        /// after completing an upgrade domain before applying health policies.
        /// It is first interpreted as a string representing an ISO 8601
        /// duration. If that fails, then it is interpreted as a number
        /// representing the total number of milliseconds.</param>
        /// <param name="healthCheckStableDuration">The amount of time that the
        /// application or cluster must remain healthy before the upgrade
        /// proceeds to the next upgrade domain. It is first interpreted as a
        /// string representing an ISO 8601 duration. If that fails, then it is
        /// interpreted as a number representing the total number of
        /// milliseconds.</param>
        /// <param name="healthCheckRetryTimeout">The amount of time to retry
        /// health evaluation when the application or cluster is unhealthy
        /// before FailureAction is executed. It is first interpreted as a
        /// string representing an ISO 8601 duration. If that fails, then it is
        /// interpreted as a number representing the total number of
        /// milliseconds.</param>
        /// <param name="upgradeTimeout">The amount of time the overall upgrade
        /// has to complete before FailureAction is executed. It is first
        /// interpreted as a string representing an ISO 8601 duration. If that
        /// fails, then it is interpreted as a number representing the total
        /// number of milliseconds.</param>
        /// <param name="upgradeDomainTimeout">The amount of time each upgrade
        /// domain has to complete before FailureAction is executed. It is
        /// first interpreted as a string representing an ISO 8601 duration. If
        /// that fails, then it is interpreted as a number representing the
        /// total number of milliseconds.</param>
        public RollingUpgradeMonitoringPolicy(string healthCheckWaitDuration = default(string), string healthCheckStableDuration = default(string), string healthCheckRetryTimeout = default(string), string upgradeTimeout = default(string), string upgradeDomainTimeout = default(string))
        {
            HealthCheckWaitDuration = healthCheckWaitDuration;
            HealthCheckStableDuration = healthCheckStableDuration;
            HealthCheckRetryTimeout = healthCheckRetryTimeout;
            UpgradeTimeout = upgradeTimeout;
            UpgradeDomainTimeout = upgradeDomainTimeout;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the amount of time to wait after completing an upgrade
        /// domain before applying health policies. It is first interpreted as
        /// a string representing an ISO 8601 duration. If that fails, then it
        /// is interpreted as a number representing the total number of
        /// milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "healthCheckWaitDuration")]
        public string HealthCheckWaitDuration { get; set; }

        /// <summary>
        /// Gets or sets the amount of time that the application or cluster
        /// must remain healthy before the upgrade proceeds to the next upgrade
        /// domain. It is first interpreted as a string representing an ISO
        /// 8601 duration. If that fails, then it is interpreted as a number
        /// representing the total number of milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "healthCheckStableDuration")]
        public string HealthCheckStableDuration { get; set; }

        /// <summary>
        /// Gets or sets the amount of time to retry health evaluation when the
        /// application or cluster is unhealthy before FailureAction is
        /// executed. It is first interpreted as a string representing an ISO
        /// 8601 duration. If that fails, then it is interpreted as a number
        /// representing the total number of milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "healthCheckRetryTimeout")]
        public string HealthCheckRetryTimeout { get; set; }

        /// <summary>
        /// Gets or sets the amount of time the overall upgrade has to complete
        /// before FailureAction is executed. It is first interpreted as a
        /// string representing an ISO 8601 duration. If that fails, then it is
        /// interpreted as a number representing the total number of
        /// milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "upgradeTimeout")]
        public string UpgradeTimeout { get; set; }

        /// <summary>
        /// Gets or sets the amount of time each upgrade domain has to complete
        /// before FailureAction is executed. It is first interpreted as a
        /// string representing an ISO 8601 duration. If that fails, then it is
        /// interpreted as a number representing the total number of
        /// milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "upgradeDomainTimeout")]
        public string UpgradeDomainTimeout { get; set; }

    }
}
