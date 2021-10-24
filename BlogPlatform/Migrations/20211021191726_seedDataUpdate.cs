using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class seedDataUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Body",
                value: "Hello World!  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus modi mollitia accusantium ipsum aliquid natus deleniti dolores rerum, consequatur perspiciatis incidunt nemo nisi est culpa qui vel expedita quaerat laborum?");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "Body",
                value: "Love me some frog legs...  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus modi mollitia accusantium ipsum aliquid natus deleniti dolores rerum, consequatur perspiciatis incidunt nemo nisi est culpa qui vel expedita quaerat laborum?");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "Body",
                value: "Call us for a free estimate on your MVC project...  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus modi mollitia accusantium ipsum aliquid natus deleniti dolores rerum, consequatur perspiciatis incidunt nemo nisi est culpa qui vel expedita quaerat laborum?");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                column: "Body",
                value: "Are you having problems getting your project to compile, call us!  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus modi mollitia accusantium ipsum aliquid natus deleniti dolores rerum, consequatur perspiciatis incidunt nemo nisi est culpa qui vel expedita quaerat laborum?");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                column: "Body",
                value: "Meet me tomorrow at the Burger King on Front Street.  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus modi mollitia accusantium ipsum aliquid natus deleniti dolores rerum, consequatur perspiciatis incidunt nemo nisi est culpa qui vel expedita quaerat laborum?");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                column: "Body",
                value: "There's a party at my house, bring a friend!  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus modi mollitia accusantium ipsum aliquid natus deleniti dolores rerum, consequatur perspiciatis incidunt nemo nisi est culpa qui vel expedita quaerat laborum?");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Body",
                value: "Hello World!");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "Body",
                value: "Love me some frog legs...");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "Body",
                value: "Call us for a free estimate on your MVC project...");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                column: "Body",
                value: "Are you having problems getting your project to compile, call us!");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                column: "Body",
                value: "Meet me tomorrow at the Burger King on Front Street.");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                column: "Body",
                value: "There's a party at my house, bring a friend!");
        }
    }
}
