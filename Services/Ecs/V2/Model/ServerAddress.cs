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
    /// 弹性云服务器的网络属性。
    /// </summary>
    public class ServerAddress 
    {
        [JsonConverter(typeof(EnumClassConverter<OSEXTIPStypeEnum>))]
        public class OSEXTIPStypeEnum
        {
            /// <summary>
            /// Enum FIXED for value: fixed
            /// </summary>
            public static readonly OSEXTIPStypeEnum FIXED = new OSEXTIPStypeEnum("fixed");

            /// <summary>
            /// Enum FLOATING for value: floating
            /// </summary>
            public static readonly OSEXTIPStypeEnum FLOATING = new OSEXTIPStypeEnum("floating");

            private static readonly Dictionary<string, OSEXTIPStypeEnum> StaticFields =
            new Dictionary<string, OSEXTIPStypeEnum>()
            {
                { "fixed", FIXED },
                { "floating", FLOATING },
            };

            private string _value;

            public OSEXTIPStypeEnum()
            {

            }

            public OSEXTIPStypeEnum(string value)
            {
                _value = value;
            }

            public static OSEXTIPStypeEnum FromValue(string value)
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

                if (this.Equals(obj as OSEXTIPStypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OSEXTIPStypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OSEXTIPStypeEnum a, OSEXTIPStypeEnum b)
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

            public static bool operator !=(OSEXTIPStypeEnum a, OSEXTIPStypeEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("addr", NullValueHandling = NullValueHandling.Ignore)]
        public string Addr { get; set; }

        [JsonProperty("OS-EXT-IPS:type", NullValueHandling = NullValueHandling.Ignore)]
        public OSEXTIPStypeEnum OSEXTIPStype { get; set; }
        [JsonProperty("OS-EXT-IPS-MAC:mac_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTIPSMACmacAddr { get; set; }

        [JsonProperty("OS-EXT-IPS:port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTIPSportId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerAddress {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  addr: ").Append(Addr).Append("\n");
            sb.Append("  oSEXTIPStype: ").Append(OSEXTIPStype).Append("\n");
            sb.Append("  oSEXTIPSMACmacAddr: ").Append(OSEXTIPSMACmacAddr).Append("\n");
            sb.Append("  oSEXTIPSportId: ").Append(OSEXTIPSportId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerAddress);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Addr == input.Addr ||
                    (this.Addr != null &&
                    this.Addr.Equals(input.Addr))
                ) && 
                (
                    this.OSEXTIPStype == input.OSEXTIPStype ||
                    (this.OSEXTIPStype != null &&
                    this.OSEXTIPStype.Equals(input.OSEXTIPStype))
                ) && 
                (
                    this.OSEXTIPSMACmacAddr == input.OSEXTIPSMACmacAddr ||
                    (this.OSEXTIPSMACmacAddr != null &&
                    this.OSEXTIPSMACmacAddr.Equals(input.OSEXTIPSMACmacAddr))
                ) && 
                (
                    this.OSEXTIPSportId == input.OSEXTIPSportId ||
                    (this.OSEXTIPSportId != null &&
                    this.OSEXTIPSportId.Equals(input.OSEXTIPSportId))
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Addr != null)
                    hashCode = hashCode * 59 + this.Addr.GetHashCode();
                if (this.OSEXTIPStype != null)
                    hashCode = hashCode * 59 + this.OSEXTIPStype.GetHashCode();
                if (this.OSEXTIPSMACmacAddr != null)
                    hashCode = hashCode * 59 + this.OSEXTIPSMACmacAddr.GetHashCode();
                if (this.OSEXTIPSportId != null)
                    hashCode = hashCode * 59 + this.OSEXTIPSportId.GetHashCode();
                return hashCode;
            }
        }
    }
}
