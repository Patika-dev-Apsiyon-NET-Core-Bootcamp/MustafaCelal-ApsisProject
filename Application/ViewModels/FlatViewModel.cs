using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class FlatViewModel
    {
        public string Block { get; set; }
        public bool IsEmpty { get; set; }
        public string RoomType { get; set; }
        public int FloorNo { get; set; }
        public int FlatNo { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
    }
}
