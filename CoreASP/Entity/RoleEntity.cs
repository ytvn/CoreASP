using CoreASP.Converter;
using CoreASP.Enum;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using JsonDictionaryAttribute = CoreASP.Converter.JsonDictionaryAttribute;

namespace CoreASP.Entity
{
    public class RoleEntity : BaseEnity
    {
        [Key]
        public int roleId { get; set; }
        [Required]
        public string description { get; set; }
        public DateTime time { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Status Status { get; set; }

        [Required]
        [JsonProperty("properties")]
        [JsonConverter(typeof(DictionaryConverter))]
        //[JsonExtensionData]
        public IDictionary<string, long> role { get; set; } = new Dictionary<string, long>();
        public override int getId()
        {
            return this.roleId;
        }
        public override void setId(int id)
        {
            this.roleId = id;
        }
    }
}
