﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace mba_model
{
    [DataContract]
    public class Project
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int ClientId { get; set; }

        [DataMember]
        [Column(TypeName = "datetime2")]
        public DateTime Created { get; set; }
        [DataMember]
        public int CreatedBy { get; set; }

        [DataMember]
        [Column(TypeName = "datetime2")]
        public DateTime? Deleted { get; set; }
        [DataMember]
        public int? DeletedBy { get; set; }

        [DataMember]
        public virtual Client Client { get; set; }
    }
}
