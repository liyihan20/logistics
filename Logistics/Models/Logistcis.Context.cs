﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logistics.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class LogisticsEntities : DbContext
    {
        public LogisticsEntities()
            : base("name=LogisticsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ei_users> ei_users { get; set; }
        public DbSet<vw_lg_users> vw_lg_users { get; set; }
        public DbSet<lg_event_log> lg_event_log { get; set; }
        public DbSet<lg_carLocation> lg_carLocation { get; set; }
        public DbSet<vw_lg_cardBord> vw_lg_cardBord { get; set; }
        public DbSet<vw_lg_localInfo> vw_lg_localInfo { get; set; }
        public DbSet<vw_lg_truckPermition> vw_lg_truckPermition { get; set; }
    
        public virtual ObjectResult<string> GetHREmpStatus(string card_no)
        {
            var card_noParameter = card_no != null ?
                new ObjectParameter("card_no", card_no) :
                new ObjectParameter("card_no", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetHREmpStatus", card_noParameter);
        }
    
        public virtual int UpdateLgPDAUser(string card_no, Nullable<int> fail_times, Nullable<System.DateTime> last_login_date, Nullable<bool> active_flag)
        {
            var card_noParameter = card_no != null ?
                new ObjectParameter("card_no", card_no) :
                new ObjectParameter("card_no", typeof(string));
    
            var fail_timesParameter = fail_times.HasValue ?
                new ObjectParameter("fail_times", fail_times) :
                new ObjectParameter("fail_times", typeof(int));
    
            var last_login_dateParameter = last_login_date.HasValue ?
                new ObjectParameter("last_login_date", last_login_date) :
                new ObjectParameter("last_login_date", typeof(System.DateTime));
    
            var active_flagParameter = active_flag.HasValue ?
                new ObjectParameter("active_flag", active_flag) :
                new ObjectParameter("active_flag", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateLgPDAUser", card_noParameter, fail_timesParameter, last_login_dateParameter, active_flagParameter);
        }
    
        public virtual int UpdatePDAPassword(string card_no, string new_pass)
        {
            var card_noParameter = card_no != null ?
                new ObjectParameter("card_no", card_no) :
                new ObjectParameter("card_no", typeof(string));
    
            var new_passParameter = new_pass != null ?
                new ObjectParameter("new_pass", new_pass) :
                new ObjectParameter("new_pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdatePDAPassword", card_noParameter, new_passParameter);
        }
    
        public virtual int UpdateLgCardInfo(Nullable<int> id, string user_no, string user_name, string op_type, string car_no)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var user_noParameter = user_no != null ?
                new ObjectParameter("user_no", user_no) :
                new ObjectParameter("user_no", typeof(string));
    
            var user_nameParameter = user_name != null ?
                new ObjectParameter("user_name", user_name) :
                new ObjectParameter("user_name", typeof(string));
    
            var op_typeParameter = op_type != null ?
                new ObjectParameter("op_type", op_type) :
                new ObjectParameter("op_type", typeof(string));
    
            var car_noParameter = car_no != null ?
                new ObjectParameter("car_no", car_no) :
                new ObjectParameter("car_no", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateLgCardInfo", idParameter, user_noParameter, user_nameParameter, op_typeParameter, car_noParameter);
        }
    
        public virtual int UpdateLgDefaultLoc(string card_no, string loc)
        {
            var card_noParameter = card_no != null ?
                new ObjectParameter("card_no", card_no) :
                new ObjectParameter("card_no", typeof(string));
    
            var locParameter = loc != null ?
                new ObjectParameter("loc", loc) :
                new ObjectParameter("loc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateLgDefaultLoc", card_noParameter, locParameter);
        }
    
        public virtual int AuditLgReturnCard(string cardNo, string user_no, string user_name, string status)
        {
            var cardNoParameter = cardNo != null ?
                new ObjectParameter("cardNo", cardNo) :
                new ObjectParameter("cardNo", typeof(string));
    
            var user_noParameter = user_no != null ?
                new ObjectParameter("user_no", user_no) :
                new ObjectParameter("user_no", typeof(string));
    
            var user_nameParameter = user_name != null ?
                new ObjectParameter("user_name", user_name) :
                new ObjectParameter("user_name", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AuditLgReturnCard", cardNoParameter, user_noParameter, user_nameParameter, statusParameter);
        }
    
        public virtual ObjectResult<GetLGFinishPermition_Result> GetLGFinishPermition(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate, string searchText, string auditorName)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("fromDate", fromDate) :
                new ObjectParameter("fromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("toDate", toDate) :
                new ObjectParameter("toDate", typeof(System.DateTime));
    
            var searchTextParameter = searchText != null ?
                new ObjectParameter("searchText", searchText) :
                new ObjectParameter("searchText", typeof(string));
    
            var auditorNameParameter = auditorName != null ?
                new ObjectParameter("auditorName", auditorName) :
                new ObjectParameter("auditorName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetLGFinishPermition_Result>("GetLGFinishPermition", fromDateParameter, toDateParameter, searchTextParameter, auditorNameParameter);
        }
    
        public virtual int AuditLGTruckPermition(string account, Nullable<int> id, string checker, Nullable<int> status, string opinion)
        {
            var accountParameter = account != null ?
                new ObjectParameter("account", account) :
                new ObjectParameter("account", typeof(string));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var checkerParameter = checker != null ?
                new ObjectParameter("checker", checker) :
                new ObjectParameter("checker", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            var opinionParameter = opinion != null ?
                new ObjectParameter("opinion", opinion) :
                new ObjectParameter("opinion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AuditLGTruckPermition", accountParameter, idParameter, checkerParameter, statusParameter, opinionParameter);
        }
    }
}
