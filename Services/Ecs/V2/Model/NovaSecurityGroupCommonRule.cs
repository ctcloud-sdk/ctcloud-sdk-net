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
    /// 
    /// </summary>
    public class NovaSecurityGroupCommonRule 
    {

        [JsonProperty("from_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? FromPort { get; set; }

        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public NovaSecurityGroupCommonGroup Group { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("ip_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string IpProtocol { get; set; }

        [JsonProperty("ip_range", NullValueHandling = NullValueHandling.Ignore)]
        public NovaSecurityGroupCommonIpRange IpRange { get; set; }

        [JsonProperty("parent_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentGroupId { get; set; }

        [JsonProperty("to_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ToPort { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaSecurityGroupCommonRule {\n");
            sb.Append("  fromPort: ").Append(FromPort).Append("\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  ipProtocol: ").Append(IpProtocol).Append("\n");
            sb.Append("  ipRange: ").Append(IpRange).Append("\n");
            sb.Append("  parentGroupId: ").Append(ParentGroupId).Append("\n");
            sb.Append("  toPort: ").Append(ToPort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaSecurityGroupCommonRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaSecurityGroupCommonRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FromPort == input.FromPort ||
                    (this.FromPort != null &&
                    this.FromPort.Equals(input.FromPort))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IpProtocol == input.IpProtocol ||
                    (this.IpProtocol != null &&
                    this.IpProtocol.Equals(input.IpProtocol))
                ) && 
                (
                    this.IpRange == input.IpRange ||
                    (this.IpRange != null &&
                    this.IpRange.Equals(input.IpRange))
                ) && 
                (
                    this.ParentGroupId == input.ParentGroupId ||
                    (this.ParentGroupId != null &&
                    this.ParentGroupId.Equals(input.ParentGroupId))
                ) && 
                (
                    this.ToPort == input.ToPort ||
                    (this.ToPort != null &&
                    this.ToPort.Equals(input.ToPort))
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
                if (this.FromPort != null)
                    hashCode = hashCode * 59 + this.FromPort.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IpProtocol != null)
                    hashCode = hashCode * 59 + this.IpProtocol.GetHashCode();
                if (this.IpRange != null)
                    hashCode = hashCode * 59 + this.IpRange.GetHashCode();
                if (this.ParentGroupId != null)
                    hashCode = hashCode * 59 + this.ParentGroupId.GetHashCode();
                if (this.ToPort != null)
                    hashCode = hashCode * 59 + this.ToPort.GetHashCode();
                return hashCode;
            }
        }
    }
}
