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
    /// The source trigger that caused a run.
    /// </summary>
    public partial class SourceTriggerDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the SourceTriggerDescriptor class.
        /// </summary>
        public SourceTriggerDescriptor()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SourceTriggerDescriptor class.
        /// </summary>
        /// <param name="id">The unique ID of the trigger.</param>
        /// <param name="eventType">The event type of the trigger.</param>
        /// <param name="commitId">The unique ID that identifies a
        /// commit.</param>
        /// <param name="pullRequestId">The unique ID that identifies pull
        /// request.</param>
        /// <param name="repositoryUrl">The repository URL.</param>
        /// <param name="branchName">The branch name in the repository.</param>
        /// <param name="providerType">The source control provider
        /// type.</param>
        public SourceTriggerDescriptor(string id = default(string), string eventType = default(string), string commitId = default(string), string pullRequestId = default(string), string repositoryUrl = default(string), string branchName = default(string), string providerType = default(string))
        {
            this.Id = id;
            this.EventType = eventType;
            this.CommitId = commitId;
            this.PullRequestId = pullRequestId;
            this.RepositoryUrl = repositoryUrl;
            this.BranchName = branchName;
            this.ProviderType = providerType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique ID of the trigger.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the event type of the trigger.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "eventType")]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or sets the unique ID that identifies a commit.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "commitId")]
        public string CommitId { get; set; }

        /// <summary>
        /// Gets or sets the unique ID that identifies pull request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "pullRequestId")]
        public string PullRequestId { get; set; }

        /// <summary>
        /// Gets or sets the repository URL.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "repositoryUrl")]
        public string RepositoryUrl { get; set; }

        /// <summary>
        /// Gets or sets the branch name in the repository.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "branchName")]
        public string BranchName { get; set; }

        /// <summary>
        /// Gets or sets the source control provider type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "providerType")]
        public string ProviderType { get; set; }

    }
}