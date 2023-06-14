using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealHouzing.DataAccessLAyer.Migrations
{
    public partial class mig_newTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutHeaders",
                columns: table => new
                {
                    AboutHeaderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutHeaderTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutHeaderTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutHeaders", x => x.AboutHeaderID);
                });

            migrationBuilder.CreateTable(
                name: "AboutQuestionHeaders",
                columns: table => new
                {
                    AboutQuestionHeaderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutQuestionHeaderTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutQuestionHeaderDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutQuestionHeaders", x => x.AboutQuestionHeaderID);
                });

            migrationBuilder.CreateTable(
                name: "AboutQuestions",
                columns: table => new
                {
                    AboutQuestionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutQuestionTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutQuestionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutQuestions", x => x.AboutQuestionID);
                });

            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "AboutService1s",
                columns: table => new
                {
                    AboutService1ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutService1Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutService1Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutService1s", x => x.AboutService1ID);
                });

            migrationBuilder.CreateTable(
                name: "AboutServiceStatistics",
                columns: table => new
                {
                    AboutServiceStatisticID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutServiceStatisticTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutServiceStatisticValue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutServiceStatistics", x => x.AboutServiceStatisticID);
                });

            migrationBuilder.CreateTable(
                name: "AboutStatistics",
                columns: table => new
                {
                    AboutStatisticID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutStatisticTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutStatisticValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutStatistics", x => x.AboutStatisticID);
                });

            migrationBuilder.CreateTable(
                name: "ContactChannels",
                columns: table => new
                {
                    ContactChannelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactChannelTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactChannelDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactChannels", x => x.ContactChannelID);
                });

            migrationBuilder.CreateTable(
                name: "ContactMaps",
                columns: table => new
                {
                    ContactMapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactMapLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMaps", x => x.ContactMapID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactMessage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    FeatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeatureDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeatureIcon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.FeatureID);
                });

            migrationBuilder.CreateTable(
                name: "Headers",
                columns: table => new
                {
                    HeaderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeaderTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headers", x => x.HeaderID);
                });

            migrationBuilder.CreateTable(
                name: "Property2s",
                columns: table => new
                {
                    Property2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Property2Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property2s", x => x.Property2ID);
                });

            migrationBuilder.CreateTable(
                name: "Property3s",
                columns: table => new
                {
                    Property3ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Property3Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Property3Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property3s", x => x.Property3ID);
                });

            migrationBuilder.CreateTable(
                name: "Property4s",
                columns: table => new
                {
                    Property4ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Property4Title1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Property4Title2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Property4Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property4s", x => x.Property4ID);
                });

            migrationBuilder.CreateTable(
                name: "Service1s",
                columns: table => new
                {
                    Service1ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Service1Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service1Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service1ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service1s", x => x.Service1ID);
                });

            migrationBuilder.CreateTable(
                name: "Service2s",
                columns: table => new
                {
                    Service2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Service2Title1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service2Title2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service2s", x => x.Service2ID);
                });

            migrationBuilder.CreateTable(
                name: "ServicePlans",
                columns: table => new
                {
                    ServicePlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicePlanTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServicePlanPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServicePlanIcon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServicePlanListing = table.Column<int>(type: "int", nullable: false),
                    ServicePlanFeatureListing = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePlans", x => x.ServicePlanID);
                });

            migrationBuilder.CreateTable(
                name: "ServiceProperties",
                columns: table => new
                {
                    ServicePropertyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicePropertyTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceProperties", x => x.ServicePropertyID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutHeaders");

            migrationBuilder.DropTable(
                name: "AboutQuestionHeaders");

            migrationBuilder.DropTable(
                name: "AboutQuestions");

            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "AboutService1s");

            migrationBuilder.DropTable(
                name: "AboutServiceStatistics");

            migrationBuilder.DropTable(
                name: "AboutStatistics");

            migrationBuilder.DropTable(
                name: "ContactChannels");

            migrationBuilder.DropTable(
                name: "ContactMaps");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Headers");

            migrationBuilder.DropTable(
                name: "Property2s");

            migrationBuilder.DropTable(
                name: "Property3s");

            migrationBuilder.DropTable(
                name: "Property4s");

            migrationBuilder.DropTable(
                name: "Service1s");

            migrationBuilder.DropTable(
                name: "Service2s");

            migrationBuilder.DropTable(
                name: "ServicePlans");

            migrationBuilder.DropTable(
                name: "ServiceProperties");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
