using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectedBus.Models
{
    public class ModelBase : IHaveAnId
    {
        public int Id { get; set; }
    }
}
