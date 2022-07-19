using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInterativeCard.Data.Entities
{
    public class Card : BaseEntity
    {
        public string ViewLink { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string MailAddress { get; set; }
        public string InstagramLink{ get; set; }
        public string FacebookLink { get; set; }
        //TODO: Herşey hazır olduktan sonra bu kısım çoğaltılacak...
    }
}
