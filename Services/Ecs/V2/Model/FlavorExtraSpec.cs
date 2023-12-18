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
    /// 云服务器规格的扩展字段。
    /// </summary>
    public class FlavorExtraSpec 
    {

        [JsonProperty("ecs:performancetype", NullValueHandling = NullValueHandling.Ignore)]
        public string Ecsperformancetype { get; set; }

        [JsonProperty("hw:numa_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public string HwnumaNodes { get; set; }

        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        [JsonProperty("hpet_support", NullValueHandling = NullValueHandling.Ignore)]
        public string HpetSupport { get; set; }

        [JsonProperty("instance_vnic:type", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceVnictype { get; set; }

        [JsonProperty("instance_vnic:instance_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceVnicinstanceBandwidth { get; set; }

        [JsonProperty("instance_vnic:max_count", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceVnicmaxCount { get; set; }

        [JsonProperty("quota:local_disk", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotalocalDisk { get; set; }

        [JsonProperty("quota:nvme_ssd", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotanvmeSsd { get; set; }

        [JsonProperty("extra_spec:io:persistent_grant", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtraSpeciopersistentGrant { get; set; }

        [JsonProperty("ecs:generation", NullValueHandling = NullValueHandling.Ignore)]
        public string Ecsgeneration { get; set; }

        [JsonProperty("ecs:virtualization_env_types", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsvirtualizationEnvTypes { get; set; }

        [JsonProperty("pci_passthrough:enable_gpu", NullValueHandling = NullValueHandling.Ignore)]
        public string PciPassthroughenableGpu { get; set; }

        [JsonProperty("pci_passthrough:gpu_specs", NullValueHandling = NullValueHandling.Ignore)]
        public string PciPassthroughgpuSpecs { get; set; }

        [JsonProperty("pci_passthrough:alias", NullValueHandling = NullValueHandling.Ignore)]
        public string PciPassthroughalias { get; set; }

        [JsonProperty("cond:operation:status", NullValueHandling = NullValueHandling.Ignore)]
        public string Condoperationstatus { get; set; }

        [JsonProperty("cond:operation:az", NullValueHandling = NullValueHandling.Ignore)]
        public string Condoperationaz { get; set; }

        [JsonProperty("quota:max_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotamaxRate { get; set; }

        [JsonProperty("quota:min_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotaminRate { get; set; }

        [JsonProperty("quota:max_pps", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotamaxPps { get; set; }

        [JsonProperty("cond:operation:charge", NullValueHandling = NullValueHandling.Ignore)]
        public string Condoperationcharge { get; set; }

        [JsonProperty("cond:operation:charge:stop", NullValueHandling = NullValueHandling.Ignore)]
        public string Condoperationchargestop { get; set; }

        [JsonProperty("cond:spot:operation:az", NullValueHandling = NullValueHandling.Ignore)]
        public string Condspotoperationaz { get; set; }

        [JsonProperty("cond:operation:roles", NullValueHandling = NullValueHandling.Ignore)]
        public string Condoperationroles { get; set; }

        [JsonProperty("cond:spot:operation:status", NullValueHandling = NullValueHandling.Ignore)]
        public string Condspotoperationstatus { get; set; }

        [JsonProperty("cond:network", NullValueHandling = NullValueHandling.Ignore)]
        public string Condnetwork { get; set; }

        [JsonProperty("cond:storage", NullValueHandling = NullValueHandling.Ignore)]
        public string Condstorage { get; set; }

        [JsonProperty("cond:compute:live_resizable", NullValueHandling = NullValueHandling.Ignore)]
        public string CondcomputeliveResizable { get; set; }

        [JsonProperty("cond:compute", NullValueHandling = NullValueHandling.Ignore)]
        public string Condcompute { get; set; }

        [JsonProperty("info:gpu:name", NullValueHandling = NullValueHandling.Ignore)]
        public string Infogpuname { get; set; }

        [JsonProperty("info:cpu:name", NullValueHandling = NullValueHandling.Ignore)]
        public string Infocpuname { get; set; }

        [JsonProperty("quota:gpu", NullValueHandling = NullValueHandling.Ignore)]
        public string Quotagpu { get; set; }

        [JsonProperty("ecs:instance_architecture", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsinstanceArchitecture { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlavorExtraSpec {\n");
            sb.Append("  ecsperformancetype: ").Append(Ecsperformancetype).Append("\n");
            sb.Append("  hwnumaNodes: ").Append(HwnumaNodes).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  hpetSupport: ").Append(HpetSupport).Append("\n");
            sb.Append("  instanceVnictype: ").Append(InstanceVnictype).Append("\n");
            sb.Append("  instanceVnicinstanceBandwidth: ").Append(InstanceVnicinstanceBandwidth).Append("\n");
            sb.Append("  instanceVnicmaxCount: ").Append(InstanceVnicmaxCount).Append("\n");
            sb.Append("  quotalocalDisk: ").Append(QuotalocalDisk).Append("\n");
            sb.Append("  quotanvmeSsd: ").Append(QuotanvmeSsd).Append("\n");
            sb.Append("  extraSpeciopersistentGrant: ").Append(ExtraSpeciopersistentGrant).Append("\n");
            sb.Append("  ecsgeneration: ").Append(Ecsgeneration).Append("\n");
            sb.Append("  ecsvirtualizationEnvTypes: ").Append(EcsvirtualizationEnvTypes).Append("\n");
            sb.Append("  pciPassthroughenableGpu: ").Append(PciPassthroughenableGpu).Append("\n");
            sb.Append("  pciPassthroughgpuSpecs: ").Append(PciPassthroughgpuSpecs).Append("\n");
            sb.Append("  pciPassthroughalias: ").Append(PciPassthroughalias).Append("\n");
            sb.Append("  condoperationstatus: ").Append(Condoperationstatus).Append("\n");
            sb.Append("  condoperationaz: ").Append(Condoperationaz).Append("\n");
            sb.Append("  quotamaxRate: ").Append(QuotamaxRate).Append("\n");
            sb.Append("  quotaminRate: ").Append(QuotaminRate).Append("\n");
            sb.Append("  quotamaxPps: ").Append(QuotamaxPps).Append("\n");
            sb.Append("  condoperationcharge: ").Append(Condoperationcharge).Append("\n");
            sb.Append("  condoperationchargestop: ").Append(Condoperationchargestop).Append("\n");
            sb.Append("  condspotoperationaz: ").Append(Condspotoperationaz).Append("\n");
            sb.Append("  condoperationroles: ").Append(Condoperationroles).Append("\n");
            sb.Append("  condspotoperationstatus: ").Append(Condspotoperationstatus).Append("\n");
            sb.Append("  condnetwork: ").Append(Condnetwork).Append("\n");
            sb.Append("  condstorage: ").Append(Condstorage).Append("\n");
            sb.Append("  condcomputeliveResizable: ").Append(CondcomputeliveResizable).Append("\n");
            sb.Append("  condcompute: ").Append(Condcompute).Append("\n");
            sb.Append("  infogpuname: ").Append(Infogpuname).Append("\n");
            sb.Append("  infocpuname: ").Append(Infocpuname).Append("\n");
            sb.Append("  quotagpu: ").Append(Quotagpu).Append("\n");
            sb.Append("  ecsinstanceArchitecture: ").Append(EcsinstanceArchitecture).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlavorExtraSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlavorExtraSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ecsperformancetype == input.Ecsperformancetype ||
                    (this.Ecsperformancetype != null &&
                    this.Ecsperformancetype.Equals(input.Ecsperformancetype))
                ) && 
                (
                    this.HwnumaNodes == input.HwnumaNodes ||
                    (this.HwnumaNodes != null &&
                    this.HwnumaNodes.Equals(input.HwnumaNodes))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.HpetSupport == input.HpetSupport ||
                    (this.HpetSupport != null &&
                    this.HpetSupport.Equals(input.HpetSupport))
                ) && 
                (
                    this.InstanceVnictype == input.InstanceVnictype ||
                    (this.InstanceVnictype != null &&
                    this.InstanceVnictype.Equals(input.InstanceVnictype))
                ) && 
                (
                    this.InstanceVnicinstanceBandwidth == input.InstanceVnicinstanceBandwidth ||
                    (this.InstanceVnicinstanceBandwidth != null &&
                    this.InstanceVnicinstanceBandwidth.Equals(input.InstanceVnicinstanceBandwidth))
                ) && 
                (
                    this.InstanceVnicmaxCount == input.InstanceVnicmaxCount ||
                    (this.InstanceVnicmaxCount != null &&
                    this.InstanceVnicmaxCount.Equals(input.InstanceVnicmaxCount))
                ) && 
                (
                    this.QuotalocalDisk == input.QuotalocalDisk ||
                    (this.QuotalocalDisk != null &&
                    this.QuotalocalDisk.Equals(input.QuotalocalDisk))
                ) && 
                (
                    this.QuotanvmeSsd == input.QuotanvmeSsd ||
                    (this.QuotanvmeSsd != null &&
                    this.QuotanvmeSsd.Equals(input.QuotanvmeSsd))
                ) && 
                (
                    this.ExtraSpeciopersistentGrant == input.ExtraSpeciopersistentGrant ||
                    (this.ExtraSpeciopersistentGrant != null &&
                    this.ExtraSpeciopersistentGrant.Equals(input.ExtraSpeciopersistentGrant))
                ) && 
                (
                    this.Ecsgeneration == input.Ecsgeneration ||
                    (this.Ecsgeneration != null &&
                    this.Ecsgeneration.Equals(input.Ecsgeneration))
                ) && 
                (
                    this.EcsvirtualizationEnvTypes == input.EcsvirtualizationEnvTypes ||
                    (this.EcsvirtualizationEnvTypes != null &&
                    this.EcsvirtualizationEnvTypes.Equals(input.EcsvirtualizationEnvTypes))
                ) && 
                (
                    this.PciPassthroughenableGpu == input.PciPassthroughenableGpu ||
                    (this.PciPassthroughenableGpu != null &&
                    this.PciPassthroughenableGpu.Equals(input.PciPassthroughenableGpu))
                ) && 
                (
                    this.PciPassthroughgpuSpecs == input.PciPassthroughgpuSpecs ||
                    (this.PciPassthroughgpuSpecs != null &&
                    this.PciPassthroughgpuSpecs.Equals(input.PciPassthroughgpuSpecs))
                ) && 
                (
                    this.PciPassthroughalias == input.PciPassthroughalias ||
                    (this.PciPassthroughalias != null &&
                    this.PciPassthroughalias.Equals(input.PciPassthroughalias))
                ) && 
                (
                    this.Condoperationstatus == input.Condoperationstatus ||
                    (this.Condoperationstatus != null &&
                    this.Condoperationstatus.Equals(input.Condoperationstatus))
                ) && 
                (
                    this.Condoperationaz == input.Condoperationaz ||
                    (this.Condoperationaz != null &&
                    this.Condoperationaz.Equals(input.Condoperationaz))
                ) && 
                (
                    this.QuotamaxRate == input.QuotamaxRate ||
                    (this.QuotamaxRate != null &&
                    this.QuotamaxRate.Equals(input.QuotamaxRate))
                ) && 
                (
                    this.QuotaminRate == input.QuotaminRate ||
                    (this.QuotaminRate != null &&
                    this.QuotaminRate.Equals(input.QuotaminRate))
                ) && 
                (
                    this.QuotamaxPps == input.QuotamaxPps ||
                    (this.QuotamaxPps != null &&
                    this.QuotamaxPps.Equals(input.QuotamaxPps))
                ) && 
                (
                    this.Condoperationcharge == input.Condoperationcharge ||
                    (this.Condoperationcharge != null &&
                    this.Condoperationcharge.Equals(input.Condoperationcharge))
                ) && 
                (
                    this.Condoperationchargestop == input.Condoperationchargestop ||
                    (this.Condoperationchargestop != null &&
                    this.Condoperationchargestop.Equals(input.Condoperationchargestop))
                ) && 
                (
                    this.Condspotoperationaz == input.Condspotoperationaz ||
                    (this.Condspotoperationaz != null &&
                    this.Condspotoperationaz.Equals(input.Condspotoperationaz))
                ) && 
                (
                    this.Condoperationroles == input.Condoperationroles ||
                    (this.Condoperationroles != null &&
                    this.Condoperationroles.Equals(input.Condoperationroles))
                ) && 
                (
                    this.Condspotoperationstatus == input.Condspotoperationstatus ||
                    (this.Condspotoperationstatus != null &&
                    this.Condspotoperationstatus.Equals(input.Condspotoperationstatus))
                ) && 
                (
                    this.Condnetwork == input.Condnetwork ||
                    (this.Condnetwork != null &&
                    this.Condnetwork.Equals(input.Condnetwork))
                ) && 
                (
                    this.Condstorage == input.Condstorage ||
                    (this.Condstorage != null &&
                    this.Condstorage.Equals(input.Condstorage))
                ) && 
                (
                    this.CondcomputeliveResizable == input.CondcomputeliveResizable ||
                    (this.CondcomputeliveResizable != null &&
                    this.CondcomputeliveResizable.Equals(input.CondcomputeliveResizable))
                ) && 
                (
                    this.Condcompute == input.Condcompute ||
                    (this.Condcompute != null &&
                    this.Condcompute.Equals(input.Condcompute))
                ) && 
                (
                    this.Infogpuname == input.Infogpuname ||
                    (this.Infogpuname != null &&
                    this.Infogpuname.Equals(input.Infogpuname))
                ) && 
                (
                    this.Infocpuname == input.Infocpuname ||
                    (this.Infocpuname != null &&
                    this.Infocpuname.Equals(input.Infocpuname))
                ) && 
                (
                    this.Quotagpu == input.Quotagpu ||
                    (this.Quotagpu != null &&
                    this.Quotagpu.Equals(input.Quotagpu))
                ) && 
                (
                    this.EcsinstanceArchitecture == input.EcsinstanceArchitecture ||
                    (this.EcsinstanceArchitecture != null &&
                    this.EcsinstanceArchitecture.Equals(input.EcsinstanceArchitecture))
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
                if (this.Ecsperformancetype != null)
                    hashCode = hashCode * 59 + this.Ecsperformancetype.GetHashCode();
                if (this.HwnumaNodes != null)
                    hashCode = hashCode * 59 + this.HwnumaNodes.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.HpetSupport != null)
                    hashCode = hashCode * 59 + this.HpetSupport.GetHashCode();
                if (this.InstanceVnictype != null)
                    hashCode = hashCode * 59 + this.InstanceVnictype.GetHashCode();
                if (this.InstanceVnicinstanceBandwidth != null)
                    hashCode = hashCode * 59 + this.InstanceVnicinstanceBandwidth.GetHashCode();
                if (this.InstanceVnicmaxCount != null)
                    hashCode = hashCode * 59 + this.InstanceVnicmaxCount.GetHashCode();
                if (this.QuotalocalDisk != null)
                    hashCode = hashCode * 59 + this.QuotalocalDisk.GetHashCode();
                if (this.QuotanvmeSsd != null)
                    hashCode = hashCode * 59 + this.QuotanvmeSsd.GetHashCode();
                if (this.ExtraSpeciopersistentGrant != null)
                    hashCode = hashCode * 59 + this.ExtraSpeciopersistentGrant.GetHashCode();
                if (this.Ecsgeneration != null)
                    hashCode = hashCode * 59 + this.Ecsgeneration.GetHashCode();
                if (this.EcsvirtualizationEnvTypes != null)
                    hashCode = hashCode * 59 + this.EcsvirtualizationEnvTypes.GetHashCode();
                if (this.PciPassthroughenableGpu != null)
                    hashCode = hashCode * 59 + this.PciPassthroughenableGpu.GetHashCode();
                if (this.PciPassthroughgpuSpecs != null)
                    hashCode = hashCode * 59 + this.PciPassthroughgpuSpecs.GetHashCode();
                if (this.PciPassthroughalias != null)
                    hashCode = hashCode * 59 + this.PciPassthroughalias.GetHashCode();
                if (this.Condoperationstatus != null)
                    hashCode = hashCode * 59 + this.Condoperationstatus.GetHashCode();
                if (this.Condoperationaz != null)
                    hashCode = hashCode * 59 + this.Condoperationaz.GetHashCode();
                if (this.QuotamaxRate != null)
                    hashCode = hashCode * 59 + this.QuotamaxRate.GetHashCode();
                if (this.QuotaminRate != null)
                    hashCode = hashCode * 59 + this.QuotaminRate.GetHashCode();
                if (this.QuotamaxPps != null)
                    hashCode = hashCode * 59 + this.QuotamaxPps.GetHashCode();
                if (this.Condoperationcharge != null)
                    hashCode = hashCode * 59 + this.Condoperationcharge.GetHashCode();
                if (this.Condoperationchargestop != null)
                    hashCode = hashCode * 59 + this.Condoperationchargestop.GetHashCode();
                if (this.Condspotoperationaz != null)
                    hashCode = hashCode * 59 + this.Condspotoperationaz.GetHashCode();
                if (this.Condoperationroles != null)
                    hashCode = hashCode * 59 + this.Condoperationroles.GetHashCode();
                if (this.Condspotoperationstatus != null)
                    hashCode = hashCode * 59 + this.Condspotoperationstatus.GetHashCode();
                if (this.Condnetwork != null)
                    hashCode = hashCode * 59 + this.Condnetwork.GetHashCode();
                if (this.Condstorage != null)
                    hashCode = hashCode * 59 + this.Condstorage.GetHashCode();
                if (this.CondcomputeliveResizable != null)
                    hashCode = hashCode * 59 + this.CondcomputeliveResizable.GetHashCode();
                if (this.Condcompute != null)
                    hashCode = hashCode * 59 + this.Condcompute.GetHashCode();
                if (this.Infogpuname != null)
                    hashCode = hashCode * 59 + this.Infogpuname.GetHashCode();
                if (this.Infocpuname != null)
                    hashCode = hashCode * 59 + this.Infocpuname.GetHashCode();
                if (this.Quotagpu != null)
                    hashCode = hashCode * 59 + this.Quotagpu.GetHashCode();
                if (this.EcsinstanceArchitecture != null)
                    hashCode = hashCode * 59 + this.EcsinstanceArchitecture.GetHashCode();
                return hashCode;
            }
        }
    }
}
