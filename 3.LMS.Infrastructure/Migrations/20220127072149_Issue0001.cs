using Microsoft.EntityFrameworkCore.Migrations;

namespace _3.LMS.Infrastructure.Migrations
{
    public partial class Issue0001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubjectsWrapper",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconOfList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconOfSlider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColoredIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconBackground = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    GradeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TermId = table.Column<int>(type: "int", nullable: false),
                    TermName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherGuide = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentGuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentPoints = table.Column<double>(type: "float", nullable: false),
                    SubjectPoints = table.Column<int>(type: "int", nullable: false),
                    Numeral = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subscribed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectsWrapper", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "9ac7aafc-c4f5-4d4a-af16-e71b2c45182c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d4d908e3-f8c5-4dd9-bcb5-0cb682e89e29");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "c4a2a40a-622d-45d4-969b-e2b9901462a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "2a0e203c-baf2-4cf9-91dc-a721b0338c73");

            migrationBuilder.InsertData(
                table: "SubjectsWrapper",
                columns: new[] { "Id", "ColoredIcon", "GradeId", "GradeName", "IconBackground", "IconOfList", "IconOfSlider", "Numeral", "ParentGuid", "StudentPoints", "SubjectName", "SubjectPoints", "Subscribed", "TeacherGuide", "TermId", "TermName" },
                values: new object[,]
                {
                    { 1, null, 1, null, null, "http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png", null, null, null, 0.0, "الجداول الزمنية", 0, false, null, 1, null },
                    { 2, null, 1, null, null, "http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png", null, null, null, 0.0, "اللغة العربية", 0, false, null, 2, null },
                    { 3, null, 1, null, null, "http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png", null, null, null, 0.0, "الجداول الزمنية", 0, false, null, 1, null },
                    { 4, null, 1, null, null, "http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png", null, null, null, 0.0, "اللغة العربية", 0, false, null, 2, null },
                    { 5, null, 2, null, null, "http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png", null, null, null, 0.0, "الجداول الزمنية", 0, false, null, 1, null },
                    { 6, null, 2, null, null, "http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png", null, null, null, 0.0, "اللغة العربية", 0, false, null, 1, null },
                    { 7, null, 2, null, null, "http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png", null, null, null, 0.0, "الجداول الزمنية", 0, false, null, 2, null },
                    { 8, null, 2, null, null, "http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png", null, null, null, 0.0, "اللغة العربية", 0, false, null, 2, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectsWrapper");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "914f1d2b-2d12-49f9-834d-ef59f75560f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "31c58daf-1c4e-406f-a055-c612066b77bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "4342691b-419d-44ec-9f27-344ea18177e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "57ccbe27-a1b0-4866-ad35-3c2673a69b06");
        }
    }
}
