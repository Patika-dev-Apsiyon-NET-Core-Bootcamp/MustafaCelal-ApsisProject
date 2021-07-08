using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Flat : Entity
    {
        public string Block { get; set; }
        public bool IsEmpty { get; set; }
        public string RoomType { get; set; }
        public int FloorNo { get; set; }
        public int FlatNo { get; set; }
        
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual User User { get; set; }
        

    }
}
