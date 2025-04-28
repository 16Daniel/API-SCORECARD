using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DashboardApi.ModelsDBRebel
{
    public partial class DBRebelContext : DbContext
    {
        public DBRebelContext()
        {
        }

        public DBRebelContext(DbContextOptions<DBRebelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alarm> Alarms { get; set; } = null!;
        public virtual DbSet<Albaran> Albarans { get; set; } = null!;
        public virtual DbSet<AudioVideo> AudioVideos { get; set; } = null!;
        public virtual DbSet<BanosMatutino> BanosMatutinos { get; set; } = null!;
        public virtual DbSet<BanosMatutino1> BanosMatutinos1 { get; set; } = null!;
        public virtual DbSet<Bar> Bars { get; set; } = null!;
        public virtual DbSet<BarCleaning> BarCleanings { get; set; } = null!;
        public virtual DbSet<BathRoomsOverallStatus> BathRoomsOverallStatuses { get; set; } = null!;
        public virtual DbSet<Bathroom> Bathrooms { get; set; } = null!;
        public virtual DbSet<CashRegisterShortage> CashRegisterShortages { get; set; } = null!;
        public virtual DbSet<CatAmount> CatAmounts { get; set; } = null!;
        public virtual DbSet<CatAssignedTo> CatAssignedTos { get; set; } = null!;
        public virtual DbSet<CatBranchLocate> CatBranchLocates { get; set; } = null!;
        public virtual DbSet<CatMenu> CatMenus { get; set; } = null!;
        public virtual DbSet<CatPartBranch> CatPartBranches { get; set; } = null!;
        public virtual DbSet<CatRole> CatRoles { get; set; } = null!;
        public virtual DbSet<CatSection> CatSections { get; set; } = null!;
        public virtual DbSet<CatSpecificSection> CatSpecificSections { get; set; } = null!;
        public virtual DbSet<CatState> CatStates { get; set; } = null!;
        public virtual DbSet<CatStatusAlbaran> CatStatusAlbarans { get; set; } = null!;
        public virtual DbSet<CatStatusRequestTransfer> CatStatusRequestTransfers { get; set; } = null!;
        public virtual DbSet<CatStatusStockChicken> CatStatusStockChickens { get; set; } = null!;
        public virtual DbSet<CatStatusTicket> CatStatusTickets { get; set; } = null!;
        public virtual DbSet<CatStatusValidateAttendance> CatStatusValidateAttendances { get; set; } = null!;
        public virtual DbSet<CatSubMenu> CatSubMenus { get; set; } = null!;
        public virtual DbSet<CatSucursal> CatSucursals { get; set; } = null!;
        public virtual DbSet<CatTicketing> CatTicketings { get; set; } = null!;
        public virtual DbSet<CatTypeField> CatTypeFields { get; set; } = null!;
        public virtual DbSet<CatWorkShift> CatWorkShifts { get; set; } = null!;
        public virtual DbSet<CheckTable> CheckTables { get; set; } = null!;
        public virtual DbSet<CommentTicketing> CommentTicketings { get; set; } = null!;
        public virtual DbSet<CompleteProductsInOrder> CompleteProductsInOrders { get; set; } = null!;
        public virtual DbSet<DrinksTemperature> DrinksTemperatures { get; set; } = null!;
        public virtual DbSet<EntriesChargedAsDeliveryNote> EntriesChargedAsDeliveryNotes { get; set; } = null!;
        public virtual DbSet<FormField> FormFields { get; set; } = null!;
        public virtual DbSet<Fridge> Fridges { get; set; } = null!;
        public virtual DbSet<FridgeSalon> FridgeSalons { get; set; } = null!;
        public virtual DbSet<FryerCleaning> FryerCleanings { get; set; } = null!;
        public virtual DbSet<GeneralCleaning> GeneralCleanings { get; set; } = null!;
        public virtual DbSet<Inventario> Inventarios { get; set; } = null!;
        public virtual DbSet<InventarioMensual> InventarioMensuals { get; set; } = null!;
        public virtual DbSet<InventarioMensualRegistro> InventarioMensualRegistros { get; set; } = null!;
        public virtual DbSet<It25pt> It25pts { get; set; } = null!;
        public virtual DbSet<ItMerma> ItMermas { get; set; } = null!;
        public virtual DbSet<ItTiempo> ItTiempos { get; set; } = null!;
        public virtual DbSet<Kitchen> Kitchens { get; set; } = null!;
        public virtual DbSet<LivingRoomBathroomCleaning> LivingRoomBathroomCleanings { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderScheduleReview> OrderScheduleReviews { get; set; } = null!;
        public virtual DbSet<PeopleCounting> PeopleCountings { get; set; } = null!;
        public virtual DbSet<Permission> Permissions { get; set; } = null!;
        public virtual DbSet<PhotoAlarm> PhotoAlarms { get; set; } = null!;
        public virtual DbSet<PhotoAudioVideo> PhotoAudioVideos { get; set; } = null!;
        public virtual DbSet<PhotoBanosMatutino> PhotoBanosMatutinos { get; set; } = null!;
        public virtual DbSet<PhotoBar> PhotoBars { get; set; } = null!;
        public virtual DbSet<PhotoBarCleaning> PhotoBarCleanings { get; set; } = null!;
        public virtual DbSet<PhotoBathRoomsOverallStatus> PhotoBathRoomsOverallStatuses { get; set; } = null!;
        public virtual DbSet<PhotoBathroom> PhotoBathrooms { get; set; } = null!;
        public virtual DbSet<PhotoCashRegisterShortage> PhotoCashRegisterShortages { get; set; } = null!;
        public virtual DbSet<PhotoCompleteProductsInOrder> PhotoCompleteProductsInOrders { get; set; } = null!;
        public virtual DbSet<PhotoDrinksTemperature> PhotoDrinksTemperatures { get; set; } = null!;
        public virtual DbSet<PhotoEntriesChargedAsDeliveryNote> PhotoEntriesChargedAsDeliveryNotes { get; set; } = null!;
        public virtual DbSet<PhotoFridge> PhotoFridges { get; set; } = null!;
        public virtual DbSet<PhotoFridgeSalon> PhotoFridgeSalons { get; set; } = null!;
        public virtual DbSet<PhotoFryerCleaning> PhotoFryerCleanings { get; set; } = null!;
        public virtual DbSet<PhotoGeneralCleaning> PhotoGeneralCleanings { get; set; } = null!;
        public virtual DbSet<PhotoKitchen> PhotoKitchens { get; set; } = null!;
        public virtual DbSet<PhotoLivingRoomBathroomCleaning> PhotoLivingRoomBathroomCleanings { get; set; } = null!;
        public virtual DbSet<PhotoOrder> PhotoOrders { get; set; } = null!;
        public virtual DbSet<PhotoOrderScheduleReview> PhotoOrderScheduleReviews { get; set; } = null!;
        public virtual DbSet<PhotoPeopleCounting> PhotoPeopleCountings { get; set; } = null!;
        public virtual DbSet<PhotoPrecookedChicken> PhotoPrecookedChickens { get; set; } = null!;
        public virtual DbSet<PhotoSalon> PhotoSalons { get; set; } = null!;
        public virtual DbSet<PhotoSatisfactionSurvey> PhotoSatisfactionSurveys { get; set; } = null!;
        public virtual DbSet<PhotoSpotlight> PhotoSpotlights { get; set; } = null!;
        public virtual DbSet<PhotoStation> PhotoStations { get; set; } = null!;
        public virtual DbSet<PhotoTabletSageKeeping> PhotoTabletSageKeepings { get; set; } = null!;
        public virtual DbSet<PhotoTicket> PhotoTickets { get; set; } = null!;
        public virtual DbSet<PhotoTicketTable> PhotoTicketTables { get; set; } = null!;
        public virtual DbSet<PhotoTicketing> PhotoTicketings { get; set; } = null!;
        public virtual DbSet<PhotoTip> PhotoTips { get; set; } = null!;
        public virtual DbSet<PhotoToSetTable> PhotoToSetTables { get; set; } = null!;
        public virtual DbSet<PhotoValidateAttendance> PhotoValidateAttendances { get; set; } = null!;
        public virtual DbSet<PhotoValidationGa> PhotoValidationGas { get; set; } = null!;
        public virtual DbSet<PhotoWaitlistTable> PhotoWaitlistTables { get; set; } = null!;
        public virtual DbSet<PhotoWashBasinWithSoapPaper> PhotoWashBasinWithSoapPapers { get; set; } = null!;
        public virtual DbSet<PrecookedChicken> PrecookedChickens { get; set; } = null!;
        public virtual DbSet<ReporteMensualTemp> ReporteMensualTemps { get; set; } = null!;
        public virtual DbSet<RequestTransfer> RequestTransfers { get; set; } = null!;
        public virtual DbSet<RhRegionalesHistorial> RhRegionalesHistorials { get; set; } = null!;
        public virtual DbSet<RiskProduct> RiskProducts { get; set; } = null!;
        public virtual DbSet<Salon> Salons { get; set; } = null!;
        public virtual DbSet<SatisfactionSurvey> SatisfactionSurveys { get; set; } = null!;
        public virtual DbSet<Spotlight> Spotlights { get; set; } = null!;
        public virtual DbSet<Station> Stations { get; set; } = null!;
        public virtual DbSet<StockChickeUsed> StockChickeUseds { get; set; } = null!;
        public virtual DbSet<StockChicken> StockChickens { get; set; } = null!;
        public virtual DbSet<StockChickenByBranch> StockChickenByBranches { get; set; } = null!;
        public virtual DbSet<TabletSafeKeeping> TabletSafeKeepings { get; set; } = null!;
        public virtual DbSet<Task> Tasks { get; set; } = null!;
        public virtual DbSet<TaskBranch> TaskBranches { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;
        public virtual DbSet<TicketTable> TicketTables { get; set; } = null!;
        public virtual DbSet<Ticketing> Ticketings { get; set; } = null!;
        public virtual DbSet<Tip> Tips { get; set; } = null!;
        public virtual DbSet<ToSetTable> ToSetTables { get; set; } = null!;
        public virtual DbSet<UbicacionesInventario> UbicacionesInventarios { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<ValidateAttendance> ValidateAttendances { get; set; } = null!;
        public virtual DbSet<ValidationGa> ValidationGas { get; set; } = null!;
        public virtual DbSet<WaitlistTable> WaitlistTables { get; set; } = null!;
        public virtual DbSet<WashBasinWithSoapPaper> WashBasinWithSoapPapers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.11.102;Initial Catalog=db_rebel_wings;Integrated Security=False;User Id=App2;Password=cqfYTj1diWmYUveF;MultipleActiveResultSets=True;Connection Timeout=120000");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alarm>(entity =>
            {
                entity.ToTable("Alarm");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Colaborador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("colaborador");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LitrosF1)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("litros_f1");

                entity.Property(e => e.LitrosF2)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("litros_f2");

                entity.Property(e => e.LitrosF3)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("litros_f3");

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supervisor");

                entity.Property(e => e.TipoF1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo_f1");

                entity.Property(e => e.TipoF2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo_f2");

                entity.Property(e => e.TipoF3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo_f3");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Alarms)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alarm_Users");
            });

            modelBuilder.Entity<Albaran>(entity =>
            {
                entity.ToTable("Albaran");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AlbaranDate)
                    .HasColumnType("date")
                    .HasColumnName("albaran_date");

                entity.Property(e => e.AlbaranDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("albaran_description");

                entity.Property(e => e.AlbaranTime).HasColumnName("albaran_time");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.N)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("n");

                entity.Property(e => e.NumAlbaran).HasColumnName("num_albaran");

                entity.Property(e => e.NumSerie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("num_serie");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TimeArrive).HasColumnName("time_arrive");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Albarans)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Albaran_Cat_Status_Albaran");
            });

            modelBuilder.Entity<AudioVideo>(entity =>
            {
                entity.ToTable("Audio_Video");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CommentSpeakersWorkProperly)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_speakers_work_properly");

                entity.Property(e => e.CommentTerraceSpeakersWorkProperly)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_terrace_speakers_work_properly");

                entity.Property(e => e.CommentTerraceTvWorksProperly)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_terrace_tv_works_properly");

                entity.Property(e => e.CommentTvWorksProperly)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_tv_works_properly");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.SpeakersWorkProperly).HasColumnName("speakers_work_properly");

                entity.Property(e => e.TerraceSpeakersWorkProperly).HasColumnName("terrace_speakers_work_properly");

                entity.Property(e => e.TerraceTvWorksProperly).HasColumnName("terrace_tv_works_properly");

                entity.Property(e => e.TvWorksProperly).HasColumnName("tv_works_properly");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<BanosMatutino>(entity =>
            {
                entity.ToTable("Banos_Matutino");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BanosMatutinos)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Banos_Matutino_Users");
            });

            modelBuilder.Entity<BanosMatutino1>(entity =>
            {
                entity.ToTable("Banos_Matutinos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BanosMatutino1s)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Banos_Matutinos_Users");
            });

            modelBuilder.Entity<Bar>(entity =>
            {
                entity.ToTable("Bar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CommentElectricalConnections)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_electrical_connections");

                entity.Property(e => e.CommentMixer)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_mixer");

                entity.Property(e => e.CommentRefrigerator)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_refrigerator");

                entity.Property(e => e.CommentSink)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_sink");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.ElectricalConnections).HasColumnName("electrical_connections");

                entity.Property(e => e.Mixer).HasColumnName("mixer");

                entity.Property(e => e.Refrigerator).HasColumnName("refrigerator");

                entity.Property(e => e.Sink).HasColumnName("sink");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<BarCleaning>(entity =>
            {
                entity.ToTable("Bar_Cleaning");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.IsClean).HasColumnName("is_clean");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<BathRoomsOverallStatus>(entity =>
            {
                entity.ToTable("BathRooms_Overall_Status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CommentAreThereAnyFaultsMen)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_are_there_any_faults_men");

                entity.Property(e => e.CommentAreThereAnyFaultsWomen)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_are_there_any_faults_women");

                entity.Property(e => e.CommentDoesAnyBathroomLeakMen)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_does_any_bathroom_leak_men");

                entity.Property(e => e.CommentDoesAnyBathroomLeakWomen)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_does_any_bathroom_leak_women");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DoesAnyBathroomLeakMen).HasColumnName("does_any_bathroom_leak_men");

                entity.Property(e => e.DoesAnyBathroomLeakWomen).HasColumnName("does_any_bathroom_leak_women");

                entity.Property(e => e.IsThereAnyFaultsMen).HasColumnName("is_there_any_faults_men");

                entity.Property(e => e.IsThereAnyFaultsWomen).HasColumnName("is_there_any_faults_women");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<Bathroom>(entity =>
            {
                entity.ToTable("Bathroom");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CommentDoors)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_doors");

                entity.Property(e => e.CommentHandWashBasin)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_hand_wash_basin");

                entity.Property(e => e.CommentLuminaires)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_luminaires");

                entity.Property(e => e.CommentUrinals)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_urinals");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Doors).HasColumnName("doors");

                entity.Property(e => e.HandWashBasin).HasColumnName("hand_wash_basin");

                entity.Property(e => e.Luminaires).HasColumnName("luminaires");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.Property(e => e.Urinals).HasColumnName("urinals");
            });

            modelBuilder.Entity<CashRegisterShortage>(entity =>
            {
                entity.ToTable("Cash_Register_Shortage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AlarmTime)
                    .HasColumnType("datetime")
                    .HasColumnName("alarm_time");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CashRegisterShortages)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cash_Register_Shortage_Users");
            });

            modelBuilder.Entity<CatAmount>(entity =>
            {
                entity.ToTable("Cat_Amount");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("amount");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<CatAssignedTo>(entity =>
            {
                entity.ToTable("Cat_AssignedTo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssignedTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("assigned_to");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<CatBranchLocate>(entity =>
            {
                entity.ToTable("Cat_Branch_Locate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Locate)
                    .HasMaxLength(50)
                    .HasColumnName("locate");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<CatMenu>(entity =>
            {
                entity.ToTable("Cat_Menu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .UseCollation("Latin1_General_100_CI_AI");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<CatPartBranch>(entity =>
            {
                entity.ToTable("Cat_Part_Branch");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PartBranch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("part_branch");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CatPartBranchCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cat_Part_Branch_Users");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.CatPartBranchUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Cat_Part_Branch_Users1");
            });

            modelBuilder.Entity<CatRole>(entity =>
            {
                entity.ToTable("Cat_Role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Description)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("description")
                    .UseCollation("Latin1_General_100_CI_AI");

                entity.Property(e => e.Role)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("role")
                    .UseCollation("Latin1_General_100_CI_AI");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<CatSection>(entity =>
            {
                entity.ToTable("Cat_Section");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .UseCollation("Latin1_General_100_CI_AI");

                entity.Property(e => e.SubMenuId).HasColumnName("sub_menu_id");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.SubMenu)
                    .WithMany(p => p.CatSections)
                    .HasForeignKey(d => d.SubMenuId)
                    .HasConstraintName("FK_Cat_Section_Cat_Sub_Menu");
            });

            modelBuilder.Entity<CatSpecificSection>(entity =>
            {
                entity.ToTable("Cat_Specific_Section");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PartBranchId).HasColumnName("part_branch_id");

                entity.Property(e => e.SpecificSection)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("specific_section");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CatSpecificSectionCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cat_Specific_Section_Users");

                entity.HasOne(d => d.PartBranch)
                    .WithMany(p => p.CatSpecificSections)
                    .HasForeignKey(d => d.PartBranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cat_Specific_Section_Cat_Part_Branch");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.CatSpecificSectionUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Cat_Specific_Section_Users1");
            });

            modelBuilder.Entity<CatState>(entity =>
            {
                entity.ToTable("Cat_State");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<CatStatusAlbaran>(entity =>
            {
                entity.ToTable("Cat_Status_Albaran");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CatStatusAlbaranCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cat_Status_Albaran_Users");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.CatStatusAlbaranUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Cat_Status_Albaran_Users1");
            });

            modelBuilder.Entity<CatStatusRequestTransfer>(entity =>
            {
                entity.ToTable("Cat_Status_Request_Transfer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<CatStatusStockChicken>(entity =>
            {
                entity.ToTable("Cat_Status_Stock_Chicken");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<CatStatusTicket>(entity =>
            {
                entity.ToTable("Cat_Status_Ticket");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CatStatusTicketCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cat_Status_Ticket_Users");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.CatStatusTicketUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Cat_Status_Ticket_Users1");
            });

            modelBuilder.Entity<CatStatusValidateAttendance>(entity =>
            {
                entity.ToTable("Cat_Status_Validate_Attendance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CatStatusValidateAttendances)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cat_Status_Validate_Attendance_Users");
            });

            modelBuilder.Entity<CatSubMenu>(entity =>
            {
                entity.ToTable("Cat_Sub_Menu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.MenuId).HasColumnName("menu_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .UseCollation("Latin1_General_100_CI_AI");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.CatSubMenus)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_Cat_Sub_Menu_Cat_Menu");
            });

            modelBuilder.Entity<CatSucursal>(entity =>
            {
                entity.ToTable("Cat_Sucursal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.CatSucursals)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_Cat_Sucursal_Cat_State");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CatSucursals)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cat_Sucursal_Users");
            });

            modelBuilder.Entity<CatTicketing>(entity =>
            {
                entity.ToTable("Cat_Ticketing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<CatTypeField>(entity =>
            {
                entity.ToTable("Cat_Type_Field");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TypeField)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type_field");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<CatWorkShift>(entity =>
            {
                entity.ToTable("Cat_WorkShift");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.Property(e => e.Workshift)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("workshift");
            });

            modelBuilder.Entity<CheckTable>(entity =>
            {
                entity.ToTable("Check_Table");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CommentProductFour)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_product_four");

                entity.Property(e => e.CommentProductOne)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_product_one");

                entity.Property(e => e.CommentProductThree)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_product_three");

                entity.Property(e => e.CommentProductTwo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_product_two");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.NumTable).HasColumnName("num_table");

                entity.Property(e => e.ProductFour).HasColumnName("product_four");

                entity.Property(e => e.ProductOne).HasColumnName("product_one");

                entity.Property(e => e.ProductThree).HasColumnName("product_three");

                entity.Property(e => e.ProductTwo).HasColumnName("product_two");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<CommentTicketing>(entity =>
            {
                entity.ToTable("Comment_Ticketing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.TicketingId).HasColumnName("ticketing_id");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Ticketing)
                    .WithMany(p => p.CommentTicketings)
                    .HasForeignKey(d => d.TicketingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Ticketing_Ticketing");
            });

            modelBuilder.Entity<CompleteProductsInOrder>(entity =>
            {
                entity.ToTable("Complete_Products_In_Order");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CompleteProductsInOrders)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Complete_Products_In_Order_Users");
            });

            modelBuilder.Entity<DrinksTemperature>(entity =>
            {
                entity.ToTable("Drinks_Temperature");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Chope).HasColumnName("chope");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DarkBeer).HasColumnName("dark_beer");

                entity.Property(e => e.DrinkFive).HasColumnName("drink_five");

                entity.Property(e => e.DrinkFour).HasColumnName("drink_four");

                entity.Property(e => e.DrinkOne).HasColumnName("drink_one");

                entity.Property(e => e.DrinkThree).HasColumnName("drink_three");

                entity.Property(e => e.DrinkTwo).HasColumnName("drink_two");

                entity.Property(e => e.LightBeer).HasColumnName("light_beer");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<EntriesChargedAsDeliveryNote>(entity =>
            {
                entity.ToTable("Entries_Charged_As_Delivery_Note");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CommentDirectDeliveriesPerDay)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_direct_deliveries_per_day");

                entity.Property(e => e.CommentRevisionNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_revision_number");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.RevisionNumber).HasColumnName("revision_number");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<FormField>(entity =>
            {
                entity.ToTable("Form_Field");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Align)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("align");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NameField)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("name_field");

                entity.Property(e => e.TaskId).HasColumnName("task_id");

                entity.Property(e => e.TypeFieldId).HasColumnName("type_field_id");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.FormFields)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Form_Field_Task");

                entity.HasOne(d => d.TypeField)
                    .WithMany(p => p.FormFields)
                    .HasForeignKey(d => d.TypeFieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Form_Field_Cat_Type_Field");
            });

            modelBuilder.Entity<Fridge>(entity =>
            {
                entity.ToTable("Fridge");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Fridges)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fridges_Users");
            });

            modelBuilder.Entity<FridgeSalon>(entity =>
            {
                entity.ToTable("Fridge_Salon");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.LayOut).HasColumnName("lay_out");

                entity.Property(e => e.Shortage).HasColumnName("shortage");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<FryerCleaning>(entity =>
            {
                entity.ToTable("Fryer_Cleaning");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.FryerCleanings)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fryer_Cleaning_Users");
            });

            modelBuilder.Entity<GeneralCleaning>(entity =>
            {
                entity.ToTable("General_Cleaning");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CleaningBooths).HasColumnName("cleaning_booths");

                entity.Property(e => e.CleaningInBuckets).HasColumnName("cleaning_in_buckets");

                entity.Property(e => e.CleanlinessInSalon).HasColumnName("cleanliness_in_salon");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.TableN)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("table_n");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Articulo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("articulo");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Diferencia)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("diferencia");

                entity.Property(e => e.Intentos).HasColumnName("intentos");

                entity.Property(e => e.InvInicial)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("inv_inicial");

                entity.Property(e => e.InvReg)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("inv_reg");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Inventarios)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventarios_Users");
            });

            modelBuilder.Entity<InventarioMensual>(entity =>
            {
                entity.ToTable("Inventario_Mensual");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Codarticulo).HasColumnName("codarticulo");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Diferencia)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("diferencia");

                entity.Property(e => e.Medida)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("medida");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.Precio)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("precio");

                entity.Property(e => e.Procesado).HasColumnName("procesado");

                entity.Property(e => e.Referencia)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("referencia");

                entity.Property(e => e.Registro).HasColumnName("registro");

                entity.Property(e => e.StockAnt)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("stock_ant");

                entity.Property(e => e.Sucursal).HasColumnName("sucursal");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("tipo");

                entity.Property(e => e.Unidades)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("unidades");

                entity.Property(e => e.Valor)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<InventarioMensualRegistro>(entity =>
            {
                entity.ToTable("Inventario_Mensual_Registro");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Captura)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("captura");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.DateCaptura)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCaptura");

                entity.Property(e => e.Procesado).HasColumnName("procesado");

                entity.Property(e => e.Sucursal).HasColumnName("sucursal");
            });

            modelBuilder.Entity<It25pt>(entity =>
            {
                entity.ToTable("IT_25PTS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cobros).HasColumnName("COBROS");

                entity.Property(e => e.CobrosMinimos).HasColumnName("COBROS_MINIMOS");

                entity.Property(e => e.Codvendedor).HasColumnName("CODVENDEDOR");

                entity.Property(e => e.Diferencia).HasColumnName("DIFERENCIA");

                entity.Property(e => e.Fechaini)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAINI");

                entity.Property(e => e.Justificacion).HasColumnName("JUSTIFICACION");

                entity.Property(e => e.Mesa).HasColumnName("MESA");

                entity.Property(e => e.Sala).HasColumnName("SALA");

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(30)
                    .HasColumnName("SUCURSAL");

                entity.Property(e => e.TotalAyc).HasColumnName("TOTAL_AYC");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .HasColumnName("USUARIO");

                entity.Property(e => e.Vendedor).HasColumnName("VENDEDOR");
            });

            modelBuilder.Entity<ItMerma>(entity =>
            {
                entity.ToTable("IT_MERMAS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codarticulo).HasColumnName("CODARTICULO");

                entity.Property(e => e.Comentarios).HasColumnName("COMENTARIOS");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(45)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Justificacion).HasColumnName("JUSTIFICACION");

                entity.Property(e => e.Numero).HasColumnName("NUMERO");

                entity.Property(e => e.Precio).HasColumnName("PRECIO");

                entity.Property(e => e.Referencia)
                    .HasMaxLength(15)
                    .HasColumnName("REFERENCIA");

                entity.Property(e => e.Serie)
                    .HasMaxLength(4)
                    .HasColumnName("SERIE");

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(30)
                    .HasColumnName("SUCURSAL");

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .HasColumnName("USUARIO");
            });

            modelBuilder.Entity<ItTiempo>(entity =>
            {
                entity.ToTable("IT_TIEMPOS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codarticulo).HasColumnName("CODARTICULO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(45)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Entiempo)
                    .HasMaxLength(1)
                    .HasColumnName("ENTIEMPO")
                    .IsFixedLength();

                entity.Property(e => e.Hora)
                    .HasColumnType("datetime")
                    .HasColumnName("HORA");

                entity.Property(e => e.Idcomanda).HasColumnName("IDCOMANDA");

                entity.Property(e => e.Minutos).HasColumnName("MINUTOS");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.Posicion).HasColumnName("POSICION");

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(30)
                    .HasColumnName("SUCURSAL");

                entity.Property(e => e.Terminal)
                    .HasMaxLength(30)
                    .HasColumnName("TERMINAL");

                entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<Kitchen>(entity =>
            {
                entity.ToTable("Kitchen");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CommentCorrectDistance)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_correct_distance");

                entity.Property(e => e.CommentDoors)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_doors");

                entity.Property(e => e.CommentElectricalConnections)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_electrical_connections");

                entity.Property(e => e.CommentExtractor)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_extractor");

                entity.Property(e => e.CommentFryer)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_fryer");

                entity.Property(e => e.CommentInteriorTemperature)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_interior_temperature");

                entity.Property(e => e.CommentLuminaires)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_luminaires");

                entity.Property(e => e.CommentMixer)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_mixer");

                entity.Property(e => e.CommentRefrigerator)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_refrigerator");

                entity.Property(e => e.CommentSink)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_sink");

                entity.Property(e => e.CommentStrainer)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_strainer");

                entity.Property(e => e.CorrectDistance).HasColumnName("correct_distance");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Doors).HasColumnName("doors");

                entity.Property(e => e.ElectricalConnections).HasColumnName("electrical_connections");

                entity.Property(e => e.Extractor).HasColumnName("extractor");

                entity.Property(e => e.Fryer).HasColumnName("fryer");

                entity.Property(e => e.InteriorTemperature).HasColumnName("interior_temperature");

                entity.Property(e => e.Luminaires).HasColumnName("luminaires");

                entity.Property(e => e.Mixer).HasColumnName("mixer");

                entity.Property(e => e.Refrigerator).HasColumnName("refrigerator");

                entity.Property(e => e.Sink).HasColumnName("sink");

                entity.Property(e => e.Strainer).HasColumnName("strainer");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<LivingRoomBathroomCleaning>(entity =>
            {
                entity.ToTable("Living_Room_Bathroom_Cleaning");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.LivingRoomBathroomCleanings)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Living_Room_Bathroom_Cleaning_Users");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AverageTime).HasColumnName("average_time");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Users");
            });

            modelBuilder.Entity<OrderScheduleReview>(entity =>
            {
                entity.ToTable("Order_Schedule_Review");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<PeopleCounting>(entity =>
            {
                entity.ToTable("People_Counting");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Dinners).HasColumnName("dinners");

                entity.Property(e => e.Tables).HasColumnName("tables");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("Permission");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Deleting).HasColumnName("deleting");

                entity.Property(e => e.Editing).HasColumnName("editing");

                entity.Property(e => e.IdCatMenu).HasColumnName("id_cat_menu");

                entity.Property(e => e.IdCatSection).HasColumnName("id_cat_section");

                entity.Property(e => e.IdCatSubMenu).HasColumnName("id_cat_sub_menu");

                entity.Property(e => e.Reading).HasColumnName("reading");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Show).HasColumnName("show");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.Property(e => e.Writing).HasColumnName("writing");

                entity.HasOne(d => d.IdCatMenuNavigation)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.IdCatMenu)
                    .HasConstraintName("FK_Permission_Cat_Menu");

                entity.HasOne(d => d.IdCatSectionNavigation)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.IdCatSection)
                    .HasConstraintName("FK_Permission_Cat_Section");

                entity.HasOne(d => d.IdCatSubMenuNavigation)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.IdCatSubMenu)
                    .HasConstraintName("FK_Permission_Cat_Sub_Menu");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Permission_Cat_Role");
            });

            modelBuilder.Entity<PhotoAlarm>(entity =>
            {
                entity.ToTable("Photo_Alarm");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AlarmId).HasColumnName("alarm_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Alarm)
                    .WithMany(p => p.PhotoAlarms)
                    .HasForeignKey(d => d.AlarmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Alarm_Alarm");
            });

            modelBuilder.Entity<PhotoAudioVideo>(entity =>
            {
                entity.ToTable("Photo_AudioVideo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AudiovideoId).HasColumnName("audiovideo_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Audiovideo)
                    .WithMany(p => p.PhotoAudioVideos)
                    .HasForeignKey(d => d.AudiovideoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_AudioVideo_AudioVideo");
            });

            modelBuilder.Entity<PhotoBanosMatutino>(entity =>
            {
                entity.ToTable("Photo_Banos_Matutino");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BanosMatutinoId).HasColumnName("banos_matutino_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.BanosMatutino)
                    .WithMany(p => p.PhotoBanosMatutinos)
                    .HasForeignKey(d => d.BanosMatutinoId)
                    .HasConstraintName("FK_Photo_Banos_Matutino_Banos_Matutino");
            });

            modelBuilder.Entity<PhotoBar>(entity =>
            {
                entity.ToTable("Photo_Bar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BarId).HasColumnName("bar_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Bar)
                    .WithMany(p => p.PhotoBars)
                    .HasForeignKey(d => d.BarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Bar_Bar");
            });

            modelBuilder.Entity<PhotoBarCleaning>(entity =>
            {
                entity.ToTable("Photo_Bar_Cleaning");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BarCleaningId).HasColumnName("bar_cleaning_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.BarCleaning)
                    .WithMany(p => p.PhotoBarCleanings)
                    .HasForeignKey(d => d.BarCleaningId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Photo_Bar_Cleaning_Bar_Cleaning");
            });

            modelBuilder.Entity<PhotoBathRoomsOverallStatus>(entity =>
            {
                entity.ToTable("Photo_BathRoomsOverallStatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BathroomsoverallstatusId).HasColumnName("bathroomsoverallstatus_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Bathroomsoverallstatus)
                    .WithMany(p => p.PhotoBathRoomsOverallStatuses)
                    .HasForeignKey(d => d.BathroomsoverallstatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_BathRoomsOverallStatus_BathRoomsOverallStatus");
            });

            modelBuilder.Entity<PhotoBathroom>(entity =>
            {
                entity.ToTable("Photo_Bathroom");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BathroomId).HasColumnName("bathroom_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Bathroom)
                    .WithMany(p => p.PhotoBathrooms)
                    .HasForeignKey(d => d.BathroomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Bathroom_Bathroom");
            });

            modelBuilder.Entity<PhotoCashRegisterShortage>(entity =>
            {
                entity.ToTable("Photo_Cash_Register_Shortage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CashRegisterShortageId).HasColumnName("cash_register_shortage_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CashRegisterShortage)
                    .WithMany(p => p.PhotoCashRegisterShortages)
                    .HasForeignKey(d => d.CashRegisterShortageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Cash_Register_Shortage_Cash_Register_Shortage");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhotoCashRegisterShortages)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Cash_Register_Shortage_Users");
            });

            modelBuilder.Entity<PhotoCompleteProductsInOrder>(entity =>
            {
                entity.ToTable("Photo_Complete_Products_In_Order");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompleteProductsInOrderId).HasColumnName("complete_products_in_order_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CompleteProductsInOrder)
                    .WithMany(p => p.PhotoCompleteProductsInOrders)
                    .HasForeignKey(d => d.CompleteProductsInOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Complete_Products_In_Order_Complete_Products_In_Order");
            });

            modelBuilder.Entity<PhotoDrinksTemperature>(entity =>
            {
                entity.ToTable("Photo_Drinks_Temperature");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DrinkTemperatureId).HasColumnName("drink_temperature_id");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.DrinkTemperature)
                    .WithMany(p => p.PhotoDrinksTemperatures)
                    .HasForeignKey(d => d.DrinkTemperatureId)
                    .HasConstraintName("FK_Photo_Drinks_Temperature_Drinks_Temperature");
            });

            modelBuilder.Entity<PhotoEntriesChargedAsDeliveryNote>(entity =>
            {
                entity.ToTable("Photo_Entries_Charged_As_Delivery_Note");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.EntriesChargedAsDeliveryNoteId).HasColumnName("entries_charged_as_delivery_note_id");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.EntriesChargedAsDeliveryNote)
                    .WithMany(p => p.PhotoEntriesChargedAsDeliveryNotes)
                    .HasForeignKey(d => d.EntriesChargedAsDeliveryNoteId)
                    .HasConstraintName("FK_Photo_Entries_Charged_As_Delivery_Note_Entries_Charged_As_Delivery_Note");
            });

            modelBuilder.Entity<PhotoFridge>(entity =>
            {
                entity.ToTable("Photo_Fridge");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.FridgeId).HasColumnName("fridge_id");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Fridge)
                    .WithMany(p => p.PhotoFridges)
                    .HasForeignKey(d => d.FridgeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Fridge_Fridge");
            });

            modelBuilder.Entity<PhotoFridgeSalon>(entity =>
            {
                entity.ToTable("Photo_Fridge_Salon");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.FridgeSalonId).HasColumnName("fridge_salon_id");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.FridgeSalon)
                    .WithMany(p => p.PhotoFridgeSalons)
                    .HasForeignKey(d => d.FridgeSalonId)
                    .HasConstraintName("FK_Photo_Fridge_Salon_Fridge_Salon");
            });

            modelBuilder.Entity<PhotoFryerCleaning>(entity =>
            {
                entity.ToTable("Photo_Fryer_Cleaning");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.FryerCleaningId).HasColumnName("fryer_cleaning_id");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.FryerCleaning)
                    .WithMany(p => p.PhotoFryerCleanings)
                    .HasForeignKey(d => d.FryerCleaningId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Fryer_Cleaning_Fryer_Cleaning");
            });

            modelBuilder.Entity<PhotoGeneralCleaning>(entity =>
            {
                entity.ToTable("Photo_General_Cleaning");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.GeneralCleaningId).HasColumnName("general_cleaning_id");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.GeneralCleaning)
                    .WithMany(p => p.PhotoGeneralCleanings)
                    .HasForeignKey(d => d.GeneralCleaningId)
                    .HasConstraintName("FK_Photo_General_Cleaning_General_Cleaning");
            });

            modelBuilder.Entity<PhotoKitchen>(entity =>
            {
                entity.ToTable("Photo_Kitchen");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.KitchenId).HasColumnName("kitchen_id");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Kitchen)
                    .WithMany(p => p.PhotoKitchens)
                    .HasForeignKey(d => d.KitchenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Kitchen_Kitchen");
            });

            modelBuilder.Entity<PhotoLivingRoomBathroomCleaning>(entity =>
            {
                entity.ToTable("Photo_Living_Room_Bathroom_Cleaning");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LivingRoomBathroomCleaningId).HasColumnName("living_room_bathroom_cleaning_id");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhotoLivingRoomBathroomCleanings)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Living_Room_Bathroom_Cleaning_Users");

                entity.HasOne(d => d.LivingRoomBathroomCleaning)
                    .WithMany(p => p.PhotoLivingRoomBathroomCleanings)
                    .HasForeignKey(d => d.LivingRoomBathroomCleaningId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Living_Room_Bathroom_Cleaning_Living_Room_Bathroom_Cleaning");
            });

            modelBuilder.Entity<PhotoOrder>(entity =>
            {
                entity.ToTable("Photo_Order");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.PhotoOrders)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Order_Order");
            });

            modelBuilder.Entity<PhotoOrderScheduleReview>(entity =>
            {
                entity.ToTable("Photo_Order_Schedule_Review");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.OrderScheduleReviewId).HasColumnName("order_schedule_review_id");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.OrderScheduleReview)
                    .WithMany(p => p.PhotoOrderScheduleReviews)
                    .HasForeignKey(d => d.OrderScheduleReviewId)
                    .HasConstraintName("FK_Photo_Order_Schedule_Review_Order_Schedule_Review");
            });

            modelBuilder.Entity<PhotoPeopleCounting>(entity =>
            {
                entity.ToTable("Photo_People_Counting");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.PeopleId).HasColumnName("people_id");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.People)
                    .WithMany(p => p.PhotoPeopleCountings)
                    .HasForeignKey(d => d.PeopleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_People_Counting_People_Counting");
            });

            modelBuilder.Entity<PhotoPrecookedChicken>(entity =>
            {
                entity.ToTable("Photo_Precooked_Chicken");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.PrecookedChickenId).HasColumnName("precooked_chicken_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.PrecookedChicken)
                    .WithMany(p => p.PhotoPrecookedChickens)
                    .HasForeignKey(d => d.PrecookedChickenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Precooked_Chicken_Precooked_Chicken");
            });

            modelBuilder.Entity<PhotoSalon>(entity =>
            {
                entity.ToTable("Photo_Salon");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.SalonId).HasColumnName("salon_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Salon)
                    .WithMany(p => p.PhotoSalons)
                    .HasForeignKey(d => d.SalonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Salon_Salon");
            });

            modelBuilder.Entity<PhotoSatisfactionSurvey>(entity =>
            {
                entity.ToTable("Photo_SatisfactionSurvey");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.SatisfactionsurveyId).HasColumnName("satisfactionsurvey_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Satisfactionsurvey)
                    .WithMany(p => p.PhotoSatisfactionSurveys)
                    .HasForeignKey(d => d.SatisfactionsurveyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_SatisfactionSurvey_SatisfactionSurvey");
            });

            modelBuilder.Entity<PhotoSpotlight>(entity =>
            {
                entity.ToTable("Photo_Spotlight");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.SpotlightId).HasColumnName("spotlight_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Spotlight)
                    .WithMany(p => p.PhotoSpotlights)
                    .HasForeignKey(d => d.SpotlightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Spotlight_Spotlight");
            });

            modelBuilder.Entity<PhotoStation>(entity =>
            {
                entity.ToTable("Photo_Station");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.StationId).HasColumnName("station_id");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.PhotoStations)
                    .HasForeignKey(d => d.StationId)
                    .HasConstraintName("FK_Photo_Station_Station");
            });

            modelBuilder.Entity<PhotoTabletSageKeeping>(entity =>
            {
                entity.ToTable("Photo_Tablet_Sage_Keeping");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.TabletSafeKeepingId).HasColumnName("tablet_safe_keeping_id");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhotoTabletSageKeepings)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Tablet_Sage_Keeping_Users");

                entity.HasOne(d => d.TabletSafeKeeping)
                    .WithMany(p => p.PhotoTabletSageKeepings)
                    .HasForeignKey(d => d.TabletSafeKeepingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Tablet_Sage_Keeping_Tablet_Safe_Keeping");
            });

            modelBuilder.Entity<PhotoTicket>(entity =>
            {
                entity.ToTable("Photo_Ticket");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.TicketId).HasColumnName("ticket_id");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.PhotoTickets)
                    .HasForeignKey(d => d.TicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Ticket_Ticket");
            });

            modelBuilder.Entity<PhotoTicketTable>(entity =>
            {
                entity.ToTable("Photo_Ticket_Table");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.TicketTableId).HasColumnName("ticket_table_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.TicketTable)
                    .WithMany(p => p.PhotoTicketTables)
                    .HasForeignKey(d => d.TicketTableId)
                    .HasConstraintName("FK_Photo_Ticket_Table_Ticket_Table");
            });

            modelBuilder.Entity<PhotoTicketing>(entity =>
            {
                entity.ToTable("Photo_Ticketing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.TicketingId).HasColumnName("ticketing_id");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Ticketing)
                    .WithMany(p => p.PhotoTicketings)
                    .HasForeignKey(d => d.TicketingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Ticketing_Ticketing");
            });

            modelBuilder.Entity<PhotoTip>(entity =>
            {
                entity.ToTable("Photo_Tip");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.TipId).HasColumnName("tip_id");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhotoTips)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Tip_Users");

                entity.HasOne(d => d.Tip)
                    .WithMany(p => p.PhotoTips)
                    .HasForeignKey(d => d.TipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Tip_Tip");
            });

            modelBuilder.Entity<PhotoToSetTable>(entity =>
            {
                entity.ToTable("Photo_To_Set_Table");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.ToSetTableId).HasColumnName("to_set_table_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.ToSetTable)
                    .WithMany(p => p.PhotoToSetTables)
                    .HasForeignKey(d => d.ToSetTableId)
                    .HasConstraintName("FK_Photo_To_Set_Table_To_Set_Table");
            });

            modelBuilder.Entity<PhotoValidateAttendance>(entity =>
            {
                entity.ToTable("Photo_ValidateAttendance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.Property(e => e.ValidateattendanceId).HasColumnName("validateattendance_id");

                entity.HasOne(d => d.Validateattendance)
                    .WithMany(p => p.PhotoValidateAttendances)
                    .HasForeignKey(d => d.ValidateattendanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_ValidateAttendance_ValidateAttendance");
            });

            modelBuilder.Entity<PhotoValidationGa>(entity =>
            {
                entity.ToTable("Photo_Validation_Gas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.Property(e => e.ValidationGasId).HasColumnName("validation_gas_id");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhotoValidationGas)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Validation_Gas_Users");

                entity.HasOne(d => d.ValidationGas)
                    .WithMany(p => p.PhotoValidationGas)
                    .HasForeignKey(d => d.ValidationGasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Validation_Gas_Validation_Gas");
            });

            modelBuilder.Entity<PhotoWaitlistTable>(entity =>
            {
                entity.ToTable("Photo_Waitlist_Table");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.Property(e => e.WaitlistTableId).HasColumnName("waitlist_table_id");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PhotoWaitlistTables)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Waitlist_Table_Users");

                entity.HasOne(d => d.WaitlistTable)
                    .WithMany(p => p.PhotoWaitlistTables)
                    .HasForeignKey(d => d.WaitlistTableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_Waitlist_Table_Waitlist_Table");
            });

            modelBuilder.Entity<PhotoWashBasinWithSoapPaper>(entity =>
            {
                entity.ToTable("Photo_WashBasin_With_Soap_Paper");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Photo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.Property(e => e.WashbasinWithSoapPaperId).HasColumnName("washbasin_with_soap_paper_id");

                entity.HasOne(d => d.WashbasinWithSoapPaper)
                    .WithMany(p => p.PhotoWashBasinWithSoapPapers)
                    .HasForeignKey(d => d.WashbasinWithSoapPaperId)
                    .HasConstraintName("FK_Photo_WashBasin_With_Soap_Paper_WashBasin_With_Soap_Paper");
            });

            modelBuilder.Entity<PrecookedChicken>(entity =>
            {
                entity.ToTable("Precooked_Chicken");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AmountBonelesOrPrecookedPotatoes).HasColumnName("amount_boneles_or_precooked_potatoes");

                entity.Property(e => e.AmountPrecookedChickenInGeneral).HasColumnName("amount_precooked_chicken_in_general");

                entity.Property(e => e.AmountPrecookedChickenOnTheTable).HasColumnName("amount_precooked_chicken_on_the_table");

                entity.Property(e => e.BonelesOrPrecookedPotatoes).HasColumnName("boneles_or_precooked_potatoes");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CommentBonelesOrPrecookedPotatoes)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_boneles_or_precooked_potatoes");

                entity.Property(e => e.CommentPrecookedChickenInGeneral)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_precooked_chicken_in_general");

                entity.Property(e => e.CommentPrecookedChickenOnTheTable)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_precooked_chicken_on_the_table");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.PrecookedChickenInGeneral).HasColumnName("precooked_chicken_in_general");

                entity.Property(e => e.PrecookedChickenOnTheTable).HasColumnName("precooked_chicken_on_the_table");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PrecookedChickens)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Precooked_Chicken_Users");
            });

            modelBuilder.Entity<ReporteMensualTemp>(entity =>
            {
                entity.ToTable("reporte_mensual_temp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("endDate");

                entity.Property(e => e.Json).HasColumnName("json");

                entity.Property(e => e.Regional).HasColumnName("regional");

                entity.Property(e => e.Registro)
                    .HasColumnType("datetime")
                    .HasColumnName("registro");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("startDate");
            });

            modelBuilder.Entity<RequestTransfer>(entity =>
            {
                entity.ToTable("Request_Transfer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("amount");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.FromBranchId).HasColumnName("from_branch_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.ToBranchId).HasColumnName("to_branch_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.RequestTransfers)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Request_Transfer_Users");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.RequestTransfers)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Request_Transfer_Cat_Status_Request_Transfer");
            });

            modelBuilder.Entity<RhRegionalesHistorial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RH_REGIONALES_HISTORIAL");

                entity.Property(e => e.Entrada)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENTRADA");

                entity.Property(e => e.Estadia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ESTADIA");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Regional)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REGIONAL");

                entity.Property(e => e.Salida)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SALIDA");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUCURSAL");
            });

            modelBuilder.Entity<RiskProduct>(entity =>
            {
                entity.ToTable("Risk_Product");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.RiskProducts)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Risk_Product_Users");
            });

            modelBuilder.Entity<Salon>(entity =>
            {
                entity.ToTable("Salon");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessDoors).HasColumnName("access_doors");

                entity.Property(e => e.Badges).HasColumnName("badges");

                entity.Property(e => e.Boths).HasColumnName("boths");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CommentAccessDoors)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_access_doors");

                entity.Property(e => e.CommentBadges)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_badges");

                entity.Property(e => e.CommentBoths)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_boths");

                entity.Property(e => e.CommentFireExtinguishers)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_fire_extinguishers");

                entity.Property(e => e.CommentFurnitureOne)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_furniture_one");

                entity.Property(e => e.CommentFurnitureTwo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_furniture_two");

                entity.Property(e => e.CommentLuminaires)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_luminaires");

                entity.Property(e => e.CommentSwitches)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_switches");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.FireExtinguishers).HasColumnName("fire_extinguishers");

                entity.Property(e => e.FurnitureOne).HasColumnName("furniture_one");

                entity.Property(e => e.FurnitureTwo).HasColumnName("furniture_two");

                entity.Property(e => e.Luminaires).HasColumnName("luminaires");

                entity.Property(e => e.Switches).HasColumnName("switches");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<SatisfactionSurvey>(entity =>
            {
                entity.ToTable("Satisfaction_Survey");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.QuestionFive).HasColumnName("question_five");

                entity.Property(e => e.QuestionFour).HasColumnName("question_four");

                entity.Property(e => e.QuestionOne).HasColumnName("question_one");

                entity.Property(e => e.QuestionSix).HasColumnName("question_six");

                entity.Property(e => e.QuestionThree).HasColumnName("question_three");

                entity.Property(e => e.QuestionTwo).HasColumnName("question_two");

                entity.Property(e => e.Review).HasColumnName("review");

                entity.Property(e => e.TableN)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("table_n");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<Spotlight>(entity =>
            {
                entity.ToTable("Spotlight");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.BrokenSpotlight).HasColumnName("broken_spotlight");

                entity.Property(e => e.CommentAutorizados)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_autorizados");

                entity.Property(e => e.CommentFoco)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_foco");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.SpotlightAutorizados).HasColumnName("spotlight_autorizados");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<Station>(entity =>
            {
                entity.ToTable("Station");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Chips).HasColumnName("chips");

                entity.Property(e => e.Clean).HasColumnName("clean");

                entity.Property(e => e.CompleteAssembly).HasColumnName("complete_assembly");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<StockChickeUsed>(entity =>
            {
                entity.ToTable("Stock_Chicke_Used");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AmountUsed)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("amount_used");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockChickenId).HasColumnName("stock_chicken_id");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.StockChickeUseds)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stock_Chicke_Used_Users");

                entity.HasOne(d => d.StockChicken)
                    .WithMany(p => p.StockChickeUseds)
                    .HasForeignKey(d => d.StockChickenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stock_Chicke_Used_Stock_Chicken");
            });

            modelBuilder.Entity<StockChicken>(entity =>
            {
                entity.ToTable("Stock_Chicken");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.StockChickenCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sales_Expectations_Users");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.StockChickens)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stock_Chicken_Cat_Status_Stock_Chicken");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.StockChickenUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Sales_Expectations_Users1");
            });

            modelBuilder.Entity<StockChickenByBranch>(entity =>
            {
                entity.ToTable("Stock_Chicken_By_Branch");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesExpectations)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("sales_expectations");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.StockChickenByBranchCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stock_Chicken_By_Branch_Users");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.StockChickenByBranchUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Stock_Chicken_By_Branch_Users1");
            });

            modelBuilder.Entity<TabletSafeKeeping>(entity =>
            {
                entity.ToTable("Tablet_Safe_Keeping");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TabletSafeKeepings)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tablet_Safe_Keeping_Users");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("Task");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssignedToId).HasColumnName("assigned_to_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Icon)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("icon");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.Property(e => e.WorkshiftId).HasColumnName("workshift_id");

                entity.HasOne(d => d.AssignedTo)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.AssignedToId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_Cat_AssignedTo");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TaskCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_Users");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.TaskUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Task_Users1");

                entity.HasOne(d => d.Workshift)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.WorkshiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_Cat_WorkShift");
            });

            modelBuilder.Entity<TaskBranch>(entity =>
            {
                entity.HasKey(e => new { e.TaskId, e.BranchId });

                entity.ToTable("Task_Branch");

                entity.Property(e => e.TaskId).HasColumnName("task_id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskBranches)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_Branch_Task");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("Ticket");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PartBranchId).HasColumnName("part_branch_id");

                entity.Property(e => e.Problem)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("problem");

                entity.Property(e => e.SpecificSectionId).HasColumnName("specific_section_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TicketCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ticket_Users");

                entity.HasOne(d => d.PartBranch)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.PartBranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ticket_Cat_Part_Branch");

                entity.HasOne(d => d.SpecificSection)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.SpecificSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ticket_Cat_Specific_Section");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ticket_Cat_Status_Ticket");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.TicketUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Ticket_Users1");
            });

            modelBuilder.Entity<TicketTable>(entity =>
            {
                entity.ToTable("Ticket_Table");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CommentFoodOnTable)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_food_on_table");

                entity.Property(e => e.CommentTicket)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_ticket");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<Ticketing>(entity =>
            {
                entity.ToTable("Ticketing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cost");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DateClosed)
                    .HasColumnType("datetime")
                    .HasColumnName("date_closed");

                entity.Property(e => e.DateOpen)
                    .HasColumnType("datetime")
                    .HasColumnName("date_open");

                entity.Property(e => e.DescribeProblem)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("describe_problem");

                entity.Property(e => e.NoTicket)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_ticket");

                entity.Property(e => e.SpecificLocation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("specific_location");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.Property(e => e.WhereAreYouLocated).HasColumnName("where_are_you_located");

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.Ticketings)
                    .HasForeignKey(d => d.Category)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ticketing_Cat_Ticketing");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Ticketings)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ticketing_Users");

                entity.HasOne(d => d.WhereAreYouLocatedNavigation)
                    .WithMany(p => p.Ticketings)
                    .HasForeignKey(d => d.WhereAreYouLocated)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ticketing_Cat_Branch_Locate");
            });

            modelBuilder.Entity<Tip>(entity =>
            {
                entity.ToTable("Tip");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Tips)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tip_Users");
            });

            modelBuilder.Entity<ToSetTable>(entity =>
            {
                entity.ToTable("To_Set_Table");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Cajeros)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cajeros");

                entity.Property(e => e.Cocineros)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cocineros");

                entity.Property(e => e.CommentCocina)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_cocina");

                entity.Property(e => e.CommentMeet)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_meet");

                entity.Property(e => e.CommentSalon)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_salon");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.Property(e => e.Vendedores)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("vendedores");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ToSetTables)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_To_Set_Table_Users");
            });

            modelBuilder.Entity<UbicacionesInventario>(entity =>
            {
                entity.ToTable("UBICACIONES_INVENTARIO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codart).HasColumnName("CODART");

                entity.Property(e => e.Idsucursal).HasColumnName("IDSUCURSAL");

                entity.Property(e => e.Idusuario).HasColumnName("IDUSUARIO");

                entity.Property(e => e.Jdata).HasColumnName("JDATA");

                entity.Property(e => e.Total).HasColumnName("TOTAL");

                entity.Property(e => e.Vista).HasColumnName("VISTA");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.ClabTrab).HasColumnName("clab_trab");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("created_date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.MotherName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mother_name");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.Property(e => e.SucursalId).HasColumnName("sucursal_id");

                entity.Property(e => e.Token)
                    .IsUnicode(false)
                    .HasColumnName("token");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Cat_Role");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_Users_Cat_State");
            });

            modelBuilder.Entity<ValidateAttendance>(entity =>
            {
                entity.ToTable("Validate_Attendance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Attendence).HasColumnName("attendence");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.ClabTrab).HasColumnName("clab_trab");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.AttendenceNavigation)
                    .WithMany(p => p.ValidateAttendances)
                    .HasForeignKey(d => d.Attendence)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Validate_Attendance_Cat_Status_Validate_Attendance");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ValidateAttendances)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Validate_Attendance_Users");
            });

            modelBuilder.Entity<ValidationGa>(entity =>
            {
                entity.ToTable("Validation_Gas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ValidationGas)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Validation_Gas_Users");
            });

            modelBuilder.Entity<WaitlistTable>(entity =>
            {
                entity.ToTable("Waitlist_Table");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HowManyTables).HasColumnName("how_many_tables");

                entity.Property(e => e.NumberPeople).HasColumnName("number_people");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.Property(e => e.WaitlistTables).HasColumnName("waitlist_tables");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.WaitlistTables)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Wait_Table_Users");
            });

            modelBuilder.Entity<WashBasinWithSoapPaper>(entity =>
            {
                entity.ToTable("WashBasin_With_Soap_Paper");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CommentDryer)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_dryer");

                entity.Property(e => e.CommentSoapPaper)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_soap_paper");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.IsThereDryer).HasColumnName("is_there_dryer");

                entity.Property(e => e.IsThereSoapPaper).HasColumnName("is_there_soap_paper");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
