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
    /// 重装操作系统body体。
    /// </summary>
    public class ChangeServerOsWithCloudInitOption 
    {

        [JsonProperty("adminpass", NullValueHandling = NullValueHandling.Ignore)]
        public string Adminpass { get; set; }

        [JsonProperty("keyname", NullValueHandling = NullValueHandling.Ignore)]
        public string Keyname { get; set; }

        [JsonProperty("userid", NullValueHandling = NullValueHandling.Ignore)]
        public string Userid { get; set; }

        [JsonProperty("imageid", NullValueHandling = NullValueHandling.Ignore)]
        public string Imageid { get; set; }

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public ChangeSeversOsMetadata Metadata { get; set; }

        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeServerOsWithCloudInitOption {\n");
            sb.Append("  adminpass: ").Append(Adminpass).Append("\n");
            sb.Append("  keyname: ").Append(Keyname).Append("\n");
            sb.Append("  userid: ").Append(Userid).Append("\n");
            sb.Append("  imageid: ").Append(Imageid).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeServerOsWithCloudInitOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeServerOsWithCloudInitOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Adminpass == input.Adminpass ||
                    (this.Adminpass != null &&
                    this.Adminpass.Equals(input.Adminpass))
                ) && 
                (
                    this.Keyname == input.Keyname ||
                    (this.Keyname != null &&
                    this.Keyname.Equals(input.Keyname))
                ) && 
                (
                    this.Userid == input.Userid ||
                    (this.Userid != null &&
                    this.Userid.Equals(input.Userid))
                ) && 
                (
                    this.Imageid == input.Imageid ||
                    (this.Imageid != null &&
                    this.Imageid.Equals(input.Imageid))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
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
                if (this.Adminpass != null)
                    hashCode = hashCode * 59 + this.Adminpass.GetHashCode();
                if (this.Keyname != null)
                    hashCode = hashCode * 59 + this.Keyname.GetHashCode();
                if (this.Userid != null)
                    hashCode = hashCode * 59 + this.Userid.GetHashCode();
                if (this.Imageid != null)
                    hashCode = hashCode * 59 + this.Imageid.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
