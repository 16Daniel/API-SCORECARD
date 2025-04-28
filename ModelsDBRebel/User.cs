using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class User
    {
        public User()
        {
            Alarms = new HashSet<Alarm>();
            BanosMatutino1s = new HashSet<BanosMatutino1>();
            BanosMatutinos = new HashSet<BanosMatutino>();
            CashRegisterShortages = new HashSet<CashRegisterShortage>();
            CatPartBranchCreatedByNavigations = new HashSet<CatPartBranch>();
            CatPartBranchUpdatedByNavigations = new HashSet<CatPartBranch>();
            CatSpecificSectionCreatedByNavigations = new HashSet<CatSpecificSection>();
            CatSpecificSectionUpdatedByNavigations = new HashSet<CatSpecificSection>();
            CatStatusAlbaranCreatedByNavigations = new HashSet<CatStatusAlbaran>();
            CatStatusAlbaranUpdatedByNavigations = new HashSet<CatStatusAlbaran>();
            CatStatusTicketCreatedByNavigations = new HashSet<CatStatusTicket>();
            CatStatusTicketUpdatedByNavigations = new HashSet<CatStatusTicket>();
            CatStatusValidateAttendances = new HashSet<CatStatusValidateAttendance>();
            CatSucursals = new HashSet<CatSucursal>();
            CompleteProductsInOrders = new HashSet<CompleteProductsInOrder>();
            Fridges = new HashSet<Fridge>();
            FryerCleanings = new HashSet<FryerCleaning>();
            Inventarios = new HashSet<Inventario>();
            LivingRoomBathroomCleanings = new HashSet<LivingRoomBathroomCleaning>();
            Orders = new HashSet<Order>();
            PhotoCashRegisterShortages = new HashSet<PhotoCashRegisterShortage>();
            PhotoLivingRoomBathroomCleanings = new HashSet<PhotoLivingRoomBathroomCleaning>();
            PhotoTabletSageKeepings = new HashSet<PhotoTabletSageKeeping>();
            PhotoTips = new HashSet<PhotoTip>();
            PhotoValidationGas = new HashSet<PhotoValidationGa>();
            PhotoWaitlistTables = new HashSet<PhotoWaitlistTable>();
            PrecookedChickens = new HashSet<PrecookedChicken>();
            RequestTransfers = new HashSet<RequestTransfer>();
            RiskProducts = new HashSet<RiskProduct>();
            StockChickeUseds = new HashSet<StockChickeUsed>();
            StockChickenByBranchCreatedByNavigations = new HashSet<StockChickenByBranch>();
            StockChickenByBranchUpdatedByNavigations = new HashSet<StockChickenByBranch>();
            StockChickenCreatedByNavigations = new HashSet<StockChicken>();
            StockChickenUpdatedByNavigations = new HashSet<StockChicken>();
            TabletSafeKeepings = new HashSet<TabletSafeKeeping>();
            TaskCreatedByNavigations = new HashSet<Task>();
            TaskUpdatedByNavigations = new HashSet<Task>();
            TicketCreatedByNavigations = new HashSet<Ticket>();
            TicketUpdatedByNavigations = new HashSet<Ticket>();
            Ticketings = new HashSet<Ticketing>();
            Tips = new HashSet<Tip>();
            ToSetTables = new HashSet<ToSetTable>();
            ValidateAttendances = new HashSet<ValidateAttendance>();
            ValidationGas = new HashSet<ValidationGa>();
            WaitlistTables = new HashSet<WaitlistTable>();
        }

        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int? ClabTrab { get; set; }
        public string Token { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string MotherName { get; set; } = null!;
        public int RoleId { get; set; }
        public int? StateId { get; set; }
        public int? SucursalId { get; set; }
        public int? BranchId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CatRole Role { get; set; } = null!;
        public virtual CatState? State { get; set; }
        public virtual ICollection<Alarm> Alarms { get; set; }
        public virtual ICollection<BanosMatutino1> BanosMatutino1s { get; set; }
        public virtual ICollection<BanosMatutino> BanosMatutinos { get; set; }
        public virtual ICollection<CashRegisterShortage> CashRegisterShortages { get; set; }
        public virtual ICollection<CatPartBranch> CatPartBranchCreatedByNavigations { get; set; }
        public virtual ICollection<CatPartBranch> CatPartBranchUpdatedByNavigations { get; set; }
        public virtual ICollection<CatSpecificSection> CatSpecificSectionCreatedByNavigations { get; set; }
        public virtual ICollection<CatSpecificSection> CatSpecificSectionUpdatedByNavigations { get; set; }
        public virtual ICollection<CatStatusAlbaran> CatStatusAlbaranCreatedByNavigations { get; set; }
        public virtual ICollection<CatStatusAlbaran> CatStatusAlbaranUpdatedByNavigations { get; set; }
        public virtual ICollection<CatStatusTicket> CatStatusTicketCreatedByNavigations { get; set; }
        public virtual ICollection<CatStatusTicket> CatStatusTicketUpdatedByNavigations { get; set; }
        public virtual ICollection<CatStatusValidateAttendance> CatStatusValidateAttendances { get; set; }
        public virtual ICollection<CatSucursal> CatSucursals { get; set; }
        public virtual ICollection<CompleteProductsInOrder> CompleteProductsInOrders { get; set; }
        public virtual ICollection<Fridge> Fridges { get; set; }
        public virtual ICollection<FryerCleaning> FryerCleanings { get; set; }
        public virtual ICollection<Inventario> Inventarios { get; set; }
        public virtual ICollection<LivingRoomBathroomCleaning> LivingRoomBathroomCleanings { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PhotoCashRegisterShortage> PhotoCashRegisterShortages { get; set; }
        public virtual ICollection<PhotoLivingRoomBathroomCleaning> PhotoLivingRoomBathroomCleanings { get; set; }
        public virtual ICollection<PhotoTabletSageKeeping> PhotoTabletSageKeepings { get; set; }
        public virtual ICollection<PhotoTip> PhotoTips { get; set; }
        public virtual ICollection<PhotoValidationGa> PhotoValidationGas { get; set; }
        public virtual ICollection<PhotoWaitlistTable> PhotoWaitlistTables { get; set; }
        public virtual ICollection<PrecookedChicken> PrecookedChickens { get; set; }
        public virtual ICollection<RequestTransfer> RequestTransfers { get; set; }
        public virtual ICollection<RiskProduct> RiskProducts { get; set; }
        public virtual ICollection<StockChickeUsed> StockChickeUseds { get; set; }
        public virtual ICollection<StockChickenByBranch> StockChickenByBranchCreatedByNavigations { get; set; }
        public virtual ICollection<StockChickenByBranch> StockChickenByBranchUpdatedByNavigations { get; set; }
        public virtual ICollection<StockChicken> StockChickenCreatedByNavigations { get; set; }
        public virtual ICollection<StockChicken> StockChickenUpdatedByNavigations { get; set; }
        public virtual ICollection<TabletSafeKeeping> TabletSafeKeepings { get; set; }
        public virtual ICollection<Task> TaskCreatedByNavigations { get; set; }
        public virtual ICollection<Task> TaskUpdatedByNavigations { get; set; }
        public virtual ICollection<Ticket> TicketCreatedByNavigations { get; set; }
        public virtual ICollection<Ticket> TicketUpdatedByNavigations { get; set; }
        public virtual ICollection<Ticketing> Ticketings { get; set; }
        public virtual ICollection<Tip> Tips { get; set; }
        public virtual ICollection<ToSetTable> ToSetTables { get; set; }
        public virtual ICollection<ValidateAttendance> ValidateAttendances { get; set; }
        public virtual ICollection<ValidationGa> ValidationGas { get; set; }
        public virtual ICollection<WaitlistTable> WaitlistTables { get; set; }
    }
}
