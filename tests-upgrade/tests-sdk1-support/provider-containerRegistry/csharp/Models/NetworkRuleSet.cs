// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using System.Linq;

    /// <summary>
    /// The network rule set for a container registry.
    /// </summary>
    public partial class NetworkRuleSet
    {
        /// <summary>
        /// Initializes a new instance of the NetworkRuleSet class.
        /// </summary>
        public NetworkRuleSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkRuleSet class.
        /// </summary>
        /// <param name="defaultAction">The default action of allow or deny
        /// when no other rules match. Possible values include: 'Allow',
        /// 'Deny'</param>
        /// <param name="virtualNetworkRules">The virtual network
        /// rules.</param>
        /// <param name="ipRules">The IP ACL rules.</param>
        public NetworkRuleSet(string defaultAction, System.Collections.Generic.IList<VirtualNetworkRule> virtualNetworkRules = default(System.Collections.Generic.IList<VirtualNetworkRule>), System.Collections.Generic.IList<IPRule> ipRules = default(System.Collections.Generic.IList<IPRule>))
        {
            this.DefaultAction = defaultAction;
            this.VirtualNetworkRules = virtualNetworkRules;
            this.IpRules = ipRules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the default action of allow or deny when no other
        /// rules match. Possible values include: 'Allow', 'Deny'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "defaultAction")]
        public string DefaultAction { get; set; }

        /// <summary>
        /// Gets or sets the virtual network rules.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "virtualNetworkRules")]
        public System.Collections.Generic.IList<VirtualNetworkRule> VirtualNetworkRules { get; set; }

        /// <summary>
        /// Gets or sets the IP ACL rules.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ipRules")]
        public System.Collections.Generic.IList<IPRule> IpRules { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.DefaultAction == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DefaultAction");
            }
            if (this.VirtualNetworkRules != null)
            {
                foreach (var element in this.VirtualNetworkRules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.IpRules != null)
            {
                foreach (var element1 in this.IpRules)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}