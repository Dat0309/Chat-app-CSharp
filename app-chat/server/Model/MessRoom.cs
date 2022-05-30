using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.Model
{
    [Table("MessRoom")]
    public partial class MessRoom
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }

        [StringLength(50)]
        public string RoomId { get; set; }

        [StringLength(50)]
        public string Message_body { get; set; }

        public DateTime CreateAt { get; set; }
    }
}
