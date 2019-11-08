using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManagementSystem.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartLines_Carts_Cartc_Id",
                table: "CartLines");

            migrationBuilder.DropForeignKey(
                name: "FK_CartLines_CavinDetails_CavinDetailscv_Id",
                table: "CartLines");

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

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Launches_Launchl_Id",
                table: "Owners");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Carts_Cartc_Id",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Users_Useru_Id",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoForLaunches_Promos_Promopr_Id",
                table: "PromoForLaunches");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoForLaunches_Users_Useru_Id",
                table: "PromoForLaunches");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoForUsers_Launches_Launchl_Id",
                table: "PromoForUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoForUsers_Promos_Promopr_Id",
                table: "PromoForUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoUsers_Promos_Promopr_Id",
                table: "PromoUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoUsers_Users_Useru_Id",
                table: "PromoUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Scheduls_Launches_Launchl_Id",
                table: "Scheduls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "Launchl_Id",
                table: "Scheduls",
                newName: "LaunchL_Id");

            migrationBuilder.RenameColumn(
                name: "s_Id",
                table: "Scheduls",
                newName: "S_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Scheduls_Launchl_Id",
                table: "Scheduls",
                newName: "IX_Scheduls_LaunchL_Id");

            migrationBuilder.RenameColumn(
                name: "Useru_Id",
                table: "PromoUsers",
                newName: "UserU_Id");

            migrationBuilder.RenameColumn(
                name: "Promopr_Id",
                table: "PromoUsers",
                newName: "PromoPr_Id");

            migrationBuilder.RenameColumn(
                name: "pu_Id",
                table: "PromoUsers",
                newName: "PU_Id");

            migrationBuilder.RenameIndex(
                name: "IX_PromoUsers_Useru_Id",
                table: "PromoUsers",
                newName: "IX_PromoUsers_UserU_Id");

            migrationBuilder.RenameIndex(
                name: "IX_PromoUsers_Promopr_Id",
                table: "PromoUsers",
                newName: "IX_PromoUsers_PromoPr_Id");

            migrationBuilder.RenameColumn(
                name: "pr_Id",
                table: "Promos",
                newName: "Pr_Id");

            migrationBuilder.RenameColumn(
                name: "Promopr_Id",
                table: "PromoForUsers",
                newName: "PromoPr_Id");

            migrationBuilder.RenameColumn(
                name: "Launchl_Id",
                table: "PromoForUsers",
                newName: "LaunchL_Id");

            migrationBuilder.RenameColumn(
                name: "pfu_id",
                table: "PromoForUsers",
                newName: "PFU_Id");

            migrationBuilder.RenameIndex(
                name: "IX_PromoForUsers_Promopr_Id",
                table: "PromoForUsers",
                newName: "IX_PromoForUsers_PromoPr_Id");

            migrationBuilder.RenameIndex(
                name: "IX_PromoForUsers_Launchl_Id",
                table: "PromoForUsers",
                newName: "IX_PromoForUsers_LaunchL_Id");

            migrationBuilder.RenameColumn(
                name: "Useru_Id",
                table: "PromoForLaunches",
                newName: "UserU_Id");

            migrationBuilder.RenameColumn(
                name: "Promopr_Id",
                table: "PromoForLaunches",
                newName: "PromoPr_Id");

            migrationBuilder.RenameColumn(
                name: "pfl_id",
                table: "PromoForLaunches",
                newName: "PFL_Id");

            migrationBuilder.RenameIndex(
                name: "IX_PromoForLaunches_Useru_Id",
                table: "PromoForLaunches",
                newName: "IX_PromoForLaunches_UserU_Id");

            migrationBuilder.RenameIndex(
                name: "IX_PromoForLaunches_Promopr_Id",
                table: "PromoForLaunches",
                newName: "IX_PromoForLaunches_PromoPr_Id");

            migrationBuilder.RenameColumn(
                name: "Useru_Id",
                table: "Payments",
                newName: "UserU_Id");

            migrationBuilder.RenameColumn(
                name: "Cartc_Id",
                table: "Payments",
                newName: "CartC_Id");

            migrationBuilder.RenameColumn(
                name: "p_Id",
                table: "Payments",
                newName: "P_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_Useru_Id",
                table: "Payments",
                newName: "IX_Payments_UserU_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_Cartc_Id",
                table: "Payments",
                newName: "IX_Payments_CartC_Id");

            migrationBuilder.RenameColumn(
                name: "ownerName",
                table: "Owners",
                newName: "OwnerName");

            migrationBuilder.RenameColumn(
                name: "Launchl_Id",
                table: "Owners",
                newName: "LaunchL_Id");

            migrationBuilder.RenameColumn(
                name: "o_Id",
                table: "Owners",
                newName: "O_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Owners_Launchl_Id",
                table: "Owners",
                newName: "IX_Owners_LaunchL_Id");

            migrationBuilder.RenameColumn(
                name: "l_Id",
                table: "Launches",
                newName: "L_Id");

            migrationBuilder.RenameColumn(
                name: "Useru_Id",
                table: "FeedBacks",
                newName: "UserU_Id");

            migrationBuilder.RenameColumn(
                name: "Cartc_Id",
                table: "FeedBacks",
                newName: "CartC_Id");

            migrationBuilder.RenameColumn(
                name: "fb_Id",
                table: "FeedBacks",
                newName: "FB_Id");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBacks_Useru_Id",
                table: "FeedBacks",
                newName: "IX_FeedBacks_UserU_Id");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBacks_Cartc_Id",
                table: "FeedBacks",
                newName: "IX_FeedBacks_CartC_Id");

            migrationBuilder.RenameColumn(
                name: "Launchl_Id",
                table: "CavinDetails",
                newName: "LaunchL_Id");

            migrationBuilder.RenameColumn(
                name: "cv_Id",
                table: "CavinDetails",
                newName: "Cv_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CavinDetails_Launchl_Id",
                table: "CavinDetails",
                newName: "IX_CavinDetails_LaunchL_Id");

            migrationBuilder.RenameColumn(
                name: "totalTk",
                table: "Carts",
                newName: "TotalTk");

            migrationBuilder.RenameColumn(
                name: "Useru_Id",
                table: "Carts",
                newName: "UserU_Id");

            migrationBuilder.RenameColumn(
                name: "Promopr_Id",
                table: "Carts",
                newName: "PromoPr_Id");

            migrationBuilder.RenameColumn(
                name: "c_Id",
                table: "Carts",
                newName: "C_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_Useru_Id",
                table: "Carts",
                newName: "IX_Carts_UserU_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_Promopr_Id",
                table: "Carts",
                newName: "IX_Carts_PromoPr_Id");

            migrationBuilder.RenameColumn(
                name: "CavinDetailscv_Id",
                table: "CartLines",
                newName: "CavinDetailsCv_Id");

            migrationBuilder.RenameColumn(
                name: "Cartc_Id",
                table: "CartLines",
                newName: "CartC_Id");

            migrationBuilder.RenameColumn(
                name: "ct_Id",
                table: "CartLines",
                newName: "CL_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CartLines_CavinDetailscv_Id",
                table: "CartLines",
                newName: "IX_CartLines_CavinDetailsCv_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CartLines_Cartc_Id",
                table: "CartLines",
                newName: "IX_CartLines_CartC_Id");

            migrationBuilder.RenameColumn(
                name: "u_Id",
                table: "User",
                newName: "U_Id");

            migrationBuilder.AddColumn<int>(
                name: "CartC_Id",
                table: "Promos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PromoForLaunchPFL_Id",
                table: "Promos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PromoForUserPFU_Id",
                table: "Promos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PromoPr_Id",
                table: "Promos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PromoUserPU_Id",
                table: "Promos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartC_Id",
                table: "Launches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CavinDetailsCv_Id",
                table: "Launches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerO_Id",
                table: "Launches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PromoForUserPFU_Id",
                table: "Launches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SchedulS_Id",
                table: "Launches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartLineCL_Id",
                table: "CavinDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartLineCL_Id",
                table: "Carts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LaunchL_Id",
                table: "Carts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentP_Id",
                table: "Carts",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 16);

            migrationBuilder.AddColumn<int>(
                name: "CartC_Id",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentP_Id",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PromoForLaunchPFL_Id",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PromoUserPU_Id",
                table: "User",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "U_Id");

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
                name: "IX_CavinDetails_CartLineCL_Id",
                table: "CavinDetails",
                column: "CartLineCL_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CartLineCL_Id",
                table: "Carts",
                column: "CartLineCL_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_LaunchL_Id",
                table: "Carts",
                column: "LaunchL_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_PaymentP_Id",
                table: "Carts",
                column: "PaymentP_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_CartC_Id",
                table: "User",
                column: "CartC_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_PaymentP_Id",
                table: "User",
                column: "PaymentP_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_PromoForLaunchPFL_Id",
                table: "User",
                column: "PromoForLaunchPFL_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_PromoUserPU_Id",
                table: "User",
                column: "PromoUserPU_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartLines_Carts_CartC_Id",
                table: "CartLines",
                column: "CartC_Id",
                principalTable: "Carts",
                principalColumn: "C_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartLines_CavinDetails_CavinDetailsCv_Id",
                table: "CartLines",
                column: "CavinDetailsCv_Id",
                principalTable: "CavinDetails",
                principalColumn: "Cv_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_CartLines_CartLineCL_Id",
                table: "Carts",
                column: "CartLineCL_Id",
                principalTable: "CartLines",
                principalColumn: "CL_Id",
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
                name: "FK_CavinDetails_Launches_LaunchL_Id",
                table: "CavinDetails",
                column: "LaunchL_Id",
                principalTable: "Launches",
                principalColumn: "L_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBacks_Carts_CartC_Id",
                table: "FeedBacks",
                column: "CartC_Id",
                principalTable: "Carts",
                principalColumn: "C_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBacks_User_UserU_Id",
                table: "FeedBacks",
                column: "UserU_Id",
                principalTable: "User",
                principalColumn: "U_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Carts_CartC_Id",
                table: "Launches",
                column: "CartC_Id",
                principalTable: "Carts",
                principalColumn: "C_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_CavinDetails_CavinDetailsCv_Id",
                table: "Launches",
                column: "CavinDetailsCv_Id",
                principalTable: "CavinDetails",
                principalColumn: "Cv_Id",
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
                name: "FK_Owners_Launches_LaunchL_Id",
                table: "Owners",
                column: "LaunchL_Id",
                principalTable: "Launches",
                principalColumn: "L_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Carts_CartC_Id",
                table: "Payments",
                column: "CartC_Id",
                principalTable: "Carts",
                principalColumn: "C_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_User_UserU_Id",
                table: "Payments",
                column: "UserU_Id",
                principalTable: "User",
                principalColumn: "U_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PromoForLaunches_Promos_PromoPr_Id",
                table: "PromoForLaunches",
                column: "PromoPr_Id",
                principalTable: "Promos",
                principalColumn: "Pr_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PromoForLaunches_User_UserU_Id",
                table: "PromoForLaunches",
                column: "UserU_Id",
                principalTable: "User",
                principalColumn: "U_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PromoForUsers_Launches_LaunchL_Id",
                table: "PromoForUsers",
                column: "LaunchL_Id",
                principalTable: "Launches",
                principalColumn: "L_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PromoForUsers_Promos_PromoPr_Id",
                table: "PromoForUsers",
                column: "PromoPr_Id",
                principalTable: "Promos",
                principalColumn: "Pr_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Promos_Carts_CartC_Id",
                table: "Promos",
                column: "CartC_Id",
                principalTable: "Carts",
                principalColumn: "C_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Promos_PromoForLaunches_PromoForLaunchPFL_Id",
                table: "Promos",
                column: "PromoForLaunchPFL_Id",
                principalTable: "PromoForLaunches",
                principalColumn: "PFL_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Promos_PromoForUsers_PromoForUserPFU_Id",
                table: "Promos",
                column: "PromoForUserPFU_Id",
                principalTable: "PromoForUsers",
                principalColumn: "PFU_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Promos_Promos_PromoPr_Id",
                table: "Promos",
                column: "PromoPr_Id",
                principalTable: "Promos",
                principalColumn: "Pr_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Promos_PromoUsers_PromoUserPU_Id",
                table: "Promos",
                column: "PromoUserPU_Id",
                principalTable: "PromoUsers",
                principalColumn: "PU_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PromoUsers_Promos_PromoPr_Id",
                table: "PromoUsers",
                column: "PromoPr_Id",
                principalTable: "Promos",
                principalColumn: "Pr_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PromoUsers_User_UserU_Id",
                table: "PromoUsers",
                column: "UserU_Id",
                principalTable: "User",
                principalColumn: "U_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Scheduls_Launches_LaunchL_Id",
                table: "Scheduls",
                column: "LaunchL_Id",
                principalTable: "Launches",
                principalColumn: "L_Id",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartLines_Carts_CartC_Id",
                table: "CartLines");

            migrationBuilder.DropForeignKey(
                name: "FK_CartLines_CavinDetails_CavinDetailsCv_Id",
                table: "CartLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_CartLines_CartLineCL_Id",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Launches_LaunchL_Id",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Payments_PaymentP_Id",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Promos_PromoPr_Id",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_User_UserU_Id",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_CavinDetails_CartLines_CartLineCL_Id",
                table: "CavinDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CavinDetails_Launches_LaunchL_Id",
                table: "CavinDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedBacks_Carts_CartC_Id",
                table: "FeedBacks");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedBacks_User_UserU_Id",
                table: "FeedBacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Carts_CartC_Id",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_CavinDetails_CavinDetailsCv_Id",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Owners_OwnerO_Id",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_PromoForUsers_PromoForUserPFU_Id",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Scheduls_SchedulS_Id",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Launches_LaunchL_Id",
                table: "Owners");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Carts_CartC_Id",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_User_UserU_Id",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoForLaunches_Promos_PromoPr_Id",
                table: "PromoForLaunches");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoForLaunches_User_UserU_Id",
                table: "PromoForLaunches");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoForUsers_Launches_LaunchL_Id",
                table: "PromoForUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoForUsers_Promos_PromoPr_Id",
                table: "PromoForUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Promos_Carts_CartC_Id",
                table: "Promos");

            migrationBuilder.DropForeignKey(
                name: "FK_Promos_PromoForLaunches_PromoForLaunchPFL_Id",
                table: "Promos");

            migrationBuilder.DropForeignKey(
                name: "FK_Promos_PromoForUsers_PromoForUserPFU_Id",
                table: "Promos");

            migrationBuilder.DropForeignKey(
                name: "FK_Promos_Promos_PromoPr_Id",
                table: "Promos");

            migrationBuilder.DropForeignKey(
                name: "FK_Promos_PromoUsers_PromoUserPU_Id",
                table: "Promos");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoUsers_Promos_PromoPr_Id",
                table: "PromoUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_PromoUsers_User_UserU_Id",
                table: "PromoUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Scheduls_Launches_LaunchL_Id",
                table: "Scheduls");

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

            migrationBuilder.DropIndex(
                name: "IX_Promos_CartC_Id",
                table: "Promos");

            migrationBuilder.DropIndex(
                name: "IX_Promos_PromoForLaunchPFL_Id",
                table: "Promos");

            migrationBuilder.DropIndex(
                name: "IX_Promos_PromoForUserPFU_Id",
                table: "Promos");

            migrationBuilder.DropIndex(
                name: "IX_Promos_PromoPr_Id",
                table: "Promos");

            migrationBuilder.DropIndex(
                name: "IX_Promos_PromoUserPU_Id",
                table: "Promos");

            migrationBuilder.DropIndex(
                name: "IX_Launches_CartC_Id",
                table: "Launches");

            migrationBuilder.DropIndex(
                name: "IX_Launches_CavinDetailsCv_Id",
                table: "Launches");

            migrationBuilder.DropIndex(
                name: "IX_Launches_OwnerO_Id",
                table: "Launches");

            migrationBuilder.DropIndex(
                name: "IX_Launches_PromoForUserPFU_Id",
                table: "Launches");

            migrationBuilder.DropIndex(
                name: "IX_Launches_SchedulS_Id",
                table: "Launches");

            migrationBuilder.DropIndex(
                name: "IX_CavinDetails_CartLineCL_Id",
                table: "CavinDetails");

            migrationBuilder.DropIndex(
                name: "IX_Carts_CartLineCL_Id",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_LaunchL_Id",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_PaymentP_Id",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_CartC_Id",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_PaymentP_Id",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_PromoForLaunchPFL_Id",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_PromoUserPU_Id",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CartC_Id",
                table: "Promos");

            migrationBuilder.DropColumn(
                name: "PromoForLaunchPFL_Id",
                table: "Promos");

            migrationBuilder.DropColumn(
                name: "PromoForUserPFU_Id",
                table: "Promos");

            migrationBuilder.DropColumn(
                name: "PromoPr_Id",
                table: "Promos");

            migrationBuilder.DropColumn(
                name: "PromoUserPU_Id",
                table: "Promos");

            migrationBuilder.DropColumn(
                name: "CartC_Id",
                table: "Launches");

            migrationBuilder.DropColumn(
                name: "CavinDetailsCv_Id",
                table: "Launches");

            migrationBuilder.DropColumn(
                name: "OwnerO_Id",
                table: "Launches");

            migrationBuilder.DropColumn(
                name: "PromoForUserPFU_Id",
                table: "Launches");

            migrationBuilder.DropColumn(
                name: "SchedulS_Id",
                table: "Launches");

            migrationBuilder.DropColumn(
                name: "CartLineCL_Id",
                table: "CavinDetails");

            migrationBuilder.DropColumn(
                name: "CartLineCL_Id",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "LaunchL_Id",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "PaymentP_Id",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CartC_Id",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PaymentP_Id",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PromoForLaunchPFL_Id",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PromoUserPU_Id",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "LaunchL_Id",
                table: "Scheduls",
                newName: "Launchl_Id");

            migrationBuilder.RenameColumn(
                name: "S_Id",
                table: "Scheduls",
                newName: "s_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Scheduls_LaunchL_Id",
                table: "Scheduls",
                newName: "IX_Scheduls_Launchl_Id");

            migrationBuilder.RenameColumn(
                name: "UserU_Id",
                table: "PromoUsers",
                newName: "Useru_Id");

            migrationBuilder.RenameColumn(
                name: "PromoPr_Id",
                table: "PromoUsers",
                newName: "Promopr_Id");

            migrationBuilder.RenameColumn(
                name: "PU_Id",
                table: "PromoUsers",
                newName: "pu_Id");

            migrationBuilder.RenameIndex(
                name: "IX_PromoUsers_UserU_Id",
                table: "PromoUsers",
                newName: "IX_PromoUsers_Useru_Id");

            migrationBuilder.RenameIndex(
                name: "IX_PromoUsers_PromoPr_Id",
                table: "PromoUsers",
                newName: "IX_PromoUsers_Promopr_Id");

            migrationBuilder.RenameColumn(
                name: "Pr_Id",
                table: "Promos",
                newName: "pr_Id");

            migrationBuilder.RenameColumn(
                name: "PromoPr_Id",
                table: "PromoForUsers",
                newName: "Promopr_Id");

            migrationBuilder.RenameColumn(
                name: "LaunchL_Id",
                table: "PromoForUsers",
                newName: "Launchl_Id");

            migrationBuilder.RenameColumn(
                name: "PFU_Id",
                table: "PromoForUsers",
                newName: "pfu_id");

            migrationBuilder.RenameIndex(
                name: "IX_PromoForUsers_PromoPr_Id",
                table: "PromoForUsers",
                newName: "IX_PromoForUsers_Promopr_Id");

            migrationBuilder.RenameIndex(
                name: "IX_PromoForUsers_LaunchL_Id",
                table: "PromoForUsers",
                newName: "IX_PromoForUsers_Launchl_Id");

            migrationBuilder.RenameColumn(
                name: "UserU_Id",
                table: "PromoForLaunches",
                newName: "Useru_Id");

            migrationBuilder.RenameColumn(
                name: "PromoPr_Id",
                table: "PromoForLaunches",
                newName: "Promopr_Id");

            migrationBuilder.RenameColumn(
                name: "PFL_Id",
                table: "PromoForLaunches",
                newName: "pfl_id");

            migrationBuilder.RenameIndex(
                name: "IX_PromoForLaunches_UserU_Id",
                table: "PromoForLaunches",
                newName: "IX_PromoForLaunches_Useru_Id");

            migrationBuilder.RenameIndex(
                name: "IX_PromoForLaunches_PromoPr_Id",
                table: "PromoForLaunches",
                newName: "IX_PromoForLaunches_Promopr_Id");

            migrationBuilder.RenameColumn(
                name: "UserU_Id",
                table: "Payments",
                newName: "Useru_Id");

            migrationBuilder.RenameColumn(
                name: "CartC_Id",
                table: "Payments",
                newName: "Cartc_Id");

            migrationBuilder.RenameColumn(
                name: "P_Id",
                table: "Payments",
                newName: "p_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_UserU_Id",
                table: "Payments",
                newName: "IX_Payments_Useru_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_CartC_Id",
                table: "Payments",
                newName: "IX_Payments_Cartc_Id");

            migrationBuilder.RenameColumn(
                name: "OwnerName",
                table: "Owners",
                newName: "ownerName");

            migrationBuilder.RenameColumn(
                name: "LaunchL_Id",
                table: "Owners",
                newName: "Launchl_Id");

            migrationBuilder.RenameColumn(
                name: "O_Id",
                table: "Owners",
                newName: "o_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Owners_LaunchL_Id",
                table: "Owners",
                newName: "IX_Owners_Launchl_Id");

            migrationBuilder.RenameColumn(
                name: "L_Id",
                table: "Launches",
                newName: "l_Id");

            migrationBuilder.RenameColumn(
                name: "UserU_Id",
                table: "FeedBacks",
                newName: "Useru_Id");

            migrationBuilder.RenameColumn(
                name: "CartC_Id",
                table: "FeedBacks",
                newName: "Cartc_Id");

            migrationBuilder.RenameColumn(
                name: "FB_Id",
                table: "FeedBacks",
                newName: "fb_Id");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBacks_UserU_Id",
                table: "FeedBacks",
                newName: "IX_FeedBacks_Useru_Id");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBacks_CartC_Id",
                table: "FeedBacks",
                newName: "IX_FeedBacks_Cartc_Id");

            migrationBuilder.RenameColumn(
                name: "LaunchL_Id",
                table: "CavinDetails",
                newName: "Launchl_Id");

            migrationBuilder.RenameColumn(
                name: "Cv_Id",
                table: "CavinDetails",
                newName: "cv_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CavinDetails_LaunchL_Id",
                table: "CavinDetails",
                newName: "IX_CavinDetails_Launchl_Id");

            migrationBuilder.RenameColumn(
                name: "UserU_Id",
                table: "Carts",
                newName: "Useru_Id");

            migrationBuilder.RenameColumn(
                name: "TotalTk",
                table: "Carts",
                newName: "totalTk");

            migrationBuilder.RenameColumn(
                name: "PromoPr_Id",
                table: "Carts",
                newName: "Promopr_Id");

            migrationBuilder.RenameColumn(
                name: "C_Id",
                table: "Carts",
                newName: "c_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_UserU_Id",
                table: "Carts",
                newName: "IX_Carts_Useru_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_PromoPr_Id",
                table: "Carts",
                newName: "IX_Carts_Promopr_Id");

            migrationBuilder.RenameColumn(
                name: "CavinDetailsCv_Id",
                table: "CartLines",
                newName: "CavinDetailscv_Id");

            migrationBuilder.RenameColumn(
                name: "CartC_Id",
                table: "CartLines",
                newName: "Cartc_Id");

            migrationBuilder.RenameColumn(
                name: "CL_Id",
                table: "CartLines",
                newName: "ct_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CartLines_CavinDetailsCv_Id",
                table: "CartLines",
                newName: "IX_CartLines_CavinDetailscv_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CartLines_CartC_Id",
                table: "CartLines",
                newName: "IX_CartLines_Cartc_Id");

            migrationBuilder.RenameColumn(
                name: "U_Id",
                table: "Users",
                newName: "u_Id");

            migrationBuilder.AlterColumn<int>(
                name: "Password",
                table: "Users",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 16);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "u_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartLines_Carts_Cartc_Id",
                table: "CartLines",
                column: "Cartc_Id",
                principalTable: "Carts",
                principalColumn: "c_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartLines_CavinDetails_CavinDetailscv_Id",
                table: "CartLines",
                column: "CavinDetailscv_Id",
                principalTable: "CavinDetails",
                principalColumn: "cv_Id",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Launches_Launchl_Id",
                table: "Owners",
                column: "Launchl_Id",
                principalTable: "Launches",
                principalColumn: "l_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Carts_Cartc_Id",
                table: "Payments",
                column: "Cartc_Id",
                principalTable: "Carts",
                principalColumn: "c_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Users_Useru_Id",
                table: "Payments",
                column: "Useru_Id",
                principalTable: "Users",
                principalColumn: "u_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PromoForLaunches_Promos_Promopr_Id",
                table: "PromoForLaunches",
                column: "Promopr_Id",
                principalTable: "Promos",
                principalColumn: "pr_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PromoForLaunches_Users_Useru_Id",
                table: "PromoForLaunches",
                column: "Useru_Id",
                principalTable: "Users",
                principalColumn: "u_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PromoForUsers_Launches_Launchl_Id",
                table: "PromoForUsers",
                column: "Launchl_Id",
                principalTable: "Launches",
                principalColumn: "l_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PromoForUsers_Promos_Promopr_Id",
                table: "PromoForUsers",
                column: "Promopr_Id",
                principalTable: "Promos",
                principalColumn: "pr_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PromoUsers_Promos_Promopr_Id",
                table: "PromoUsers",
                column: "Promopr_Id",
                principalTable: "Promos",
                principalColumn: "pr_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PromoUsers_Users_Useru_Id",
                table: "PromoUsers",
                column: "Useru_Id",
                principalTable: "Users",
                principalColumn: "u_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Scheduls_Launches_Launchl_Id",
                table: "Scheduls",
                column: "Launchl_Id",
                principalTable: "Launches",
                principalColumn: "l_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
