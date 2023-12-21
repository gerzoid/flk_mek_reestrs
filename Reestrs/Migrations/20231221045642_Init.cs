using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reestrs.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KSG_KPGs",
                columns: table => new
                {
                    KSG_KPGId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BZTSZ = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    CRIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IT_SL = table.Column<decimal>(type: "decimal(6,5)", precision: 6, scale: 5, nullable: false),
                    KOEF_D = table.Column<decimal>(type: "decimal(7,5)", precision: 7, scale: 5, nullable: false),
                    KOEF_U = table.Column<decimal>(type: "decimal(7,5)", precision: 7, scale: 5, nullable: false),
                    KOEF_UP = table.Column<decimal>(type: "decimal(7,5)", precision: 7, scale: 5, nullable: false),
                    KOEF_Z = table.Column<decimal>(type: "decimal(8,5)", precision: 8, scale: 5, nullable: false),
                    KSG_PG = table.Column<int>(type: "int", nullable: false),
                    N_KPG = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    N_KSG = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SL_K = table.Column<int>(type: "int", nullable: false),
                    VER_KSG = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KSG_KPGs", x => x.KSG_KPGId);
                });

            migrationBuilder.CreateTable(
                name: "LEK_DOSEs",
                columns: table => new
                {
                    LEK_DOSEId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COL_INJ = table.Column<int>(type: "int", nullable: false),
                    DOSE_INJ = table.Column<decimal>(type: "decimal(14,7)", precision: 14, scale: 7, nullable: false),
                    ED_IZM = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    METHOD_INJ = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LEK_DOSEs", x => x.LEK_DOSEId);
                });

            migrationBuilder.CreateTable(
                name: "ONK_SLs",
                columns: table => new
                {
                    ONK_SLId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BSA = table.Column<decimal>(type: "decimal(3,2)", precision: 3, scale: 2, nullable: false),
                    DS1_T = table.Column<int>(type: "int", nullable: false),
                    HEI = table.Column<int>(type: "int", nullable: true),
                    K_FR = table.Column<int>(type: "int", nullable: true),
                    MTSTZ = table.Column<int>(type: "int", nullable: true),
                    ONK_M = table.Column<int>(type: "int", nullable: true),
                    ONK_N = table.Column<int>(type: "int", nullable: true),
                    ONK_T = table.Column<int>(type: "int", nullable: true),
                    SOD = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: false),
                    STAD = table.Column<int>(type: "int", nullable: true),
                    WEI = table.Column<decimal>(type: "decimal(4,1)", precision: 4, scale: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ONK_SLs", x => x.ONK_SLId);
                });

            migrationBuilder.CreateTable(
                name: "PACIENTs",
                columns: table => new
                {
                    PACIENTId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COMENTP = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DOCDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOCNUM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DOCORG = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DOCSER = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DOCTYPE = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    DOST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOST_P = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DR_P = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ENP = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    FAM = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    FAM_P = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ID_PAC = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IM = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    IM_P = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    INV = table.Column<int>(type: "int", nullable: true),
                    MR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MSE = table.Column<int>(type: "int", nullable: true),
                    NOVOR = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    NPOLIS = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OKATOG = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    OKATOP = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    OT = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    OT_P = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    SMO = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    SMO_NAM = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SMO_OGRN = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SMO_OK = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    SNILS = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    SPOLIS = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ST_OKATO = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    VNOV_D = table.Column<int>(type: "int", nullable: true),
                    VPOLIS = table.Column<int>(type: "int", nullable: false),
                    W = table.Column<int>(type: "int", nullable: true),
                    W_P = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PACIENTs", x => x.PACIENTId);
                });

            migrationBuilder.CreateTable(
                name: "PersLists",
                columns: table => new
                {
                    PersListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersLists", x => x.PersListId);
                });

            migrationBuilder.CreateTable(
                name: "SCHETs",
                columns: table => new
                {
                    SCHETId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODE = table.Column<int>(type: "int", nullable: false),
                    CODE_MO = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    COMENTS = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DISP = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    DSCHET = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MONTH = table.Column<int>(type: "int", nullable: false),
                    NSCHET = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PLAT = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    SANK_EKMP = table.Column<decimal>(type: "decimal(17,2)", precision: 17, scale: 2, nullable: true),
                    SANK_MEE = table.Column<decimal>(type: "decimal(17,2)", precision: 17, scale: 2, nullable: true),
                    SANK_MEK = table.Column<decimal>(type: "decimal(17,2)", precision: 17, scale: 2, nullable: true),
                    SUMMAP = table.Column<decimal>(type: "decimal(17,2)", precision: 17, scale: 2, nullable: true),
                    SUMMAV = table.Column<decimal>(type: "decimal(17,2)", precision: 17, scale: 2, nullable: false),
                    YEAR = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCHETs", x => x.SCHETId);
                });

            migrationBuilder.CreateTable(
                name: "Z_SLs",
                columns: table => new
                {
                    Z_SLId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DATE_Z_1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATE_Z_2 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FOR_POM = table.Column<int>(type: "int", nullable: false),
                    IDCASE = table.Column<int>(type: "int", nullable: false),
                    IDSP = table.Column<int>(type: "int", nullable: false),
                    ISHOD = table.Column<int>(type: "int", nullable: false),
                    KD_Z = table.Column<int>(type: "int", nullable: true),
                    LPU = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    NPR_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NPR_MO = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    OPLATA = table.Column<int>(type: "int", nullable: true),
                    OS_SLUCH = table.Column<int>(type: "int", nullable: true),
                    P_DISP2 = table.Column<int>(type: "int", nullable: true),
                    P_OTK = table.Column<int>(type: "int", nullable: false),
                    RSLT = table.Column<int>(type: "int", nullable: false),
                    RSLT_D = table.Column<int>(type: "int", nullable: true),
                    SUMP = table.Column<decimal>(type: "decimal(17,2)", precision: 17, scale: 2, nullable: true),
                    SUMV = table.Column<decimal>(type: "decimal(17,2)", precision: 17, scale: 2, nullable: false),
                    USL_OK = table.Column<int>(type: "int", nullable: false),
                    VB_P = table.Column<int>(type: "int", nullable: true),
                    VBR = table.Column<int>(type: "int", nullable: false),
                    VIDPOM = table.Column<int>(type: "int", nullable: false),
                    VNOV_M = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Z_SLs", x => x.Z_SLId);
                });

            migrationBuilder.CreateTable(
                name: "Zglvs_h",
                columns: table => new
                {
                    ZGLVId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_OKATO1 = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    DATA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FILENAME = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    OKATO_OMS = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    SD_Z = table.Column<int>(type: "int", nullable: false),
                    VERSION = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zglvs_h", x => x.ZGLVId);
                });

            migrationBuilder.CreateTable(
                name: "SL_KOEFs",
                columns: table => new
                {
                    SL_KOEFId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDSL = table.Column<int>(type: "int", nullable: false),
                    Z_SL = table.Column<decimal>(type: "decimal(6,5)", precision: 6, scale: 5, nullable: false),
                    KSG_KPGId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SL_KOEFs", x => x.SL_KOEFId);
                    table.ForeignKey(
                        name: "FK_SL_KOEFs_KSG_KPGs_KSG_KPGId",
                        column: x => x.KSG_KPGId,
                        principalTable: "KSG_KPGs",
                        principalColumn: "KSG_KPGId");
                });

            migrationBuilder.CreateTable(
                name: "B_DIAGs",
                columns: table => new
                {
                    B_DIAGId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DIAG_CODE = table.Column<int>(type: "int", nullable: false),
                    DIAG_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DIAG_RSLT = table.Column<int>(type: "int", nullable: true),
                    DIAG_TIP = table.Column<int>(type: "int", nullable: false),
                    REC_RSLT = table.Column<int>(type: "int", nullable: true),
                    ONK_SLId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_B_DIAGs", x => x.B_DIAGId);
                    table.ForeignKey(
                        name: "FK_B_DIAGs_ONK_SLs_ONK_SLId",
                        column: x => x.ONK_SLId,
                        principalTable: "ONK_SLs",
                        principalColumn: "ONK_SLId");
                });

            migrationBuilder.CreateTable(
                name: "B_PROTs",
                columns: table => new
                {
                    B_PROTId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    D_PROT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PROT = table.Column<int>(type: "int", nullable: false),
                    ONK_SLId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_B_PROTs", x => x.B_PROTId);
                    table.ForeignKey(
                        name: "FK_B_PROTs_ONK_SLs_ONK_SLId",
                        column: x => x.ONK_SLId,
                        principalTable: "ONK_SLs",
                        principalColumn: "ONK_SLId");
                });

            migrationBuilder.CreateTable(
                name: "ONK_USLs",
                columns: table => new
                {
                    ONK_USLId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HIR_TIP = table.Column<int>(type: "int", nullable: true),
                    LEK_TIP_L = table.Column<int>(type: "int", nullable: true),
                    LEK_TIP_V = table.Column<int>(type: "int", nullable: true),
                    LUCH_TIP = table.Column<int>(type: "int", nullable: true),
                    PPTR = table.Column<int>(type: "int", nullable: true),
                    USL_TIP = table.Column<int>(type: "int", nullable: false),
                    ONK_SLId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ONK_USLs", x => x.ONK_USLId);
                    table.ForeignKey(
                        name: "FK_ONK_USLs_ONK_SLs_ONK_SLId",
                        column: x => x.ONK_SLId,
                        principalTable: "ONK_SLs",
                        principalColumn: "ONK_SLId");
                });

            migrationBuilder.CreateTable(
                name: "Pers",
                columns: table => new
                {
                    PersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COMENTP = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DOCDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOCNUM = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DOCORG = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DOCSER = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DOCTYPE = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    DOST = table.Column<int>(type: "int", nullable: true),
                    DOST_P = table.Column<int>(type: "int", nullable: true),
                    DR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DR_P = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FAM = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    FAM_P = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ID_PAC = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IM = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    IM_P = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    MR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OKATOG = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    OKATOP = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    OT = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    OT_P = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    SNILS = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    TEL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    W = table.Column<int>(type: "int", nullable: false),
                    W_P = table.Column<int>(type: "int", nullable: true),
                    PersListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pers", x => x.PersId);
                    table.ForeignKey(
                        name: "FK_Pers_PersLists_PersListId",
                        column: x => x.PersListId,
                        principalTable: "PersLists",
                        principalColumn: "PersListId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zglvs_l",
                columns: table => new
                {
                    ZglvId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DATA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FILENAME = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    FILENAME1 = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    VERSION = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    PersListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zglvs_l", x => x.ZglvId);
                    table.ForeignKey(
                        name: "FK_Zglvs_l_PersLists_PersListId",
                        column: x => x.PersListId,
                        principalTable: "PersLists",
                        principalColumn: "PersListId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SANKs",
                columns: table => new
                {
                    SankId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODE_EXP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DATE_ACT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NUM_ACT = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    S_CODE = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    S_COM = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    S_IST = table.Column<int>(type: "int", nullable: false),
                    S_OSN = table.Column<int>(type: "int", nullable: true),
                    S_SUM = table.Column<decimal>(type: "decimal(17,2)", precision: 17, scale: 2, nullable: false),
                    S_TIP = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    SL_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersListId = table.Column<int>(type: "int", nullable: false),
                    Z_SLId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SANKs", x => x.SankId);
                    table.ForeignKey(
                        name: "FK_SANKs_PersLists_PersListId",
                        column: x => x.PersListId,
                        principalTable: "PersLists",
                        principalColumn: "PersListId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SANKs_Z_SLs_Z_SLId",
                        column: x => x.Z_SLId,
                        principalTable: "Z_SLs",
                        principalColumn: "Z_SLId");
                });

            migrationBuilder.CreateTable(
                name: "SLs",
                columns: table => new
                {
                    SLId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KSG_KPGId = table.Column<int>(type: "int", nullable: true),
                    ONK_SLId = table.Column<int>(type: "int", nullable: true),
                    C_ZAB = table.Column<int>(type: "int", nullable: true),
                    CODE_MES1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CODE_MES2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    COMENTSL = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DATE_1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATE_2 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DET = table.Column<int>(type: "int", nullable: false),
                    DISP = table.Column<int>(type: "int", nullable: true),
                    DN = table.Column<int>(type: "int", nullable: true),
                    DS_ONK = table.Column<int>(type: "int", nullable: false),
                    DS0 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DS1 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DS1_PR = table.Column<int>(type: "int", nullable: true),
                    DS2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DS3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ED_COL = table.Column<decimal>(type: "decimal(7,2)", precision: 7, scale: 2, nullable: true),
                    IDDOKT = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    KD = table.Column<int>(type: "int", nullable: true),
                    LPU_1 = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    METOD_HMP = table.Column<int>(type: "int", nullable: true),
                    NHISTORY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    P_CEL = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    P_PER = table.Column<int>(type: "int", nullable: true),
                    PODR = table.Column<int>(type: "int", nullable: true),
                    PR_D_N = table.Column<int>(type: "int", nullable: true),
                    PROFIL = table.Column<int>(type: "int", nullable: false),
                    PROFIL_K = table.Column<int>(type: "int", nullable: true),
                    PRVS = table.Column<int>(type: "int", nullable: false),
                    REAB = table.Column<int>(type: "int", nullable: true),
                    SL_ID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    SUM_M = table.Column<decimal>(type: "decimal(17,2)", precision: 17, scale: 2, nullable: false),
                    TAL_D = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TAL_NUM = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TAL_P = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TARIF = table.Column<decimal>(type: "decimal(17,2)", precision: 17, scale: 2, nullable: true),
                    VERS_SPEC = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    VID_HMP = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    WEI = table.Column<decimal>(type: "decimal(4,1)", precision: 4, scale: 1, nullable: true),
                    Z_SLId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLs", x => x.SLId);
                    table.ForeignKey(
                        name: "FK_SLs_KSG_KPGs_KSG_KPGId",
                        column: x => x.KSG_KPGId,
                        principalTable: "KSG_KPGs",
                        principalColumn: "KSG_KPGId");
                    table.ForeignKey(
                        name: "FK_SLs_ONK_SLs_ONK_SLId",
                        column: x => x.ONK_SLId,
                        principalTable: "ONK_SLs",
                        principalColumn: "ONK_SLId");
                    table.ForeignKey(
                        name: "FK_SLs_Z_SLs_Z_SLId",
                        column: x => x.Z_SLId,
                        principalTable: "Z_SLs",
                        principalColumn: "Z_SLId");
                });

            migrationBuilder.CreateTable(
                name: "ZL_LISTs",
                columns: table => new
                {
                    ZL_LISTId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SCHETId = table.Column<int>(type: "int", nullable: false),
                    ZGLVId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZL_LISTs", x => x.ZL_LISTId);
                    table.ForeignKey(
                        name: "FK_ZL_LISTs_SCHETs_SCHETId",
                        column: x => x.SCHETId,
                        principalTable: "SCHETs",
                        principalColumn: "SCHETId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZL_LISTs_Zglvs_h_ZGLVId",
                        column: x => x.ZGLVId,
                        principalTable: "Zglvs_h",
                        principalColumn: "ZGLVId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CONSs",
                columns: table => new
                {
                    CONSId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DT_CONS = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PR_CONS = table.Column<int>(type: "int", nullable: false),
                    SLId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONSs", x => x.CONSId);
                    table.ForeignKey(
                        name: "FK_CONSs_SLs_SLId",
                        column: x => x.SLId,
                        principalTable: "SLs",
                        principalColumn: "SLId");
                });

            migrationBuilder.CreateTable(
                name: "DS2_Ns",
                columns: table => new
                {
                    DS2_NId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DS2 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DS2_PR = table.Column<int>(type: "int", nullable: false),
                    PR_DS2_N = table.Column<int>(type: "int", nullable: false),
                    SLId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DS2_Ns", x => x.DS2_NId);
                    table.ForeignKey(
                        name: "FK_DS2_Ns_SLs_SLId",
                        column: x => x.SLId,
                        principalTable: "SLs",
                        principalColumn: "SLId");
                });

            migrationBuilder.CreateTable(
                name: "LEK_PRs",
                columns: table => new
                {
                    LEK_PRId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COD_MARK = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CODE_SH = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DATA_INJ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LEK_DOSEId = table.Column<int>(type: "int", nullable: true),
                    REGNUM = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    ONK_USLId = table.Column<int>(type: "int", nullable: true),
                    SLId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LEK_PRs", x => x.LEK_PRId);
                    table.ForeignKey(
                        name: "FK_LEK_PRs_LEK_DOSEs_LEK_DOSEId",
                        column: x => x.LEK_DOSEId,
                        principalTable: "LEK_DOSEs",
                        principalColumn: "LEK_DOSEId");
                    table.ForeignKey(
                        name: "FK_LEK_PRs_ONK_USLs_ONK_USLId",
                        column: x => x.ONK_USLId,
                        principalTable: "ONK_USLs",
                        principalColumn: "ONK_USLId");
                    table.ForeignKey(
                        name: "FK_LEK_PRs_SLs_SLId",
                        column: x => x.SLId,
                        principalTable: "SLs",
                        principalColumn: "SLId");
                });

            migrationBuilder.CreateTable(
                name: "NAPRs",
                columns: table => new
                {
                    NAPRId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MET_ISSL = table.Column<int>(type: "int", nullable: true),
                    NAPR_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NAPR_MO = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    NAPR_USL = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NAPR_V = table.Column<int>(type: "int", nullable: false),
                    SLId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NAPRs", x => x.NAPRId);
                    table.ForeignKey(
                        name: "FK_NAPRs_SLs_SLId",
                        column: x => x.SLId,
                        principalTable: "SLs",
                        principalColumn: "SLId");
                });

            migrationBuilder.CreateTable(
                name: "NAZs",
                columns: table => new
                {
                    NAZId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAPR_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NAPR_MO = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    NAZ_N = table.Column<int>(type: "int", nullable: false),
                    NAZ_PK = table.Column<int>(type: "int", nullable: true),
                    NAZ_PMP = table.Column<int>(type: "int", nullable: true),
                    NAZ_R = table.Column<int>(type: "int", nullable: false),
                    NAZ_SP = table.Column<int>(type: "int", nullable: true),
                    NAZ_USL = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    NAZ_V = table.Column<int>(type: "int", nullable: true),
                    SLId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NAZs", x => x.NAZId);
                    table.ForeignKey(
                        name: "FK_NAZs_SLs_SLId",
                        column: x => x.SLId,
                        principalTable: "SLs",
                        principalColumn: "SLId");
                });

            migrationBuilder.CreateTable(
                name: "USLs",
                columns: table => new
                {
                    USLId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODE_MD = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CODE_USL = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    COMENTU = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: true),
                    DATE_IN = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATE_OUT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DET = table.Column<int>(type: "int", nullable: false),
                    DS = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IDSERV = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    KOL_USL = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    LPU = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    LPU_1 = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    NPL = table.Column<int>(type: "int", nullable: true),
                    P_OTK = table.Column<int>(type: "int", nullable: false),
                    PODR = table.Column<int>(type: "int", nullable: true),
                    PROFIL = table.Column<int>(type: "int", nullable: true),
                    PRVS = table.Column<int>(type: "int", nullable: true),
                    SUMV_USL = table.Column<decimal>(type: "decimal(17,2)", precision: 17, scale: 2, nullable: false),
                    TARIF = table.Column<decimal>(type: "decimal(17,2)", precision: 17, scale: 2, nullable: true),
                    VID_VME = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SLId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USLs", x => x.USLId);
                    table.ForeignKey(
                        name: "FK_USLs_SLs_SLId",
                        column: x => x.SLId,
                        principalTable: "SLs",
                        principalColumn: "SLId");
                });

            migrationBuilder.CreateTable(
                name: "ZAPs",
                columns: table => new
                {
                    ZAPId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PACIENTId = table.Column<int>(type: "int", nullable: false),
                    Z_SLId = table.Column<int>(type: "int", nullable: false),
                    ZL_LISTId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZAPs", x => x.ZAPId);
                    table.ForeignKey(
                        name: "FK_ZAPs_PACIENTs_PACIENTId",
                        column: x => x.PACIENTId,
                        principalTable: "PACIENTs",
                        principalColumn: "PACIENTId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZAPs_ZL_LISTs_ZL_LISTId",
                        column: x => x.ZL_LISTId,
                        principalTable: "ZL_LISTs",
                        principalColumn: "ZL_LISTId");
                    table.ForeignKey(
                        name: "FK_ZAPs_Z_SLs_Z_SLId",
                        column: x => x.Z_SLId,
                        principalTable: "Z_SLs",
                        principalColumn: "Z_SLId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MED_DEVs",
                columns: table => new
                {
                    MED_DEVId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODE_MEDDEV = table.Column<int>(type: "int", nullable: false),
                    DATE_MED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NUMBER_SER = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    USLId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MED_DEVs", x => x.MED_DEVId);
                    table.ForeignKey(
                        name: "FK_MED_DEVs_USLs_USLId",
                        column: x => x.USLId,
                        principalTable: "USLs",
                        principalColumn: "USLId");
                });

            migrationBuilder.CreateTable(
                name: "MR_USL_Ns",
                columns: table => new
                {
                    MR_USL_NId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODE_MD = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    MR_N = table.Column<int>(type: "int", nullable: false),
                    PRVS = table.Column<int>(type: "int", nullable: true),
                    USLId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MR_USL_Ns", x => x.MR_USL_NId);
                    table.ForeignKey(
                        name: "FK_MR_USL_Ns_USLs_USLId",
                        column: x => x.USLId,
                        principalTable: "USLs",
                        principalColumn: "USLId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_B_DIAGs_ONK_SLId",
                table: "B_DIAGs",
                column: "ONK_SLId");

            migrationBuilder.CreateIndex(
                name: "IX_B_PROTs_ONK_SLId",
                table: "B_PROTs",
                column: "ONK_SLId");

            migrationBuilder.CreateIndex(
                name: "IX_CONSs_SLId",
                table: "CONSs",
                column: "SLId");

            migrationBuilder.CreateIndex(
                name: "IX_DS2_Ns_SLId",
                table: "DS2_Ns",
                column: "SLId");

            migrationBuilder.CreateIndex(
                name: "IX_LEK_PRs_LEK_DOSEId",
                table: "LEK_PRs",
                column: "LEK_DOSEId");

            migrationBuilder.CreateIndex(
                name: "IX_LEK_PRs_ONK_USLId",
                table: "LEK_PRs",
                column: "ONK_USLId");

            migrationBuilder.CreateIndex(
                name: "IX_LEK_PRs_SLId",
                table: "LEK_PRs",
                column: "SLId");

            migrationBuilder.CreateIndex(
                name: "IX_MED_DEVs_USLId",
                table: "MED_DEVs",
                column: "USLId");

            migrationBuilder.CreateIndex(
                name: "IX_MR_USL_Ns_USLId",
                table: "MR_USL_Ns",
                column: "USLId");

            migrationBuilder.CreateIndex(
                name: "IX_NAPRs_SLId",
                table: "NAPRs",
                column: "SLId");

            migrationBuilder.CreateIndex(
                name: "IX_NAZs_SLId",
                table: "NAZs",
                column: "SLId");

            migrationBuilder.CreateIndex(
                name: "IX_ONK_USLs_ONK_SLId",
                table: "ONK_USLs",
                column: "ONK_SLId");

            migrationBuilder.CreateIndex(
                name: "IX_Pers_PersListId",
                table: "Pers",
                column: "PersListId");

            migrationBuilder.CreateIndex(
                name: "IX_SANKs_PersListId",
                table: "SANKs",
                column: "PersListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SANKs_Z_SLId",
                table: "SANKs",
                column: "Z_SLId");

            migrationBuilder.CreateIndex(
                name: "IX_SL_KOEFs_KSG_KPGId",
                table: "SL_KOEFs",
                column: "KSG_KPGId");

            migrationBuilder.CreateIndex(
                name: "IX_SLs_KSG_KPGId",
                table: "SLs",
                column: "KSG_KPGId");

            migrationBuilder.CreateIndex(
                name: "IX_SLs_ONK_SLId",
                table: "SLs",
                column: "ONK_SLId");

            migrationBuilder.CreateIndex(
                name: "IX_SLs_Z_SLId",
                table: "SLs",
                column: "Z_SLId");

            migrationBuilder.CreateIndex(
                name: "IX_USLs_SLId",
                table: "USLs",
                column: "SLId");

            migrationBuilder.CreateIndex(
                name: "IX_ZAPs_PACIENTId",
                table: "ZAPs",
                column: "PACIENTId");

            migrationBuilder.CreateIndex(
                name: "IX_ZAPs_Z_SLId",
                table: "ZAPs",
                column: "Z_SLId");

            migrationBuilder.CreateIndex(
                name: "IX_ZAPs_ZL_LISTId",
                table: "ZAPs",
                column: "ZL_LISTId");

            migrationBuilder.CreateIndex(
                name: "IX_Zglvs_l_PersListId",
                table: "Zglvs_l",
                column: "PersListId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ZL_LISTs_SCHETId",
                table: "ZL_LISTs",
                column: "SCHETId");

            migrationBuilder.CreateIndex(
                name: "IX_ZL_LISTs_ZGLVId",
                table: "ZL_LISTs",
                column: "ZGLVId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "B_DIAGs");

            migrationBuilder.DropTable(
                name: "B_PROTs");

            migrationBuilder.DropTable(
                name: "CONSs");

            migrationBuilder.DropTable(
                name: "DS2_Ns");

            migrationBuilder.DropTable(
                name: "LEK_PRs");

            migrationBuilder.DropTable(
                name: "MED_DEVs");

            migrationBuilder.DropTable(
                name: "MR_USL_Ns");

            migrationBuilder.DropTable(
                name: "NAPRs");

            migrationBuilder.DropTable(
                name: "NAZs");

            migrationBuilder.DropTable(
                name: "Pers");

            migrationBuilder.DropTable(
                name: "SANKs");

            migrationBuilder.DropTable(
                name: "SL_KOEFs");

            migrationBuilder.DropTable(
                name: "ZAPs");

            migrationBuilder.DropTable(
                name: "Zglvs_l");

            migrationBuilder.DropTable(
                name: "LEK_DOSEs");

            migrationBuilder.DropTable(
                name: "ONK_USLs");

            migrationBuilder.DropTable(
                name: "USLs");

            migrationBuilder.DropTable(
                name: "PACIENTs");

            migrationBuilder.DropTable(
                name: "ZL_LISTs");

            migrationBuilder.DropTable(
                name: "PersLists");

            migrationBuilder.DropTable(
                name: "SLs");

            migrationBuilder.DropTable(
                name: "SCHETs");

            migrationBuilder.DropTable(
                name: "Zglvs_h");

            migrationBuilder.DropTable(
                name: "KSG_KPGs");

            migrationBuilder.DropTable(
                name: "ONK_SLs");

            migrationBuilder.DropTable(
                name: "Z_SLs");
        }
    }
}
