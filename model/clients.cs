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
    
    public partial class clients
    {
        public clients()
        {
            this.clientsHotels = new HashSet<clientsHotels>();
            this.clientsTours = new HashSet<clientsTours>();
        }
    
        public long client_id { get; set; }
        public string clientName { get; set; }
        public string clientSirname { get; set; }
        public string clientAdress { get; set; }
        public string clientPhoneNumber { get; set; }
        public int PassportNumber { get; set; }
        public int PassportSeries { get; set; }
        public string email { get; set; }
        public long authorisation_id { get; set; }
    
        public virtual authorisation authorisation { get; set; }
        public virtual ICollection<clientsHotels> clientsHotels { get; set; }
        public virtual ICollection<clientsTours> clientsTours { get; set; }
    }
}
