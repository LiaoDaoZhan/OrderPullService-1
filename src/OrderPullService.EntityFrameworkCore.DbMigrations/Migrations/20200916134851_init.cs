using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderPullService.EntityFrameworkCore.DbMigrations.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderPullServiceShops",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ErpCode = table.Column<string>(nullable: true),
                    Platform_Name = table.Column<string>(nullable: true),
                    Platform_IsISV = table.Column<bool>(nullable: true),
                    Platform_BuyUrl = table.Column<string>(nullable: true),
                    Platform_AppKey = table.Column<string>(nullable: true),
                    Platform_AppSecret = table.Column<string>(nullable: true),
                    Platform_HttpApiUrl = table.Column<string>(nullable: true),
                    Platform_SessionKey = table.Column<string>(nullable: true),
                    ShopPlatformType = table.Column<int>(nullable: false),
                    AutoMatic = table.Column<bool>(nullable: false),
                    AutoSync = table.Column<bool>(nullable: false),
                    AutoExamine = table.Column<bool>(nullable: true),
                    SendName = table.Column<string>(nullable: true),
                    SendTelPhone = table.Column<string>(nullable: true),
                    SendMobilePhone = table.Column<string>(nullable: true),
                    DeptNo = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ReMark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPullServiceShops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderPullServiceTrades",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    OriTradeId = table.Column<string>(nullable: true),
                    SellStates = table.Column<string>(nullable: true),
                    ShopId = table.Column<Guid>(nullable: false),
                    SellerNick = table.Column<string>(nullable: true),
                    PicPath = table.Column<string>(nullable: true),
                    Payment = table.Column<string>(nullable: true),
                    SellerRate = table.Column<bool>(nullable: false),
                    PostFee = table.Column<string>(nullable: true),
                    ReceiverName = table.Column<string>(nullable: true),
                    ReceiverState = table.Column<string>(nullable: true),
                    ReceiverAddress = table.Column<string>(nullable: true),
                    ReceiverZip = table.Column<string>(nullable: true),
                    ReceiverMobile = table.Column<string>(nullable: true),
                    ReceiverPhone = table.Column<string>(nullable: true),
                    ConsignTime = table.Column<string>(nullable: true),
                    ReceivedPayment = table.Column<string>(nullable: true),
                    ReceiverCountry = table.Column<string>(nullable: true),
                    ReceiverTown = table.Column<string>(nullable: true),
                    Tid = table.Column<string>(nullable: true),
                    Currency = table.Column<string>(nullable: true),
                    ItemNumber = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Statu_CN = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    TotalFee = table.Column<string>(nullable: true),
                    Created = table.Column<string>(nullable: true),
                    PayTime = table.Column<DateTime>(nullable: true),
                    Modified = table.Column<string>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: true),
                    BuyerMessage = table.Column<string>(nullable: true),
                    BuyerMemo = table.Column<string>(nullable: true),
                    BuyerFlag = table.Column<string>(nullable: true),
                    SellerFlag = table.Column<string>(nullable: true),
                    SellerMemo = table.Column<string>(nullable: true),
                    BuyerNick = table.Column<string>(nullable: true),
                    BuyerLoginId = table.Column<string>(nullable: true),
                    AdjustFee = table.Column<string>(nullable: true),
                    TradeFrom = table.Column<string>(nullable: true),
                    BuyerRate = table.Column<bool>(nullable: false),
                    ReceiverCity = table.Column<string>(nullable: true),
                    ReceiverDistrict = table.Column<string>(nullable: true),
                    DeliveryWarehouse = table.Column<int>(nullable: false),
                    Invoice_InvoiceKind = table.Column<string>(nullable: true),
                    Invoice_InvoiceTitle = table.Column<string>(nullable: true),
                    Invoice_InvoiceContent = table.Column<string>(nullable: true),
                    Invoice_TaxNum = table.Column<string>(nullable: true),
                    Invoice_BankName = table.Column<string>(nullable: true),
                    Invoice_SubBankName = table.Column<string>(nullable: true),
                    Invoice_BankAccount = table.Column<string>(nullable: true),
                    IsInvoice = table.Column<bool>(nullable: true),
                    IsUse = table.Column<bool>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    EnabledMark = table.Column<bool>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SortCode = table.Column<int>(nullable: true),
                    ReponseData = table.Column<string>(nullable: true),
                    TimingPromise = table.Column<string>(nullable: true),
                    EsTime = table.Column<string>(nullable: true),
                    PromiseService = table.Column<string>(nullable: true),
                    DeliveryTime = table.Column<string>(nullable: true),
                    StateNum = table.Column<int>(nullable: true),
                    SendTime = table.Column<DateTime>(nullable: true),
                    LoanAmount = table.Column<string>(nullable: true),
                    LoanTime = table.Column<string>(nullable: true),
                    LogisticsNo = table.Column<string>(nullable: true),
                    GmtReceived = table.Column<string>(nullable: true),
                    EscrowFeeEpxressRate = table.Column<string>(nullable: true),
                    EscrowFeeEpxress = table.Column<string>(nullable: true),
                    EscrowFee = table.Column<string>(nullable: true),
                    AfflicateFee = table.Column<decimal>(nullable: true),
                    AutoDealFlag = table.Column<bool>(nullable: false),
                    Mailno = table.Column<string>(nullable: true),
                    BillingAmount = table.Column<decimal>(nullable: true),
                    PackAmount = table.Column<decimal>(nullable: true),
                    MailNoAmount = table.Column<decimal>(nullable: true),
                    OrdeActionAmount = table.Column<decimal>(nullable: true),
                    YJYunFei = table.Column<decimal>(nullable: true),
                    ReceiveStatus = table.Column<string>(nullable: true),
                    RecvStatusDesc = table.Column<string>(nullable: true),
                    LogisticsStatus = table.Column<string>(nullable: true),
                    IsChangeInfo = table.Column<bool>(nullable: true),
                    FrozenStatus = table.Column<string>(nullable: true),
                    FundStatus = table.Column<string>(nullable: true),
                    IssueStatus = table.Column<string>(nullable: true),
                    IssueInfoModel = table.Column<string>(nullable: true),
                    IssueInfoStatus = table.Column<string>(nullable: true),
                    IssueInfoTime = table.Column<string>(nullable: true),
                    OrderEndReason = table.Column<string>(nullable: true),
                    RefundCashAmt = table.Column<string>(nullable: true),
                    RefundCouponAmt = table.Column<string>(nullable: true),
                    RefundReason = table.Column<string>(nullable: true),
                    RefundStatus = table.Column<string>(nullable: true),
                    RefundTime = table.Column<string>(nullable: true),
                    RefundType = table.Column<string>(nullable: true),
                    CancelRequestReason = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPullServiceTrades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderPullServiceTradeDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    TradeId = table.Column<Guid>(nullable: false),
                    ItemMealName = table.Column<string>(nullable: true),
                    PicPath = table.Column<string>(nullable: true),
                    SellerNick = table.Column<string>(nullable: true),
                    BuyerNick = table.Column<string>(nullable: true),
                    BuyerLoginId = table.Column<string>(nullable: true),
                    RefundStatus = table.Column<string>(nullable: true),
                    OutId = table.Column<string>(nullable: true),
                    SnapshotUrl = table.Column<string>(nullable: true),
                    Snapshot = table.Column<string>(nullable: true),
                    TimeoutActionTim = table.Column<string>(nullable: true),
                    BuyerRate = table.Column<bool>(nullable: false),
                    SellerRate = table.Column<bool>(nullable: false),
                    Oid = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    StateNum = table.Column<int>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    is_sh_ship = table.Column<string>(nullable: true),
                    NumId = table.Column<string>(nullable: true),
                    ItemMealId = table.Column<string>(nullable: true),
                    SkuId = table.Column<string>(nullable: true),
                    Num = table.Column<string>(nullable: true),
                    OutSkuId = table.Column<string>(nullable: true),
                    OrderFrom = table.Column<string>(nullable: true),
                    TotalFee = table.Column<string>(nullable: true),
                    Payment = table.Column<string>(nullable: true),
                    DiscountFee = table.Column<string>(nullable: true),
                    AdjustFee = table.Column<string>(nullable: true),
                    SkuPropertiesName = table.Column<string>(nullable: true),
                    EndTime = table.Column<string>(nullable: true),
                    EnabledMark = table.Column<bool>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SortCode = table.Column<int>(nullable: true),
                    Discount = table.Column<string>(nullable: true),
                    oPrice = table.Column<string>(nullable: true),
                    EscrowFeeRate = table.Column<string>(nullable: true),
                    EscrowFee = table.Column<string>(nullable: true),
                    AfflicateFeeRate = table.Column<decimal>(nullable: true),
                    AfflicateFee = table.Column<decimal>(nullable: true),
                    TyingNum = table.Column<int>(nullable: true),
                    Cost = table.Column<decimal>(nullable: true),
                    YJCost = table.Column<decimal>(nullable: true),
                    YJBillingAmount = table.Column<decimal>(nullable: true),
                    BillingAmount = table.Column<decimal>(nullable: true),
                    PackAmount = table.Column<decimal>(nullable: true),
                    MailNoAmount = table.Column<decimal>(nullable: true),
                    OrdeActionAmount = table.Column<decimal>(nullable: true),
                    PayTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPullServiceTradeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderPullServiceTradeDetails_OrderPullServiceTrades_TradeId",
                        column: x => x.TradeId,
                        principalTable: "OrderPullServiceTrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderPullServiceTradeDetails_TradeId",
                table: "OrderPullServiceTradeDetails",
                column: "TradeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderPullServiceShops");

            migrationBuilder.DropTable(
                name: "OrderPullServiceTradeDetails");

            migrationBuilder.DropTable(
                name: "OrderPullServiceTrades");
        }
    }
}
