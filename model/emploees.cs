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
    
    public partial class emploees
    {
        public emploees()
        {
            this.tourEmploees = new HashSet<tourEmploees>();
        }
    
        public long emploee_id { get; set; }
        public long speciality_id { get; set; }
        public string emploeeFirstName { get; set; }
        public string emploeeSirname { get; set; }
        public string emploeeAdress { get; set; }
        public int emploeePassportNumber { get; set; }
        public int emploeePassportSeries { get; set; }
        public decimal emploeeStavka { get; set; }
        public Nullable<long> authorisation_id { get; set; }
    
        public virtual authorisation authorisation { get; set; }
        public virtual specialities specialities { get; set; }
        public virtual ICollection<tourEmploees> tourEmploees { get; set; }
    }
}