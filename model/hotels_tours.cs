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
    
    public partial class hotels_tours
    {
        public long hotel_id { get; set; }
        public long tour_id { get; set; }
        public long hotel_tour_id { get; set; }
    
        public virtual hotels hotels { get; set; }
        public virtual tours tours { get; set; }
    }
}
