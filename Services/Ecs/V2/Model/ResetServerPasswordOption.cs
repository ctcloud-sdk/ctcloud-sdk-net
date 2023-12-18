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
    public class ResetServerPasswordOption 
    {

        [JsonProperty("new_password", NullValueHandling = NullValueHandling.Ignore)]
        public string NewPassword { get; set; }

        [JsonProperty("is_check_password", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCheckPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetServerPasswordOption {\n");
            sb.Append("  newPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  isCheckPassword: ").Append(IsCheckPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetServerPasswordOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetServerPasswordOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
                ) && 
                (
                    this.IsCheckPassword == input.IsCheckPassword ||
                    (this.IsCheckPassword != null &&
                    this.IsCheckPassword.Equals(input.IsCheckPassword))
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
                if (this.NewPassword != null)
                    hashCode = hashCode * 59 + this.NewPassword.GetHashCode();
                if (this.IsCheckPassword != null)
                    hashCode = hashCode * 59 + this.IsCheckPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
