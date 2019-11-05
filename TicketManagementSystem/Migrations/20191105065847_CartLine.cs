using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManagementSystem.Migrations
{
    public partial class CartLine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Promo_Promopr_Id",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_Cart_User_Useru_Id",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_CavinDetails_Launch_Launchl_Id",
                table: "CavinDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedBack_Cart_Cartc_Id",
                table: "FeedBack");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedBack_User_Useru_Id",
                table: "FeedBack");

            migrationBuilder.DropTable(
                name: "CharterTime");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Promo",
                table: "Promo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Launch",
                table: "Launch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FeedBack",
                table: "FeedBack");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Promo",
                newName: "Promos");

            migrationBuilder.RenameTable(
                name: "Launch",
                newName: "Launches");

            migrationBuilder.RenameTable(
                name: "FeedBack",
                newName: "FeedBacks");

            migrationBuilder.RenameTable(
                name: "Cart",
                newName: "Carts");

            migrationBuilder.RenameColumn(
                name: "cavinNumber",
                table: "CavinDetails",
                newName: "CavinNumber");

            migrationBuilder.RenameColumn(
                name: "cavinCatagory",
                table: "CavinDetails",
                newName: "CavinCatagory");

            migrationBuilder.RenameColumn(
                name: "startDate",
                table: "Promos",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "promoCode",
                table: "Promos",
                newName: "PromoCode");

            migrationBuilder.RenameColumn(
                name: "maxAmount",
                table: "Promos",
                newName: "MaxAmount");

            migrationBuilder.RenameColumn(
                name: "endDate",
                table: "Promos",
                newName: "EndDate");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBack_Useru_Id",
                table: "FeedBacks",
                newName: "IX_FeedBacks_Useru_Id");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBack_Cartc_Id",
                table: "FeedBacks",
                newName: "IX_FeedBacks_Cartc_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_Useru_Id",
                table: "Carts",
                newName: "IX_Carts_Useru_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_Promopr_Id",
                table: "Carts",
                newName: "IX_Carts_Promopr_Id");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 16);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "u_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Promos",
                table: "Promos",
                column: "pr_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Launches",
                table: "Launches",
                column: "l_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FeedBacks",
                table: "FeedBacks",
                column: "fb_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "c_Id");

            migrationBuilder.CreateTable(
                name: "CartLines",
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
                    table.PrimaryKey("PK_CartLines", x => x.ct_Id);
                    table.ForeignKey(
                        name: "FK_CartLines_Carts_Cartc_Id",
                        column: x => x.Cartc_Id,
                        principalTable: "Carts",
                        principalColumn: "c_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartLines_CavinDetails_CavinDetailscv_Id",
                        column: x => x.CavinDetailscv_Id,
                        principalTable: "CavinDetails",
                        principalColumn: "cv_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    o_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ownerName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Launchl_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.o_Id);
                    table.ForeignKey(
                        name: "FK_Owners_Launches_Launchl_Id",
                        column: x => x.Launchl_Id,
                        principalTable: "Launches",
                        principalColumn: "l_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    p_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PaymentStatus = table.Column<string>(nullable: false),
                    PaymentOption = table.Column<string>(nullable: false),
                    Useru_Id = table.Column<int>(nullable: true),
                    Cartc_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.p_Id);
                    table.ForeignKey(
                        name: "FK_Payments_Carts_Cartc_Id",
                        column: x => x.Cartc_Id,
                        principalTable: "Carts",
                        principalColumn: "c_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Users_Useru_Id",
                        column: x => x.Useru_Id,
                        principalTable: "Users",
                        principalColumn: "u_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PromoForLaunches",
                columns: table => new
                {
                    pfl_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Useru_Id = table.Column<int>(nullable: true),
                    Promopr_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoForLaunches", x => x.pfl_id);
                    table.ForeignKey(
                        name: "FK_PromoForLaunches_Promos_Promopr_Id",
                        column: x => x.Promopr_Id,
                        principalTable: "Promos",
                        principalColumn: "pr_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PromoForLaunches_Users_Useru_Id",
                        column: x => x.Useru_Id,
                        principalTable: "Users",
                        principalColumn: "u_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PromoForUsers",
                columns: table => new
                {
                    pfu_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Launchl_Id = table.Column<int>(nullable: true),
                    Promopr_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoForUsers", x => x.pfu_id);
                    table.ForeignKey(
                        name: "FK_PromoForUsers_Launches_Launchl_Id",
                        column: x => x.Launchl_Id,
                        principalTable: "Launches",
                        principalColumn: "l_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PromoForUsers_Promos_Promopr_Id",
                        column: x => x.Promopr_Id,
                        principalTable: "Promos",
                        principalColumn: "pr_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PromoUsers",
                columns: table => new
                {
                    pu_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<string>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    Useru_Id = table.Column<int>(nullable: true),
                    Promopr_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoUsers", x => x.pu_Id);
                    table.ForeignKey(
                        name: "FK_PromoUsers_Promos_Promopr_Id",
                        column: x => x.Promopr_Id,
                        principalTable: "Promos",
                        principalColumn: "pr_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PromoUsers_Users_Useru_Id",
                        column: x => x.Useru_Id,
                        principalTable: "Users",
                        principalColumn: "u_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Scheduls",
                columns: table => new
                {
                    s_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<string>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    From = table.Column<string>(nullable: false),
                    To = table.Column<string>(nullable: false),
                    Launchl_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scheduls", x => x.s_Id);
                    table.ForeignKey(
                        name: "FK_Scheduls_Launches_Launchl_Id",
                        column: x => x.Launchl_Id,
                        principalTable: "Launches",
                        principalColumn: "l_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartLines_Cartc_Id",
                table: "CartLines",
                column: "Cartc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CartLines_CavinDetailscv_Id",
                table: "CartLines",
                column: "CavinDetailscv_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_Launchl_Id",
                table: "Owners",
                column: "Launchl_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Cartc_Id",
                table: "Payments",
                column: "Cartc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Useru_Id",
                table: "Payments",
                column: "Useru_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PromoForLaunches_Promopr_Id",
                table: "PromoForLaunches",
                column: "Promopr_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PromoForLaunches_Useru_Id",
                table: "PromoForLaunches",
                column: "Useru_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PromoForUsers_Launchl_Id",
                table: "PromoForUsers",
                column: "Launchl_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PromoForUsers_Promopr_Id",
                table: "PromoForUsers",
                column: "Promopr_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PromoUsers_Promopr_Id",
                table: "PromoUsers",
                column: "Promopr_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PromoUsers_Useru_Id",
                table: "PromoUsers",
                column: "Useru_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Scheduls_Launchl_Id",
                table: "Scheduls",
                column: "Launchl_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Promos_Promopr_Id",
                table: "Carts",
                column: "Promopr_Id",
                principalTable: "Promos",
                principalColumn: "pr_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_Useru_Id",
                table: "Carts",
                column: "Useru_Id",
                principalTable: "Users",
                principalColumn: "u_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CavinDetails_Launches_Launchl_Id",
                table: "CavinDetails",
                column: "Launchl_Id",
                principalTable: "Launches",
                principalColumn: "l_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBacks_Carts_Cartc_Id",
                table: "FeedBacks",
                column: "Cartc_Id",
                principalTable: "Carts",
                principalColumn: "c_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBacks_Users_Useru_Id",
                table: "FeedBacks",
                column: "Useru_Id",
                principalTable: "Users",
                principalColumn: "u_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Promos_Promopr_Id",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_Useru_Id",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_CavinDetails_Launches_Launchl_Id",
                table: "CavinDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedBacks_Carts_Cartc_Id",
                table: "FeedBacks");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedBacks_Users_Useru_Id",
                table: "FeedBacks");

            migrationBuilder.DropTable(
                name: "CartLines");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PromoForLaunches");

            migrationBuilder.DropTable(
                name: "PromoForUsers");

            migrationBuilder.DropTable(
                name: "PromoUsers");

            migrationBuilder.DropTable(
                name: "Scheduls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Promos",
                table: "Promos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Launches",
                table: "Launches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FeedBacks",
                table: "FeedBacks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Promos",
                newName: "Promo");

            migrationBuilder.RenameTable(
                name: "Launches",
                newName: "Launch");

            migrationBuilder.RenameTable(
                name: "FeedBacks",
                newName: "FeedBack");

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "Cart");

            migrationBuilder.RenameColumn(
                name: "CavinNumber",
                table: "CavinDetails",
                newName: "cavinNumber");

            migrationBuilder.RenameColumn(
                name: "CavinCatagory",
                table: "CavinDetails",
                newName: "cavinCatagory");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Promo",
                newName: "startDate");

            migrationBuilder.RenameColumn(
                name: "PromoCode",
                table: "Promo",
                newName: "promoCode");

            migrationBuilder.RenameColumn(
                name: "MaxAmount",
                table: "Promo",
                newName: "maxAmount");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Promo",
                newName: "endDate");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBacks_Useru_Id",
                table: "FeedBack",
                newName: "IX_FeedBack_Useru_Id");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBacks_Cartc_Id",
                table: "FeedBack",
                newName: "IX_FeedBack_Cartc_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_Useru_Id",
                table: "Cart",
                newName: "IX_Cart_Useru_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_Promopr_Id",
                table: "Cart",
                newName: "IX_Cart_Promopr_Id");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "u_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Promo",
                table: "Promo",
                column: "pr_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Launch",
                table: "Launch",
                column: "l_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FeedBack",
                table: "FeedBack",
                column: "fb_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                table: "Cart",
                column: "c_Id");

            migrationBuilder.CreateTable(
                name: "CharterTime",
                columns: table => new
                {
                    ct_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cartc_Id = table.Column<int>(nullable: true),
                    Catarory = table.Column<string>(nullable: false),
                    CavinDetailscv_Id = table.Column<int>(nullable: true),
                    Price = table.Column<string>(nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_CharterTime_Cartc_Id",
                table: "CharterTime",
                column: "Cartc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CharterTime_CavinDetailscv_Id",
                table: "CharterTime",
                column: "CavinDetailscv_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Promo_Promopr_Id",
                table: "Cart",
                column: "Promopr_Id",
                principalTable: "Promo",
                principalColumn: "pr_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_User_Useru_Id",
                table: "Cart",
                column: "Useru_Id",
                principalTable: "User",
                principalColumn: "u_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CavinDetails_Launch_Launchl_Id",
                table: "CavinDetails",
                column: "Launchl_Id",
                principalTable: "Launch",
                principalColumn: "l_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBack_Cart_Cartc_Id",
                table: "FeedBack",
                column: "Cartc_Id",
                principalTable: "Cart",
                principalColumn: "c_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBack_User_Useru_Id",
                table: "FeedBack",
                column: "Useru_Id",
                principalTable: "User",
                principalColumn: "u_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
