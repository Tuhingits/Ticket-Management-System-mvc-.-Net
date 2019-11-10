using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManagementSystem.Migrations
{
    public partial class Launch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_CartLines_CartLineCL_Id",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_User_UserU_Id",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_CavinDetails_CartLines_CartLineCL_Id",
                table: "CavinDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedBacks_User_UserU_Id",
                table: "FeedBacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_User_UserU_Id",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoForLaunches_User_UserU_Id",
                table: "PromoForLaunches");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoUsers_User_UserU_Id",
                table: "PromoUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Carts_CartC_Id",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Payments_PaymentP_Id",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_PromoForLaunches_PromoForLaunchPFL_Id",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_PromoUsers_PromoUserPU_Id",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "FB_Id",
                table: "FeedBacks",
                newName: "Fb_Id");

            migrationBuilder.RenameColumn(
                name: "CartLineCL_Id",
                table: "CavinDetails",
                newName: "CartLineCl_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CavinDetails_CartLineCL_Id",
                table: "CavinDetails",
                newName: "IX_CavinDetails_CartLineCl_Id");

            migrationBuilder.RenameColumn(
                name: "CartLineCL_Id",
                table: "Carts",
                newName: "CartLineCl_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_CartLineCL_Id",
                table: "Carts",
                newName: "IX_Carts_CartLineCl_Id");

            migrationBuilder.RenameColumn(
                name: "CL_Id",
                table: "CartLines",
                newName: "Cl_Id");

            migrationBuilder.RenameIndex(
                name: "IX_User_PromoUserPU_Id",
                table: "Users",
                newName: "IX_Users_PromoUserPU_Id");

            migrationBuilder.RenameIndex(
                name: "IX_User_PromoForLaunchPFL_Id",
                table: "Users",
                newName: "IX_Users_PromoForLaunchPFL_Id");

            migrationBuilder.RenameIndex(
                name: "IX_User_PaymentP_Id",
                table: "Users",
                newName: "IX_Users_PaymentP_Id");

            migrationBuilder.RenameIndex(
                name: "IX_User_CartC_Id",
                table: "Users",
                newName: "IX_Users_CartC_Id");

            migrationBuilder.AddColumn<int>(
                name: "FeedBackFb_Id",
                table: "Carts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FeedBackFb_Id",
                table: "Users",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "U_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_FeedBackFb_Id",
                table: "Carts",
                column: "FeedBackFb_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_FeedBackFb_Id",
                table: "Users",
                column: "FeedBackFb_Id");

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
                name: "FK_FeedBacks_Users_UserU_Id",
                table: "FeedBacks",
                column: "UserU_Id",
                principalTable: "Users",
                principalColumn: "U_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Users_UserU_Id",
                table: "Payments",
                column: "UserU_Id",
                principalTable: "Users",
                principalColumn: "U_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PromoForLaunches_Users_UserU_Id",
                table: "PromoForLaunches",
                column: "UserU_Id",
                principalTable: "Users",
                principalColumn: "U_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PromoUsers_Users_UserU_Id",
                table: "PromoUsers",
                column: "UserU_Id",
                principalTable: "Users",
                principalColumn: "U_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Carts_CartC_Id",
                table: "Users",
                column: "CartC_Id",
                principalTable: "Carts",
                principalColumn: "C_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_FeedBacks_FeedBackFb_Id",
                table: "Users",
                column: "FeedBackFb_Id",
                principalTable: "FeedBacks",
                principalColumn: "Fb_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Payments_PaymentP_Id",
                table: "Users",
                column: "PaymentP_Id",
                principalTable: "Payments",
                principalColumn: "P_Id",
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
                name: "FK_Carts_CartLines_CartLineCl_Id",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_FeedBacks_FeedBackFb_Id",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_UserU_Id",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_CavinDetails_CartLines_CartLineCl_Id",
                table: "CavinDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedBacks_Users_UserU_Id",
                table: "FeedBacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Users_UserU_Id",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoForLaunches_Users_UserU_Id",
                table: "PromoForLaunches");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoUsers_Users_UserU_Id",
                table: "PromoUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Carts_CartC_Id",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_FeedBacks_FeedBackFb_Id",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Payments_PaymentP_Id",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_PromoForLaunches_PromoForLaunchPFL_Id",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_PromoUsers_PromoUserPU_Id",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Carts_FeedBackFb_Id",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_FeedBackFb_Id",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FeedBackFb_Id",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "FeedBackFb_Id",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "Fb_Id",
                table: "FeedBacks",
                newName: "FB_Id");

            migrationBuilder.RenameColumn(
                name: "CartLineCl_Id",
                table: "CavinDetails",
                newName: "CartLineCL_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CavinDetails_CartLineCl_Id",
                table: "CavinDetails",
                newName: "IX_CavinDetails_CartLineCL_Id");

            migrationBuilder.RenameColumn(
                name: "CartLineCl_Id",
                table: "Carts",
                newName: "CartLineCL_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_CartLineCl_Id",
                table: "Carts",
                newName: "IX_Carts_CartLineCL_Id");

            migrationBuilder.RenameColumn(
                name: "Cl_Id",
                table: "CartLines",
                newName: "CL_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PromoUserPU_Id",
                table: "User",
                newName: "IX_User_PromoUserPU_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PromoForLaunchPFL_Id",
                table: "User",
                newName: "IX_User_PromoForLaunchPFL_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PaymentP_Id",
                table: "User",
                newName: "IX_User_PaymentP_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CartC_Id",
                table: "User",
                newName: "IX_User_CartC_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "U_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_CartLines_CartLineCL_Id",
                table: "Carts",
                column: "CartLineCL_Id",
                principalTable: "CartLines",
                principalColumn: "CL_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_User_UserU_Id",
                table: "Carts",
                column: "UserU_Id",
                principalTable: "User",
                principalColumn: "U_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CavinDetails_CartLines_CartLineCL_Id",
                table: "CavinDetails",
                column: "CartLineCL_Id",
                principalTable: "CartLines",
                principalColumn: "CL_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBacks_User_UserU_Id",
                table: "FeedBacks",
                column: "UserU_Id",
                principalTable: "User",
                principalColumn: "U_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_User_UserU_Id",
                table: "Payments",
                column: "UserU_Id",
                principalTable: "User",
                principalColumn: "U_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PromoForLaunches_User_UserU_Id",
                table: "PromoForLaunches",
                column: "UserU_Id",
                principalTable: "User",
                principalColumn: "U_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PromoUsers_User_UserU_Id",
                table: "PromoUsers",
                column: "UserU_Id",
                principalTable: "User",
                principalColumn: "U_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Carts_CartC_Id",
                table: "User",
                column: "CartC_Id",
                principalTable: "Carts",
                principalColumn: "C_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Payments_PaymentP_Id",
                table: "User",
                column: "PaymentP_Id",
                principalTable: "Payments",
                principalColumn: "P_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_PromoForLaunches_PromoForLaunchPFL_Id",
                table: "User",
                column: "PromoForLaunchPFL_Id",
                principalTable: "PromoForLaunches",
                principalColumn: "PFL_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_PromoUsers_PromoUserPU_Id",
                table: "User",
                column: "PromoUserPU_Id",
                principalTable: "PromoUsers",
                principalColumn: "PU_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
