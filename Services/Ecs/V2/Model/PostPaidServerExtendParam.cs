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
    public class PostPaidServerExtendParam 
    {
        [JsonConverter(typeof(EnumClassConverter<InterruptionPolicyEnum>))]
        public class InterruptionPolicyEnum
        {
            /// <summary>
            /// Enum IMMEDIATE for value: immediate
            /// </summary>
            public static readonly InterruptionPolicyEnum IMMEDIATE = new InterruptionPolicyEnum("immediate");

            private static readonly Dictionary<string, InterruptionPolicyEnum> StaticFields =
            new Dictionary<string, InterruptionPolicyEnum>()
            {
                { "immediate", IMMEDIATE },
            };

            private string _value;

            public InterruptionPolicyEnum()
            {

            }

            public InterruptionPolicyEnum(string value)
            {
                _value = value;
            }

            public static InterruptionPolicyEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as InterruptionPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InterruptionPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InterruptionPolicyEnum a, InterruptionPolicyEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(InterruptionPolicyEnum a, InterruptionPolicyEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("chargingMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargingMode { get; set; }

        [JsonProperty("regionID", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionID { get; set; }

        [JsonProperty("support_auto_recovery", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportAutoRecovery { get; set; }

        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        [JsonProperty("marketType", NullValueHandling = NullValueHandling.Ignore)]
        public string MarketType { get; set; }

        [JsonProperty("spotPrice", NullValueHandling = NullValueHandling.Ignore)]
        public string SpotPrice { get; set; }

        [JsonProperty("diskPrior", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskPrior { get; set; }

        [JsonProperty("spot_duration_hours", NullValueHandling = NullValueHandling.Ignore)]
        public int? SpotDurationHours { get; set; }

        [JsonProperty("interruption_policy", NullValueHandling = NullValueHandling.Ignore)]
        public InterruptionPolicyEnum InterruptionPolicy { get; set; }
        [JsonProperty("spot_duration_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SpotDurationCount { get; set; }

        [JsonProperty("CB_CSBS_BACKUP", NullValueHandling = NullValueHandling.Ignore)]
        public string CbCsbsBackup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostPaidServerExtendParam {\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  regionID: ").Append(RegionID).Append("\n");
            sb.Append("  supportAutoRecovery: ").Append(SupportAutoRecovery).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  marketType: ").Append(MarketType).Append("\n");
            sb.Append("  spotPrice: ").Append(SpotPrice).Append("\n");
            sb.Append("  diskPrior: ").Append(DiskPrior).Append("\n");
            sb.Append("  spotDurationHours: ").Append(SpotDurationHours).Append("\n");
            sb.Append("  interruptionPolicy: ").Append(InterruptionPolicy).Append("\n");
            sb.Append("  spotDurationCount: ").Append(SpotDurationCount).Append("\n");
            sb.Append("  cbCsbsBackup: ").Append(CbCsbsBackup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostPaidServerExtendParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostPaidServerExtendParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChargingMode == input.ChargingMode ||
                    (this.ChargingMode != null &&
                    this.ChargingMode.Equals(input.ChargingMode))
                ) && 
                (
                    this.RegionID == input.RegionID ||
                    (this.RegionID != null &&
                    this.RegionID.Equals(input.RegionID))
                ) && 
                (
                    this.SupportAutoRecovery == input.SupportAutoRecovery ||
                    (this.SupportAutoRecovery != null &&
                    this.SupportAutoRecovery.Equals(input.SupportAutoRecovery))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.MarketType == input.MarketType ||
                    (this.MarketType != null &&
                    this.MarketType.Equals(input.MarketType))
                ) && 
                (
                    this.SpotPrice == input.SpotPrice ||
                    (this.SpotPrice != null &&
                    this.SpotPrice.Equals(input.SpotPrice))
                ) && 
                (
                    this.DiskPrior == input.DiskPrior ||
                    (this.DiskPrior != null &&
                    this.DiskPrior.Equals(input.DiskPrior))
                ) && 
                (
                    this.SpotDurationHours == input.SpotDurationHours ||
                    (this.SpotDurationHours != null &&
                    this.SpotDurationHours.Equals(input.SpotDurationHours))
                ) && 
                (
                    this.InterruptionPolicy == input.InterruptionPolicy ||
                    (this.InterruptionPolicy != null &&
                    this.InterruptionPolicy.Equals(input.InterruptionPolicy))
                ) && 
                (
                    this.SpotDurationCount == input.SpotDurationCount ||
                    (this.SpotDurationCount != null &&
                    this.SpotDurationCount.Equals(input.SpotDurationCount))
                ) && 
                (
                    this.CbCsbsBackup == input.CbCsbsBackup ||
                    (this.CbCsbsBackup != null &&
                    this.CbCsbsBackup.Equals(input.CbCsbsBackup))
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
                if (this.ChargingMode != null)
                    hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.RegionID != null)
                    hashCode = hashCode * 59 + this.RegionID.GetHashCode();
                if (this.SupportAutoRecovery != null)
                    hashCode = hashCode * 59 + this.SupportAutoRecovery.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.MarketType != null)
                    hashCode = hashCode * 59 + this.MarketType.GetHashCode();
                if (this.SpotPrice != null)
                    hashCode = hashCode * 59 + this.SpotPrice.GetHashCode();
                if (this.DiskPrior != null)
                    hashCode = hashCode * 59 + this.DiskPrior.GetHashCode();
                if (this.SpotDurationHours != null)
                    hashCode = hashCode * 59 + this.SpotDurationHours.GetHashCode();
                if (this.InterruptionPolicy != null)
                    hashCode = hashCode * 59 + this.InterruptionPolicy.GetHashCode();
                if (this.SpotDurationCount != null)
                    hashCode = hashCode * 59 + this.SpotDurationCount.GetHashCode();
                if (this.CbCsbsBackup != null)
                    hashCode = hashCode * 59 + this.CbCsbsBackup.GetHashCode();
                return hashCode;
            }
        }
    }
}
