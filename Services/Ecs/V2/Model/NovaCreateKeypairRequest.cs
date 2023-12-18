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
    /// Request Object
    /// </summary>
    public class NovaCreateKeypairRequest 
    {

        [SDKProperty("OpenStack-API-Version", IsHeader = true)]
        [JsonProperty("OpenStack-API-Version", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenStackAPIVersion { get; set; }

        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public NovaCreateKeypairRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaCreateKeypairRequest {\n");
            sb.Append("  openStackAPIVersion: ").Append(OpenStackAPIVersion).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaCreateKeypairRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaCreateKeypairRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OpenStackAPIVersion == input.OpenStackAPIVersion ||
                    (this.OpenStackAPIVersion != null &&
                    this.OpenStackAPIVersion.Equals(input.OpenStackAPIVersion))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.OpenStackAPIVersion != null)
                    hashCode = hashCode * 59 + this.OpenStackAPIVersion.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
