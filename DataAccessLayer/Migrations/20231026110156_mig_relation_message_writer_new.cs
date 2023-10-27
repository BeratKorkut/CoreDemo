using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_relation_message_writer_new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Message2s",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageSenderID = table.Column<int>(type: "int", nullable: false),
                    MessageReceiverID = table.Column<int>(type: "int", nullable: false),
                    MessageSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message2s", x => x.MessageID);
                    table.ForeignKey(
                        name: "FK_Message2s_Writers_MessageReceiverID",
                        column: x => x.MessageReceiverID,
                        principalTable: "Writers",
                        principalColumn: "WriterID");
                    table.ForeignKey(
                        name: "FK_Message2s_Writers_MessageSenderID",
                        column: x => x.MessageSenderID,
                        principalTable: "Writers",
                        principalColumn: "WriterID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Message2s_MessageReceiverID",
                table: "Message2s",
                column: "MessageReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_Message2s_MessageSenderID",
                table: "Message2s",
                column: "MessageSenderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message2s");
        }
    }
}
