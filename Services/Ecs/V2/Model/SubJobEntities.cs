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
    public class SubJobEntities 
    {

        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        [JsonProperty("nic_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NicId { get; set; }

        [JsonProperty("errorcode_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorcodeMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubJobEntities {\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  nicId: ").Append(NicId).Append("\n");
            sb.Append("  errorcodeMessage: ").Append(ErrorcodeMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubJobEntities);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubJobEntities input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServerId == input.ServerId ||
                    (this.ServerId != null &&
                    this.ServerId.Equals(input.ServerId))
                ) && 
                (
                    this.NicId == input.NicId ||
                    (this.NicId != null &&
                    this.NicId.Equals(input.NicId))
                ) && 
                (
                    this.ErrorcodeMessage == input.ErrorcodeMessage ||
                    (this.ErrorcodeMessage != null &&
                    this.ErrorcodeMessage.Equals(input.ErrorcodeMessage))
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
                if (this.ServerId != null)
                    hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.NicId != null)
                    hashCode = hashCode * 59 + this.NicId.GetHashCode();
                if (this.ErrorcodeMessage != null)
                    hashCode = hashCode * 59 + this.ErrorcodeMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
