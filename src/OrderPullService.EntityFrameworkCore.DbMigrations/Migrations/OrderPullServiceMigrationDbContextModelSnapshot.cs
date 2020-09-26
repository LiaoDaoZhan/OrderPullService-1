﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderPullService.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace OrderPullService.EntityFrameworkCore.DbMigrations.Migrations
{
    [DbContext(typeof(OrderPullServiceMigrationDbContext))]
    partial class OrderPullServiceMigrationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.SqlServer)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrderPullService.Shop", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("AutoExamine")
                        .HasColumnType("bit");

                    b.Property<bool>("AutoMatic")
                        .HasColumnType("bit");

                    b.Property<bool>("AutoSync")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeptNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ErpCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReMark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SendMobilePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SendName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SendTelPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShopPlatformType")
                        .HasColumnType("int");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("OrderPullServiceShops");
                });

            modelBuilder.Entity("OrderPullService.Trade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdjustFee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("AfflicateFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("AutoDealFlag")
                        .HasColumnType("bit");

                    b.Property<decimal?>("BillingAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BuyerFlag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerLoginId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerMemo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerNick")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BuyerRate")
                        .HasColumnType("bit");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("ConsignTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeliveryTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeliveryWarehouse")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EsTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EscrowFee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EscrowFeeEpxress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EscrowFeeEpxressRate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrozenStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FundStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GmtReceived")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsChangeInfo")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool?>("IsInvoice")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsUse")
                        .HasColumnType("bit");

                    b.Property<string>("IssueInfoModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssueInfoStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssueInfoTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssueStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoanAmount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoanTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogisticsNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogisticsStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("MailNoAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Mailno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("OrdeActionAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OrderEndReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriTradeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PackAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("PayTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Payment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostFee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessingStatus")
                        .HasColumnType("int");

                    b.Property<string>("PromiseService")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiveStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceivedPayment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverMobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverTown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverZip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecvStatusDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefundCashAmt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefundCouponAmt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefundReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefundStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefundTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefundType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerFlag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerMemo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerNick")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SellerRate")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("SendTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ShopId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StateNum")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Tid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimingPromise")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TradeFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("YJYunFei")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("OrderPullServiceTrades");
                });

            modelBuilder.Entity("OrderPullService.TradeDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("AdjustFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("AfflicateFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("AfflicateFeeRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("BillingAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BuyerLoginId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerNick")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BuyerRate")
                        .HasColumnType("bit");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<decimal?>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DiscountFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("EscrowFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("EscrowFeeRate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("IsShShip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemMealId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemMealName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("MailNoAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("Num")
                        .HasColumnType("bigint");

                    b.Property<string>("NumId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("OrdeActionAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OrderFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OutId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OutSkuId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PackAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("PayTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Payment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PicPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefundStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerNick")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SellerRate")
                        .HasColumnType("bit");

                    b.Property<Guid>("ShopId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SkuId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkuPropertiesName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StateNum")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TimeoutActionTim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("TradeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("TyingNum")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("YJBillingAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("YJCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("oPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("TradeId");

                    b.ToTable("OrderPullServiceTradeDetails");
                });

            modelBuilder.Entity("OrderPullService.TradePromotion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("DiscountFee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GiftItemId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GiftItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GiftItemNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PromotionDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PromotionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PromotionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ShopId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TardeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("TradeOriId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TardeId");

                    b.ToTable("OrderPullServiceTradePromotions");
                });

            modelBuilder.Entity("OrderPullService.Shop", b =>
                {
                    b.OwnsOne("OrderPullService.ShopPlatform", "Platform", b1 =>
                        {
                            b1.Property<Guid>("ShopId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("AppKey")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("AppSecret")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("BuyUrl")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("HttpApiUrl")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<bool>("IsISV")
                                .HasColumnType("bit");

                            b1.Property<string>("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("SessionKey")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ShopId");

                            b1.ToTable("OrderPullServiceShops");

                            b1.WithOwner()
                                .HasForeignKey("ShopId");
                        });
                });

            modelBuilder.Entity("OrderPullService.Trade", b =>
                {
                    b.OwnsOne("OrderPullService.TradeInvoice", "Invoice", b1 =>
                        {
                            b1.Property<Guid>("TradeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("BankAccount")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("BankName")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("InvoiceContent")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("InvoiceKind")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("InvoiceTitle")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("SubBankName")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("TaxNum")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("TradeId");

                            b1.ToTable("OrderPullServiceTrades");

                            b1.WithOwner()
                                .HasForeignKey("TradeId");
                        });
                });

            modelBuilder.Entity("OrderPullService.TradeDetail", b =>
                {
                    b.HasOne("OrderPullService.Trade", "Trade")
                        .WithMany("Details")
                        .HasForeignKey("TradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrderPullService.TradePromotion", b =>
                {
                    b.HasOne("OrderPullService.Trade", "Trade")
                        .WithMany("PromotionDetails")
                        .HasForeignKey("TardeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
