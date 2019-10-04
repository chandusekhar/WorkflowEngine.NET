namespace WF.Sample.Oracle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WORKFLOWINBOX")]
    public partial class WorkflowInbox
    {
        public Guid Id { get; set; }

        public Guid ProcessId { get; set; }

        [Required]
        [StringLength(256)]
        public string IdentityId { get; set; }
    }
}
