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
    
    public partial class airlines
    {
        public airlines()
        {
            this.tours = new HashSet<tours>();
        }
    
        public long airlines_id { get; set; }
        public string airlineName { get; set; }
    
        public virtual ICollection<tours> tours { get; set; }
    }
}