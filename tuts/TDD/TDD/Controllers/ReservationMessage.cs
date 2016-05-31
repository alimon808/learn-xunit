using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Controllers
{
    public class ReservationMessage
    {
        public ReservationMessage(DateTime pickupDate)
        {
            if (pickupDate < SystemTime.Now())
            {
                throw new ArgumentException("Pickup date can't be in the past", "pickupDate");
            }

            PickupDate = pickupDate;
        }

        public DateTime PickupDate { get; set; }
    }
}
