//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelBookingSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class checkIn
    {
        public int id { get; set; }
        public int lodger_id { get; set; }
        public int room_id { get; set; }
        public int hotel_id { get; set; }
        public System.DateTime checkIn_date { get; set; }
        public double total_cost { get; set; }
        public System.DateTime checkOut_date { get; set; }
    }
}