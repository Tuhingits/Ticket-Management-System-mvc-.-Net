using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManagementSystem.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    C_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<string>(nullable: false),
                    TotalTk = table.Column<string>(nullable: false),
                    UserU_Id = table.Column<int>(nullable: true),
                    PromoPr_Id = table.Column<int>(nullable: true),
                    LaunchL_Id = table.Column<int>(nullable: true),
                    CartLineCl_Id = table.Column<int>(nullable: true),
                    FeedBackFb_Id = table.Column<int>(nullable: true),
                    PaymentP_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.C_Id);
                });

            migrationBuilder.CreateTable(
                name: "CavinDetails",
                columns: table => new
                {
                    Cv_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CavinCatagory = table.Column<string>(nullable: false),
                    Rent = table.Column<double>(nullable: false),
                    Position = table.Column<string>(nullable: false),
                    CavinNumber = table.Column<string>(nullable: false),
                    LaunchL_Id = table.Column<int>(nullable: true),
                    CartLineCl_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CavinDetails", x => x.Cv_Id);
                });

            migrationBuilder.CreateTable(
                name: "CartLines",
                columns: table => new
                {
                    Cl_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<string>(nullable: false),
                    Catarory = table.Column<string>(nullable: false),
                    CartC_Id = table.Column<int>(nullable: true),
                    CavinDetailsCv_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartLines", x => x.Cl_Id);
                    table.ForeignKey(
                        name: "FK_CartLines_Carts_CartC_Id",
                        column: x => x.CartC_Id,
                        principalTable: "Carts",
                        principalColumn: "C_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartLines_CavinDetails_CavinDetailsCv_Id",
                        column: x => x.CavinDetailsCv_Id,
                        principalTable: "CavinDetails",
                        principalColumn: "Cv_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FeedBacks",
                columns: table => new
                {
                    Fb_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Details = table.Column<string>(nullable: false),
                    Filter = table.Column<string>(nullable: false),
                    CartC_Id = table.Column<int>(nullable: true),
                    UserU_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBacks", x => x.Fb_Id);
                    table.ForeignKey(
                        name: "FK_FeedBacks_Carts_CartC_Id",
                        column: x => x.CartC_Id,
                        principalTable: "Carts",
                        principalColumn: "C_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Launches",
                columns: table => new
                {
                    L_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Rout = table.Column<string>(nullable: false),
                    CartC_Id = table.Column<int>(nullable: true),
                    CavinDetailsCv_Id = table.Column<int>(nullable: true),
                    OwnerO_Id = table.Column<int>(nullable: true),
                    PromoForUserPFU_Id = table.Column<int>(nullable: true),
                    SchedulS_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Launches", x => x.L_Id);
                    table.ForeignKey(
                        name: "FK_Launches_Carts_CartC_Id",
                        column: x => x.CartC_Id,
                        principalTable: "Carts",
                        principalColumn: "C_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Launches_CavinDetails_CavinDetailsCv_Id",
                        column: x => x.CavinDetailsCv_Id,
                        principalTable: "CavinDetails",
                        principalColumn: "Cv_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    O_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OwnerName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    LaunchL_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.O_Id);
                    table.ForeignKey(
                        name: "FK_Owners_Launches_LaunchL_Id",
                        column: x => x.LaunchL_Id,
                        principalTable: "Launches",
                        principalColumn: "L_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Scheduls",
                columns: table => new
                {
                    S_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<string>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    From = table.Column<string>(nullable: false),
                    To = table.Column<string>(nullable: false),
                    LaunchL_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scheduls", x => x.S_Id);
                    table.ForeignKey(
                        name: "FK_Scheduls_Launches_LaunchL_Id",
                        column: x => x.LaunchL_Id,
                        principalTable: "Launches",
                        principalColumn: "L_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    P_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PaymentStatus = table.Column<string>(nullable: false),
                    PaymentOption = table.Column<string>(nullable: false),
                    UserU_Id = table.Column<int>(nullable: true),
                    CartC_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.P_Id);
                    table.ForeignKey(
                        name: "FK_Payments_Carts_CartC_Id",
                        column: x => x.CartC_Id,
                        principalTable: "Carts",
                        principalColumn: "C_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Promos",
                columns: table => new
                {
                    Pr_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PromoCode = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Discount = table.Column<string>(nullable: false),
                    MaxAmount = table.Column<double>(nullable: false),
                    CartC_Id = table.Column<int>(nullable: true),
                    PromoForLaunchPFL_Id = table.Column<int>(nullable: true),
                    PromoForUserPFU_Id = table.Column<int>(nullable: true),
                    PromoPr_Id = table.Column<int>(nullable: true),
                    PromoUserPU_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promos", x => x.Pr_Id);
                    table.ForeignKey(
                        name: "FK_Promos_Carts_CartC_Id",
                        column: x => x.CartC_Id,
                        principalTable: "Carts",
                        principalColumn: "C_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Promos_Promos_PromoPr_Id",
                        column: x => x.PromoPr_Id,
                        principalTable: "Promos",
                        principalColumn: "Pr_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PromoForUsers",
                columns: table => new
                {
                    PFU_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LaunchL_Id = table.Column<int>(nullable: true),
                    PromoPr_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoForUsers", x => x.PFU_Id);
                    table.ForeignKey(
                        name: "FK_PromoForUsers_Launches_LaunchL_Id",
                        column: x => x.LaunchL_Id,
                        principalTable: "Launches",
                        principalColumn: "L_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PromoForUsers_Promos_PromoPr_Id",
                        column: x => x.PromoPr_Id,
                        principalTable: "Promos",
                        principalColumn: "Pr_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    U_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 16, nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    CartC_Id = table.Column<int>(nullable: true),
                    FeedBackFb_Id = table.Column<int>(nullable: true),
                    PaymentP_Id = table.Column<int>(nullable: true),
                    PromoForLaunchPFL_Id = table.Column<int>(nullable: true),
                    PromoUserPU_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.U_Id);
                    table.ForeignKey(
                        name: "FK_Users_Carts_CartC_Id",
                        column: x => x.CartC_Id,
                        principalTable: "Carts",
                        principalColumn: "C_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_FeedBacks_FeedBackFb_Id",
                        column: x => x.FeedBackFb_Id,
                        principalTable: "FeedBacks",
                        principalColumn: "Fb_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Payments_PaymentP_Id",
                        column: x => x.PaymentP_Id,
                        principalTable: "Payments",
                        principalColumn: "P_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PromoForLaunches",
                columns: table => new
                {
                    PFL_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserU_Id = table.Column<int>(nullable: true),
                    PromoPr_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoForLaunches", x => x.PFL_Id);
                    table.ForeignKey(
                        name: "FK_PromoForLaunches_Promos_PromoPr_Id",
                        column: x => x.PromoPr_Id,
                        principalTable: "Promos",
                        principalColumn: "Pr_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PromoForLaunches_Users_UserU_Id",
                        column: x => x.UserU_Id,
                        principalTable: "Users",
                        principalColumn: "U_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PromoUsers",
                columns: table => new
                {
                    PU_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<string>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    UserU_Id = table.Column<int>(nullable: true),
                    PromoPr_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoUsers", x => x.PU_Id);
                    table.ForeignKey(
                        name: "FK_PromoUsers_Promos_PromoPr_Id",
                        column: x => x.PromoPr_Id,
                        principalTable: "Promos",
                        principalColumn: "Pr_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PromoUsers_Users_UserU_Id",
                        column: x => x.UserU_Id,
                        principalTable: "Users",
                        principalColumn: "U_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartLines_CartC_Id",
                table: "CartLines",
                column: "CartC_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CartLines_CavinDetailsCv_Id",
                table: "CartLines",
                column: "CavinDetailsCv_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CartLineCl_Id",
                table: "Carts",
                column: "CartLineCl_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_FeedBackFb_Id",
                table: "Carts",
                column: "FeedBackFb_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_LaunchL_Id",
                table: "Carts",
                column: "LaunchL_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_PaymentP_Id",
                table: "Carts",
                column: "PaymentP_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_PromoPr_Id",
                table: "Carts",
                column: "PromoPr_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserU_Id",
                table: "Carts",
                column: "UserU_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CavinDetails_CartLineCl_Id",
                table: "CavinDetails",
                column: "CartLineCl_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CavinDetails_LaunchL_Id",
                table: "CavinDetails",
                column: "LaunchL_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_CartC_Id",
                table: "FeedBacks",
                column: "CartC_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_UserU_Id",
                table: "FeedBacks",
                column: "UserU_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Launches_CartC_Id",
                table: "Launches",
                column: "CartC_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Launches_CavinDetailsCv_Id",
                table: "Launches",
                column: "CavinDetailsCv_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Launches_OwnerO_Id",
                table: "Launches",
                column: "OwnerO_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Launches_PromoForUserPFU_Id",
                table: "Launches",
                column: "PromoForUserPFU_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Launches_SchedulS_Id",
                table: "Launches",
                column: "SchedulS_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_LaunchL_Id",
                table: "Owners",
                column: "LaunchL_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CartC_Id",
                table: "Payments",
                column: "CartC_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserU_Id",
                table: "Payments",
                column: "UserU_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PromoForLaunches_PromoPr_Id",
                table: "PromoForLaunches",
                column: "PromoPr_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PromoForLaunches_UserU_Id",
                table: "PromoForLaunches",
                column: "UserU_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PromoForUsers_LaunchL_Id",
                table: "PromoForUsers",
                column: "LaunchL_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PromoForUsers_PromoPr_Id",
                table: "PromoForUsers",
                column: "PromoPr_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Promos_CartC_Id",
                table: "Promos",
                column: "CartC_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Promos_PromoForLaunchPFL_Id",
                table: "Promos",
                column: "PromoForLaunchPFL_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Promos_PromoForUserPFU_Id",
                table: "Promos",
                column: "PromoForUserPFU_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Promos_PromoPr_Id",
                table: "Promos",
                column: "PromoPr_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Promos_PromoUserPU_Id",
                table: "Promos",
                column: "PromoUserPU_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PromoUsers_PromoPr_Id",
                table: "PromoUsers",
                column: "PromoPr_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PromoUsers_UserU_Id",
                table: "PromoUsers",
                column: "UserU_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Scheduls_LaunchL_Id",
                table: "Scheduls",
                column: "LaunchL_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CartC_Id",
                table: "Users",
                column: "CartC_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_FeedBackFb_Id",
                table: "Users",
                column: "FeedBackFb_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PaymentP_Id",
                table: "Users",
                column: "PaymentP_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PromoForLaunchPFL_Id",
                table: "Users",
                column: "PromoForLaunchPFL_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PromoUserPU_Id",
                table: "Users",
                column: "PromoUserPU_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_CartLines_CartLineCl_Id",
                table: "Carts",
                column: "CartLineCl_Id",
                principalTable: "CartLines",
                principalColumn: "Cl_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_FeedBacks_FeedBackFb_Id",
                table: "Carts",
                column: "FeedBackFb_Id",
                principalTable: "FeedBacks",
                principalColumn: "Fb_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Launches_LaunchL_Id",
                table: "Carts",
                column: "LaunchL_Id",
                principalTable: "Launches",
                principalColumn: "L_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Payments_PaymentP_Id",
                table: "Carts",
                column: "PaymentP_Id",
                principalTable: "Payments",
                principalColumn: "P_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Promos_PromoPr_Id",
                table: "Carts",
                column: "PromoPr_Id",
                principalTable: "Promos",
                principalColumn: "Pr_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserU_Id",
                table: "Carts",
                column: "UserU_Id",
                principalTable: "Users",
                principalColumn: "U_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CavinDetails_CartLines_CartLineCl_Id",
                table: "CavinDetails",
                column: "CartLineCl_Id",
                principalTable: "CartLines",
                principalColumn: "Cl_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CavinDetails_Launches_LaunchL_Id",
                table: "CavinDetails",
                column: "LaunchL_Id",
                principalTable: "Launches",
                principalColumn: "L_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBacks_Users_UserU_Id",
                table: "FeedBacks",
                column: "UserU_Id",
                principalTable: "Users",
                principalColumn: "U_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Owners_OwnerO_Id",
                table: "Launches",
                column: "OwnerO_Id",
                principalTable: "Owners",
                principalColumn: "O_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_PromoForUsers_PromoForUserPFU_Id",
                table: "Launches",
                column: "PromoForUserPFU_Id",
                principalTable: "PromoForUsers",
                principalColumn: "PFU_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Scheduls_SchedulS_Id",
                table: "Launches",
                column: "SchedulS_Id",
                principalTable: "Scheduls",
                principalColumn: "S_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Users_UserU_Id",
                table: "Payments",
                column: "UserU_Id",
                principalTable: "Users",
                principalColumn: "U_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Promos_PromoForUsers_PromoForUserPFU_Id",
                table: "Promos",
                column: "PromoForUserPFU_Id",
                principalTable: "PromoForUsers",
                principalColumn: "PFU_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Promos_PromoForLaunches_PromoForLaunchPFL_Id",
                table: "Promos",
                column: "PromoForLaunchPFL_Id",
                principalTable: "PromoForLaunches",
                principalColumn: "PFL_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Promos_PromoUsers_PromoUserPU_Id",
                table: "Promos",
                column: "PromoUserPU_Id",
                principalTable: "PromoUsers",
                principalColumn: "PU_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_PromoForLaunches_PromoForLaunchPFL_Id",
                table: "Users",
                column: "PromoForLaunchPFL_Id",
                principalTable: "PromoForLaunches",
                principalColumn: "PFL_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_PromoUsers_PromoUserPU_Id",
                table: "Users",
                column: "PromoUserPU_Id",
                principalTable: "PromoUsers",
                principalColumn: "PU_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartLines_Carts_CartC_Id",
                table: "CartLines");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedBacks_Carts_CartC_Id",
                table: "FeedBacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Carts_CartC_Id",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Carts_CartC_Id",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Promos_Carts_CartC_Id",
                table: "Promos");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Carts_CartC_Id",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_CartLines_CavinDetails_CavinDetailsCv_Id",
                table: "CartLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_CavinDetails_CavinDetailsCv_Id",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_FeedBacks_FeedBackFb_Id",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Launches_LaunchL_Id",
                table: "Owners");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoForUsers_Launches_LaunchL_Id",
                table: "PromoForUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Scheduls_Launches_LaunchL_Id",
                table: "Scheduls");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Payments_PaymentP_Id",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoForLaunches_Promos_PromoPr_Id",
                table: "PromoForLaunches");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoForUsers_Promos_PromoPr_Id",
                table: "PromoForUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoUsers_Promos_PromoPr_Id",
                table: "PromoUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoForLaunches_Users_UserU_Id",
                table: "PromoForLaunches");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoUsers_Users_UserU_Id",
                table: "PromoUsers");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "CavinDetails");

            migrationBuilder.DropTable(
                name: "CartLines");

            migrationBuilder.DropTable(
                name: "FeedBacks");

            migrationBuilder.DropTable(
                name: "Launches");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Scheduls");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Promos");

            migrationBuilder.DropTable(
                name: "PromoForUsers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "PromoForLaunches");

            migrationBuilder.DropTable(
                name: "PromoUsers");
        }
    }
}
