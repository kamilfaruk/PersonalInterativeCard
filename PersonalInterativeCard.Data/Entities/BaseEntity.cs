using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInterativeCard.Data.Entities
{
    /// <summary>
    /// Tüm entity modellerimizde kalıtım yoluyla kullanılır. Abstract  yaparak new() ile oluşturulması engellenir.
    /// </summary>
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime? UpdatedTime { get; set; }
    }
}
