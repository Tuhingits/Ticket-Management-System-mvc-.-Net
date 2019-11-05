using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManagementSystem.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Launch",
                columns: table => new
                {
                    l_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Rout = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Launch", x => x.l_Id);
                });

            migrationBuilder.CreateTable(
                name: "Promo",
                columns: table => new
                {
                    pr_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    promoCode = table.Column<string>(nullable: false),
                    startDate = table.Column<DateTime>(nullable: false),
                    endDate = table.Column<DateTime>(nullable: false),
                    Discount = table.Column<string>(nullable: false),
                    maxAmount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promo", x => x.pr_Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    u_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 16, nullable: false),
                    Password = table.Column<int>(maxLength: 16, nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.u_Id);
                });

            migrationBuilder.CreateTable(
                name: "CavinDetails",
                columns: table => new
                {
                    cv_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cavinCatagory = table.Column<string>(nullable: false),
                    Rent = table.Column<double>(nullable: false),
                    Position = table.Column<string>(nullable: false),
                    cavinNumber = table.Column<string>(nullable: false),
                    Launchl_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CavinDetails", x => x.cv_Id);
                    table.ForeignKey(
                        name: "FK_CavinDetails_Launch_Launchl_Id",
                        column: x => x.Launchl_Id,
                        principalTable: "Launch",
                        principalColumn: "l_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    c_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<string>(nullable: false),
                    totalTk = table.Column<string>(nullable: false),
                    Useru_Id = table.Column<int>(nullable: true),
                    Promopr_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.c_Id);
                    table.ForeignKey(
                        name: "FK_Cart_Promo_Promopr_Id",
                        column: x => x.Promopr_Id,
                        principalTable: "Promo",
                        principalColumn: "pr_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cart_User_Useru_Id",
                        column: x => x.Useru_Id,
                        principalTable: "User",
                        principalColumn: "u_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharterTime",
                columns: table => new
                {
                    ct_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<string>(nullable: false),
                    Catarory = table.Column<string>(nullable: false),
                    Cartc_Id = table.Column<int>(nullable: true),
                    CavinDetailscv_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharterTime", x => x.ct_Id);
                    table.ForeignKey(
                        name: "FK_CharterTime_Cart_Cartc_Id",
                        column: x => x.Cartc_Id,
                        principalTable: "Cart",
                        principalColumn: "c_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharterTime_CavinDetails_CavinDetailscv_Id",
                        column: x => x.CavinDetailscv_Id,
                        principalTable: "CavinDetails",
                        principalColumn: "cv_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FeedBack",
                columns: table => new
                {
                    fb_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Details = table.Column<string>(nullable: false),
                    Filter = table.Column<string>(nullable: false),
                    Cartc_Id = table.Column<int>(nullable: true),
                    Useru_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBack", x => x.fb_Id);
                    table.ForeignKey(
                        name: "FK_FeedBack_Cart_Cartc_Id",
                        column: x => x.Cartc_Id,
                        principalTable: "Cart",
                        principalColumn: "c_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FeedBack_User_Useru_Id",
                        column: x => x.Useru_Id,
                        principalTable: "User",
                        principalColumn: "u_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_Promopr_Id",
                table: "Cart",
                column: "Promopr_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_Useru_Id",
                table: "Cart",
                column: "Useru_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CavinDetails_Launchl_Id",
                table: "CavinDetails",
                column: "Launchl_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CharterTime_Cartc_Id",
                table: "CharterTime",
                column: "Cartc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CharterTime_CavinDetailscv_Id",
                table: "CharterTime",
                column: "CavinDetailscv_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBack_Cartc_Id",
                table: "FeedBack",
                column: "Cartc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBack_Useru_Id",
                table: "FeedBack",
                column: "Useru_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharterTime");

            migrationBuilder.DropTable(
                name: "FeedBack");

            migrationBuilder.DropTable(
                name: "CavinDetails");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Launch");

            migrationBuilder.DropTable(
                name: "Promo");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
