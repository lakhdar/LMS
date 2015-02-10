namespace Application.DTOs
{
    using Domain.Core;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class ListWithTotalDTO
    {
        public int Total { get; set; }
        public IEnumerable<EntityBase> List { get; set; } 
    }
}
