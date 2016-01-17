using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Axmor_TestIssue.Core.Models
{
    [Serializable]
    public class BaseEntity
    {
        [Required]
        [DataMember]
        public DateTime CreateDate { get; set; }
        [Required]
        [DataMember]
        public DateTime ModifyDate { get; set; }
        [Required]
        [DataMember]
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        [Required]
        [DataMember]
        public bool IsDeleted { get; set; }
    }
}
