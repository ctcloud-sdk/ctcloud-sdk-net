using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using CtCloud.SDK.Core;

namespace CtCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 弹性云服务器调度信息。
    /// </summary>
    public class ServerSchedulerHints 
    {

        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Group { get; set; }

        [JsonProperty("tenancy", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tenancy { get; set; }

        [JsonProperty("dedicated_host_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DedicatedHostId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerSchedulerHints {\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("  tenancy: ").Append(Tenancy).Append("\n");
            sb.Append("  dedicatedHostId: ").Append(DedicatedHostId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerSchedulerHints);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerSchedulerHints input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Group == input.Group ||
                    this.Group != null &&
                    input.Group != null &&
                    this.Group.SequenceEqual(input.Group)
                ) && 
                (
                    this.Tenancy == input.Tenancy ||
                    this.Tenancy != null &&
                    input.Tenancy != null &&
                    this.Tenancy.SequenceEqual(input.Tenancy)
                ) && 
                (
                    this.DedicatedHostId == input.DedicatedHostId ||
                    this.DedicatedHostId != null &&
                    input.DedicatedHostId != null &&
                    this.DedicatedHostId.SequenceEqual(input.DedicatedHostId)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Tenancy != null)
                    hashCode = hashCode * 59 + this.Tenancy.GetHashCode();
                if (this.DedicatedHostId != null)
                    hashCode = hashCode * 59 + this.DedicatedHostId.GetHashCode();
                return hashCode;
            }
        }
    }
}
