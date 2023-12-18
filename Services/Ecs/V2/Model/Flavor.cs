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
    /// 云服务器规格。
    /// </summary>
    public class Flavor 
    {

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public string Vcpus { get; set; }

        [JsonProperty("ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ram { get; set; }

        [JsonProperty("disk", NullValueHandling = NullValueHandling.Ignore)]
        public string Disk { get; set; }

        [JsonProperty("swap", NullValueHandling = NullValueHandling.Ignore)]
        public string Swap { get; set; }

        [JsonProperty("OS-FLV-EXT-DATA:ephemeral", NullValueHandling = NullValueHandling.Ignore)]
        public int? OSFLVEXTDATAephemeral { get; set; }

        [JsonProperty("OS-FLV-DISABLED:disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OSFLVDISABLEDdisabled { get; set; }

        [JsonProperty("rxtx_factor", NullValueHandling = NullValueHandling.Ignore)]
        public float? RxtxFactor { get; set; }

        [JsonProperty("rxtx_quota", NullValueHandling = NullValueHandling.Ignore)]
        public string RxtxQuota { get; set; }

        [JsonProperty("rxtx_cap", NullValueHandling = NullValueHandling.Ignore)]
        public string RxtxCap { get; set; }

        [JsonProperty("os-flavor-access:is_public", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OsFlavorAccessisPublic { get; set; }

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlavorLink> Links { get; set; }

        [JsonProperty("os_extra_specs", NullValueHandling = NullValueHandling.Ignore)]
        public FlavorExtraSpec OsExtraSpecs { get; set; }

        [JsonProperty("attachableQuantity", NullValueHandling = NullValueHandling.Ignore)]
        public ServerAttachableQuantity AttachableQuantity { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Flavor {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  vcpus: ").Append(Vcpus).Append("\n");
            sb.Append("  ram: ").Append(Ram).Append("\n");
            sb.Append("  disk: ").Append(Disk).Append("\n");
            sb.Append("  swap: ").Append(Swap).Append("\n");
            sb.Append("  oSFLVEXTDATAephemeral: ").Append(OSFLVEXTDATAephemeral).Append("\n");
            sb.Append("  oSFLVDISABLEDdisabled: ").Append(OSFLVDISABLEDdisabled).Append("\n");
            sb.Append("  rxtxFactor: ").Append(RxtxFactor).Append("\n");
            sb.Append("  rxtxQuota: ").Append(RxtxQuota).Append("\n");
            sb.Append("  rxtxCap: ").Append(RxtxCap).Append("\n");
            sb.Append("  osFlavorAccessisPublic: ").Append(OsFlavorAccessisPublic).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  osExtraSpecs: ").Append(OsExtraSpecs).Append("\n");
            sb.Append("  attachableQuantity: ").Append(AttachableQuantity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Flavor);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Flavor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Vcpus == input.Vcpus ||
                    (this.Vcpus != null &&
                    this.Vcpus.Equals(input.Vcpus))
                ) && 
                (
                    this.Ram == input.Ram ||
                    (this.Ram != null &&
                    this.Ram.Equals(input.Ram))
                ) && 
                (
                    this.Disk == input.Disk ||
                    (this.Disk != null &&
                    this.Disk.Equals(input.Disk))
                ) && 
                (
                    this.Swap == input.Swap ||
                    (this.Swap != null &&
                    this.Swap.Equals(input.Swap))
                ) && 
                (
                    this.OSFLVEXTDATAephemeral == input.OSFLVEXTDATAephemeral ||
                    (this.OSFLVEXTDATAephemeral != null &&
                    this.OSFLVEXTDATAephemeral.Equals(input.OSFLVEXTDATAephemeral))
                ) && 
                (
                    this.OSFLVDISABLEDdisabled == input.OSFLVDISABLEDdisabled ||
                    (this.OSFLVDISABLEDdisabled != null &&
                    this.OSFLVDISABLEDdisabled.Equals(input.OSFLVDISABLEDdisabled))
                ) && 
                (
                    this.RxtxFactor == input.RxtxFactor ||
                    (this.RxtxFactor != null &&
                    this.RxtxFactor.Equals(input.RxtxFactor))
                ) && 
                (
                    this.RxtxQuota == input.RxtxQuota ||
                    (this.RxtxQuota != null &&
                    this.RxtxQuota.Equals(input.RxtxQuota))
                ) && 
                (
                    this.RxtxCap == input.RxtxCap ||
                    (this.RxtxCap != null &&
                    this.RxtxCap.Equals(input.RxtxCap))
                ) && 
                (
                    this.OsFlavorAccessisPublic == input.OsFlavorAccessisPublic ||
                    (this.OsFlavorAccessisPublic != null &&
                    this.OsFlavorAccessisPublic.Equals(input.OsFlavorAccessisPublic))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.OsExtraSpecs == input.OsExtraSpecs ||
                    (this.OsExtraSpecs != null &&
                    this.OsExtraSpecs.Equals(input.OsExtraSpecs))
                ) && 
                (
                    this.AttachableQuantity == input.AttachableQuantity ||
                    (this.AttachableQuantity != null &&
                    this.AttachableQuantity.Equals(input.AttachableQuantity))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Vcpus != null)
                    hashCode = hashCode * 59 + this.Vcpus.GetHashCode();
                if (this.Ram != null)
                    hashCode = hashCode * 59 + this.Ram.GetHashCode();
                if (this.Disk != null)
                    hashCode = hashCode * 59 + this.Disk.GetHashCode();
                if (this.Swap != null)
                    hashCode = hashCode * 59 + this.Swap.GetHashCode();
                if (this.OSFLVEXTDATAephemeral != null)
                    hashCode = hashCode * 59 + this.OSFLVEXTDATAephemeral.GetHashCode();
                if (this.OSFLVDISABLEDdisabled != null)
                    hashCode = hashCode * 59 + this.OSFLVDISABLEDdisabled.GetHashCode();
                if (this.RxtxFactor != null)
                    hashCode = hashCode * 59 + this.RxtxFactor.GetHashCode();
                if (this.RxtxQuota != null)
                    hashCode = hashCode * 59 + this.RxtxQuota.GetHashCode();
                if (this.RxtxCap != null)
                    hashCode = hashCode * 59 + this.RxtxCap.GetHashCode();
                if (this.OsFlavorAccessisPublic != null)
                    hashCode = hashCode * 59 + this.OsFlavorAccessisPublic.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.OsExtraSpecs != null)
                    hashCode = hashCode * 59 + this.OsExtraSpecs.GetHashCode();
                if (this.AttachableQuantity != null)
                    hashCode = hashCode * 59 + this.AttachableQuantity.GetHashCode();
                return hashCode;
            }
        }
    }
}
