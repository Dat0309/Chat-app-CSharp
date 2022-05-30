using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.Model
{
    [Table("MessPrivate")]
    public partial class MessPrivate
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string UserId_Send { get; set; }

        [StringLength(50)]
        public string UserId_Receiver { get; set; }

        [StringLength(50)]
        public string Message_body { get; set; }

        public DateTime CreateAt { get; set; }
    }
}
