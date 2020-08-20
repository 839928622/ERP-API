using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP_API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttachedFil",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelationNum = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    FileUrl = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    AddAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachedFil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "品牌编号")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "品牌名称"),
                    EnglishName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "品牌英文名称"),
                    FullName = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "品牌全程"),
                    Company = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "公司"),
                    ProductPlace = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    WebSite = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    LogoUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    PY = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CanvassAgreement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgreementContent = table.Column<string>(nullable: false, defaultValueSql: "('')"),
                    UserId = table.Column<int>(nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanvassAgreement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatagoryParams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITypeCode = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    BranchId = table.Column<int>(nullable: false),
                    PlatId = table.Column<int>(nullable: false),
                    ParamsName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    UserBy = table.Column<int>(nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatagoryParams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CrawlerRequest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Url = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    DataSource = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    CategoryName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    IsGrabGroup = table.Column<bool>(nullable: false),
                    SuccessNum = table.Column<int>(nullable: false),
                    FailNum = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    CreateBy = table.Column<int>(nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrawlerRequest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    Name = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    ShortName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Type = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    EmployeesNum = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Province = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    City = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Area = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    PostCode = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    Telphone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Fax = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Website = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    RegisterMethod = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Level = table.Column<int>(nullable: false, defaultValueSql: "((3))", comment: "客户级别：1-5,5最高"),
                    SalesId = table.Column<int>(nullable: false, comment: "默认销售员"),
                    ServiceId = table.Column<int>(nullable: false, comment: "客服"),
                    StatementManId = table.Column<int>(nullable: false, comment: "对账员"),
                    OrderDiscount = table.Column<int>(nullable: false, defaultValueSql: "((100))", comment: "默认的折扣，对专柜也有效！"),
                    OrderMemo = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "开单特殊说明"),
                    OrderPrintNum = table.Column<int>(nullable: false, defaultValueSql: "((2))", comment: "订单打印份数"),
                    StoreMemo = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "理货特殊说明"),
                    StatementMemo = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "对账备注"),
                    PayType = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "现结，月结"),
                    PayMethod = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "支票，现金，电汇，其它"),
                    Credit = table.Column<int>(nullable: false, comment: "信用额度"),
                    CreditDays = table.Column<int>(nullable: false, comment: "账期"),
                    InvoiceType = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "增票，普票，收据，无需发票"),
                    InvoiceName = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    InvoiceTaxNo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InvoiceAddress = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    InvoicePhone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InvoiceBank = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    InvoiceBankAccount = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    InvoiceContent = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    InvoiceMemo = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    IsOrdering = table.Column<bool>(nullable: false, comment: "1:开启连续下单状态"),
                    IsMultiAccount = table.Column<bool>(nullable: false, defaultValueSql: "((1))", comment: "是否启用多账号"),
                    IsComfirmOrder = table.Column<bool>(nullable: false, comment: "是否启用审核下单"),
                    ConfirmLevel = table.Column<int>(nullable: false, defaultValueSql: "((5))", comment: "审核下单level"),
                    IsCounter = table.Column<bool>(nullable: false, comment: "是否启用专柜"),
                    IsBuyOutCounter = table.Column<bool>(nullable: false, comment: "是否可以买专柜以外的商品"),
                    IsBudget = table.Column<bool>(nullable: false, comment: "是否启用预算管理"),
                    IsStoreManager = table.Column<bool>(nullable: false, comment: "是否启用库存管理"),
                    PY = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    InvoiceCategory = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('纸质发票')"),
                    EmailForInvoice = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    IsPublic = table.Column<bool>(nullable: false),
                    PrintTemplateId = table.Column<int>(nullable: false),
                    OnlyServiceOrder = table.Column<bool>(nullable: false),
                    OnlyStatementManCheck = table.Column<bool>(nullable: false),
                    IsDisable = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Balance = table.Column<decimal>(type: "money", nullable: false),
                    IsBalance = table.Column<bool>(nullable: false),
                    BalanceType = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    LimitOrderByBalance = table.Column<bool>(nullable: true),
                    Memo = table.Column<string>(maxLength: 1000, nullable: true),
                    WinformDeliveryTemplateId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBalanceLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "PK")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, comment: "租户编号"),
                    CustomerId = table.Column<int>(nullable: false, comment: "客户编号"),
                    CustomerName = table.Column<string>(maxLength: 200, nullable: false, comment: "客户名称"),
                    Direction = table.Column<int>(nullable: false, comment: "1、增加 2、减少"),
                    Change = table.Column<decimal>(type: "money", nullable: false, comment: "变更值"),
                    Amount = table.Column<decimal>(type: "money", nullable: false, comment: "金额"),
                    DeptId = table.Column<int>(nullable: true, comment: "部门编号"),
                    DeptName = table.Column<string>(maxLength: 200, nullable: true, comment: "部门名称"),
                    UserId = table.Column<int>(nullable: true, comment: "联系人编号"),
                    UserName = table.Column<string>(maxLength: 200, nullable: true, comment: "联系人名称"),
                    RelationId = table.Column<int>(nullable: true, comment: "关联订单编号"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false, comment: "创建时间"),
                    CreationId = table.Column<int>(nullable: false, comment: "创建人"),
                    Remark = table.Column<string>(maxLength: 200, nullable: true, comment: "备注")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBalanceLog", x => x.Id);
                },
                comment: "客户余额日志");

            migrationBuilder.CreateTable(
                name: "CustomerInvoiceInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    InvoiceTaxNo = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "税号"),
                    InvoiceAddress = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "地址"),
                    InvoicePhone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InvoiceBank = table.Column<string>(unicode: false, maxLength: 100, nullable: true, comment: "开户行"),
                    InvoiceAccount = table.Column<string>(unicode: false, maxLength: 100, nullable: true, comment: "开户行账号"),
                    InvoiceMemo = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "发票备注"),
                    MemberName = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInvoiceInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    Customer = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    UserId = table.Column<int>(nullable: false, comment: "操作人Id(Sys_Users)"),
                    UserName = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "操作人名称"),
                    Category = table.Column<string>(maxLength: 50, nullable: false, comment: "操作类别"),
                    Operate = table.Column<string>(maxLength: 200, nullable: false, comment: "操作"),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "添加时间"),
                    Tracking = table.Column<string>(nullable: true, comment: "修改详细信息，扩展字段")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerPreReceiveMoney",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    CustomerId = table.Column<int>(nullable: false, comment: "客户Id"),
                    CustomerName = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: "客户名称"),
                    OrderStatementId = table.Column<int>(nullable: false, comment: "对账单Id"),
                    InitialBalance = table.Column<decimal>(type: "money", nullable: false, comment: "期初金额"),
                    Operate = table.Column<string>(maxLength: 10, nullable: false, comment: "操作(预收、收款、撤销)"),
                    PreReceiveMoney = table.Column<decimal>(type: "money", nullable: false, comment: "预收金额"),
                    ReceiveMoney = table.Column<decimal>(type: "money", nullable: false, comment: "收款金额"),
                    Balance = table.Column<decimal>(type: "money", nullable: false, comment: "余额"),
                    OperatorId = table.Column<int>(nullable: false, comment: "操作人Id"),
                    OperatorName = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "操作人名称"),
                    Memo = table.Column<string>(type: "text", nullable: true, comment: "备注"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "更新时间"),
                    PayType = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    ReceiveAccount = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "((0))"),
                    ActualPayTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPreReceiveMoney", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "PK")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false, comment: "客户编号"),
                    Name = table.Column<string>(maxLength: 200, nullable: false, comment: "名称"),
                    Alias = table.Column<string>(maxLength: 200, nullable: false, comment: "别名"),
                    Logo = table.Column<string>(maxLength: 2000, nullable: false, comment: "Logo"),
                    Image = table.Column<string>(maxLength: 2000, nullable: false, comment: "图片"),
                    Tenant = table.Column<int>(nullable: false, comment: "租户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerSetting", x => x.Id);
                },
                comment: "重要客户自定义设置");

            migrationBuilder.CreateTable(
                name: "DefaultStore",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Place = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    OrderType = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    StoreId = table.Column<int>(nullable: false, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefaultStore", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryLine",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    LineName = table.Column<string>(maxLength: 50, nullable: false),
                    LineRange = table.Column<string>(maxLength: 200, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryLine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryLineCustomer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    LineId = table.Column<int>(nullable: false),
                    Distance = table.Column<int>(nullable: false, comment: "配送距离（公里）"),
                    Remark = table.Column<string>(maxLength: 100, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryLineCustomer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryLineMember",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(nullable: false),
                    LineId = table.Column<int>(nullable: false),
                    Distance = table.Column<int>(nullable: false, comment: "配送距离（公里）"),
                    Remark = table.Column<string>(maxLength: 100, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryLineMember", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DellOrderGoodsPo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    OrderDetailId = table.Column<int>(nullable: false),
                    PO = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "生成的传给戴尔的订单号"),
                    GoodsId = table.Column<int>(nullable: true),
                    GoodsName = table.Column<string>(maxLength: 500, nullable: true),
                    GoodsNum = table.Column<int>(nullable: true),
                    GoodsPrice = table.Column<decimal>(type: "money", nullable: true),
                    Status = table.Column<string>(maxLength: 50, nullable: true, comment: "状态"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DellOrderGoodsPo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dept",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Code = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PCode = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Level = table.Column<int>(nullable: false),
                    IsSepareSettle = table.Column<bool>(nullable: false, comment: "是否独立结算"),
                    IsSepareOrder = table.Column<bool>(nullable: false, comment: "是否独立下单"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Balance = table.Column<decimal>(type: "money", nullable: false),
                    IsBalance = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dept", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeptTemp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Code = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PCode = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Level = table.Column<int>(nullable: false),
                    IsSepareSettle = table.Column<bool>(nullable: false),
                    IsSepareOrder = table.Column<bool>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Balance = table.Column<decimal>(type: "money", nullable: false),
                    IsBalance = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeptTemp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistributionCustomerInvoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, comment: "开票方，即销方"),
                    CustomerId = table.Column<int>(nullable: false, comment: "客户编号"),
                    CustomerName = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: "客户名称"),
                    InvoiceType = table.Column<int>(nullable: false, comment: "发票类型"),
                    InvoiceNo = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "发票号码"),
                    InvoiceCode = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "发票代码"),
                    InvoiceDate = table.Column<DateTime>(type: "datetime", nullable: false, comment: "开票日期"),
                    InvoiceMoney = table.Column<decimal>(type: "money", nullable: false, comment: "开票金额"),
                    ChargeOff = table.Column<decimal>(type: "money", nullable: false, comment: "销账金额"),
                    LinkManId = table.Column<int>(nullable: false, comment: "联系人编号"),
                    LinkMan = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "联系人名称"),
                    DeliveryType = table.Column<int>(nullable: false, comment: "配送方式"),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "联系人邮箱"),
                    Mobile = table.Column<string>(unicode: false, maxLength: 20, nullable: true, comment: "联系人手机号"),
                    BuyerName = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: "购方名称"),
                    BuyerTaxNo = table.Column<string>(unicode: false, maxLength: 20, nullable: false, comment: "购方税号"),
                    BuyerBank = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "购方开户行"),
                    BuyerBankAccount = table.Column<string>(unicode: false, maxLength: 100, nullable: true, comment: "购方开户行账号"),
                    BuyerPhone = table.Column<string>(unicode: false, maxLength: 20, nullable: true, comment: "购方电话"),
                    BuyerAddress = table.Column<string>(unicode: false, maxLength: 80, nullable: true, comment: "购方地址"),
                    SaleName = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "销方名称"),
                    SaleTaxNo = table.Column<string>(unicode: false, maxLength: 20, nullable: true, comment: "销方税号"),
                    SaleBank = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "销方开户行"),
                    SaleBankAccount = table.Column<string>(unicode: false, maxLength: 100, nullable: true, comment: "销方开户行账号"),
                    SalePhone = table.Column<string>(unicode: false, maxLength: 20, nullable: true, comment: "销方电话"),
                    SaleAddress = table.Column<string>(unicode: false, maxLength: 80, nullable: true, comment: "销方地址"),
                    Memo = table.Column<string>(unicode: false, maxLength: 1000, nullable: true, comment: "开票备注"),
                    UserId = table.Column<int>(nullable: false, comment: "开票操作人"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "开票操作时间"),
                    IsDelete = table.Column<bool>(nullable: false),
                    StatementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionCustomerInvoice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistributionCustomerInvoiceDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(nullable: false, comment: "DistributionCustomerInvoice表Id"),
                    OrderId = table.Column<int>(nullable: false, comment: "订单编号"),
                    GoodsId = table.Column<int>(nullable: false, comment: "商品编号"),
                    Num = table.Column<int>(nullable: false, comment: "数量"),
                    Price = table.Column<decimal>(type: "money", nullable: false, comment: "单价"),
                    Amount = table.Column<decimal>(type: "money", nullable: false, comment: "金额"),
                    ChargeOffAmount = table.Column<decimal>(type: "money", nullable: false),
                    TaxRate = table.Column<decimal>(type: "money", nullable: false, comment: "税率"),
                    TaxCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "商品税收编码"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionCustomerInvoiceDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistributionCustomerReceiveMoney",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, comment: "收款方"),
                    CustomerId = table.Column<int>(nullable: false, comment: "付款方"),
                    CustomerName = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: "付款方名称"),
                    Operate = table.Column<string>(maxLength: 20, nullable: false, comment: "操作类型"),
                    ChargeOff = table.Column<decimal>(type: "money", nullable: false, comment: "销账金额，与订单的销账金额相等"),
                    ReceiveMoney = table.Column<decimal>(type: "money", nullable: false, comment: "实际收款金额"),
                    ReceiveDate = table.Column<DateTime>(type: "datetime", nullable: false, comment: "收款日期"),
                    PayType = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "支付方式"),
                    ReceiveAccount = table.Column<int>(nullable: true, comment: "付款账户，Sys_BranchBankInfo的编号"),
                    Memo = table.Column<string>(maxLength: 500, nullable: true, comment: "收款备注"),
                    UserId = table.Column<int>(nullable: false, comment: "收款操作人"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    StatementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionCustomerReceiveMoney", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistributionCustomerReceiveMoneyDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiveMoneyId = table.Column<int>(nullable: false, comment: "分销订单收款记录表Id"),
                    OrderId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    Num = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false, comment: "明细实收金额"),
                    ChargeOffAmount = table.Column<decimal>(type: "money", nullable: false, comment: "明细销账金额"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    GoodsName = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Unit = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionCustomerReceiveMoneyDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistributionInvoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, comment: "开票方，即销方"),
                    PBranchId = table.Column<int>(nullable: false, comment: "收票方，即上级公司/购方"),
                    InvoiceType = table.Column<int>(nullable: false, comment: "发票类型"),
                    InvoiceNo = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "发票号码"),
                    InvoiceCode = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "发票代码"),
                    InvoiceDate = table.Column<DateTime>(type: "datetime", nullable: false, comment: "开票日期"),
                    InvoiceMoney = table.Column<decimal>(type: "money", nullable: false, comment: "开票金额"),
                    ChargeOff = table.Column<decimal>(type: "money", nullable: false, comment: "销账金额"),
                    LinkManId = table.Column<int>(nullable: false, comment: "联系人编号"),
                    LinkMan = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "联系人名称"),
                    DeliveryType = table.Column<int>(nullable: false, comment: "配送方式"),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "联系人邮箱"),
                    Mobile = table.Column<string>(unicode: false, maxLength: 20, nullable: true, comment: "联系人手机号"),
                    BuyerName = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: "购方名称"),
                    BuyerTaxNo = table.Column<string>(unicode: false, maxLength: 20, nullable: false, comment: "购方税号"),
                    BuyerBank = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "购方开户行"),
                    BuyerBankAccount = table.Column<string>(unicode: false, maxLength: 100, nullable: true, comment: "购方开户行账号"),
                    BuyerPhone = table.Column<string>(unicode: false, maxLength: 20, nullable: true, comment: "购方电话"),
                    BuyerAddress = table.Column<string>(unicode: false, maxLength: 80, nullable: true, comment: "购方地址"),
                    SaleName = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "销方名称"),
                    SaleTaxNo = table.Column<string>(unicode: false, maxLength: 20, nullable: true, comment: "销方税号"),
                    SaleBank = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "销方开户行"),
                    SaleBankAccount = table.Column<string>(unicode: false, maxLength: 100, nullable: true, comment: "销方开户行账号"),
                    SalePhone = table.Column<string>(unicode: false, maxLength: 20, nullable: true, comment: "销方电话"),
                    SaleAddress = table.Column<string>(unicode: false, maxLength: 80, nullable: true, comment: "销方地址"),
                    Memo = table.Column<string>(unicode: false, maxLength: 1000, nullable: true, comment: "开票备注"),
                    UserId = table.Column<int>(nullable: false, comment: "开票操作人"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "开票操作时间"),
                    IsDelete = table.Column<bool>(nullable: false),
                    StatementId = table.Column<int>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionInvoice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistributionInvoiceDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(nullable: false, comment: "DistributionInvoice表Id"),
                    OrderId = table.Column<int>(nullable: false, comment: "订单编号"),
                    GoodsId = table.Column<int>(nullable: false, comment: "商品编号"),
                    Num = table.Column<int>(nullable: false, comment: "数量"),
                    Price = table.Column<decimal>(type: "money", nullable: false, comment: "单价"),
                    Amount = table.Column<decimal>(type: "money", nullable: false, comment: "金额"),
                    ChargeOffAmount = table.Column<decimal>(type: "money", nullable: false),
                    TaxRate = table.Column<decimal>(type: "money", nullable: false, comment: "税率"),
                    TaxCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "商品税收编码"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionInvoiceDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistributionOperation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    IsPicked = table.Column<bool>(nullable: false),
                    IsPrinted = table.Column<bool>(nullable: false),
                    IsDelivered = table.Column<bool>(nullable: false),
                    IsArrived = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionOperation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistributionOrderState",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    IsPicked = table.Column<bool>(nullable: false),
                    PickTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsPrinted = table.Column<bool>(nullable: false),
                    PrintTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDelivered = table.Column<bool>(nullable: false),
                    DeliveryTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsArrived = table.Column<bool>(nullable: false),
                    ArriveTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    AllocationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsLocked = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsConverted = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    ServiceResponseTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceiveMoneyStatus = table.Column<int>(nullable: false, comment: "收款状态：0:未收款；1：已收款；2：部分收款"),
                    InvoiceStatus = table.Column<int>(nullable: false, comment: "收票状态：0:未收票；1：已收票；2：部分收票"),
                    SumMoney = table.Column<decimal>(type: "money", nullable: false),
                    ReceiveChargeOff = table.Column<decimal>(type: "money", nullable: false),
                    InvoiceChargeOff = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionOrderState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistributionPay",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, comment: "付款方"),
                    ChildBranchId = table.Column<int>(nullable: false, comment: "收款方"),
                    ChargeOff = table.Column<decimal>(type: "money", nullable: false, comment: "销账金额，与订单的销账金额相等"),
                    PayMoney = table.Column<decimal>(type: "money", nullable: false, comment: "实际收款金额"),
                    PayDate = table.Column<DateTime>(type: "datetime", nullable: false, comment: "付款日期"),
                    PayType = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "支付方式"),
                    PayAccount = table.Column<int>(nullable: true, comment: "付款账号"),
                    Memo = table.Column<string>(maxLength: 500, nullable: true, comment: "付款备注"),
                    UserId = table.Column<int>(nullable: false, comment: "操作人"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "操作时间"),
                    IsDelete = table.Column<bool>(nullable: false),
                    StatementId = table.Column<int>(nullable: false, comment: "对账单号")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionPay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistributionPayDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "PK")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayId = table.Column<int>(nullable: false, comment: "FK"),
                    OrderId = table.Column<int>(nullable: false, comment: "订单Id"),
                    GoodsId = table.Column<int>(nullable: false, comment: "商品Id"),
                    Num = table.Column<int>(nullable: false, comment: "数量"),
                    Price = table.Column<decimal>(type: "money", nullable: false, comment: "单价"),
                    Amount = table.Column<decimal>(type: "money", nullable: false, comment: "明细实收金额"),
                    ChargeOffAmount = table.Column<decimal>(type: "money", nullable: false, comment: "销账金额"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "操作时间"),
                    IsDelete = table.Column<bool>(nullable: false, comment: "是否删除")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionPayDetail", x => x.Id);
                },
                comment: "分销收款明细");

            migrationBuilder.CreateTable(
                name: "DistributionReceiveInvoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "PK")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, comment: "购方"),
                    ChildBranchId = table.Column<int>(nullable: false, comment: "销方，即下一级公司"),
                    InvoiceType = table.Column<int>(nullable: false, comment: "发票类型"),
                    InvoiceNo = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "发票号码"),
                    InvoiceCode = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "发票代码"),
                    InvoiceDate = table.Column<DateTime>(type: "datetime", nullable: false, comment: "开票日期"),
                    ReceiveDate = table.Column<DateTime>(type: "datetime", nullable: false, comment: "收票日期"),
                    InvoiceMoney = table.Column<decimal>(type: "money", nullable: false, comment: "开票金额"),
                    ChargeOff = table.Column<decimal>(type: "money", nullable: false, comment: "销账金额"),
                    BuyerName = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: "购方名称"),
                    BuyerTaxNo = table.Column<string>(unicode: false, maxLength: 20, nullable: false, comment: "购方税号"),
                    BuyerBank = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "购方开户行"),
                    BuyerBankAccount = table.Column<string>(unicode: false, maxLength: 100, nullable: true, comment: "购方开户行账号"),
                    BuyerPhone = table.Column<string>(unicode: false, maxLength: 20, nullable: true, comment: "购方电话"),
                    BuyerAddress = table.Column<string>(unicode: false, maxLength: 80, nullable: true, comment: "购方地址"),
                    SaleName = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "销方名称"),
                    SaleTaxNo = table.Column<string>(unicode: false, maxLength: 20, nullable: true, comment: "销方税号"),
                    SaleBank = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "销方开户行"),
                    SaleBankAccount = table.Column<string>(unicode: false, maxLength: 100, nullable: true, comment: "销方开户行账号"),
                    SalePhone = table.Column<string>(unicode: false, maxLength: 20, nullable: true, comment: "销方电话"),
                    SaleAddress = table.Column<string>(unicode: false, maxLength: 80, nullable: true, comment: "销方地址"),
                    Memo = table.Column<string>(unicode: false, maxLength: 1000, nullable: true, comment: "开票备注"),
                    UserId = table.Column<int>(nullable: false, comment: "开票操作人"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "收票操作时间"),
                    IsDelete = table.Column<bool>(nullable: false),
                    StatementId = table.Column<int>(nullable: false, comment: "对账单Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionReceiveInvoice", x => x.Id);
                },
                comment: "分销收票");

            migrationBuilder.CreateTable(
                name: "DistributionReceiveInvoiceDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiveInvoiceId = table.Column<int>(nullable: false, comment: "DistributionReceiveInvoice表Id"),
                    OrderId = table.Column<int>(nullable: false, comment: "订单编号"),
                    GoodsId = table.Column<int>(nullable: false, comment: "商品编号"),
                    Num = table.Column<int>(nullable: false, comment: "数量"),
                    Price = table.Column<decimal>(type: "money", nullable: false, comment: "单价"),
                    Amount = table.Column<decimal>(type: "money", nullable: false, comment: "开票金额"),
                    ChargeOffAmount = table.Column<decimal>(type: "money", nullable: false, comment: "销账金额"),
                    TaxRate = table.Column<decimal>(type: "money", nullable: false, comment: "税率"),
                    TaxCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "商品税收编码"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionReceiveInvoiceDetail", x => x.Id);
                },
                comment: "分销收票明细");

            migrationBuilder.CreateTable(
                name: "DistributionReceiveMoney",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, comment: "收款方"),
                    PBranchId = table.Column<int>(nullable: false, comment: "付款方"),
                    ChargeOff = table.Column<decimal>(type: "money", nullable: false, comment: "销账金额，与订单的销账金额相等"),
                    ReceiveMoney = table.Column<decimal>(type: "money", nullable: false, comment: "实际收款金额"),
                    ReceiveDate = table.Column<DateTime>(type: "datetime", nullable: false, comment: "收款日期"),
                    PayType = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "支付方式"),
                    ReceiveAccount = table.Column<int>(nullable: true, comment: "付款账户，Sys_BranchBankInfo的编号"),
                    Memo = table.Column<string>(maxLength: 500, nullable: true, comment: "收款备注"),
                    UserId = table.Column<int>(nullable: false, comment: "收款操作人"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionReceiveMoney", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistributionReceiveMoneyDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiveMoneyId = table.Column<int>(nullable: false, comment: "分销订单收款记录表Id"),
                    OrderId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    Num = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false, comment: "明细实收金额"),
                    ChargeOffAmount = table.Column<decimal>(type: "money", nullable: false, comment: "明细销账金额"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionReceiveMoneyDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DOStatement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    SumMoney = table.Column<decimal>(type: "money", nullable: false),
                    PaidMoney = table.Column<decimal>(type: "money", nullable: false),
                    PayStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Memo = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    PrintNum = table.Column<int>(nullable: false),
                    InvoiceType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InvoiceStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InvoiceMoney = table.Column<decimal>(type: "money", nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ChargeOff = table.Column<decimal>(type: "money", nullable: false),
                    InvoiceChargeOff = table.Column<decimal>(type: "money", nullable: false),
                    SumGoodsAmount = table.Column<decimal>(type: "money", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApplyReceiveMoney = table.Column<decimal>(type: "money", nullable: true),
                    ApplyInvoiceMoney = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOStatement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DOStatementDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatementId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOStatementDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DPStatement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, comment: "租户"),
                    SupplierId = table.Column<int>(nullable: false, comment: "分销商"),
                    SumMoney = table.Column<decimal>(type: "money", nullable: false, comment: "对账单总额"),
                    PaidMoney = table.Column<decimal>(type: "money", nullable: false, comment: "收款金额"),
                    PayStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('未付款')", comment: "未付款、已付款、部分付款"),
                    ChargeOff = table.Column<decimal>(type: "money", nullable: false, comment: "销账金额"),
                    Memo = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "备注"),
                    UpdateBy = table.Column<int>(nullable: false, comment: "操作人"),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "操作时间"),
                    InvoiceMoney = table.Column<decimal>(type: "money", nullable: false, comment: "收票金额"),
                    InvoiceStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: true, defaultValueSql: "('未收票')", comment: "未收票、已收票、部分收票"),
                    PaidApplyMoney = table.Column<decimal>(type: "money", nullable: false, comment: "付款申请金额"),
                    InvoiceApplyMoney = table.Column<decimal>(type: "money", nullable: false, comment: "收票申请金额"),
                    InvoiceChargeOff = table.Column<decimal>(type: "money", nullable: false, comment: "收票销账金额")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DPStatement", x => x.Id);
                },
                comment: "分销商对账");

            migrationBuilder.CreateTable(
                name: "DPStatementDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DPStatementId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DPStatementDetail", x => x.Id);
                },
                comment: "分销商对账明细");

            migrationBuilder.CreateTable(
                name: "EmailInvoiceSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    PlatIdentity = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "平台身份认证编号"),
                    SaleName = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: "销售方名称"),
                    SaleBank = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: "销售方开户行"),
                    SaleBankAccount = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "销售方开户行账号"),
                    SaleTaxNum = table.Column<string>(unicode: false, maxLength: 20, nullable: false, comment: "销售方税号"),
                    SalePhone = table.Column<string>(unicode: false, maxLength: 20, nullable: false, comment: "销售方电话"),
                    SaleAddress = table.Column<string>(unicode: false, maxLength: 80, nullable: false, comment: "销售方地址"),
                    PlatAPI = table.Column<string>(unicode: false, nullable: false, comment: "平台电子发票API"),
                    IsEnable = table.Column<bool>(nullable: false, comment: "是否开启"),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "添加时间"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "更新时间"),
                    AppKey = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    AppSecret = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Token = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    ExpiresTime = table.Column<long>(nullable: true),
                    Plat = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailInvoiceSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinanceAudit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: true),
                    FinanceId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    Remark = table.Column<string>(maxLength: 1000, nullable: true),
                    Type = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    FinanceData = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinanceRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    BankId = table.Column<int>(nullable: false, comment: "账户编号"),
                    BankInfo = table.Column<string>(maxLength: 1000, nullable: true, comment: "开户行+账号名称"),
                    InitBalance = table.Column<decimal>(type: "money", nullable: false, comment: "原金额"),
                    OperateAmount = table.Column<decimal>(type: "money", nullable: false, comment: "操作金额"),
                    Balance = table.Column<decimal>(type: "money", nullable: false, comment: "余额"),
                    Operate = table.Column<string>(maxLength: 200, nullable: false, comment: "操作"),
                    PayType = table.Column<string>(maxLength: 200, nullable: true, comment: "支付方式"),
                    DebtorId = table.Column<int>(nullable: false, comment: "借方"),
                    LenderId = table.Column<int>(nullable: false, comment: "贷方"),
                    DebtorName = table.Column<string>(maxLength: 500, nullable: false, comment: "借方名称"),
                    LenderName = table.Column<string>(maxLength: 500, nullable: false, comment: "贷方名称"),
                    SubjectCode = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "科目code"),
                    SubjectName = table.Column<string>(maxLength: 500, nullable: true, comment: "科目名称"),
                    Tpn = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "第三方"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: true, comment: "备注"),
                    OpreteDate = table.Column<DateTime>(type: "datetime", nullable: true, comment: "实际收/付款日期"),
                    AddAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinanceSubject",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Code = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "科目编号"),
                    Pcode = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "上级编号"),
                    Name = table.Column<string>(maxLength: 500, nullable: false, comment: "科目名称"),
                    Type = table.Column<string>(maxLength: 50, nullable: false, comment: "类型"),
                    AddAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatetAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceSubject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Franchisee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    CompanyName = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: "公司名称"),
                    CompanyProvince = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "公司地址省份"),
                    CompanyCity = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "公司地址城市"),
                    CompanyArea = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "公司地址区县"),
                    CompanyAddress = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: "公司详细地址"),
                    ContractWay = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "联系方式"),
                    LocationProvince = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "所在地省份"),
                    LocationCity = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "所在地城市"),
                    LocationArea = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "所在地区县"),
                    LocationAddress = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: "所在地详细地址"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    PassWord = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    Mobile = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Franchisee", x => x.Id);
                },
                comment: "加盟商");

            migrationBuilder.CreateTable(
                name: "Gift",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsId = table.Column<int>(nullable: false),
                    Point = table.Column<int>(nullable: false),
                    MaxNum = table.Column<int>(nullable: false),
                    IsValid = table.Column<int>(nullable: false),
                    GiftName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "礼品显示出来的名称，例如：反光书包"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gift", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    BranchId = table.Column<int>(nullable: false, comment: "0：共有商品"),
                    TypeId = table.Column<int>(nullable: false, comment: "商品类别Id"),
                    BrandId = table.Column<int>(nullable: false, comment: "品牌Id"),
                    SN = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')", comment: "商品名称，不包括品牌和型号"),
                    DisplayName = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('‘’')"),
                    PY = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('‘’')"),
                    Unit = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('‘’')", comment: "基本单位"),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    InPrice = table.Column<decimal>(type: "decimal(18, 4)", nullable: false, comment: "最新进价"),
                    Length = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PackingList = table.Column<string>(type: "text", nullable: false, comment: "包装清单"),
                    Service = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('‘’')", comment: "服务条款"),
                    Recommend = table.Column<int>(nullable: false, comment: "推荐度"),
                    RecommendDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(((1900)-(1))-(1))"),
                    cuxiao = table.Column<decimal>(type: "numeric(18, 2)", nullable: false, comment: ">0说明是促销商品"),
                    cuxiaoDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(((1949)-(10))-(1))", comment: "促销截止日期"),
                    Rate = table.Column<int>(nullable: false, defaultValueSql: "((-1))", comment: "积分比例"),
                    HomeImage = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('‘’')"),
                    IsEnable = table.Column<bool>(nullable: false, defaultValueSql: "((1))", comment: "是否有效，1：有效，0：禁用商品"),
                    IsWeb = table.Column<bool>(nullable: false, defaultValueSql: "((1))", comment: "网站是否可见"),
                    CombinationType = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('单一')", comment: "商品的组合类型：单一、母商品、子商品、组合商品"),
                    ParentId = table.Column<int>(nullable: false, comment: ">1 说明是子商品，0：普通商品，1：母商品"),
                    SaleNumber = table.Column<int>(nullable: false, comment: "销售数量，每日集中计算"),
                    SaleCount = table.Column<int>(nullable: false, comment: "销售次数，每日集中计算"),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    StockNum = table.Column<int>(nullable: false),
                    Feature = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    UserId = table.Column<int>(nullable: false),
                    InnerId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PhotoNum = table.Column<int>(nullable: false),
                    DetailPhotoNum = table.Column<int>(nullable: false),
                    Model = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    IsPublic = table.Column<bool>(nullable: false),
                    DonvvSKU = table.Column<int>(nullable: false),
                    MinimumQuantity = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    SalesAnalysis = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('正常品')"),
                    ForbidWebOrderByNoStock = table.Column<bool>(nullable: false),
                    PriceExtend = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    Color = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    FranchiseeId = table.Column<int>(nullable: false),
                    Tpn = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TPName = table.Column<string>(maxLength: 500, nullable: true),
                    TaxCode = table.Column<string>(maxLength: 50, nullable: true),
                    DataSource = table.Column<int>(nullable: true, comment: "是否抓取/下载"),
                    Tags = table.Column<string>(unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')", comment: "商品标签")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsCaptcha",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    Captcha = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    BranchId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsCaptcha", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "PK")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(nullable: false, comment: "父级Id"),
                    Name = table.Column<string>(maxLength: 50, nullable: false, comment: "名称"),
                    GoodsType = table.Column<int>(nullable: true, comment: "商品类目"),
                    Url = table.Column<string>(maxLength: 200, nullable: true, comment: "链接"),
                    Icon = table.Column<string>(maxLength: 200, nullable: true, comment: "图标"),
                    Order = table.Column<int>(nullable: false, comment: "排序"),
                    Tenant = table.Column<int>(nullable: false, comment: "租户Id"),
                    CreationTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "创建时间"),
                    CreatorUserId = table.Column<int>(nullable: false, comment: "创建用户"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "修改时间"),
                    LastModifierUserId = table.Column<int>(nullable: true, comment: "修改用户"),
                    IsDeleted = table.Column<bool>(nullable: false, comment: "是否删除"),
                    DeletionTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "删除时间"),
                    DeleterUserId = table.Column<int>(nullable: true, comment: "删除用户"),
                    Remark = table.Column<string>(maxLength: 200, nullable: true, comment: "备注")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsCategory", x => x.Id);
                },
                comment: "虚拟类目");

            migrationBuilder.CreateTable(
                name: "GoodsComment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false, defaultValueSql: "((3))"),
                    Label = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Content = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    OrderTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsComment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsDefaultInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsId = table.Column<int>(nullable: false),
                    PurchaseUserId = table.Column<int>(nullable: false),
                    AddUserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsDefaultInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsExtensions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "PK")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsId = table.Column<int>(nullable: false, comment: "商品编号"),
                    Remark = table.Column<string>(type: "text", nullable: true, comment: "规格内容"),
                    VirtualSales = table.Column<int>(nullable: true, comment: "商品虚拟销量，用于应对投标")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsExtensions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsGroupDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsGroupId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    Num = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsGroupDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsId = table.Column<int>(nullable: false),
                    Category = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatorUserId = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(maxLength: 200, nullable: true),
                    Tenant = table.Column<int>(nullable: false),
                    GoodsName = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    UserName = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    Tracking = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsModelValue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsId = table.Column<int>(nullable: false),
                    ModelId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsModelValue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsPackage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "(N'小')", comment: "[小、中、大]"),
                    Num = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    IsDefault = table.Column<int>(nullable: false),
                    BarCode = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('‘’')"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    PriceExtend = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    DonvvSpuCode = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    DonvvSkuCode = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsPackage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsPackageLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    OldNum = table.Column<int>(nullable: false),
                    Num = table.Column<int>(nullable: false),
                    OldName = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    IsDefault = table.Column<int>(nullable: false),
                    OldBarCode = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true),
                    BarCode = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsPackageLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsParamValue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsId = table.Column<int>(nullable: false),
                    ParamId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    GroupName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsParamValue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsPhoto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsId = table.Column<int>(nullable: false),
                    PhotoUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: false, comment: "图片在文件服务器上的访问路径"),
                    IsHomeImage = table.Column<bool>(nullable: false),
                    IsDetailPhoto = table.Column<bool>(nullable: false),
                    Sort = table.Column<int>(nullable: false, defaultValueSql: "((10))"),
                    UserId = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Width = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    Height = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    Photo250Url = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    Photo100Url = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    ImgServerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsPhoto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsPriceLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    GoodsId = table.Column<int>(nullable: false),
                    OldPrice = table.Column<decimal>(type: "money", nullable: false),
                    NewPrice = table.Column<decimal>(type: "money", nullable: false),
                    Memo = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsPriceLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Code = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PCode = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Level = table.Column<int>(nullable: false),
                    PointRate = table.Column<int>(nullable: false, defaultValueSql: "((100))", comment: "积分比率"),
                    PriceArea = table.Column<string>(unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')", comment: "价格区间展示"),
                    IsVisible = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsLeaf = table.Column<bool>(nullable: false, defaultValueSql: "((1))", comment: "是否是叶子分类（一般是3级），只允许在叶子分类下添加商品"),
                    DefaultUnit = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DefaultSource = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    PY = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsTypeParam",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    HasOption = table.Column<bool>(nullable: false),
                    IsCondition = table.Column<bool>(nullable: false),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsTypeParam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsTypeParamGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(nullable: false),
                    ParamSource = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    GroupName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Sort = table.Column<int>(nullable: false, defaultValueSql: "((10))"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsTypeParamGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsTypeParamOption",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParamId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Sort = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsTypeParamOption", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsTypePrivateInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: false),
                    Alias = table.Column<string>(maxLength: 50, nullable: false),
                    Sort = table.Column<int>(nullable: false, defaultValueSql: "((99))"),
                    IsDisable = table.Column<bool>(nullable: false),
                    PointRate = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsTypePrivateInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsTypeUpdate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    TypeCode = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Level = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsTypeUpdate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupOrderStatement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    SumMoney = table.Column<decimal>(type: "money", nullable: false),
                    PaidMoney = table.Column<decimal>(type: "money", nullable: false),
                    PayStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Memo = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ChargeOff = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupOrderStatement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupOrderStatementDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderStatementId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupOrderStatementDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupPay",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderStatementId = table.Column<int>(nullable: false),
                    ChargeOff = table.Column<decimal>(type: "money", nullable: false),
                    PayMoney = table.Column<decimal>(type: "money", nullable: false),
                    PayType = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PayDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Memo = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupPay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_Analysis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(nullable: false),
                    AppKey = table.Column<string>(unicode: false, maxLength: 3000, nullable: true),
                    AppSecret = table.Column<string>(unicode: false, maxLength: 3000, nullable: true),
                    Token = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    ExpiresTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_Analysis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_BeiJingGoods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    I_ProductId = table.Column<string>(maxLength: 255, nullable: true),
                    I_Category = table.Column<string>(maxLength: 255, nullable: true),
                    I_Brand = table.Column<string>(maxLength: 255, nullable: true),
                    I_ProductName = table.Column<string>(maxLength: 500, nullable: true),
                    I_SalePrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_BeiJingGoods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_BeiJingGoodsMap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    I_BeiJingProductId = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DonvvGoodsId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_BeiJingGoodsMap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_BeiJingProductParam",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TPPV_PK = table.Column<string>(maxLength: 255, nullable: true),
                    I_ProductId = table.Column<string>(maxLength: 255, nullable: true),
                    TLSP_PK = table.Column<string>(maxLength: 255, nullable: true),
                    I_ParamName = table.Column<string>(maxLength: 255, nullable: true),
                    I_ParamValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_BeiJingProductParam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_BeiJingZhengCaiCityList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(maxLength: 255, nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Parent = table.Column<string>(maxLength: 255, nullable: true),
                    type = table.Column<string>(maxLength: 255, nullable: true),
                    Memo = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_BeiJingZhengCaiCityList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    I_PlatId = table.Column<int>(nullable: false),
                    I_TypeCode = table.Column<string>(maxLength: 100, nullable: false),
                    I_TypeName = table.Column<string>(maxLength: 100, nullable: false),
                    I_Category = table.Column<string>(maxLength: 100, nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(8, 4)", nullable: false),
                    Discount2 = table.Column<decimal>(type: "decimal(8, 4)", nullable: true),
                    Discount3 = table.Column<decimal>(type: "decimal(8, 4)", nullable: true),
                    Discount4 = table.Column<decimal>(type: "decimal(8, 4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_ChengDuCategoryExt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: true),
                    Code = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Summoney = table.Column<decimal>(type: "money", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_ChengDuCategoryExt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_ChengDuCategoryParam",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Type = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Vals = table.Column<string>(type: "text", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_ChengDuCategoryParam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_ChengDuParamValue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    ParamId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 500, nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_ChengDuParamValue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_EfficientGoods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    IProjectId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    GoodsName = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Model = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    EfficientGoodsCardNum = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    EfficientGoodsImagePath = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    EfficientGoodsCardOrgan = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    AddAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    AddBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_EfficientGoods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_EGoods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    CertNo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CertDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Url = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_EGoods", x => x.Id);
                },
                comment: "商品环保标志");

            migrationBuilder.CreateTable(
                name: "I_ErrLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ErrorMessage = table.Column<string>(maxLength: 500, nullable: false),
                    JsonStr = table.Column<string>(maxLength: 500, nullable: false),
                    ControllerName = table.Column<string>(maxLength: 50, nullable: false),
                    ActionName = table.Column<string>(maxLength: 50, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_ErrLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_Goods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    I_ProjectId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Unit = table.Column<string>(maxLength: 50, nullable: false),
                    Num = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsEnable = table.Column<bool>(nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    MarketPrice = table.Column<decimal>(type: "money", nullable: true),
                    IsModify = table.Column<bool>(nullable: true),
                    StockNum = table.Column<int>(nullable: true),
                    IsNeededPush = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_Goods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_GoodsLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    I_ProjectId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    GoodsName = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Unit = table.Column<string>(maxLength: 50, nullable: false),
                    Num = table.Column<int>(nullable: false),
                    IsEnable = table.Column<bool>(nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    MarketPrice = table.Column<decimal>(type: "money", nullable: true),
                    Operate = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    OperateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Memo = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_GoodsLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_GoodsMap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(nullable: false),
                    ProductId = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    ProductName = table.Column<string>(nullable: false, defaultValueSql: "('')"),
                    ProductUrl = table.Column<string>(unicode: false, nullable: false, defaultValueSql: "('')"),
                    SkuId = table.Column<int>(nullable: false),
                    ProductNameEC = table.Column<string>(nullable: false, defaultValueSql: "('')"),
                    ProductUrlEC = table.Column<string>(unicode: false, nullable: false, defaultValueSql: "('')"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_GoodsMap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_GoodsOperateLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    OperateType = table.Column<int>(nullable: false, comment: @"1，新增商品；
2，修改商品信息；
3，删除商品；
4，商品上下架状态变更；
5，商品价格变更；
6，商品库存变更；
7，商品配件、服务变更；
8，商品图片变更
"),
                    IsDel = table.Column<bool>(nullable: false, comment: "是否删除"),
                    dtCreate = table.Column<DateTime>(type: "datetime", nullable: false),
                    dtUpdate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_GoodsOperateLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_GoodsPart",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 500, nullable: false, comment: "配件名称"),
                    Price = table.Column<decimal>(type: "money", nullable: false, comment: "售价"),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_GoodsPart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_Message",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IProjectId = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: true),
                    Result = table.Column<string>(type: "text", nullable: true),
                    IsDelete = table.Column<bool>(nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remark = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_Message", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_OrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    I_OrderId = table.Column<string>(maxLength: 50, nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    Num = table.Column<int>(nullable: false),
                    Unit = table.Column<string>(maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_OrderDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_OrderExtension",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    AttrName = table.Column<string>(maxLength: 500, nullable: true),
                    AttrVal = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_OrderExtension", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    I_ProjectId = table.Column<int>(nullable: false),
                    I_OrderId = table.Column<string>(maxLength: 100, nullable: false),
                    I_Customer = table.Column<string>(maxLength: 50, nullable: true),
                    SumMoney = table.Column<decimal>(type: "money", nullable: false),
                    OrderTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_Plat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    I_ProviderId = table.Column<int>(nullable: false),
                    IsPostData = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Memo = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_Plat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    ServerId = table.Column<int>(nullable: false),
                    AppKey = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    AppSecret = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Token = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    ExpiredTime = table.Column<long>(nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_ProductsForZGLY",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IProductName = table.Column<string>(maxLength: 500, nullable: true),
                    ISku = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_ProductsForZGLY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_ProductsMapForZGLY",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IProductSku = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    DonvvSku = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    BranchId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_ProductsMapForZGLY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_Project",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    I_PlatId = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: false),
                    ServerId = table.Column<int>(nullable: false),
                    AppKey = table.Column<string>(maxLength: 100, nullable: false),
                    AppSecret = table.Column<string>(maxLength: 100, nullable: false),
                    AccessToken = table.Column<string>(maxLength: 100, nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    client_id = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PrivateKey = table.Column<string>(unicode: false, maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_ProjectExtention",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    I_ProjectId = table.Column<int>(nullable: false),
                    PropName = table.Column<string>(maxLength: 100, nullable: false),
                    PropValue = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_ProjectExtention", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_Provider",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Memo = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_Provider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IContract",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: true),
                    ContractName = table.Column<string>(maxLength: 100, nullable: true),
                    BankName = table.Column<string>(maxLength: 100, nullable: true),
                    BankAccount = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ConNum = table.Column<string>(maxLength: 50, nullable: true),
                    Signature = table.Column<string>(type: "text", nullable: true),
                    Sign = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(maxLength: 1000, nullable: true),
                    Fax = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Tel = table.Column<string>(maxLength: 100, nullable: true),
                    CompanyNum = table.Column<string>(maxLength: 100, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IContract", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IContractMY",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IProjectId = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: false),
                    orderId = table.Column<int>(nullable: false),
                    fileName = table.Column<string>(maxLength: 50, nullable: false),
                    fileByte = table.Column<string>(type: "text", nullable: false, comment: "未签章合同文件流"),
                    fileByted = table.Column<string>(type: "text", nullable: true, comment: "已签章合同文件流"),
                    IsSigned = table.Column<bool>(nullable: false, comment: "是否签章 0：否；1：是"),
                    fielUrl = table.Column<string>(maxLength: 255, nullable: true, comment: "pdf所在路径"),
                    dtSubmitTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "提交时间"),
                    dtSignTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "签章时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IContractMY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IntroductionInvestment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(nullable: false, defaultValueSql: "('')"),
                    UserId = table.Column<int>(nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntroductionInvestment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreId = table.Column<int>(nullable: false),
                    StoreZone = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    GoodsId = table.Column<int>(nullable: false),
                    Num = table.Column<int>(nullable: false),
                    AC = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    IsCustomGoods = table.Column<bool>(nullable: false),
                    OrderDetailId = table.Column<int>(nullable: false),
                    StoreZoneMemo = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    GiftNum = table.Column<int>(nullable: false),
                    AFC = table.Column<decimal>(type: "decimal(18, 4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventoryLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    Operate = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "操作类型"),
                    RelationId = table.Column<int>(nullable: false, comment: "相关Id"),
                    OldNum = table.Column<int>(nullable: false, comment: "操作前的数量"),
                    Num = table.Column<int>(nullable: false, comment: "本次操作数量，可为负数，比如拣货就是 负数，入库就是正数"),
                    AC = table.Column<decimal>(type: "money", nullable: false),
                    OldStoreZone = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    StoreZone = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    NewNum = table.Column<int>(nullable: false),
                    IsCustomGoods = table.Column<bool>(nullable: false),
                    AFC = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventoryModifyAC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifyACId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    StoreZone = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    GoodsId = table.Column<int>(nullable: false),
                    Num = table.Column<int>(nullable: false),
                    OldAC = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    NewAC = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    StoreZoneMemo = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryModifyAC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventoryStock",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreId = table.Column<int>(nullable: false, comment: "仓库号，如果为0，表示共有商品"),
                    GoodsId = table.Column<int>(nullable: false),
                    MinStock = table.Column<int>(nullable: false, comment: "最小库存，安全库存"),
                    MaxStock = table.Column<int>(nullable: false, comment: "最大库存，库存上限"),
                    Memo = table.Column<string>(maxLength: 500, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryStock", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    OrderStatementId = table.Column<int>(nullable: false),
                    InvoiceRequireId = table.Column<int>(nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    InvoiceNo = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    InvoiceType = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    InvoiceMoney = table.Column<decimal>(type: "money", nullable: false),
                    Memo = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UserId = table.Column<int>(nullable: false),
                    InvoiceCode = table.Column<string>(unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    Content = table.Column<string>(unicode: false, nullable: false, defaultValueSql: "('')"),
                    ReceiveMoneyId = table.Column<int>(nullable: true),
                    IsPushInvoicePlat = table.Column<bool>(nullable: true),
                    OrderNo = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PlatInvoiceRequestNo = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    IsInvoiceSuccess = table.Column<bool>(nullable: true),
                    PdfUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    InvoiceDetailUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    IsRelateDetail = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    OrderStatementId = table.Column<int>(nullable: false),
                    InvoiceRequireId = table.Column<int>(nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    InvoiceNo = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    InvoiceType = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    InvoiceMoney = table.Column<decimal>(type: "money", nullable: false),
                    Memo = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    InvoiceCode = table.Column<string>(unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    Content = table.Column<string>(unicode: false, nullable: false, defaultValueSql: "('')"),
                    ReceiveMoneyId = table.Column<int>(nullable: true),
                    IsPushInvoicePlat = table.Column<bool>(nullable: true),
                    OrderNo = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PlatInvoiceRequestNo = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    IsInvoiceSuccess = table.Column<bool>(nullable: true),
                    PdfUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    InvoiceDetailUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    InvoiceCreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    InvoiceCreateUserId = table.Column<int>(nullable: false),
                    InvoiceDeleteTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    InvoiceDeleteUserId = table.Column<int>(nullable: false),
                    CancelPdfUrl = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    CancelDetailUrl = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    CancelOrderNo = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    CancelPlatInvoiceRequestNo = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    StatementIds = table.Column<string>(unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceRequire",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false, comment: "预留字段：收票人"),
                    StatementId = table.Column<int>(nullable: false),
                    InvoiceName = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    InvoiceType = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    InvoiceContent = table.Column<string>(nullable: false),
                    InvoiceAmount = table.Column<decimal>(type: "money", nullable: false),
                    InvoiceMemo = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    InvoiceStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "((0))"),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DistributionType = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    IsRelateDetail = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    BuyerTaxNum = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    BuyerBank = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    BuyerBankAccount = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    BuyerAddress = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    SaleName = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    SaleTaxNum = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    SaleBank = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    SaleBankAccount = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    SalePhone = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    SaleAddress = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    IsCrossInvoice = table.Column<bool>(nullable: false),
                    PreInvoiceId = table.Column<int>(nullable: false),
                    BuyerPhone = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceRequire", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceRequireDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "唯一标示ID")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceRequireId = table.Column<int>(nullable: false, comment: "开票申请表ID"),
                    OrderDetailId = table.Column<int>(nullable: false, comment: "订单明细Id"),
                    GoodsInvoiceNum = table.Column<int>(nullable: false),
                    StatementId = table.Column<int>(nullable: true),
                    OrderId = table.Column<int>(nullable: true),
                    InvoiceMoney = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TaxRate = table.Column<decimal>(type: "money", nullable: true),
                    TaxCode = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    DisplayName = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    GoodsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceRequireDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IOrderContract",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: true),
                    ContractId = table.Column<int>(nullable: true),
                    ContractNum = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    DeliveryTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceiveUser = table.Column<string>(maxLength: 50, nullable: true),
                    BranchId = table.Column<int>(nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Fax = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Tel = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IOrderContract", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoginedIdentity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(nullable: false),
                    BuyerCookie = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    SessionId = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    PostUrl = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    UserEmail = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginedIdentity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logistics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    LogisticName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    LogisticNo = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    AddAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogisticsCompany",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    ShortName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    IsDefault = table.Column<bool>(nullable: false, comment: "快递，物流，国际"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    IsDisable = table.Column<bool>(nullable: false),
                    SupportedId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogisticsCompany", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogisticsDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    Content = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    OperateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Operator = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogisticsDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogisticsInfomation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogisticsCompanyId = table.Column<int>(nullable: false),
                    TrackingNumber = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    FromUser = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    FromTelphone = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    FromAddress = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    ToUser = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ToTelphone = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ToAddress = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    ImgUrl = table.Column<string>(unicode: false, maxLength: 300, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    OrderId = table.Column<int>(nullable: false),
                    LogisticsInfo = table.Column<string>(nullable: false, defaultValueSql: "('')"),
                    OrderType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogisticsInfomation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogisticsSubscribeLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrackingNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    Context = table.Column<string>(nullable: false, defaultValueSql: "('')"),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogisticsSubscribeLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogisticsSupported",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogisticsCompany = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    Code = table.Column<string>(unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    Memo = table.Column<string>(maxLength: 1000, nullable: true),
                    Type = table.Column<string>(maxLength: 50, nullable: true),
                    CountryCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MajorParamsDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsId = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: false),
                    PlatId = table.Column<int>(nullable: false),
                    ParamsName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    ParamsValue = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    UserBy = table.Column<int>(nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MajorParamsDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MallFloatAd",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    Position = table.Column<string>(maxLength: 50, nullable: false),
                    ImgPath = table.Column<string>(maxLength: 200, nullable: true),
                    ImgUrl = table.Column<string>(maxLength: 200, nullable: true),
                    Height = table.Column<int>(nullable: true),
                    Width = table.Column<int>(nullable: true),
                    Code = table.Column<string>(maxLength: 2000, nullable: true),
                    IsEnable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MallFloatAd", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MallSideBar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    HoverName = table.Column<string>(maxLength: 10, nullable: false),
                    Icon = table.Column<string>(maxLength: 50, nullable: false),
                    IsEnable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MallSideBar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    DeptId = table.Column<int>(nullable: false),
                    LoginName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PassWord = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    RealName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Telphone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "邮箱"),
                    IM = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "即时通讯Id"),
                    LoginNumber = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    Point = table.Column<double>(nullable: false, comment: "积分"),
                    Province = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    City = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Area = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    PostCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    RegisterMethod = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('平台开通')", comment: "注册方式"),
                    RegisterDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ConfirmLevel = table.Column<int>(nullable: false, comment: "用户的审核级别"),
                    VIPCounterLevel = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    IsMainContact = table.Column<bool>(nullable: false, comment: "是否主要联系人"),
                    IsAdmin = table.Column<bool>(nullable: false, comment: "是否是公司管理员"),
                    IsOrderAuthority = table.Column<bool>(nullable: false, comment: "是否有下单权限"),
                    IsEnable = table.Column<bool>(nullable: false, defaultValueSql: "((1))", comment: "是否有效"),
                    IsCheckMobile = table.Column<bool>(nullable: false, comment: "手机是否验证"),
                    IsCheckEmail = table.Column<bool>(nullable: false, comment: "邮件是否验证"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    BranchId = table.Column<int>(nullable: false),
                    Role = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    IsForbidden = table.Column<bool>(nullable: false),
                    IsDerectApply = table.Column<bool>(nullable: false),
                    IsEmailApply = table.Column<bool>(nullable: false),
                    IsOrderForManyDepts = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "('1')"),
                    Balance = table.Column<decimal>(type: "money", nullable: false),
                    IsBalance = table.Column<bool>(nullable: false),
                    HeadPortraitUrl = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Position = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberAddress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(nullable: false),
                    RealName = table.Column<string>(maxLength: 50, nullable: false),
                    Province = table.Column<string>(maxLength: 20, nullable: true),
                    City = table.Column<string>(maxLength: 20, nullable: true),
                    Area = table.Column<string>(maxLength: 20, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    Mobile = table.Column<string>(maxLength: 50, nullable: true),
                    TelPhone = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberAddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberAddressTemp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(nullable: false),
                    RealName = table.Column<string>(maxLength: 50, nullable: false),
                    Province = table.Column<string>(maxLength: 20, nullable: true),
                    City = table.Column<string>(maxLength: 20, nullable: true),
                    Area = table.Column<string>(maxLength: 20, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    Mobile = table.Column<string>(maxLength: 50, nullable: true),
                    TelPhone = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberAddressTemp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberApplyDept",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false, comment: "客户Id"),
                    MemberId = table.Column<int>(nullable: false, comment: "联系人Id"),
                    DeptId = table.Column<int>(nullable: false, comment: "此联系人能审核的部门Id"),
                    DeptName = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "部门名称"),
                    Code = table.Column<string>(unicode: false, maxLength: 100, nullable: true, comment: "部门编号"),
                    PCode = table.Column<string>(unicode: false, maxLength: 100, nullable: true, comment: "父部门编号"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "更新时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberApplyDept", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberAuth",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(nullable: true),
                    BranchId = table.Column<int>(nullable: true),
                    AccessToken = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    RereshToken = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    StrustNo = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    ExpireTimeSpan = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberAuth", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberCart",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    Num = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    IsEnable = table.Column<bool>(nullable: false),
                    IsChecked = table.Column<bool>(nullable: false),
                    Multiples = table.Column<int>(nullable: false),
                    DisplayNum = table.Column<int>(nullable: false),
                    DisplayUnit = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberCart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberFav",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberFav", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberInvoiceInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(nullable: false),
                    MemberName = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('0')"),
                    InvoiceCategory = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "发票类别（纸质、电子）"),
                    InvoiceType = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "发票类型"),
                    InvoiceContent = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "发票内容"),
                    InvoiceName = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: "发票抬头"),
                    InvoiceTaxNo = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "税号"),
                    InvoiceAddress = table.Column<string>(unicode: false, maxLength: 500, nullable: false, comment: "地址"),
                    InvoicePhone = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "注册手机"),
                    InvoiceBank = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "开户行"),
                    InvoiceBankAccount = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "开户行账号"),
                    InvoiceMemo = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "发票备注"),
                    EmailForInvoice = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "电子发票邮箱"),
                    CustomerId = table.Column<int>(nullable: true),
                    IsDefault = table.Column<bool>(nullable: true),
                    InvoiceReceivePhone = table.Column<string>(unicode: false, maxLength: 50, nullable: true, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberInvoiceInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, comment: "懂微租户唯一标识"),
                    CustomerId = table.Column<int>(nullable: false, comment: "客户Id"),
                    MemberId = table.Column<int>(nullable: false, comment: "联系人Id"),
                    MemberName = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "联系人名称"),
                    Operate = table.Column<int>(nullable: false, comment: "操作，枚举"),
                    Memo = table.Column<string>(maxLength: 500, nullable: true, comment: "备注"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "更新时间"),
                    Tracking = table.Column<string>(nullable: true, comment: "联系人关联信息"),
                    CustomerName = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberOrderDept",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false, comment: "客户Id"),
                    MemberId = table.Column<int>(nullable: false, comment: "联系人Id"),
                    DeptId = table.Column<int>(nullable: false, comment: "此联系人能下单的部门Id"),
                    DeptName = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "部门名称"),
                    Code = table.Column<string>(unicode: false, maxLength: 100, nullable: true, comment: "部门编号"),
                    PCode = table.Column<string>(unicode: false, maxLength: 100, nullable: true, comment: "父部门编号"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "更新时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberOrderDept", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberPoint",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    RelationId = table.Column<int>(nullable: false),
                    Income = table.Column<decimal>(type: "money", nullable: false),
                    Spend = table.Column<decimal>(type: "money", nullable: false),
                    Balance = table.Column<decimal>(type: "money", nullable: false),
                    Memo = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberPoint", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberTemp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    DeptId = table.Column<int>(nullable: false),
                    LoginName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PassWord = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    RealName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Telphone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    IM = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LoginNumber = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    Point = table.Column<double>(nullable: false),
                    Province = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    City = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Area = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    PostCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    RegisterMethod = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('平台开通')"),
                    RegisterDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ConfirmLevel = table.Column<int>(nullable: false),
                    VIPCounterLevel = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    IsMainContact = table.Column<bool>(nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false),
                    IsOrderAuthority = table.Column<bool>(nullable: false),
                    IsEnable = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsCheckMobile = table.Column<bool>(nullable: false),
                    IsCheckEmail = table.Column<bool>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    BranchId = table.Column<int>(nullable: false),
                    Role = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    IsForbidden = table.Column<bool>(nullable: false),
                    IsDerectApply = table.Column<bool>(nullable: false),
                    IsEmailApply = table.Column<bool>(nullable: false),
                    IsOrderForManyDepts = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "('1')"),
                    Balance = table.Column<decimal>(type: "money", nullable: false),
                    IsBalance = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberTemp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModifyAC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    Unit = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    OldInPrice = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    OldAC = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    ModifyGoodsInPrice = table.Column<bool>(nullable: false),
                    NewInPrice = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    ModifyInventoryAC = table.Column<bool>(nullable: false),
                    StockNum = table.Column<int>(nullable: false),
                    ModifyOrderDetailAC = table.Column<int>(nullable: false),
                    OrderCount = table.Column<int>(nullable: false),
                    NewAC = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Memo = table.Column<string>(maxLength: 1000, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModifyAC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NeedToPurchase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Memo = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    PrintNum = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NeedToPurchase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NeedToPurchaseDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NeedToPurchaseId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    GoodsMemo = table.Column<string>(unicode: false, nullable: false),
                    Num = table.Column<int>(nullable: false),
                    LackNum = table.Column<int>(nullable: false),
                    PurchaseType = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PurchaseMemo = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    CreditCard = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Emergency = table.Column<bool>(nullable: false),
                    SupplierId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    InPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, defaultValueSql: "((0))"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    IsCustomGoods = table.Column<bool>(nullable: false),
                    OrderDetailId = table.Column<int>(nullable: false),
                    Memo = table.Column<string>(nullable: true),
                    StoreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NeedToPurchaseDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NeedToPurchaseOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NeedToPurchaseId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NeedToPurchaseOrder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 300, nullable: false),
                    NewsTypeId = table.Column<int>(nullable: false),
                    Author = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "(N'‘’')"),
                    PublishDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Content = table.Column<string>(type: "text", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    IsTop = table.Column<bool>(nullable: false),
                    IsEnable = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notify_Msg",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "PK")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TempletId = table.Column<int>(nullable: false, comment: "模板Id"),
                    TempletValue = table.Column<string>(type: "text", nullable: true, comment: "模板值"),
                    Title = table.Column<string>(maxLength: 200, nullable: true, comment: "标题"),
                    Content = table.Column<string>(type: "text", nullable: false, comment: "内容"),
                    SendId = table.Column<int>(nullable: true, comment: "发送者Id"),
                    ReceiveId = table.Column<int>(nullable: true, comment: "接受者Id"),
                    Status = table.Column<int>(nullable: false, comment: "未发送/发送中/发送成功/发送失败"),
                    Type = table.Column<int>(nullable: false, comment: "消息类型"),
                    Item = table.Column<int>(nullable: false, comment: "消息分类    邮件/短信/系统消息/用户消息"),
                    RelationId = table.Column<int>(nullable: true, comment: "关联值"),
                    Extend1 = table.Column<string>(maxLength: 200, nullable: true, comment: "扩展属性"),
                    Extend2 = table.Column<int>(nullable: true, comment: "扩展值"),
                    CreationTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "创建时间"),
                    CreatorUserId = table.Column<int>(nullable: false, comment: "创建用户"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "修改时间"),
                    LastModifierUserId = table.Column<int>(nullable: true, comment: "修改用户"),
                    IsDeleted = table.Column<bool>(nullable: false, comment: "是否删除"),
                    DeletionTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "删除时间"),
                    DeleterUserId = table.Column<int>(nullable: true, comment: "删除用户"),
                    Remark = table.Column<string>(maxLength: 200, nullable: true, comment: "备注"),
                    Tenant = table.Column<int>(nullable: false, comment: "租户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notify_Msg", x => x.Id);
                },
                comment: "系统消息");

            migrationBuilder.CreateTable(
                name: "Notify_Setting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppKey = table.Column<string>(maxLength: 200, nullable: true),
                    Email = table.Column<string>(maxLength: 200, nullable: true),
                    EmailName = table.Column<string>(maxLength: 200, nullable: true),
                    EmailPsw = table.Column<string>(maxLength: 200, nullable: true),
                    EmailSmtp = table.Column<string>(maxLength: 200, nullable: true),
                    EmailNickName = table.Column<string>(maxLength: 200, nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Extend1 = table.Column<string>(maxLength: 200, nullable: true),
                    Extend2 = table.Column<string>(maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatorUserId = table.Column<int>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastModifierUserId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletionTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleterUserId = table.Column<int>(nullable: true),
                    Remark = table.Column<string>(maxLength: 200, nullable: true),
                    Tenant = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notify_Setting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notify_SmsSign",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "PK")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false, comment: "名称"),
                    DisplayName = table.Column<string>(maxLength: 50, nullable: false, comment: "显示名称"),
                    Status = table.Column<int>(nullable: false, comment: "状态"),
                    IsEnabled = table.Column<bool>(nullable: false, comment: "是否启用"),
                    Extend1 = table.Column<string>(maxLength: 50, nullable: true, comment: "扩展字段1"),
                    Extend2 = table.Column<string>(maxLength: 50, nullable: true, comment: "扩展字段2"),
                    CreationTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "创建时间"),
                    CreatorUserId = table.Column<int>(nullable: false, comment: "创建用户"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "修改时间"),
                    LastModifierUserId = table.Column<int>(nullable: true, comment: "修改用户"),
                    IsDeleted = table.Column<bool>(nullable: false, comment: "是否删除"),
                    DeletionTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "删除时间"),
                    DeleterUserId = table.Column<int>(nullable: true, comment: "删除用户"),
                    Remark = table.Column<string>(maxLength: 200, nullable: true, comment: "备注"),
                    Tenant = table.Column<int>(nullable: false, comment: "租户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notify_SmsSign", x => x.Id);
                },
                comment: "短信签名");

            migrationBuilder.CreateTable(
                name: "Notify_Templet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "PK")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false, comment: "名称"),
                    Mode = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false, comment: "类型"),
                    SignId = table.Column<int>(nullable: true, comment: "签名Id"),
                    Code = table.Column<long>(nullable: true, comment: "外部编码"),
                    Title = table.Column<string>(maxLength: 200, nullable: true, comment: "标题"),
                    Templet = table.Column<string>(type: "text", nullable: false, comment: "模板内容"),
                    DisplayTemplet = table.Column<string>(type: "text", nullable: false, comment: "显示内容"),
                    Status = table.Column<int>(nullable: false, comment: "未审核/审核中/审核成功/审核失败"),
                    Reason = table.Column<string>(maxLength: 200, nullable: true, comment: "审核备注"),
                    CreationTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "创建时间"),
                    CreatorUserId = table.Column<int>(nullable: false, comment: "创建用户"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "修改时间"),
                    LastModifierUserId = table.Column<int>(nullable: true, comment: "修改用户"),
                    IsDeleted = table.Column<bool>(nullable: false, comment: "是否删除"),
                    DeletionTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "删除时间"),
                    DeleterUserId = table.Column<int>(nullable: true, comment: "删除用户"),
                    Remark = table.Column<string>(maxLength: 200, nullable: true, comment: "备注"),
                    Tenant = table.Column<int>(nullable: false, comment: "租户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notify_Templet", x => x.Id);
                },
                comment: "系统邮件模板");

            migrationBuilder.CreateTable(
                name: "OrderAfterSale",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    DisplayName = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Unit = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ApplyType = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ApplyNum = table.Column<int>(nullable: false),
                    ApplyReason = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    QuestionDescribe = table.Column<string>(maxLength: 500, nullable: false),
                    ReturnWay = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PickupAddress = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    PickupDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceiveAddress = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    ApplyUserId = table.Column<int>(nullable: false),
                    ApplyUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ApplyTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ContactWay = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    DisplayStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    InnerStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    OperateUserId = table.Column<int>(nullable: true),
                    OperateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    OperateType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    OperateMessage = table.Column<string>(maxLength: 500, nullable: true),
                    OperateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsEvaluate = table.Column<bool>(nullable: false),
                    Updatetime = table.Column<DateTime>(type: "datetime", nullable: false),
                    OrderDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderAfterSale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderAfterSaleFlow",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AfterSaleId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    OperateType = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    OperateUserId = table.Column<int>(nullable: false),
                    OperateUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    OperateMessage = table.Column<string>(maxLength: 500, nullable: false),
                    Memo = table.Column<string>(maxLength: 500, nullable: true),
                    DisplayStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    InnerStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderAfterSaleFlow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderAfterSalePhoto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AfterSaleId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    PhotoUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderAfterSalePhoto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderArchive",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    Page = table.Column<int>(nullable: false),
                    PhotoUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    SaveNum = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AllPage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderArchive", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderBox",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    BoxId = table.Column<int>(nullable: false),
                    PrintNum = table.Column<int>(nullable: false, comment: "包裹码打印次数"),
                    PrintTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "包裹的状态：未处理，已打印，已打包，已装车."),
                    StoreZone = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "包裹所在区域"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    PackageNumber = table.Column<int>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderBox", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderCheckoutLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "PK")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(nullable: false),
                    CheckoutTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "结账时间"),
                    CreationTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "创建时间"),
                    CreatorUserId = table.Column<int>(nullable: false, comment: "创建用户"),
                    Remark = table.Column<string>(maxLength: 200, nullable: true, comment: "备注"),
                    Tenant = table.Column<int>(nullable: false, comment: "租户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCheckoutLog", x => x.Id);
                },
                comment: "订单结账日志");

            migrationBuilder.CreateTable(
                name: "OrderDelivery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(nullable: false, comment: "车辆Id"),
                    CarUserId = table.Column<int>(nullable: false, comment: "车辆司机Id"),
                    StockOutUserId = table.Column<int>(nullable: false, comment: "出库员Id"),
                    Status = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')", comment: "装车状态"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Memo = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Address = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Latitude = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Longitude = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDelivery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDeliveryBox",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDeliveryId = table.Column<int>(nullable: false),
                    OrderBoxId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Address = table.Column<string>(unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    Latitude = table.Column<string>(unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    Longitude = table.Column<string>(unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDeliveryBox", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    Num = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    AC = table.Column<decimal>(type: "money", nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    Point = table.Column<decimal>(type: "money", nullable: false),
                    PurchaseMemo = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    PickNum = table.Column<int>(nullable: false),
                    IsGift = table.Column<bool>(nullable: false, comment: "是否是赠品"),
                    SingleRemark = table.Column<string>(nullable: true),
                    InternalRemark = table.Column<string>(nullable: true),
                    IsTotalPriceModel = table.Column<bool>(nullable: false),
                    IsCustomGoods = table.Column<bool>(nullable: false),
                    AntiCounterfeiting = table.Column<bool>(nullable: false),
                    DisplayNum = table.Column<int>(nullable: false),
                    DisplayUnit = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DisplayPrice = table.Column<decimal>(type: "money", nullable: false),
                    IsComment = table.Column<bool>(nullable: false),
                    OldOrderId = table.Column<int>(nullable: false),
                    RefundNum = table.Column<int>(nullable: false),
                    GrossProfitPercent = table.Column<string>(unicode: false, maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    TaxRate = table.Column<decimal>(type: "money", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "money", nullable: false),
                    NoTaxAmount = table.Column<decimal>(type: "money", nullable: false),
                    GrossProfit = table.Column<decimal>(type: "money", nullable: false),
                    NoTaxPrice = table.Column<decimal>(type: "money", nullable: false),
                    DisplayNoTaxPrice = table.Column<decimal>(type: "money", nullable: false),
                    AFC = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDistribution",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false, comment: "订单编号"),
                    BranchId = table.Column<int>(nullable: false, comment: "订单所属Branch"),
                    PBranchId = table.Column<int>(nullable: false, comment: "订单所属Branch的父Branch"),
                    OriginalBranchId = table.Column<int>(nullable: false, comment: "订单最原始的BranchId"),
                    ParentReceiveRate = table.Column<double>(nullable: false),
                    SumMoney = table.Column<decimal>(type: "money", nullable: false, comment: "上级抽层后的订单总额"),
                    UserId = table.Column<int>(nullable: false, comment: "分配人员"),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    PayStatus = table.Column<int>(nullable: false, comment: "付款状态"),
                    PayChargeOff = table.Column<decimal>(type: "money", nullable: false, comment: "付款金额"),
                    InvoiceStatus = table.Column<int>(nullable: false, comment: "收票金额"),
                    InvoiceChargeOff = table.Column<decimal>(type: "money", nullable: false, comment: "收票状态")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDistribution", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDistributionDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    OrderDistributionId = table.Column<int>(nullable: false, comment: "分销订单与集团成员关联表Id"),
                    Num = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false, comment: "上级抽层后的单价"),
                    Amount = table.Column<decimal>(type: "money", nullable: false, comment: "上级抽层后的金额"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDistributionDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderGoodsComments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsId = table.Column<int>(nullable: false),
                    OrderDetailId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    CommentContent = table.Column<string>(maxLength: 500, nullable: false),
                    Recommend = table.Column<int>(nullable: false),
                    IsAnonymous = table.Column<bool>(nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Label = table.Column<string>(maxLength: 500, nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderGoodsComments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderInvoiceInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false, comment: "发票类型"),
                    Name = table.Column<string>(maxLength: 500, nullable: true, comment: "购方发票抬头"),
                    Content = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "购方发票内容"),
                    TaxNo = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "购方税号"),
                    Address = table.Column<string>(unicode: false, maxLength: 500, nullable: false, comment: "购方地址"),
                    Phone = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "购方注册电话"),
                    Bank = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "购方开户行"),
                    BankAccount = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "购方开户行账号"),
                    Memo = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "发票备注"),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "购方电子邮箱"),
                    Mobile = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "购方手机号")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderInvoiceInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    Status = table.Column<string>(maxLength: 50, nullable: false),
                    Operate = table.Column<string>(maxLength: 200, nullable: false),
                    IsInner = table.Column<bool>(nullable: false, comment: "1:内部可见；0：客户可见"),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderModify",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    OldNum = table.Column<int>(nullable: false),
                    NewNum = table.Column<int>(nullable: false),
                    OldPrice = table.Column<decimal>(type: "money", nullable: false),
                    NewPrice = table.Column<decimal>(type: "money", nullable: false),
                    PurchaseType = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('‘’')", comment: "订单修改后，自动生成 采购单时用到的状态"),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    IsNeedCollect = table.Column<bool>(nullable: false),
                    NeedToPurchaseId = table.Column<int>(nullable: false),
                    DisplayUnit = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    Memo = table.Column<string>(type: "text", nullable: true),
                    OldTaxRate = table.Column<decimal>(type: "money", nullable: false),
                    NewTaxRate = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderModify", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderModifyAC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifyACId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    SumMoney = table.Column<decimal>(type: "money", nullable: false, comment: "订单金额"),
                    GrossProfit = table.Column<decimal>(type: "money", nullable: false, comment: "毛利"),
                    NewGrossProfit = table.Column<decimal>(type: "money", nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    Num = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    OldAC = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    NewAC = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    OldGrossProfitPercent = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "((0))"),
                    NewGrossProfitPercent = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderModifyAC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderPicking",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    PickingUserId = table.Column<int>(nullable: false, comment: "理货员Id"),
                    DistributeUserId = table.Column<int>(nullable: false, comment: "分单员"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPicking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderPickingLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    OrderDetailId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    StoreZone = table.Column<string>(fixedLength: true, maxLength: 100, nullable: false),
                    PickingUserId = table.Column<int>(nullable: false),
                    Num = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    GiftNum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPickingLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderReceiveMoney",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderStatementId = table.Column<int>(nullable: false),
                    ChargeOff = table.Column<decimal>(type: "money", nullable: false, comment: "销账金额"),
                    ReceiveMoney = table.Column<decimal>(type: "money", nullable: false, comment: "收款金额"),
                    ReceiveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PayType = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "付款方式"),
                    Memo = table.Column<string>(maxLength: 500, nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ReceiveAccount = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    PreReceiveMoneyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderReceiveMoney", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderReceiveMoneyDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiveMoneyId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    Num = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    ChargeOffAmount = table.Column<decimal>(type: "money", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    GoodsName = table.Column<string>(unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderReceiveMoneyDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "添加订单，根据GUID得到 订单的Id"),
                    BranchId = table.Column<int>(nullable: false, defaultValueSql: "((1))", comment: "SYNAct客户Id"),
                    CustomerId = table.Column<int>(nullable: false, comment: "客户Id，个人客户则为0"),
                    DeptId = table.Column<int>(nullable: false, comment: "Member所在部门的Id"),
                    MemberId = table.Column<int>(nullable: false),
                    OrderType = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "((0))", comment: "订单类型"),
                    OrderTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "下单时间"),
                    PlanDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "计划配送日期"),
                    FinishDate = table.Column<DateTime>(type: "datetime", nullable: true, comment: "订单完成时间"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "最近更新时间"),
                    RowNum = table.Column<int>(nullable: false),
                    SumMoney = table.Column<decimal>(type: "money", nullable: false, comment: "订单金额"),
                    GrossProfit = table.Column<decimal>(type: "money", nullable: false, comment: "毛利"),
                    Point = table.Column<decimal>(type: "money", nullable: false, comment: "积分"),
                    Customer = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    DeptName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    RealName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "收货人姓名"),
                    Telphone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Memo = table.Column<string>(type: "text", nullable: true),
                    IsInvoice = table.Column<int>(nullable: false, comment: "1:开发票；0：不开发票"),
                    InvoiceName = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "发票抬头"),
                    InvoiceType = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "发票类型"),
                    InvoiceContent = table.Column<string>(maxLength: 4000, nullable: true, comment: "发票内容"),
                    SaveNum = table.Column<int>(nullable: false),
                    PrintNum = table.Column<int>(nullable: false),
                    PrintTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(((1900)-(1))-(1))"),
                    PayType = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "支付方式"),
                    PayStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "((0))", comment: "付款状态"),
                    IsEnable = table.Column<bool>(nullable: false, comment: "0:草稿 1:正式订单"),
                    IsEmergency = table.Column<bool>(nullable: false, comment: "是否紧急，1：紧急订单"),
                    IsInner = table.Column<bool>(nullable: false, comment: "1:内部可见，客户端对账不可见，主要用于"),
                    IsDelete = table.Column<bool>(nullable: false, comment: "1 删除的订单"),
                    IsStorage = table.Column<bool>(nullable: false, comment: "是否已经入库，Member库存管理时使用"),
                    IsCopied = table.Column<bool>(nullable: false, comment: "是否被复制"),
                    RawOrderId = table.Column<int>(nullable: false, comment: "原订单Id"),
                    UserId = table.Column<int>(nullable: false, comment: "下单人Id"),
                    SalesId = table.Column<int>(nullable: false, comment: "业务员Id，统计业绩时用"),
                    ServiceId = table.Column<int>(nullable: false),
                    ServiceStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ServiceFinishTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PurchaseStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PurchaseFinishTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    StoreStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    StoreFinishTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    PackageNum = table.Column<int>(nullable: false),
                    DeliveryStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DeliveryFinishTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsArchive = table.Column<bool>(nullable: false, comment: "是否已经归档"),
                    ApplyId = table.Column<int>(nullable: false, comment: "VIPApply的Id"),
                    I_OrderId = table.Column<string>(unicode: false, maxLength: 100, nullable: true, comment: "接口：订单Id"),
                    I_Name = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "接口：单位名称"),
                    ChargeOff = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    IsChecked = table.Column<bool>(nullable: false),
                    DeliveryType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    RawBranchId = table.Column<int>(nullable: false),
                    GroupChecked = table.Column<bool>(nullable: false),
                    InvoiceCategory = table.Column<string>(unicode: false, maxLength: 50, nullable: true, defaultValueSql: "('纸质发票')"),
                    EmailForInvoice = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    InvoiceInfo = table.Column<string>(nullable: true),
                    IsConfirm = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    ConfirmStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ConfirmFinishTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsShowAmountInPrint = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    PaymentType = table.Column<string>(maxLength: 20, nullable: true),
                    LogisticsId = table.Column<int>(nullable: false),
                    GroupReceivePercent = table.Column<double>(nullable: false),
                    ThirdPartyId = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    usercode = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    QuotationStatus = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "('未处理')"),
                    AuditStatus = table.Column<int>(nullable: false),
                    AuditReason = table.Column<int>(nullable: false),
                    AuditRemark = table.Column<string>(maxLength: 300, nullable: true),
                    StoreId = table.Column<int>(nullable: true),
                    StoreName = table.Column<string>(maxLength: 50, nullable: true),
                    Checkout = table.Column<bool>(nullable: false),
                    ArchivedTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01 00:00:00.000')"),
                    IsSpecial = table.Column<bool>(nullable: true),
                    CreateVoucherResult = table.Column<bool>(nullable: true),
                    FinancialSoftware = table.Column<int>(nullable: true),
                    Balance = table.Column<decimal>(type: "money", nullable: false),
                    PayAmount = table.Column<decimal>(type: "money", nullable: false),
                    Freight = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ProjectId = table.Column<int>(nullable: true),
                    OrderAmount = table.Column<decimal>(type: "money", nullable: false),
                    TaxMoney = table.Column<decimal>(type: "money", nullable: false),
                    NoTaxMoney = table.Column<decimal>(type: "money", nullable: false),
                    GrossProfitPercent = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    SumMoney = table.Column<decimal>(type: "money", nullable: false),
                    PaidMoney = table.Column<decimal>(type: "money", nullable: false),
                    PayStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Memo = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    PrintNum = table.Column<int>(nullable: false),
                    InvoiceType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InvoiceStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InvoiceMoney = table.Column<decimal>(type: "money", nullable: false),
                    NeedToInvoice = table.Column<decimal>(type: "money", nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ChargeOff = table.Column<decimal>(type: "money", nullable: false),
                    IsCrossInvoice = table.Column<bool>(nullable: false),
                    SumGoodsAmount = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatementCrossInvoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    StatementId = table.Column<int>(nullable: false),
                    InvoiceRequireId = table.Column<int>(nullable: false),
                    IsDetele = table.Column<bool>(nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatementCrossInvoice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatementDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderStatementId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatementDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParamGather",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    PlatId = table.Column<int>(nullable: false),
                    ParamsName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    UserBy = table.Column<int>(nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParamGather", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    LogText = table.Column<string>(nullable: true),
                    Amount = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlatformInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    I_ProjectId = table.Column<int>(nullable: false),
                    PlatformCode = table.Column<string>(maxLength: 100, nullable: false),
                    PlatformName = table.Column<string>(maxLength: 100, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatformInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreGoodsPhoto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PhotoUrl = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    IsHomeImage = table.Column<bool>(nullable: true),
                    IsDetailPhoto = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreGoodsPhoto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreInvoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    CustomerName = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    InvoiceName = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    InvoiceType = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    InvoiceContent = table.Column<string>(nullable: false),
                    InvoiceCode = table.Column<string>(unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    InvoiceDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    InvoiceNo = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    InvoiceRemark = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    InvoiceEmail = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    InvoiceMobile = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    BuyerTaxNum = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    BuyerBank = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    BuyerBankAccount = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    BuyerAddress = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    SaleName = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    SaleTaxNum = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    SaleBank = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    SaleBankAccount = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    SalePhone = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    SaleAddress = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DistributionType = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    MemberId = table.Column<int>(nullable: false),
                    InitialAmount = table.Column<decimal>(type: "money", nullable: false),
                    Operate = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    PreInvoiceAmount = table.Column<decimal>(type: "money", nullable: false),
                    InvoiceAmount = table.Column<decimal>(type: "money", nullable: false),
                    UserName = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    Balance = table.Column<decimal>(type: "money", nullable: false),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreInvoice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrintTempletDic",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Tag = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Vuale = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Code = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Pcode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrintTempletDic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product_GoodsType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    DonvvTypeId = table.Column<int>(nullable: false, comment: "Donvv产品库的商品分类Id"),
                    DonvvTypeName = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "Donvv产品库的商品分类名称"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_GoodsType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product_Info",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsId = table.Column<int>(nullable: false),
                    IsChecked = table.Column<bool>(nullable: false),
                    Params = table.Column<string>(type: "text", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    SourceUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Info", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProGoodsType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Code = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PCode = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Level = table.Column<int>(nullable: false),
                    PointRate = table.Column<int>(nullable: false, defaultValueSql: "((100))"),
                    PriceArea = table.Column<string>(unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    IsVisible = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsLeaf = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    DefaultUnit = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DefaultSource = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    PY = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProGoodsType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    NeedToPurchaseId = table.Column<int>(nullable: false, comment: "采购汇总单Id"),
                    SupplierId = table.Column<int>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PurchaseType = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    SumMoney = table.Column<decimal>(type: "money", nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    SupplierStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')", comment: "供应商反馈状态"),
                    IsChecked = table.Column<bool>(nullable: false, comment: "是否对账"),
                    PayStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "付款状态"),
                    Memo = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    ReceiptUserId = table.Column<int>(nullable: false, comment: "收货员Id"),
                    UserId = table.Column<int>(nullable: false, comment: "生成采购单人员的Id"),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('2017-04-17')"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ChargeOff = table.Column<decimal>(type: "money", nullable: false),
                    PutInStoreTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-1-1')"),
                    SaveNum = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsMerge = table.Column<bool>(nullable: false),
                    IsBrandPurchase = table.Column<bool>(nullable: false),
                    AddUserId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: true),
                    TaxMoney = table.Column<decimal>(type: "money", nullable: false),
                    NoTaxMoney = table.Column<decimal>(type: "money", nullable: false),
                    EstimateRecieveDate = table.Column<DateTime>(type: "datetime", nullable: true, comment: "预计到货时间或者预计收货时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    BillsPrice = table.Column<decimal>(type: "money", nullable: false, comment: "开单价"),
                    InPrice = table.Column<decimal>(type: "money", nullable: false, comment: "换算后的进价"),
                    Num = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    ReceivedNum = table.Column<int>(nullable: false),
                    IsEmergency = table.Column<bool>(nullable: false),
                    SupplierNum = table.Column<int>(nullable: false),
                    DelayDate = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "('')"),
                    PurchaseStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DetailMemo = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    IsCustomGoods = table.Column<bool>(nullable: false),
                    OrderDetailId = table.Column<int>(nullable: false),
                    OldPurchaseId = table.Column<int>(nullable: false),
                    IsDonvvSupply = table.Column<bool>(nullable: true),
                    DonvvBrandId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DonvvBrandName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    IsGift = table.Column<bool>(nullable: false),
                    RefundNum = table.Column<int>(nullable: false),
                    InvoiceType = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    TaxRate = table.Column<decimal>(type: "money", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "money", nullable: false),
                    NoTaxAmount = table.Column<decimal>(type: "money", nullable: false),
                    NoTaxInPrice = table.Column<decimal>(type: "money", nullable: false),
                    IsTotalAmount = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseId = table.Column<int>(nullable: false),
                    PurchaseType = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    SumMoney = table.Column<decimal>(type: "money", nullable: false),
                    PurchaseStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Memo = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Operate = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    IsInner = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseMerge",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FinalPurchaseId = table.Column<int>(nullable: false),
                    NeedToPurchaseId = table.Column<int>(nullable: false),
                    PurchaseId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    Num = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseMerge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseModify",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    OldNum = table.Column<int>(nullable: false),
                    NewNum = table.Column<int>(nullable: false),
                    OldPrice = table.Column<decimal>(type: "money", nullable: false),
                    NewPrice = table.Column<decimal>(type: "money", nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Memo = table.Column<string>(type: "text", nullable: true),
                    OldTaxRate = table.Column<decimal>(type: "money", nullable: false),
                    NewTaxRate = table.Column<decimal>(type: "money", nullable: false),
                    OldNoTaxPrice = table.Column<decimal>(type: "money", nullable: false),
                    NewNoTaxPrice = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseModify", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchasePay",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseStatementId = table.Column<int>(nullable: false),
                    ChargeOff = table.Column<decimal>(type: "money", nullable: false),
                    PayMoney = table.Column<decimal>(type: "money", nullable: false),
                    PayType = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "全额付款，部分付款，补足余款，优惠付款"),
                    PayDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Memo = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    PayAccount = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PrepaymentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasePay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchasePayDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayId = table.Column<int>(nullable: false, comment: "采购付款记录表Id"),
                    PurchaseId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    Num = table.Column<int>(nullable: false),
                    InPrice = table.Column<decimal>(type: "money", nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false, comment: "明细实收金额"),
                    ChargeOffAmount = table.Column<decimal>(type: "money", nullable: false, comment: "明细销账金额"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasePayDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseQuote",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "主键")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, comment: "租户编号"),
                    PurchaseId = table.Column<int>(nullable: false, comment: "采购单号"),
                    DonvvBrandId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "品牌库品牌编号"),
                    DonvvBrandName = table.Column<string>(unicode: false, maxLength: 100, nullable: true, comment: "品牌库品牌名称"),
                    DonvvSupplierId = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "品牌库供应商编号"),
                    DonvvSupplierName = table.Column<string>(unicode: false, maxLength: 100, nullable: true, comment: "品牌库供应商名称"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "更新时间"),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('未处理')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseQuote", x => x.Id);
                },
                comment: "采购单报价表");

            migrationBuilder.CreateTable(
                name: "PurchaseQuoteDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "主键")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseQuoteId = table.Column<int>(nullable: false, comment: "采购报价单号"),
                    GoodsId = table.Column<int>(nullable: false, comment: "商品编号"),
                    DonvvSKU = table.Column<int>(nullable: false, comment: "品牌库商品编号"),
                    Num = table.Column<int>(nullable: false, comment: "商品数量"),
                    Price = table.Column<decimal>(type: "money", nullable: false, comment: "价格"),
                    Amount = table.Column<decimal>(type: "money", nullable: false, comment: "金额"),
                    Unit = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "单位"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "更新时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseQuoteDetail", x => x.Id);
                },
                comment: "采购报价单明细");

            migrationBuilder.CreateTable(
                name: "PurchaseStatement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    SupplierId = table.Column<int>(nullable: false),
                    SumMoney = table.Column<decimal>(type: "money", nullable: false),
                    PaidMoney = table.Column<decimal>(type: "money", nullable: false),
                    PayStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('未付款')", comment: "未付款、已付款、部分付款"),
                    Memo = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ChargeOff = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseStatement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseStatementDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseStatementId = table.Column<int>(nullable: false),
                    PurchaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseStatementDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quotation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    QuotationTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ValidTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    ValidDay = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegisterProtocol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProtocolContent = table.Column<string>(nullable: false, defaultValueSql: "('')"),
                    UserId = table.Column<int>(nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    BranchId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    ProtocolName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterProtocol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesPlan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    Customer = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    SalesId = table.Column<int>(nullable: false),
                    SalesName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PlanDate = table.Column<DateTime>(type: "date", nullable: false),
                    PlanMoney = table.Column<decimal>(type: "money", nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    Memo = table.Column<string>(type: "text", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesPlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesStoreMap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: true),
                    SalesNo = table.Column<int>(nullable: true, comment: "销售员Id"),
                    SalesName = table.Column<string>(maxLength: 50, nullable: true, comment: "销售员名称"),
                    StoreId = table.Column<int>(nullable: true, comment: "仓库Id"),
                    StoreName = table.Column<string>(maxLength: 50, nullable: true, comment: "仓库名称"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "更新日期"),
                    IsEnable = table.Column<bool>(nullable: true, comment: "是否启用")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesStoreMap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(maxLength: 50, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    RelationId = table.Column<int>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false),
                    CustomerName = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerPhone = table.Column<string>(maxLength: 50, nullable: false),
                    Province = table.Column<int>(nullable: false),
                    ProvinceName = table.Column<string>(maxLength: 200, nullable: false),
                    City = table.Column<int>(nullable: false),
                    CityName = table.Column<string>(maxLength: 200, nullable: false),
                    Country = table.Column<int>(nullable: false),
                    CountryName = table.Column<string>(maxLength: 200, nullable: false),
                    Address = table.Column<string>(maxLength: 500, nullable: false),
                    PlantTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(nullable: false),
                    FlowState = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatorUserId = table.Column<int>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastModifierUserId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletionTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleterUserId = table.Column<int>(nullable: true),
                    Remark = table.Column<string>(maxLength: 200, nullable: true),
                    Tenant = table.Column<int>(nullable: false),
                    ApplyUserId = table.Column<int>(nullable: false),
                    ApplyUserName = table.Column<string>(maxLength: 200, nullable: false),
                    SumMoney = table.Column<decimal>(type: "money", nullable: false),
                    LastPrintTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "上一次/最近一次打印的时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceOrder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceOrderDelivery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(nullable: false, comment: "车辆编号"),
                    CarUserId = table.Column<int>(nullable: false, comment: "送货员编号"),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "状态"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceOrderDelivery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceOrderDeliveryDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryId = table.Column<int>(nullable: false, comment: "装车编号"),
                    OrderId = table.Column<int>(nullable: false, comment: "订单编号"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceOrderDeliveryDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceOrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: true),
                    ItemId = table.Column<int>(nullable: true),
                    GoodsId = table.Column<int>(nullable: true),
                    GoodsName = table.Column<string>(maxLength: 200, nullable: false),
                    Num = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(maxLength: 200, nullable: true),
                    Unit = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceOrderDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceOrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(nullable: false),
                    Item = table.Column<int>(nullable: true),
                    ItemName = table.Column<string>(maxLength: 200, nullable: false),
                    Num = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceOrderItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceOrderLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(nullable: false),
                    ServiceCode = table.Column<string>(maxLength: 50, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatorUserId = table.Column<int>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastModifierUserId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    DeletionTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleterUserId = table.Column<int>(nullable: true),
                    Remark = table.Column<string>(maxLength: 200, nullable: true),
                    Tenant = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceOrderLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceOrderStaff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceOrderStaff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiChuanLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: true),
                    Content = table.Column<string>(maxLength: 2000, nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiChuanLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SourceGoods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    SourceId = table.Column<int>(nullable: false, comment: "抓取商品来源"),
                    Url = table.Column<string>(unicode: false, maxLength: 500, nullable: false, comment: "抓取商品Url"),
                    SourceSku = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: "抓取商品SKU"),
                    SourceMainSku = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "抓取商品主SKU"),
                    SpecVals = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "抓取商品规格信息"),
                    SourceCategory = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: "抓取商品分类"),
                    SourceBrand = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: "抓取商品品牌"),
                    SourcePrice = table.Column<decimal>(type: "money", nullable: false, comment: "抓取商品售价"),
                    TargetParentId = table.Column<int>(nullable: false, comment: "母商品编号"),
                    TargetGoodsId = table.Column<int>(nullable: false, comment: "目标商品编号"),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false, comment: "创建时间"),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true, comment: "更新时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceGoods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Place = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoreZone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreId = table.Column<int>(nullable: false),
                    Code = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: ""),
                    PCode = table.Column<string>(unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('‘’')"),
                    Type = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Memo = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    PrintNum = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreZone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Strategy_GrossProfit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "PK")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false, comment: "策略名称"),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "开始时间"),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "结束时间"),
                    Term = table.Column<int>(nullable: false, comment: "条件  1、开单 2、pc 3、m 4、门店"),
                    Way = table.Column<int>(nullable: false, comment: "方式  1、禁止  2、提醒  3、通知  4、审核"),
                    IsEnabled = table.Column<bool>(nullable: false, comment: "是否启用"),
                    Extend1 = table.Column<int>(nullable: true, comment: "扩展参数"),
                    Extend2 = table.Column<string>(maxLength: 200, nullable: true, comment: "扩展参数"),
                    CreationTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "创建时间"),
                    CreatorUserId = table.Column<int>(nullable: false, comment: "创建用户"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "修改时间"),
                    LastModifierUserId = table.Column<int>(nullable: true, comment: "修改用户"),
                    IsDeleted = table.Column<bool>(nullable: false, comment: "是否删除"),
                    DeletionTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "删除时间"),
                    DeleterUserId = table.Column<int>(nullable: true, comment: "删除用户"),
                    Remark = table.Column<string>(maxLength: 200, nullable: true, comment: "备注"),
                    Tenant = table.Column<int>(nullable: false, comment: "租户"),
                    Privilege = table.Column<int>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strategy_GrossProfit", x => x.Id);
                },
                comment: "商品毛利策略");

            migrationBuilder.CreateTable(
                name: "StrategyItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "PK")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(nullable: false, comment: "策略规则Id"),
                    Type = table.Column<int>(nullable: false, comment: "类型  用户/角色/部门"),
                    Mode = table.Column<int>(nullable: false, comment: "模式 包含/排查"),
                    ItemId = table.Column<int>(nullable: false, comment: "明细Id"),
                    ItemName = table.Column<string>(maxLength: 200, nullable: false, comment: "明细名称"),
                    Extend1 = table.Column<int>(nullable: true, comment: "扩展参数"),
                    Extend2 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, comment: "扩展参数"),
                    Extend3 = table.Column<string>(maxLength: 200, nullable: true, comment: "扩展参数"),
                    Category = table.Column<int>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StrategyItem", x => x.Id);
                },
                comment: "策略规则明细");

            migrationBuilder.CreateTable(
                name: "StrategyOrigin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "PK")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrategyId = table.Column<int>(nullable: false, comment: "策略Id"),
                    Mode = table.Column<int>(nullable: false, comment: "无/值/范围/选项"),
                    RangeAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, comment: "界限值"),
                    MaxAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, comment: "界限值-最大值"),
                    MinAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, comment: "界限值-最小值"),
                    TargetAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, comment: "目标值"),
                    Extend1 = table.Column<int>(nullable: true, comment: "扩展参数"),
                    Extend2 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, comment: "扩展参数"),
                    Extend3 = table.Column<string>(maxLength: 200, nullable: true, comment: "扩展参数"),
                    Category = table.Column<int>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StrategyOrigin", x => x.Id);
                },
                comment: "策略明细");

            migrationBuilder.CreateTable(
                name: "StrategyRange",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "PK")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrategyId = table.Column<int>(nullable: false, comment: "策略Id"),
                    Type = table.Column<int>(nullable: false, comment: "类型 类目/品牌//明细"),
                    Mode = table.Column<int>(nullable: false, comment: "模式 包含/排查"),
                    ItemId = table.Column<int>(nullable: false, comment: "明细Id"),
                    ItemName = table.Column<string>(maxLength: 200, nullable: false, comment: "明细名称"),
                    Extend1 = table.Column<int>(nullable: true, comment: "扩展参数"),
                    Extend2 = table.Column<string>(maxLength: 200, nullable: true, comment: "扩展参数"),
                    Category = table.Column<int>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StrategyRange", x => x.Id);
                },
                comment: "策略界限");

            migrationBuilder.CreateTable(
                name: "StrategyRule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "PK")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrategyId = table.Column<int>(nullable: false, comment: "策略Id"),
                    Mode = table.Column<int>(nullable: false, comment: "无/值/范围/选项"),
                    RangeAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, comment: "界限值"),
                    MaxAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, comment: "界限值-最大值"),
                    MinAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, comment: "界限值-最小值"),
                    TargetAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, comment: "目标值"),
                    Extend1 = table.Column<int>(nullable: true, comment: "扩展参数"),
                    Extend2 = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, comment: "扩展参数"),
                    Extend3 = table.Column<string>(maxLength: 200, nullable: true, comment: "扩展参数"),
                    Category = table.Column<int>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StrategyRule", x => x.Id);
                },
                comment: "策略规则");

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    IsEnable = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    Name = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "供应商名称"),
                    ShortName = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "简称"),
                    Type = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "供应商类型"),
                    Attitude = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "供应商对我们的重视程度"),
                    InvoiceType = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "发票类型"),
                    PayType = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "结款方式"),
                    LinkMan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TelPhone = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    QQ = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    MainBrand = table.Column<string>(unicode: false, maxLength: 200, nullable: true, comment: "主营品牌"),
                    Major = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "主营业务范围"),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    PassWord = table.Column<string>(unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('lueSGJZetyySpUndWjMBEg==')"),
                    PY = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    IsPublic = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    AddUserId = table.Column<int>(nullable: false),
                    SupplierTaxNo = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    OpeningBank = table.Column<string>(maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    BankAccount = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    ExpiredPayment = table.Column<int>(nullable: false),
                    AddUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DonvvSupplierId = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupplierContacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepId = table.Column<int>(nullable: false),
                    SuppplierId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Moblie = table.Column<string>(maxLength: 50, nullable: true),
                    Telphone = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierContacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupplierDepartment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Code = table.Column<string>(maxLength: 50, nullable: false),
                    PCode = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierDepartment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupplierInvoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "收供应商发票表主键，自增ID")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, comment: "懂微SAAS平台用户ID"),
                    SupplierId = table.Column<int>(nullable: false, comment: "供应商ID"),
                    UserId = table.Column<int>(nullable: false, comment: "操作者ID"),
                    InvoiceType = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "发票类型"),
                    InvoiceName = table.Column<string>(maxLength: 500, nullable: false, comment: "发票抬头"),
                    InvoiceCode = table.Column<string>(unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('')", comment: "发票代码"),
                    InvoiceNo = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "发票号码"),
                    InvoiceMoney = table.Column<decimal>(type: "money", nullable: false, comment: "发票金额"),
                    Content = table.Column<string>(nullable: false, defaultValueSql: "('')", comment: "发票内容"),
                    InvoiceDate = table.Column<DateTime>(type: "datetime", nullable: false, comment: "发票开票日期"),
                    Memo = table.Column<string>(maxLength: 500, nullable: false, comment: "备注"),
                    ReceiveDate = table.Column<DateTime>(type: "datetime", nullable: false, comment: "收到发票日期，默认系统录入时间"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "保存收票信息系统时间"),
                    IsDelete = table.Column<bool>(nullable: false),
                    InvoiceCompany = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierInvoice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupplierInvoiceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierInvoiceId = table.Column<int>(nullable: false),
                    PurchaseId = table.Column<int>(nullable: false),
                    SupplierId = table.Column<int>(nullable: false),
                    SupplierName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    DisplayName = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    InPrice = table.Column<decimal>(type: "money", nullable: true),
                    Num = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: true),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    InvoicedNum = table.Column<int>(nullable: false),
                    ToInvoiceMoney = table.Column<decimal>(type: "money", nullable: true),
                    BranchId = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierInvoiceDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupplierPrepayment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    SupplierId = table.Column<int>(nullable: false, comment: "供应商Id"),
                    SupplierName = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: "供应商名称"),
                    PurchaseStatementId = table.Column<int>(nullable: false, comment: "对账单Id"),
                    InitialBalance = table.Column<decimal>(type: "money", nullable: false, comment: "期初金额"),
                    Operate = table.Column<string>(maxLength: 10, nullable: false, comment: "操作(预付、付款、撤销)"),
                    Prepayment = table.Column<decimal>(type: "money", nullable: false, comment: "预付金额"),
                    Payment = table.Column<decimal>(type: "money", nullable: false, comment: "付款金额"),
                    Balance = table.Column<decimal>(type: "money", nullable: false, comment: "余额"),
                    OperatorId = table.Column<int>(nullable: false, comment: "操作人Id"),
                    OperatorName = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "操作人名称"),
                    Memo = table.Column<string>(type: "text", nullable: true, comment: "备注"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "更新时间"),
                    PayType = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    PayAccount = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "((0))"),
                    ActualPayTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierPrepayment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupplierSettleAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "供应商结账表主键，自增ID")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, comment: "懂微SAAS平台用户ID"),
                    SupplierId = table.Column<int>(nullable: false, comment: "供应商ID"),
                    UserId = table.Column<int>(nullable: false, comment: "操作者ID"),
                    LastTimeSADate = table.Column<DateTime>(type: "datetime", nullable: false, comment: "上一次结账截止时间，若为第一次结账，则值为1900-1-1"),
                    SettleAccountDate = table.Column<DateTime>(type: "datetime", nullable: false, comment: "结账截止时间"),
                    PurchaseAmount = table.Column<decimal>(type: "money", nullable: false, comment: "区间采购金额"),
                    PurchasePayAmount = table.Column<decimal>(type: "money", nullable: false, comment: "区间付款金额"),
                    InvoiceAmount = table.Column<decimal>(type: "money", nullable: false, comment: "区间收发票金额"),
                    LastTimeBalance = table.Column<decimal>(type: "money", nullable: false, comment: "上次结账的余额"),
                    Balance = table.Column<decimal>(type: "money", nullable: false, comment: "余额（可手工调整）=上次余额+区间付款金额-区间收发票金额"),
                    Memo = table.Column<string>(maxLength: 500, nullable: false, comment: "备注"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "保存结账信息时的系统时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierSettleAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurveysFeedBack",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opinion = table.Column<string>(maxLength: 3000, nullable: true),
                    Satisfaction = table.Column<string>(maxLength: 50, nullable: false),
                    BranchId = table.Column<int>(nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(maxLength: 50, nullable: true),
                    Mail = table.Column<string>(maxLength: 50, nullable: true),
                    UserName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveysFeedBack", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Agent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    ParentId = table.Column<int>(nullable: false, comment: "推荐代理商Id，预备以后多级提成制度"),
                    Province = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    City = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    Bank = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    AcountNo = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    LinkMan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Telphone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Agent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Agent_Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    LoginName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PassWord = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Telphone = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Agent_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Approve",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyId = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    ApproveKey = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ApproveAccount = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ApproveMethod = table.Column<int>(nullable: true),
                    ApproveType = table.Column<int>(nullable: true),
                    ApproveAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApproveCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ApproveCount = table.Column<int>(nullable: true),
                    ApproveLimit = table.Column<int>(nullable: true),
                    ApproveValid = table.Column<bool>(nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Approve", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Authorize",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    OldExpiredDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AuthorizeYear = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    NewExpiredDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    OldUserNum = table.Column<int>(nullable: false),
                    AuthorizeNum = table.Column<int>(nullable: false),
                    NewUserNum = table.Column<int>(nullable: false),
                    Money = table.Column<decimal>(type: "money", nullable: false),
                    PayStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('未付款')"),
                    SysUserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Authorize", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Branch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "分支机构名称"),
                    ShortName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Province = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ProvinceSort = table.Column<int>(nullable: false, defaultValueSql: "((10))"),
                    City = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    CitySort = table.Column<int>(nullable: false, defaultValueSql: "((10))"),
                    Address = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Telphone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LinkMan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    IsUseSiteGoods = table.Column<int>(nullable: false),
                    Introduction = table.Column<string>(type: "text", nullable: true),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    IsEnable = table.Column<int>(nullable: false, defaultValueSql: "((1))", comment: "是否有效"),
                    UserNum = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    ExpiredDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "截止有效期：过期后系统将不能登录"),
                    Domain = table.Column<string>(unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    DonvvDomain = table.Column<string>(unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    BranchType = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    Domain2 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    IsEasy = table.Column<bool>(nullable: false),
                    CityAlias = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Memo = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Branch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Branch_CSS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    CssId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Branch_CSS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchActivity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "ntext", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    PhotoPath = table.Column<string>(maxLength: 200, nullable: false),
                    Link = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    IsEnable = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ProductTpn = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchActivity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchActivityContent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Url = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchActivityContent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchActivityGift",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(nullable: false),
                    ActivityRuleId = table.Column<int>(nullable: false),
                    GiftNum = table.Column<int>(nullable: false),
                    MaxGiftNum = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    GoodsName = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Unit = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    SalePrice = table.Column<decimal>(type: "money", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchActivityGift", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchActivityRange",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(nullable: false),
                    ItemType = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    ItemCode = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchActivityRange", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchActivityRule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(nullable: false),
                    RangeAmount = table.Column<decimal>(type: "money", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "money", nullable: false),
                    GiftMaxNum = table.Column<int>(nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchActivityRule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchAds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    Image1 = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Href1 = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchAds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchArea",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    AreaIndex = table.Column<int>(nullable: true),
                    TypeId = table.Column<int>(nullable: false),
                    AreaName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    LeftLayout = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Image1 = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Image2 = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Image3 = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Href1 = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Href2 = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Href3 = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Image4 = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Image5 = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Image6 = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Image7 = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Image8 = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Href4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Href5 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Href6 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Href7 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Href8 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    BackGroundColor = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchArea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchAreaDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaId = table.Column<int>(nullable: false),
                    Sort = table.Column<int>(nullable: false, defaultValueSql: "((99))"),
                    Width = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Alt = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Href = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ImgUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchAreaDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchAreas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    Header_Height = table.Column<int>(nullable: false),
                    Header_BackGroundColor = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Header_FontSize = table.Column<int>(nullable: false),
                    Header_FontColor = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Cols = table.Column<int>(nullable: false),
                    Rows = table.Column<int>(nullable: false),
                    Memo = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    IsShowHeader = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    Row_Height = table.Column<int>(nullable: false),
                    Col_Width = table.Column<int>(nullable: false),
                    Col_Space = table.Column<int>(nullable: false),
                    Row_Space = table.Column<int>(nullable: false),
                    Border_width = table.Column<int>(nullable: false),
                    Border_color = table.Column<string>(unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    IsEnable = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchAreas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchAuth",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerId = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: false),
                    AppKey = table.Column<string>(unicode: false, maxLength: 3000, nullable: true),
                    AppSecret = table.Column<string>(unicode: false, maxLength: 3000, nullable: true),
                    Token = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    ExpiresTime = table.Column<long>(nullable: true),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchAuth", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchBankInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    AccountName = table.Column<string>(maxLength: 100, nullable: false, comment: "户名（公司名称）"),
                    BankName = table.Column<string>(maxLength: 100, nullable: false, comment: "开户行"),
                    AccountNumber = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "账号"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    Balance = table.Column<decimal>(type: "money", nullable: true),
                    IsEnable = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchBankInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchEmailSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    SMTPServer = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "发信服务器"),
                    IsEnableSSL = table.Column<bool>(nullable: false, comment: "是否使用安全链接（SSL）"),
                    Address = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: "发信邮箱地址"),
                    UserName = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "登录账号"),
                    Password = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "登录密码"),
                    NickName = table.Column<string>(maxLength: 100, nullable: false, comment: "发信人昵称"),
                    IsCheck = table.Column<bool>(nullable: false, comment: "是否检验邮箱"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchEmailSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchERPSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    ERPName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    IconUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchERPSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchFloor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    FloorIndex = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    FloorName = table.Column<string>(maxLength: 10, nullable: false),
                    LeftLayout = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "左侧广告位布局，枚举：整体、上下、上左右"),
                    AutoSub = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    Image1 = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Href1 = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Image2 = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Href2 = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Image3 = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Href3 = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    BackGroundColor = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    IsDisplayCustomerTypeAndGoods = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchFloor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchFloorBrandingWall",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchFloorId = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false),
                    ColumnsNum = table.Column<int>(nullable: false),
                    ColumnsSpace = table.Column<int>(nullable: false),
                    IsEnable = table.Column<bool>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchFloorBrandingWall", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchFloorBrandingWallPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImgPath = table.Column<string>(maxLength: 300, nullable: false),
                    ImgHref = table.Column<string>(maxLength: 300, nullable: false),
                    BranchFloorId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchFloorBrandingWallPhotos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchFloorDisplayType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchFloorId = table.Column<int>(nullable: false),
                    DisplayTypeId = table.Column<int>(nullable: false),
                    DisplayTypeName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    GoodsName = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    TypeSort = table.Column<int>(nullable: false),
                    GoodsSort = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchFloorDisplayType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchGoodsType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false, comment: "商品类别ID"),
                    IsFloor = table.Column<bool>(nullable: false, defaultValueSql: "((1))", comment: "是否需要在楼层中显示数据"),
                    Sort = table.Column<int>(nullable: false, defaultValueSql: "((10))", comment: "首页大类和Floor中的显示顺序"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchGoodsType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchHelp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    GroupId = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: false),
                    IsLocked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchHelp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchHelpContent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    HelpId = table.Column<int>(nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false, defaultValueSql: "('')"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchHelpContent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchHelpGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    BranchId = table.Column<int>(nullable: false),
                    IsLocked = table.Column<bool>(nullable: false, comment: "是否锁定，锁定后不允许修改"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchHelpGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchHelpGroupPrivateInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(nullable: false, comment: "帮助文件一级分类Id"),
                    BranchId = table.Column<int>(nullable: false),
                    Alias = table.Column<string>(maxLength: 50, nullable: false, comment: "帮助文件一级分类的自定义名"),
                    Sort = table.Column<int>(nullable: false, defaultValueSql: "((99))", comment: "排序"),
                    IsDisable = table.Column<bool>(nullable: false, comment: "是否禁用"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchHelpGroupPrivateInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchHelpPrivateInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HelpId = table.Column<int>(nullable: false, comment: "帮助文件二级分类Id"),
                    BranchId = table.Column<int>(nullable: false),
                    Alias = table.Column<string>(maxLength: 50, nullable: false, comment: "帮助文件一级分类的自定义名"),
                    Sort = table.Column<int>(nullable: false, defaultValueSql: "((99))", comment: "排序"),
                    IsDisable = table.Column<bool>(nullable: false, comment: "是否禁用"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchHelpPrivateInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchHotWords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    HotWords = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Sort = table.Column<int>(nullable: false, defaultValueSql: "((10))"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Href = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchHotWords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchPay",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    PaymentId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    AppId = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "账号"),
                    PartnerId = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "合作者ID"),
                    Secret = table.Column<string>(unicode: false, maxLength: 3000, nullable: true, comment: "应用秘钥"),
                    AppSecret = table.Column<string>(unicode: false, maxLength: 3000, nullable: true),
                    Public_key = table.Column<string>(unicode: false, maxLength: 3000, nullable: true),
                    Sslcert_path = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Sort = table.Column<int>(nullable: true, defaultValueSql: "((99))"),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    CertFileUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: true, defaultValueSql: "('')"),
                    BizType = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchPay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchPayment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ImgUrl = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: true),
                    PoundageType = table.Column<int>(nullable: true),
                    PoundageAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ApiPath = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    RedirectUrl = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    ReturnUrl = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    NotifyUrl = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    SortId = table.Column<int>(nullable: true),
                    IsOk = table.Column<int>(nullable: true),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchPayment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchSeo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "PK")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 200, nullable: true, comment: "标题"),
                    Keywords = table.Column<string>(maxLength: 200, nullable: true, comment: "关键字"),
                    Description = table.Column<string>(maxLength: 200, nullable: true, comment: "描述"),
                    Code = table.Column<string>(maxLength: 2000, nullable: true, comment: "SEO代码"),
                    Tenant = table.Column<int>(nullable: false, comment: "租户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchSeo", x => x.Id);
                },
                comment: "站点seo");

            migrationBuilder.CreateTable(
                name: "Sys_BranchServicePromise",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    Cols = table.Column<int>(nullable: false),
                    Col_Width = table.Column<int>(nullable: false),
                    Rows = table.Column<int>(nullable: false),
                    Row_Height = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchServicePromise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchServicePromiseDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromiseId = table.Column<int>(nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Href = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ImgUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchServicePromiseDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "是否显示虚拟销量，用于")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    OrderConfirm_Gift = table.Column<bool>(nullable: false, comment: "订单审核：赠品模式时  1 开启此功能 0 不开启此功能"),
                    OrderConfirm_PriceLessInPrice = table.Column<bool>(nullable: false, comment: "订单审核：销售开单售价低于进价时 1 开启此功能 0 不开启此功能"),
                    PurchaseCollect_DefaultPurchaser = table.Column<int>(nullable: false),
                    AutoAuditing = table.Column<bool>(nullable: false),
                    HideSaleNum = table.Column<bool>(nullable: false),
                    HidePurchaseZero = table.Column<bool>(nullable: false),
                    ReturnOrderInStoreForCheck = table.Column<bool>(nullable: false),
                    AccountPeriodLimitOrder = table.Column<int>(nullable: false),
                    IsCustomMessageSignature = table.Column<bool>(nullable: false),
                    GoodsCategory = table.Column<bool>(nullable: false),
                    GoodsDetailDisplayInventory = table.Column<bool>(nullable: false),
                    GoodsListRandom = table.Column<bool>(nullable: false),
                    Canvass = table.Column<bool>(nullable: false),
                    AddThirdPartyId = table.Column<bool>(nullable: false),
                    IsShowGrossProfit = table.Column<bool>(nullable: false),
                    IsAccountVialid = table.Column<bool>(nullable: false),
                    GroupCheckedAllOrder = table.Column<bool>(nullable: false),
                    IsCustomerDetails = table.Column<bool>(nullable: false),
                    BranchSite = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    SingleStroe = table.Column<bool>(nullable: false),
                    CustomerNeedApprove = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    IsRepeatGoodsSN = table.Column<bool>(nullable: false),
                    IsHideGoodsEvaluate = table.Column<bool>(nullable: false),
                    IsThird = table.Column<bool>(nullable: false),
                    CustomerManageId = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    LimitOrderForNoStock = table.Column<bool>(nullable: true),
                    IsDefaultStore = table.Column<bool>(nullable: false, defaultValueSql: "('0')"),
                    LimitWebOrderForNoVirtualStock = table.Column<int>(nullable: true),
                    FinanceAudit = table.Column<bool>(nullable: true),
                    OnlyMallOrder = table.Column<bool>(nullable: true),
                    BranchIdOfHideMoney = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    InPriceHigherThanPrice = table.Column<bool>(nullable: true),
                    OrderRequiredMemo = table.Column<bool>(nullable: true),
                    ModifyGoodsUnit = table.Column<bool>(nullable: true),
                    IsShowInvalidPurchaser = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    IsShowGoodsSaleCount = table.Column<bool>(nullable: true),
                    OrderConfirm_ReturnDirectDelivery = table.Column<bool>(nullable: true),
                    PurchaseCollectByStore = table.Column<bool>(nullable: true),
                    StoreOrderUsePrice = table.Column<bool>(nullable: true),
                    OrderDefaultTaxRate = table.Column<decimal>(type: "money", nullable: true),
                    PurchaseDefaultTaxRate = table.Column<decimal>(type: "money", nullable: true),
                    SpecifySupplier = table.Column<bool>(nullable: false, comment: "高级设置：汇总开单的时候，是否必须指定供应商，默认为否，"),
                    ShowVirtualSales = table.Column<bool>(nullable: false),
                    OrderToDistribution = table.Column<bool>(nullable: true, comment: "销售单转分销单"),
                    StoreOrderSpecifySalesman = table.Column<bool>(nullable: false),
                    StoreOrderSpicifyInventory = table.Column<bool>(nullable: false),
                    PurchaseByOwin = table.Column<bool>(nullable: false),
                    ExportByAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchSiteFooter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    Url = table.Column<string>(maxLength: 500, nullable: true),
                    Image = table.Column<string>(maxLength: 200, nullable: false),
                    Order = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatorUserId = table.Column<int>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastModifierUserId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletionTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleterUserId = table.Column<int>(nullable: true),
                    Remark = table.Column<string>(maxLength: 2000, nullable: true),
                    Tenant = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchSiteFooter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchSiteSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    SiteName = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    LogoUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    Telphone = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    UseGoodsTypes = table.Column<bool>(nullable: false, comment: "是否启用自选商品分类"),
                    UseTopMenus = table.Column<bool>(nullable: false, comment: "是否自选一级菜单"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CompanyName = table.Column<string>(unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    CompanyAddress = table.Column<string>(unicode: false, maxLength: 300, nullable: false, defaultValueSql: "('')"),
                    ICP_No = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    CompanyTelphone = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    IsShowSubGoods = table.Column<bool>(nullable: false),
                    UseQQCustomer = table.Column<bool>(nullable: false),
                    QQ = table.Column<string>(unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    IconUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    VerificationCodeName = table.Column<string>(maxLength: 20, nullable: true),
                    ContactImage = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    HtmlValidate = table.Column<string>(unicode: false, nullable: false, defaultValueSql: "('')"),
                    Qrcode = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    SubTelphone = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchSiteSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchSiteSolution",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "PK")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: true, comment: "名称"),
                    Url = table.Column<string>(maxLength: 200, nullable: true, comment: "链接"),
                    Image = table.Column<string>(maxLength: 200, nullable: false, comment: "图片"),
                    Order = table.Column<int>(nullable: false, comment: "排序"),
                    CreationTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "创建时间"),
                    CreatorUserId = table.Column<int>(nullable: false, comment: "创建用户"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "修改时间"),
                    LastModifierUserId = table.Column<int>(nullable: true, comment: "修改用户"),
                    IsDeleted = table.Column<bool>(nullable: false, comment: "是否删除"),
                    DeletionTime = table.Column<DateTime>(type: "datetime", nullable: true, comment: "删除时间"),
                    DeleterUserId = table.Column<int>(nullable: true, comment: "删除用户"),
                    Remark = table.Column<string>(maxLength: 200, nullable: true, comment: "备注"),
                    Tenant = table.Column<int>(nullable: false, comment: "租户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchSiteSolution", x => x.Id);
                },
                comment: "解决方案");

            migrationBuilder.CreateTable(
                name: "Sys_BranchTheme",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    IsEnable = table.Column<bool>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchTheme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchThemeArea",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThemeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    Cols = table.Column<int>(nullable: false),
                    Rows = table.Column<int>(nullable: false),
                    Row_Height = table.Column<int>(nullable: false),
                    Col_Width = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(maxLength: 1000, nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    IsEnable = table.Column<bool>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Col_Space = table.Column<int>(nullable: false),
                    Row_Space = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchThemeArea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchThemeAreaGoodsTab",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThemeAreaId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    SearchType = table.Column<string>(maxLength: 100, nullable: false),
                    IsShowHead = table.Column<bool>(nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    TabHref = table.Column<string>(maxLength: 200, nullable: false),
                    IsEnable = table.Column<bool>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchThemeAreaGoodsTab", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchThemeAreaPhoto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThemeAreaId = table.Column<int>(nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    ImgHref = table.Column<string>(maxLength: 200, nullable: false),
                    ImgUrl = table.Column<string>(maxLength: 200, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsEnable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchThemeAreaPhoto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_BranchThirdParty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "PK")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false, comment: "名称"),
                    Tenant = table.Column<int>(nullable: false, comment: "租户")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchThirdParty", x => x.Id);
                },
                comment: "第三方入驻");

            migrationBuilder.CreateTable(
                name: "Sys_BranchTopMenu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    Url = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    IsBlank = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    Sort = table.Column<int>(nullable: false, defaultValueSql: "((10))"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_BranchTopMenu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_CanvassAgreement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "text", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatorUserId = table.Column<int>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastModifierUserId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletionTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleterUserId = table.Column<int>(nullable: true),
                    Remark = table.Column<string>(maxLength: 200, nullable: true),
                    Tenant = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_CanvassAgreement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Car",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Plate = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    IsEnable = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    Memo = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Car", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_CarLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(nullable: false),
                    Kil = table.Column<decimal>(type: "decimal(18, 2)", nullable: false, comment: "里程"),
                    Oil = table.Column<decimal>(type: "decimal(18, 2)", nullable: false, comment: "加油量"),
                    OilMoney = table.Column<decimal>(type: "money", nullable: false, comment: "加油金额"),
                    Memo = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_CarLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_CarUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_CarUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    level = table.Column<int>(nullable: true),
                    createTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Config",
                columns: table => new
                {
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "键"),
                    Value = table.Column<string>(unicode: false, maxLength: 500, nullable: false, comment: "值"),
                    BranchId = table.Column<int>(nullable: false, comment: "租户")
                },
                constraints: table =>
                {
                },
                comment: "系统配置表");

            migrationBuilder.CreateTable(
                name: "Sys_Dept",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, comment: "所属分支机构"),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "部门名称"),
                    Code = table.Column<string>(unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('0')"),
                    PCode = table.Column<string>(unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('0')"),
                    Memo = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Dept", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_DictionaryType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "主键ID")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "类型名称"),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "类型描述说明"),
                    Sort = table.Column<int>(nullable: false, comment: "类型顺序"),
                    IsDelete = table.Column<bool>(nullable: false, comment: "是否删除"),
                    BranchId = table.Column<int>(nullable: false),
                    IsSystem = table.Column<bool>(nullable: false),
                    CreateUser = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "创建人"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "创建时间"),
                    UpdateUser = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "修改人"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "修改时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_DictionaryType", x => x.Id);
                },
                comment: "编码类型");

            migrationBuilder.CreateTable(
                name: "Sys_Distribution",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(nullable: false, comment: "分销集团Id"),
                    BranchId = table.Column<int>(nullable: false),
                    PBranchId = table.Column<int>(nullable: false, comment: "父BranchId"),
                    TopBranchId = table.Column<int>(nullable: false, comment: "第一级BranchId"),
                    Level = table.Column<int>(nullable: false, comment: "层级"),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ParentReceiveRate = table.Column<double>(nullable: false, comment: "上级公司抽成比例")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Distribution", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_DistributionGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 200, nullable: false, comment: "分销集团名称"),
                    TopBranchId = table.Column<int>(nullable: false, comment: "第一级BranchId"),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_DistributionGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_ErrorLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableName = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    RelationId = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ErrorMessage = table.Column<string>(type: "text", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_ErrorLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Group",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    LeaderBranchId = table.Column<int>(nullable: false),
                    UserNum = table.Column<int>(nullable: false),
                    ExpiredDate = table.Column<DateTime>(type: "date", nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    IsDistribuionGroup = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Group", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_GroupBranch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: false),
                    JoinType = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    IsGroupAccount = table.Column<bool>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_GroupBranch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_GroupLoginSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    body_bg_color = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    wrapper_width = table.Column<int>(nullable: false),
                    wrapper_minheight = table.Column<int>(nullable: false),
                    wrapper_bg_color = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    wrapper_bg_img = table.Column<string>(unicode: false, maxLength: 300, nullable: false),
                    header_height = table.Column<int>(nullable: false),
                    header_logo_img = table.Column<string>(unicode: false, maxLength: 300, nullable: false),
                    login_height = table.Column<int>(nullable: false),
                    login_bg_img = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    login_box_top = table.Column<int>(nullable: false),
                    login_box_right = table.Column<int>(nullable: false),
                    footer_height = table.Column<int>(nullable: false),
                    footer_bg_color = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    footer_color = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    updatetime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    header_bg_color = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    header_bg_img = table.Column<string>(unicode: false, maxLength: 300, nullable: false, defaultValueSql: "('')"),
                    login_box_bg_color = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    login_box_radius = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_GroupLoginSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_MapiServer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerId = table.Column<int>(nullable: false),
                    ServerName = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    ServerUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    AppKey = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    AppSecret = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Token = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    ExpiresTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_MapiServer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Permission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientType = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('Donvv')", comment: "枚举类型ClientType，区分不同的终端"),
                    GroupId = table.Column<int>(nullable: false, comment: ""),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    IsMenu = table.Column<bool>(nullable: false, defaultValueSql: "((1))", comment: "1:菜单 0：内置权限，例如：销售收款"),
                    Menu = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')", comment: "要显示的菜单名称"),
                    Controller = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    Action = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    Icon = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('‘’')", comment: "图标文件：Iconfont 编码"),
                    Sort = table.Column<int>(nullable: false, defaultValueSql: "((10))", comment: "menu排序"),
                    IsBlank = table.Column<bool>(nullable: false, comment: "1：允许打开多个新页面（例如：销售开单）；0：只能打开一个页面"),
                    Memo = table.Column<string>(unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Permission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_PermissionGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientType = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('PC')", comment: "PC,PDA,APP"),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Sort = table.Column<int>(nullable: false, defaultValueSql: "((10))"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_PermissionGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Price",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pirce = table.Column<int>(nullable: false, defaultValueSql: "((1200))", comment: "单账号年费用"),
                    StartNum = table.Column<int>(nullable: false, defaultValueSql: "((5))", comment: "起步账号数量"),
                    StartAmount = table.Column<int>(nullable: false, defaultValueSql: "((5000))", comment: "起步售价"),
                    Memo = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Price", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_PrintSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Order_Header = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "订单打印的页眉"),
                    Order_LogoUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Order_Instruction = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "底部说明"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    PrintFlag = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    IsDefault = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_PrintSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_PrintTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Type = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Content = table.Column<string>(type: "text", nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_PrintTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_PrintValidate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Token = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    ExpiresTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_PrintValidate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Renew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "开通、增加"),
                    AcountNum = table.Column<int>(nullable: false, defaultValueSql: "((1))", comment: "本次续费账号数量"),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    ExpiredDate = table.Column<DateTime>(type: "date", nullable: false, comment: "不包含"),
                    Money = table.Column<decimal>(type: "money", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Renew", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    GroupName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Memo = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_RolePermission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    PermissionId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_RolePermission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_SiteCSS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "Css,LayOut"),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    CssFileName = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Memo = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_SiteCSS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Sms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Mobile = table.Column<string>(unicode: false, maxLength: 250, nullable: true, comment: "手机号码"),
                    SMSCode = table.Column<int>(nullable: false, comment: ">0 验证码"),
                    Content = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "短信内容"),
                    Status = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Sms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_UrlLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    IP = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Url = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Memo = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_UrlLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_UserRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PassWord = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    BranchId = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    DeptId = table.Column<int>(nullable: false),
                    IsSales = table.Column<bool>(nullable: false),
                    Position = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Telphone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    BirthDay = table.Column<DateTime>(type: "datetime", nullable: true, comment: "生日"),
                    IsYinLi = table.Column<bool>(nullable: false, comment: "1：阴历生日"),
                    JoinDate = table.Column<DateTime>(type: "date", nullable: true, comment: "入职日期"),
                    IDCard = table.Column<string>(unicode: false, maxLength: 18, nullable: true),
                    ModifyTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    IsCheckMobile = table.Column<bool>(nullable: false),
                    IsValid = table.Column<bool>(nullable: false, comment: "1:有效，0：无效"),
                    IsAdmin = table.Column<bool>(nullable: false),
                    token = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "('')"),
                    tokenEndDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    DingId = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemManager",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    PassWord = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Role = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemManager", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    TaxRate = table.Column<decimal>(type: "money", nullable: false, comment: "增值税率"),
                    GoodsCategory = table.Column<string>(maxLength: 1000, nullable: true, comment: "货物或劳务类别"),
                    DescribeInfo = table.Column<string>(maxLength: 2000, nullable: true, comment: "说明"),
                    Memo = table.Column<string>(maxLength: 2000, nullable: true, comment: "备注"),
                    IsDefault = table.Column<bool>(nullable: false, comment: "是否默认"),
                    AddUserId = table.Column<int>(nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateUserId = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CategoryShortName = table.Column<string>(maxLength: 500, nullable: true),
                    TaxCode = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    GoodsTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxCategoryGoodsMap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxCategoryId = table.Column<int>(nullable: false, comment: "税率分类Id"),
                    GoodsId = table.Column<int>(nullable: false, comment: "商品编号"),
                    BranchId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxCategoryGoodsMap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "temp",
                columns: table => new
                {
                    公司名称 = table.Column<string>(maxLength: 255, nullable: true),
                    公司编码 = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ThirdCategory",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    source = table.Column<string>(maxLength: 500, nullable: true),
                    categoryName = table.Column<string>(maxLength: 500, nullable: true),
                    subCategoryName = table.Column<string>(maxLength: 500, nullable: true),
                    typeId = table.Column<int>(nullable: true),
                    updateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThirdCategory", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ThirdPartyGoodsCategoryMatch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, comment: "客户Id"),
                    ThirdPartyGoodsCategoryId = table.Column<int>(nullable: false, comment: "第三方商品分类编码"),
                    ThirdPartyGoodsCategoryName = table.Column<string>(maxLength: 500, nullable: true, comment: "第三方商品分类名称"),
                    LocalGoodsCategoryId = table.Column<int>(nullable: false, comment: "本地商品分类编码"),
                    LocalGoodsCategoryName = table.Column<string>(maxLength: 500, nullable: true, comment: "本地商品分类名称")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThirdPartyGoodsCategoryMatch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThirdPartyGoodsMatch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchID = table.Column<int>(nullable: false, comment: "客户Id"),
                    ThirdPartyGoodsId = table.Column<int>(nullable: false, comment: "第三方商品Id"),
                    ThirdPartyGoodsName = table.Column<string>(maxLength: 500, nullable: true, comment: "第三方商品名称"),
                    LocalGoodsId = table.Column<int>(nullable: false, comment: "本地商品id"),
                    LocalGoodsName = table.Column<string>(maxLength: 500, nullable: true, comment: "本地商品名称")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThirdPartyGoodsMatch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThirdPartyLogin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(nullable: true),
                    UUId = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Type = table.Column<string>(maxLength: 50, nullable: true),
                    BranchId = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThirdPartyLogin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThirdProduct",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_code = table.Column<string>(maxLength: 500, nullable: false),
                    source = table.Column<string>(maxLength: 500, nullable: false),
                    goodsId = table.Column<int>(nullable: false),
                    introduction = table.Column<string>(nullable: true),
                    addTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    finishTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PhotoNum = table.Column<int>(nullable: true),
                    DetailPhotoNum = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThirdProduct", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Transfer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutBranchId = table.Column<int>(nullable: false),
                    OutStoreId = table.Column<int>(nullable: false),
                    OutStoreUserId = table.Column<int>(nullable: false),
                    OutStoreDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(((1900)-(1))-(1))"),
                    OutStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    LogisticsInfomationId = table.Column<int>(nullable: false),
                    InBranchId = table.Column<int>(nullable: false),
                    InStoreId = table.Column<int>(nullable: false),
                    InStoreUserId = table.Column<int>(nullable: false),
                    InStoreDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(((1900)-(1))-(1))"),
                    InStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "((-1))"),
                    Memo = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowNum = table.Column<int>(nullable: false),
                    SumMoney = table.Column<decimal>(type: "money", nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsChecked = table.Column<bool>(nullable: false),
                    IsArchive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransferArchive",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransferId = table.Column<int>(nullable: false),
                    Page = table.Column<int>(nullable: false),
                    PhotoUrl = table.Column<string>(unicode: false, maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    SaveNum = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AllPage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferArchive", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransferBox",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransferId = table.Column<int>(nullable: false),
                    BoxId = table.Column<int>(nullable: false),
                    PrintNum = table.Column<int>(nullable: false),
                    PrintTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    StoreZone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferBox", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransferDelivery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(nullable: false),
                    CarUserId = table.Column<int>(nullable: false),
                    StockOutUserId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Memo = table.Column<string>(unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferDelivery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransferDeliveryBox",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransferDeliveryId = table.Column<int>(nullable: false),
                    TransferBoxId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Address = table.Column<string>(unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    Latitude = table.Column<string>(unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    Longitude = table.Column<string>(unicode: false, maxLength: 200, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferDeliveryBox", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransferDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransferId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    Num = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PickNum = table.Column<int>(nullable: false),
                    ReceivedNum = table.Column<int>(nullable: false),
                    ReceivedStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    SingleRemark = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransferLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransferId = table.Column<int>(nullable: false, comment: "调拨单号"),
                    OperatorName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "('')", comment: "操作人名称(Sys_User的Name)"),
                    Status = table.Column<string>(maxLength: 50, nullable: false, comment: "调拨单状态"),
                    Operate = table.Column<string>(maxLength: 200, nullable: false, comment: "操作"),
                    IsInner = table.Column<bool>(nullable: false, comment: "1:内部可见；0：客户可见"),
                    OperatorId = table.Column<int>(nullable: false, comment: "操作人Id(Sys_User的Id)"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransferPicking",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransferId = table.Column<int>(nullable: false),
                    PickingUserId = table.Column<int>(nullable: false, comment: "理货员Id"),
                    DistributeUserId = table.Column<int>(nullable: false, comment: "分单员"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferPicking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransferPickingLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransferId = table.Column<int>(nullable: false, comment: "调拨单号"),
                    TransferDetailId = table.Column<int>(nullable: false, comment: "调拨单明细ID"),
                    GoodsId = table.Column<int>(nullable: false, comment: "商品Id"),
                    StoreId = table.Column<int>(nullable: false, comment: "调出仓库Id"),
                    StoreZone = table.Column<string>(fixedLength: true, maxLength: 100, nullable: false, comment: "库位"),
                    PickingUserId = table.Column<int>(nullable: false, comment: "拣货员Id"),
                    Num = table.Column<int>(nullable: false, comment: "拣货数量"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferPickingLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransferReceiveMoney",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransferStatementId = table.Column<int>(nullable: false),
                    ChargeOff = table.Column<decimal>(type: "money", nullable: false, comment: "销账金额"),
                    ReceiveMoney = table.Column<decimal>(type: "money", nullable: false, comment: "收款金额"),
                    ReceiveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PayType = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "付款方式"),
                    Memo = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferReceiveMoney", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransferStatement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, comment: "调入公司BranchId"),
                    SumMoney = table.Column<decimal>(type: "money", nullable: false),
                    PaidMoney = table.Column<decimal>(type: "money", nullable: false),
                    PayStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Memo = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    UserId = table.Column<int>(nullable: false, comment: "操作员"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ChargeOff = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferStatement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransferStatementDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransferStatementId = table.Column<int>(nullable: false),
                    TransferId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferStatementDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VIPApply",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 10, nullable: false),
                    SumMoney = table.Column<decimal>(type: "money", nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: false),
                    ConfirmLevel = table.Column<int>(nullable: false),
                    OperatorId = table.Column<int>(nullable: false),
                    Memo = table.Column<string>(maxLength: 500, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InvoiceName = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    InvoiceType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InvoiceContent = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    InvoiceCategory = table.Column<string>(unicode: false, maxLength: 50, nullable: true, defaultValueSql: "('纸质发票')"),
                    EmailForInvoice = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    InvoiceInfo = table.Column<string>(nullable: true),
                    PayType = table.Column<string>(maxLength: 20, nullable: true),
                    DeptId = table.Column<int>(nullable: false),
                    LogisticsId = table.Column<int>(nullable: false),
                    Balance = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIPApply", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VIPApplyDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplyId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    Num = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))"),
                    DisplayNum = table.Column<int>(nullable: false),
                    DisplayUnit = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DisplayPrice = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIPApplyDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VIPApplyInvoiceInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplyId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false, comment: "发票类型"),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "购方发票抬头"),
                    Content = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "购方发票内容"),
                    TaxNo = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "购方税号"),
                    Address = table.Column<string>(unicode: false, maxLength: 500, nullable: false, comment: "购方地址"),
                    Phone = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "购方注册电话"),
                    Bank = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "购方开户行"),
                    BankAccount = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "购方开户行账号"),
                    Memo = table.Column<string>(unicode: false, maxLength: 500, nullable: true, comment: "发票备注"),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "购方电子邮箱"),
                    Mobile = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "购方手机号")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIPApplyInvoiceInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VIPApplyLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "Id，主键")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplyId = table.Column<int>(nullable: false, comment: "申请单Id"),
                    ApplyUserId = table.Column<int>(nullable: false, comment: "申请人Id(MemberId)"),
                    OperatorId = table.Column<int>(nullable: false, comment: "操作人Id(MemberId)"),
                    OperateStatus = table.Column<string>(maxLength: 10, nullable: false, comment: "操作状态（待审核，已审核，已驳回）"),
                    Memo = table.Column<string>(maxLength: 500, nullable: true, comment: "备注"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIPApplyLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VIPApplyModify",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplyId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    OldNum = table.Column<int>(nullable: false),
                    NewNum = table.Column<int>(nullable: false),
                    OperaterId = table.Column<int>(nullable: false, comment: "修改人的MemberId"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Unit = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIPApplyModify", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VIPCounter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    Name = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Memo = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    GoodsNum = table.Column<int>(nullable: false),
                    CustomerNum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIPCounter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VIPCounterCustomer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CounterId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Discount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false, defaultValueSql: "((1))"),
                    UserId = table.Column<int>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIPCounterCustomer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VIPCounterDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CounterId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    VIPPrice = table.Column<decimal>(type: "money", nullable: false),
                    Level = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    IsSales = table.Column<bool>(nullable: false, defaultValueSql: "((1))", comment: "是否在售"),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIPCounterDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VirtualInventory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    GoodsId = table.Column<int>(nullable: false),
                    Num = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VirtualInventory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YangCaiOrderLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: true),
                    UserCode = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    LogText = table.Column<string>(maxLength: 4000, nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceiptCode = table.Column<string>(maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    ReceiptAmount = table.Column<decimal>(type: "decimal(18, 4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YangCaiOrderLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Dictionary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "主键ID"),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "编码名称"),
                    EnglishName = table.Column<string>(unicode: false, maxLength: 50, nullable: true, comment: "编码英文"),
                    ParentId = table.Column<int>(nullable: false, comment: "上级编号"),
                    Sort = table.Column<int>(nullable: false, comment: "编码顺序"),
                    IsEnable = table.Column<bool>(nullable: false, comment: "是否启用"),
                    IsDefault = table.Column<bool>(nullable: false, comment: "是否默认"),
                    IsDelete = table.Column<bool>(nullable: false, comment: "是否删除"),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: false, comment: "编码描述说明"),
                    TypeId = table.Column<int>(nullable: false, comment: "编码类型Id"),
                    TypeName = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "类型名称"),
                    CreateName = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "创建人"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "创建时间"),
                    UpdateUser = table.Column<string>(unicode: false, maxLength: 50, nullable: false, comment: "修改人"),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "修改时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Dictionary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SYS_DICT_Relation_SYS_DICT",
                        column: x => x.TypeId,
                        principalTable: "Sys_DictionaryType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "编码");

            migrationBuilder.CreateIndex(
                name: "IX_Brand",
                table: "Brand",
                columns: new[] { "BranchId", "FullName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer",
                table: "Customer",
                columns: new[] { "BranchId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "<Name of Missing Index, sysname,>",
                table: "Customer",
                columns: new[] { "Id", "Name", "Type", "Status", "EmployeesNum", "Telphone", "SalesId", "PayMethod", "CreditDays", "BranchId", "PayType" });

            migrationBuilder.CreateIndex(
                name: "CreateDate",
                table: "CustomerBalanceLog",
                column: "CreateDate");

            migrationBuilder.CreateIndex(
                name: "CustomerId",
                table: "CustomerBalanceLog",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "CustomerName",
                table: "CustomerBalanceLog",
                column: "CustomerName");

            migrationBuilder.CreateIndex(
                name: "DeptId",
                table: "CustomerBalanceLog",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "RelationId",
                table: "CustomerBalanceLog",
                column: "RelationId");

            migrationBuilder.CreateIndex(
                name: "UserId",
                table: "CustomerBalanceLog",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryLine",
                table: "DeliveryLine",
                columns: new[] { "BranchId", "LineName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BranchId",
                table: "DistributionPay",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ChildBranchId",
                table: "DistributionPay",
                column: "ChildBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "DistributionPay",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsId",
                table: "DistributionPayDetail",
                column: "GoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderId",
                table: "DistributionPayDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_PayId",
                table: "DistributionPayDetail",
                column: "PayId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchId",
                table: "DistributionReceiveInvoice",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ChildBranchId",
                table: "DistributionReceiveInvoice",
                column: "ChildBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_StatementId",
                table: "DistributionReceiveInvoice",
                column: "StatementId");

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "DistributionReceiveInvoice",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsId",
                table: "DistributionReceiveInvoiceDetail",
                column: "GoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderId",
                table: "DistributionReceiveInvoiceDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveInvoiceId",
                table: "DistributionReceiveInvoiceDetail",
                column: "ReceiveInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchId",
                table: "DPStatement",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceStatus",
                table: "DPStatement",
                column: "InvoiceStatus");

            migrationBuilder.CreateIndex(
                name: "IX_PayStatus",
                table: "DPStatement",
                column: "PayStatus");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseStatement",
                table: "DPStatement",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_DPStatementId",
                table: "DPStatementDetail",
                column: "DPStatementId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderId",
                table: "DPStatementDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "NonClusteredIndex-20181031-134951",
                table: "Goods",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "NonClusteredIndex-20181031-135019",
                table: "Goods",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "NonClusteredIndex-20181031-135038",
                table: "Goods",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "Index_ParentId",
                table: "GoodsCategory",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "Index_CreatorUserId",
                table: "GoodsLog",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "Index_GoodsId",
                table: "GoodsLog",
                column: "GoodsId");

            migrationBuilder.CreateIndex(
                name: "Index_GoodsName",
                table: "GoodsLog",
                column: "GoodsName");

            migrationBuilder.CreateIndex(
                name: "Index_UserName",
                table: "GoodsLog",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsModelType",
                table: "GoodsModelValue",
                column: "GoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsPackage",
                table: "GoodsPackage",
                columns: new[] { "GoodsId", "Type" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GoodsParamValue",
                table: "GoodsParamValue",
                column: "GoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsParamValue_1",
                table: "GoodsParamValue",
                columns: new[] { "ParamId", "Value" });

            migrationBuilder.CreateIndex(
                name: "goodsphotoindex",
                table: "GoodsPhoto",
                column: "GoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsTypeParams",
                table: "GoodsTypeParam",
                columns: new[] { "GroupId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GoodsTypeParamGroup",
                table: "GoodsTypeParamGroup",
                columns: new[] { "TypeId", "GroupName", "BranchId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GoodsTypePrivateInfo",
                table: "GoodsTypePrivateInfo",
                columns: new[] { "TypeId", "BranchId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_I_Goods",
                table: "I_Goods",
                columns: new[] { "GoodsId", "Unit", "I_ProjectId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventory",
                table: "Inventory",
                columns: new[] { "GoodsId", "StoreId", "StoreZone", "IsCustomGoods", "OrderDetailId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InventoryStock",
                table: "InventoryStock",
                columns: new[] { "GoodsId", "StoreId" });

            migrationBuilder.CreateIndex(
                name: "IX_MemberAddress",
                table: "MemberAddress",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberCart",
                table: "MemberCart",
                columns: new[] { "MemberId", "GoodsId", "Multiples", "DisplayUnit" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MemberFav",
                table: "MemberFav",
                columns: new[] { "GoodsId", "MemberId" });

            migrationBuilder.CreateIndex(
                name: "IX_MemberPoint",
                table: "MemberPoint",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderArchive",
                table: "OrderArchive",
                columns: new[] { "OrderId", "Page" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderBox",
                table: "OrderBox",
                columns: new[] { "OrderId", "BoxId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Tenant",
                table: "OrderCheckoutLog",
                column: "Tenant");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDeliveryBox",
                table: "OrderDeliveryBox",
                column: "OrderBoxId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail",
                table: "OrderDetail",
                columns: new[] { "OrderId", "GoodsId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderModify",
                table: "OrderModify",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPicking",
                table: "OrderPicking",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_GUID",
                table: "Orders",
                column: "Guid");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_1",
                table: "Orders",
                columns: new[] { "BranchId", "CustomerId", "MemberId" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatement",
                table: "OrderStatement",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatementDetail",
                table: "OrderStatementDetail",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "I_PurchaseId",
                table: "PurchaseDetail",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetail",
                table: "PurchaseDetail",
                columns: new[] { "GoodsId", "PurchaseId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseLog",
                table: "PurchaseLog",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseModify",
                table: "PurchaseModify",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseStatement",
                table: "PurchaseStatement",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseId",
                table: "PurchaseStatementDetail",
                column: "PurchaseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseStatementDetail",
                table: "PurchaseStatementDetail",
                columns: new[] { "PurchaseId", "PurchaseStatementId" });

            migrationBuilder.CreateIndex(
                name: "IX_Store",
                table: "Store",
                columns: new[] { "BranchId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StoreZone",
                table: "StoreZone",
                columns: new[] { "StoreId", "Code" });

            migrationBuilder.CreateIndex(
                name: "Index_CreationTime",
                table: "Strategy_GrossProfit",
                column: "CreationTime");

            migrationBuilder.CreateIndex(
                name: "Index_EndTime",
                table: "Strategy_GrossProfit",
                column: "EndTime");

            migrationBuilder.CreateIndex(
                name: "Index_StartTime",
                table: "Strategy_GrossProfit",
                column: "StartTime");

            migrationBuilder.CreateIndex(
                name: "Index_Tenant",
                table: "Strategy_GrossProfit",
                column: "Tenant");

            migrationBuilder.CreateIndex(
                name: "Index_ItemId",
                table: "StrategyItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "Index_TypeId",
                table: "StrategyItem",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "Index_StrategyId",
                table: "StrategyOrigin",
                column: "StrategyId");

            migrationBuilder.CreateIndex(
                name: "Index_ItemId",
                table: "StrategyRange",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "Index_StrategyId",
                table: "StrategyRule",
                column: "StrategyId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Agent",
                table: "Sys_Agent",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Branch",
                table: "Sys_Branch",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sys_BranchActivity",
                table: "Sys_BranchActivity",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityId",
                table: "Sys_BranchActivityContent",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityId",
                table: "Sys_BranchActivityGift",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityRuleId",
                table: "Sys_BranchActivityGift",
                column: "ActivityRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsId",
                table: "Sys_BranchActivityGift",
                column: "GoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityId",
                table: "Sys_BranchActivityRange",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityId",
                table: "Sys_BranchActivityRule",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_BranchAreas",
                table: "Sys_BranchAreas",
                columns: new[] { "BranchId", "Name" });

            migrationBuilder.CreateIndex(
                name: "Index_Tenant",
                table: "Sys_BranchSiteSolution",
                column: "Tenant");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Car",
                table: "Sys_Car",
                columns: new[] { "BranchId", "Plate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sys_CarUser",
                table: "Sys_CarUser",
                columns: new[] { "CarId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Dept",
                table: "Sys_Dept",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Dictionary_TypeId",
                table: "Sys_Dictionary",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_DictionaryType",
                table: "Sys_DictionaryType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sys_GroupBranch",
                table: "Sys_GroupBranch",
                columns: new[] { "BranchId", "GroupId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Role",
                table: "Sys_Role",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Sms",
                table: "Sys_Sms",
                column: "Mobile");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_UserRole",
                table: "Sys_UserRole",
                columns: new[] { "RoleId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SystemManager",
                table: "SystemManager",
                column: "LoginName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransferDetail",
                table: "TransferDetail",
                columns: new[] { "GoodsId", "TransferId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VIPApplyDetail",
                table: "VIPApplyDetail",
                columns: new[] { "ApplyId", "GoodsId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VIPApplyModify",
                table: "VIPApplyModify",
                column: "ApplyId");

            migrationBuilder.CreateIndex(
                name: "IX_VIPCounter",
                table: "VIPCounter",
                columns: new[] { "BranchId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VIPCounterCustomer",
                table: "VIPCounterCustomer",
                columns: new[] { "CounterId", "CustomerId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VIPCounterDetail",
                table: "VIPCounterDetail",
                columns: new[] { "CounterId", "GoodsId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttachedFil");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "CanvassAgreement");

            migrationBuilder.DropTable(
                name: "CatagoryParams");

            migrationBuilder.DropTable(
                name: "CrawlerRequest");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "CustomerBalanceLog");

            migrationBuilder.DropTable(
                name: "CustomerInvoiceInfo");

            migrationBuilder.DropTable(
                name: "CustomerLog");

            migrationBuilder.DropTable(
                name: "CustomerPreReceiveMoney");

            migrationBuilder.DropTable(
                name: "CustomerSetting");

            migrationBuilder.DropTable(
                name: "DefaultStore");

            migrationBuilder.DropTable(
                name: "DeliveryLine");

            migrationBuilder.DropTable(
                name: "DeliveryLineCustomer");

            migrationBuilder.DropTable(
                name: "DeliveryLineMember");

            migrationBuilder.DropTable(
                name: "DellOrderGoodsPo");

            migrationBuilder.DropTable(
                name: "Dept");

            migrationBuilder.DropTable(
                name: "DeptTemp");

            migrationBuilder.DropTable(
                name: "DistributionCustomerInvoice");

            migrationBuilder.DropTable(
                name: "DistributionCustomerInvoiceDetail");

            migrationBuilder.DropTable(
                name: "DistributionCustomerReceiveMoney");

            migrationBuilder.DropTable(
                name: "DistributionCustomerReceiveMoneyDetail");

            migrationBuilder.DropTable(
                name: "DistributionInvoice");

            migrationBuilder.DropTable(
                name: "DistributionInvoiceDetail");

            migrationBuilder.DropTable(
                name: "DistributionOperation");

            migrationBuilder.DropTable(
                name: "DistributionOrderState");

            migrationBuilder.DropTable(
                name: "DistributionPay");

            migrationBuilder.DropTable(
                name: "DistributionPayDetail");

            migrationBuilder.DropTable(
                name: "DistributionReceiveInvoice");

            migrationBuilder.DropTable(
                name: "DistributionReceiveInvoiceDetail");

            migrationBuilder.DropTable(
                name: "DistributionReceiveMoney");

            migrationBuilder.DropTable(
                name: "DistributionReceiveMoneyDetail");

            migrationBuilder.DropTable(
                name: "DOStatement");

            migrationBuilder.DropTable(
                name: "DOStatementDetail");

            migrationBuilder.DropTable(
                name: "DPStatement");

            migrationBuilder.DropTable(
                name: "DPStatementDetail");

            migrationBuilder.DropTable(
                name: "EmailInvoiceSetting");

            migrationBuilder.DropTable(
                name: "FinanceAudit");

            migrationBuilder.DropTable(
                name: "FinanceRecord");

            migrationBuilder.DropTable(
                name: "FinanceSubject");

            migrationBuilder.DropTable(
                name: "Franchisee");

            migrationBuilder.DropTable(
                name: "Gift");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "GoodsCaptcha");

            migrationBuilder.DropTable(
                name: "GoodsCategory");

            migrationBuilder.DropTable(
                name: "GoodsComment");

            migrationBuilder.DropTable(
                name: "GoodsDefaultInfo");

            migrationBuilder.DropTable(
                name: "GoodsExtensions");

            migrationBuilder.DropTable(
                name: "GoodsGroupDetail");

            migrationBuilder.DropTable(
                name: "GoodsLog");

            migrationBuilder.DropTable(
                name: "GoodsModel");

            migrationBuilder.DropTable(
                name: "GoodsModelValue");

            migrationBuilder.DropTable(
                name: "GoodsPackage");

            migrationBuilder.DropTable(
                name: "GoodsPackageLog");

            migrationBuilder.DropTable(
                name: "GoodsParamValue");

            migrationBuilder.DropTable(
                name: "GoodsPhoto");

            migrationBuilder.DropTable(
                name: "GoodsPriceLog");

            migrationBuilder.DropTable(
                name: "GoodsType");

            migrationBuilder.DropTable(
                name: "GoodsTypeParam");

            migrationBuilder.DropTable(
                name: "GoodsTypeParamGroup");

            migrationBuilder.DropTable(
                name: "GoodsTypeParamOption");

            migrationBuilder.DropTable(
                name: "GoodsTypePrivateInfo");

            migrationBuilder.DropTable(
                name: "GoodsTypeUpdate");

            migrationBuilder.DropTable(
                name: "GroupOrderStatement");

            migrationBuilder.DropTable(
                name: "GroupOrderStatementDetail");

            migrationBuilder.DropTable(
                name: "GroupPay");

            migrationBuilder.DropTable(
                name: "I_Analysis");

            migrationBuilder.DropTable(
                name: "I_BeiJingGoods");

            migrationBuilder.DropTable(
                name: "I_BeiJingGoodsMap");

            migrationBuilder.DropTable(
                name: "I_BeiJingProductParam");

            migrationBuilder.DropTable(
                name: "I_BeiJingZhengCaiCityList");

            migrationBuilder.DropTable(
                name: "I_Category");

            migrationBuilder.DropTable(
                name: "I_ChengDuCategoryExt");

            migrationBuilder.DropTable(
                name: "I_ChengDuCategoryParam");

            migrationBuilder.DropTable(
                name: "I_ChengDuParamValue");

            migrationBuilder.DropTable(
                name: "I_EfficientGoods");

            migrationBuilder.DropTable(
                name: "I_EGoods");

            migrationBuilder.DropTable(
                name: "I_ErrLog");

            migrationBuilder.DropTable(
                name: "I_Goods");

            migrationBuilder.DropTable(
                name: "I_GoodsLog");

            migrationBuilder.DropTable(
                name: "I_GoodsMap");

            migrationBuilder.DropTable(
                name: "I_GoodsOperateLog");

            migrationBuilder.DropTable(
                name: "I_GoodsPart");

            migrationBuilder.DropTable(
                name: "I_Message");

            migrationBuilder.DropTable(
                name: "I_OrderDetail");

            migrationBuilder.DropTable(
                name: "I_OrderExtension");

            migrationBuilder.DropTable(
                name: "I_Orders");

            migrationBuilder.DropTable(
                name: "I_Plat");

            migrationBuilder.DropTable(
                name: "I_Product");

            migrationBuilder.DropTable(
                name: "I_ProductsForZGLY");

            migrationBuilder.DropTable(
                name: "I_ProductsMapForZGLY");

            migrationBuilder.DropTable(
                name: "I_Project");

            migrationBuilder.DropTable(
                name: "I_ProjectExtention");

            migrationBuilder.DropTable(
                name: "I_Provider");

            migrationBuilder.DropTable(
                name: "IContract");

            migrationBuilder.DropTable(
                name: "IContractMY");

            migrationBuilder.DropTable(
                name: "IntroductionInvestment");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "InventoryLog");

            migrationBuilder.DropTable(
                name: "InventoryModifyAC");

            migrationBuilder.DropTable(
                name: "InventoryStock");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "InvoiceLog");

            migrationBuilder.DropTable(
                name: "InvoiceRequire");

            migrationBuilder.DropTable(
                name: "InvoiceRequireDetail");

            migrationBuilder.DropTable(
                name: "IOrderContract");

            migrationBuilder.DropTable(
                name: "LoginedIdentity");

            migrationBuilder.DropTable(
                name: "Logistics");

            migrationBuilder.DropTable(
                name: "LogisticsCompany");

            migrationBuilder.DropTable(
                name: "LogisticsDetail");

            migrationBuilder.DropTable(
                name: "LogisticsInfomation");

            migrationBuilder.DropTable(
                name: "LogisticsSubscribeLog");

            migrationBuilder.DropTable(
                name: "LogisticsSupported");

            migrationBuilder.DropTable(
                name: "MajorParamsDetail");

            migrationBuilder.DropTable(
                name: "MallFloatAd");

            migrationBuilder.DropTable(
                name: "MallSideBar");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "MemberAddress");

            migrationBuilder.DropTable(
                name: "MemberAddressTemp");

            migrationBuilder.DropTable(
                name: "MemberApplyDept");

            migrationBuilder.DropTable(
                name: "MemberAuth");

            migrationBuilder.DropTable(
                name: "MemberCart");

            migrationBuilder.DropTable(
                name: "MemberFav");

            migrationBuilder.DropTable(
                name: "MemberInvoiceInfo");

            migrationBuilder.DropTable(
                name: "MemberLog");

            migrationBuilder.DropTable(
                name: "MemberOrderDept");

            migrationBuilder.DropTable(
                name: "MemberPoint");

            migrationBuilder.DropTable(
                name: "MemberRole");

            migrationBuilder.DropTable(
                name: "MemberTemp");

            migrationBuilder.DropTable(
                name: "ModifyAC");

            migrationBuilder.DropTable(
                name: "NeedToPurchase");

            migrationBuilder.DropTable(
                name: "NeedToPurchaseDetail");

            migrationBuilder.DropTable(
                name: "NeedToPurchaseOrder");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "NewsType");

            migrationBuilder.DropTable(
                name: "Notify_Msg");

            migrationBuilder.DropTable(
                name: "Notify_Setting");

            migrationBuilder.DropTable(
                name: "Notify_SmsSign");

            migrationBuilder.DropTable(
                name: "Notify_Templet");

            migrationBuilder.DropTable(
                name: "OrderAfterSale");

            migrationBuilder.DropTable(
                name: "OrderAfterSaleFlow");

            migrationBuilder.DropTable(
                name: "OrderAfterSalePhoto");

            migrationBuilder.DropTable(
                name: "OrderArchive");

            migrationBuilder.DropTable(
                name: "OrderBox");

            migrationBuilder.DropTable(
                name: "OrderCheckoutLog");

            migrationBuilder.DropTable(
                name: "OrderDelivery");

            migrationBuilder.DropTable(
                name: "OrderDeliveryBox");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "OrderDistribution");

            migrationBuilder.DropTable(
                name: "OrderDistributionDetail");

            migrationBuilder.DropTable(
                name: "OrderGoodsComments");

            migrationBuilder.DropTable(
                name: "OrderInvoiceInfo");

            migrationBuilder.DropTable(
                name: "OrderLog");

            migrationBuilder.DropTable(
                name: "OrderModify");

            migrationBuilder.DropTable(
                name: "OrderModifyAC");

            migrationBuilder.DropTable(
                name: "OrderPicking");

            migrationBuilder.DropTable(
                name: "OrderPickingLog");

            migrationBuilder.DropTable(
                name: "OrderReceiveMoney");

            migrationBuilder.DropTable(
                name: "OrderReceiveMoneyDetail");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "OrderStatement");

            migrationBuilder.DropTable(
                name: "OrderStatementCrossInvoice");

            migrationBuilder.DropTable(
                name: "OrderStatementDetail");

            migrationBuilder.DropTable(
                name: "ParamGather");

            migrationBuilder.DropTable(
                name: "PayLog");

            migrationBuilder.DropTable(
                name: "PlatformInfo");

            migrationBuilder.DropTable(
                name: "PreGoodsPhoto");

            migrationBuilder.DropTable(
                name: "PreInvoice");

            migrationBuilder.DropTable(
                name: "PrintTempletDic");

            migrationBuilder.DropTable(
                name: "Product_GoodsType");

            migrationBuilder.DropTable(
                name: "Product_Info");

            migrationBuilder.DropTable(
                name: "ProGoodsType");

            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropTable(
                name: "PurchaseDetail");

            migrationBuilder.DropTable(
                name: "PurchaseLog");

            migrationBuilder.DropTable(
                name: "PurchaseMerge");

            migrationBuilder.DropTable(
                name: "PurchaseModify");

            migrationBuilder.DropTable(
                name: "PurchasePay");

            migrationBuilder.DropTable(
                name: "PurchasePayDetail");

            migrationBuilder.DropTable(
                name: "PurchaseQuote");

            migrationBuilder.DropTable(
                name: "PurchaseQuoteDetail");

            migrationBuilder.DropTable(
                name: "PurchaseStatement");

            migrationBuilder.DropTable(
                name: "PurchaseStatementDetail");

            migrationBuilder.DropTable(
                name: "Quotation");

            migrationBuilder.DropTable(
                name: "RegisterProtocol");

            migrationBuilder.DropTable(
                name: "SalesPlan");

            migrationBuilder.DropTable(
                name: "SalesStoreMap");

            migrationBuilder.DropTable(
                name: "ServiceOrder");

            migrationBuilder.DropTable(
                name: "ServiceOrderDelivery");

            migrationBuilder.DropTable(
                name: "ServiceOrderDeliveryDetail");

            migrationBuilder.DropTable(
                name: "ServiceOrderDetail");

            migrationBuilder.DropTable(
                name: "ServiceOrderItem");

            migrationBuilder.DropTable(
                name: "ServiceOrderLog");

            migrationBuilder.DropTable(
                name: "ServiceOrderStaff");

            migrationBuilder.DropTable(
                name: "SiChuanLog");

            migrationBuilder.DropTable(
                name: "SourceGoods");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "StoreZone");

            migrationBuilder.DropTable(
                name: "Strategy_GrossProfit");

            migrationBuilder.DropTable(
                name: "StrategyItem");

            migrationBuilder.DropTable(
                name: "StrategyOrigin");

            migrationBuilder.DropTable(
                name: "StrategyRange");

            migrationBuilder.DropTable(
                name: "StrategyRule");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "SupplierContacts");

            migrationBuilder.DropTable(
                name: "SupplierDepartment");

            migrationBuilder.DropTable(
                name: "SupplierInvoice");

            migrationBuilder.DropTable(
                name: "SupplierInvoiceDetails");

            migrationBuilder.DropTable(
                name: "SupplierPrepayment");

            migrationBuilder.DropTable(
                name: "SupplierSettleAccounts");

            migrationBuilder.DropTable(
                name: "SurveysFeedBack");

            migrationBuilder.DropTable(
                name: "Sys_Agent");

            migrationBuilder.DropTable(
                name: "Sys_Agent_Users");

            migrationBuilder.DropTable(
                name: "Sys_Approve");

            migrationBuilder.DropTable(
                name: "Sys_Authorize");

            migrationBuilder.DropTable(
                name: "Sys_Branch");

            migrationBuilder.DropTable(
                name: "Sys_Branch_CSS");

            migrationBuilder.DropTable(
                name: "Sys_BranchActivity");

            migrationBuilder.DropTable(
                name: "Sys_BranchActivityContent");

            migrationBuilder.DropTable(
                name: "Sys_BranchActivityGift");

            migrationBuilder.DropTable(
                name: "Sys_BranchActivityRange");

            migrationBuilder.DropTable(
                name: "Sys_BranchActivityRule");

            migrationBuilder.DropTable(
                name: "Sys_BranchAds");

            migrationBuilder.DropTable(
                name: "Sys_BranchArea");

            migrationBuilder.DropTable(
                name: "Sys_BranchAreaDetail");

            migrationBuilder.DropTable(
                name: "Sys_BranchAreas");

            migrationBuilder.DropTable(
                name: "Sys_BranchAuth");

            migrationBuilder.DropTable(
                name: "Sys_BranchBankInfo");

            migrationBuilder.DropTable(
                name: "Sys_BranchEmailSetting");

            migrationBuilder.DropTable(
                name: "Sys_BranchERPSetting");

            migrationBuilder.DropTable(
                name: "Sys_BranchFloor");

            migrationBuilder.DropTable(
                name: "Sys_BranchFloorBrandingWall");

            migrationBuilder.DropTable(
                name: "Sys_BranchFloorBrandingWallPhotos");

            migrationBuilder.DropTable(
                name: "Sys_BranchFloorDisplayType");

            migrationBuilder.DropTable(
                name: "Sys_BranchGoodsType");

            migrationBuilder.DropTable(
                name: "Sys_BranchHelp");

            migrationBuilder.DropTable(
                name: "Sys_BranchHelpContent");

            migrationBuilder.DropTable(
                name: "Sys_BranchHelpGroup");

            migrationBuilder.DropTable(
                name: "Sys_BranchHelpGroupPrivateInfo");

            migrationBuilder.DropTable(
                name: "Sys_BranchHelpPrivateInfo");

            migrationBuilder.DropTable(
                name: "Sys_BranchHotWords");

            migrationBuilder.DropTable(
                name: "Sys_BranchPay");

            migrationBuilder.DropTable(
                name: "Sys_BranchPayment");

            migrationBuilder.DropTable(
                name: "Sys_BranchSeo");

            migrationBuilder.DropTable(
                name: "Sys_BranchServicePromise");

            migrationBuilder.DropTable(
                name: "Sys_BranchServicePromiseDetail");

            migrationBuilder.DropTable(
                name: "Sys_BranchSetting");

            migrationBuilder.DropTable(
                name: "Sys_BranchSiteFooter");

            migrationBuilder.DropTable(
                name: "Sys_BranchSiteSetting");

            migrationBuilder.DropTable(
                name: "Sys_BranchSiteSolution");

            migrationBuilder.DropTable(
                name: "Sys_BranchTheme");

            migrationBuilder.DropTable(
                name: "Sys_BranchThemeArea");

            migrationBuilder.DropTable(
                name: "Sys_BranchThemeAreaGoodsTab");

            migrationBuilder.DropTable(
                name: "Sys_BranchThemeAreaPhoto");

            migrationBuilder.DropTable(
                name: "Sys_BranchThirdParty");

            migrationBuilder.DropTable(
                name: "Sys_BranchTopMenu");

            migrationBuilder.DropTable(
                name: "Sys_CanvassAgreement");

            migrationBuilder.DropTable(
                name: "Sys_Car");

            migrationBuilder.DropTable(
                name: "Sys_CarLog");

            migrationBuilder.DropTable(
                name: "Sys_CarUser");

            migrationBuilder.DropTable(
                name: "Sys_City");

            migrationBuilder.DropTable(
                name: "Sys_Config");

            migrationBuilder.DropTable(
                name: "Sys_Dept");

            migrationBuilder.DropTable(
                name: "Sys_Dictionary");

            migrationBuilder.DropTable(
                name: "Sys_Distribution");

            migrationBuilder.DropTable(
                name: "Sys_DistributionGroup");

            migrationBuilder.DropTable(
                name: "Sys_ErrorLog");

            migrationBuilder.DropTable(
                name: "Sys_Group");

            migrationBuilder.DropTable(
                name: "Sys_GroupBranch");

            migrationBuilder.DropTable(
                name: "Sys_GroupLoginSetting");

            migrationBuilder.DropTable(
                name: "Sys_MapiServer");

            migrationBuilder.DropTable(
                name: "Sys_Permission");

            migrationBuilder.DropTable(
                name: "Sys_PermissionGroup");

            migrationBuilder.DropTable(
                name: "Sys_Price");

            migrationBuilder.DropTable(
                name: "Sys_PrintSetting");

            migrationBuilder.DropTable(
                name: "Sys_PrintTemplate");

            migrationBuilder.DropTable(
                name: "Sys_PrintValidate");

            migrationBuilder.DropTable(
                name: "Sys_Renew");

            migrationBuilder.DropTable(
                name: "Sys_Role");

            migrationBuilder.DropTable(
                name: "Sys_RolePermission");

            migrationBuilder.DropTable(
                name: "Sys_SiteCSS");

            migrationBuilder.DropTable(
                name: "Sys_Sms");

            migrationBuilder.DropTable(
                name: "Sys_UrlLog");

            migrationBuilder.DropTable(
                name: "Sys_UserRole");

            migrationBuilder.DropTable(
                name: "Sys_Users");

            migrationBuilder.DropTable(
                name: "SystemManager");

            migrationBuilder.DropTable(
                name: "TaxCategory");

            migrationBuilder.DropTable(
                name: "TaxCategoryGoodsMap");

            migrationBuilder.DropTable(
                name: "temp");

            migrationBuilder.DropTable(
                name: "ThirdCategory");

            migrationBuilder.DropTable(
                name: "ThirdPartyGoodsCategoryMatch");

            migrationBuilder.DropTable(
                name: "ThirdPartyGoodsMatch");

            migrationBuilder.DropTable(
                name: "ThirdPartyLogin");

            migrationBuilder.DropTable(
                name: "ThirdProduct");

            migrationBuilder.DropTable(
                name: "Transfer");

            migrationBuilder.DropTable(
                name: "TransferArchive");

            migrationBuilder.DropTable(
                name: "TransferBox");

            migrationBuilder.DropTable(
                name: "TransferDelivery");

            migrationBuilder.DropTable(
                name: "TransferDeliveryBox");

            migrationBuilder.DropTable(
                name: "TransferDetail");

            migrationBuilder.DropTable(
                name: "TransferLog");

            migrationBuilder.DropTable(
                name: "TransferPicking");

            migrationBuilder.DropTable(
                name: "TransferPickingLog");

            migrationBuilder.DropTable(
                name: "TransferReceiveMoney");

            migrationBuilder.DropTable(
                name: "TransferStatement");

            migrationBuilder.DropTable(
                name: "TransferStatementDetail");

            migrationBuilder.DropTable(
                name: "VIPApply");

            migrationBuilder.DropTable(
                name: "VIPApplyDetail");

            migrationBuilder.DropTable(
                name: "VIPApplyInvoiceInfo");

            migrationBuilder.DropTable(
                name: "VIPApplyLog");

            migrationBuilder.DropTable(
                name: "VIPApplyModify");

            migrationBuilder.DropTable(
                name: "VIPCounter");

            migrationBuilder.DropTable(
                name: "VIPCounterCustomer");

            migrationBuilder.DropTable(
                name: "VIPCounterDetail");

            migrationBuilder.DropTable(
                name: "VirtualInventory");

            migrationBuilder.DropTable(
                name: "YangCaiOrderLog");

            migrationBuilder.DropTable(
                name: "Sys_DictionaryType");
        }
    }
}
