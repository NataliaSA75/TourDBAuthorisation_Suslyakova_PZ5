//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace db3.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class hotels
    {
        public hotels()
        {
            this.clientsHotels = new HashSet<clientsHotels>();
            this.hotels_tours = new HashSet<hotels_tours>();
            this.rooms = new HashSet<rooms>();
        }
    
        public long hotel_id { get; set; }
        public long kurort_id { get; set; }
        public string hotel { get; set; }
        public long status_id { get; set; }
        public string description { get; set; }
        public string adress { get; set; }
        public string phoneNumber { get; set; }
    
        public virtual ICollection<clientsHotels> clientsHotels { get; set; }
        public virtual ICollection<hotels_tours> hotels_tours { get; set; }
        public virtual kurorts kurorts { get; set; }
        public virtual statuses statuses { get; set; }
        public virtual ICollection<rooms> rooms { get; set; }
    }
}
