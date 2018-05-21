USE [master]
GO
/****** Object:  Database [outpostwars]    Script Date: 5/20/2018 7:11:34 PM ******/
CREATE DATABASE [outpostwars]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'outpostwars', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\outpostwars.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'outpostwars_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\outpostwars_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [outpostwars] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [outpostwars].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [outpostwars] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [outpostwars] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [outpostwars] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [outpostwars] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [outpostwars] SET ARITHABORT OFF 
GO
ALTER DATABASE [outpostwars] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [outpostwars] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [outpostwars] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [outpostwars] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [outpostwars] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [outpostwars] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [outpostwars] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [outpostwars] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [outpostwars] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [outpostwars] SET  DISABLE_BROKER 
GO
ALTER DATABASE [outpostwars] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [outpostwars] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [outpostwars] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [outpostwars] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [outpostwars] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [outpostwars] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [outpostwars] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [outpostwars] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [outpostwars] SET  MULTI_USER 
GO
ALTER DATABASE [outpostwars] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [outpostwars] SET DB_CHAINING OFF 
GO
ALTER DATABASE [outpostwars] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [outpostwars] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [outpostwars] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [outpostwars] SET QUERY_STORE = OFF
GO
USE [outpostwars]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [outpostwars]
GO
/****** Object:  Table [dbo].[Alliance]    Script Date: 5/20/2018 7:11:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alliance](
	[id] [int] NOT NULL,
	[name] [varchar](20) NULL,
	[icon] [int] NOT NULL,
	[banner] [int] NOT NULL,
	[rank1title] [varchar](10) NOT NULL,
	[rank2title] [varchar](10) NOT NULL,
	[rank3title] [varchar](10) NOT NULL,
	[rank4title] [varchar](10) NOT NULL,
	[rank5title] [varchar](10) NOT NULL,
	[permInviteMembers] [int] NOT NULL,
	[permRemoveMembers] [int] NOT NULL,
	[permPromoteMember] [int] NOT NULL,
	[permKickMember] [int] NOT NULL,
	[permEditClan] [int] NOT NULL,
	[permEditPerms] [int] NOT NULL,
 CONSTRAINT [PK_Alliance] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AllianceLedger]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AllianceLedger](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[playerID] [int] NOT NULL,
	[timestamp] [datetime] NOT NULL,
	[resourceType] [int] NOT NULL,
	[value] [int] NOT NULL,
	[allianceID] [int] NOT NULL,
	[itemID] [int] NOT NULL,
 CONSTRAINT [PK_AllianceLedger] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AllianceMember]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AllianceMember](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idPlayer] [int] NOT NULL,
	[idAlliance] [int] NOT NULL,
	[rank] [int] NOT NULL,
	[timestampJoin] [datetime] NOT NULL,
	[currency] [int] NOT NULL,
 CONSTRAINT [PK_AllianceMember] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AllianceStore]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AllianceStore](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[itemID] [int] NOT NULL,
	[qty] [int] NOT NULL,
	[allianceID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AllianceWallet]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AllianceWallet](
	[idAlliance] [int] NOT NULL,
	[resourceID1] [int] NOT NULL,
	[resourceID2] [int] NOT NULL,
	[resourceID3] [int] NOT NULL,
	[resourceID4] [int] NOT NULL,
	[resourceID5] [int] NOT NULL,
	[resourceQty1] [int] NOT NULL,
	[resourceQty2] [int] NOT NULL,
	[resourceQty3] [int] NOT NULL,
	[resourceQty4] [int] NOT NULL,
	[resourceQty5] [int] NOT NULL,
	[showResource1ToAlliance] [bit] NOT NULL,
	[showResource2ToAlliance] [bit] NOT NULL,
	[showResource3ToAlliance] [bit] NOT NULL,
	[showResource4ToAlliance] [bit] NOT NULL,
	[showResource5ToAlliance] [bit] NOT NULL,
 CONSTRAINT [PK_AllianceWallet] PRIMARY KEY CLUSTERED 
(
	[idAlliance] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Auth]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Auth](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[passwordHash] [varchar](64) NOT NULL,
	[lastLoginTimestamp] [datetime] NOT NULL,
	[playerID] [int] NOT NULL,
 CONSTRAINT [PK_Auth] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BattleEvent]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BattleEvent](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[timestamp] [datetime] NOT NULL,
	[attackerID] [int] NOT NULL,
	[defenderID] [int] NOT NULL,
	[mapX] [int] NOT NULL,
	[mapY] [int] NOT NULL,
	[sectorID] [int] NOT NULL,
 CONSTRAINT [PK_BattleEvent] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fleetBuilding]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fleetBuilding](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idPlayer] [int] NOT NULL,
	[shipID] [int] NOT NULL,
	[qty] [int] NOT NULL,
	[completitionTimeReaminingSeconds] [int] NOT NULL,
 CONSTRAINT [PK_fleetBuilding] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fleets]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fleets](
	[id] [int] NOT NULL,
	[playerID] [int] NOT NULL,
	[shipID] [int] NOT NULL,
	[qty] [int] NOT NULL,
	[showOnWorldMap] [bit] NOT NULL,
	[mapX] [int] NOT NULL,
	[mapY] [int] NOT NULL,
	[sectorID] [int] NOT NULL,
 CONSTRAINT [PK_Fleets] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GameSettings]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GameSettings](
	[hashExpirationHours] [int] NOT NULL,
	[baseMovementSpeed] [decimal](18, 5) NOT NULL,
	[alllowLogins] [bit] NOT NULL,
	[maintnenceMode] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[itemID] [int] NULL,
	[qty] [int] NULL,
	[playerID] [int] NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](20) NULL,
	[icon] [varchar](50) NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Log]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Log](
	[id] [bigint] NOT NULL,
	[playerID] [int] NOT NULL,
	[action] [varchar](30) NOT NULL,
	[details] [text] NOT NULL,
	[timestamp] [datetime] NOT NULL,
	[isCritical] [bit] NOT NULL,
	[isWarning] [bit] NOT NULL,
 CONSTRAINT [PK_Log] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[timestamp] [datetime] NOT NULL,
	[idPlayer] [int] NOT NULL,
	[success] [bit] NOT NULL,
	[detail] [text] NULL,
	[ip] [varchar](128) NOT NULL,
	[userAgent] [text] NOT NULL,
	[screenWidth] [int] NOT NULL,
	[screenHeight] [int] NOT NULL,
	[isMobile] [bit] NOT NULL,
	[isTablet] [bit] NOT NULL,
	[isDesktop] [bit] NOT NULL,
	[authID] [int] NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Message]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Message](
	[id] [int] NOT NULL,
	[player1ID] [int] NOT NULL,
	[player2ID] [int] NOT NULL,
	[allianceID] [int] NOT NULL,
	[contents] [varchar](255) NOT NULL,
	[isPlayerToPlayer] [bit] NOT NULL,
	[isToClan] [bit] NOT NULL,
	[timestamp] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nodes]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nodes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[mapX] [int] NOT NULL,
	[mapY] [int] NOT NULL,
	[sectorID] [int] NOT NULL,
	[resourceTypeID] [int] NOT NULL,
	[unitsReamining] [int] NOT NULL,
 CONSTRAINT [PK_Nodes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Outpost]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Outpost](
	[IdPlayer] [int] NOT NULL,
	[mapX] [int] NOT NULL,
	[mapY] [int] NOT NULL,
	[power] [int] NOT NULL,
	[sectorID] [int] NOT NULL,
 CONSTRAINT [PK_Outpost] PRIMARY KEY CLUSTERED 
(
	[IdPlayer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Player]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Player](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[characterName] [varchar](15) NOT NULL,
	[firstName] [varchar](10) NOT NULL,
	[lastName] [varchar](10) NOT NULL,
	[email] [varchar](256) NOT NULL,
	[userName] [varchar](13) NOT NULL,
	[passwordResetHash] [varchar](64) NULL,
	[passwordHashExpiration] [datetime] NULL,
	[facebookToken] [varchar](255) NULL,
	[googleToken] [varchar](255) NULL,
	[createdAtTimestamp] [datetime] NOT NULL,
	[updatedAtTimestamp] [datetime] NOT NULL,
	[lastLoginTimestamp] [datetime] NOT NULL,
	[enabled] [bit] NULL,
	[allianceID] [int] NOT NULL,
	[sourceClickID] [int] NULL,
	[sourceSub1] [varchar](20) NULL,
	[sourceSub2] [varchar](20) NULL,
	[sourceSub3] [varchar](20) NULL,
	[sourceSub4] [varchar](20) NULL,
	[sourceSub5] [varchar](20) NULL,
	[firstLoginComplete] [bit] NOT NULL,
	[salt] [varchar](10) NOT NULL,
	[sectorID] [int] NOT NULL,
	[canLoginDuringMaintnence] [bit] NOT NULL,
 CONSTRAINT [PK_Player] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlayerBuff]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlayerBuff](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[IdPlayer] [int] NOT NULL,
	[statID] [int] NOT NULL,
	[value] [int] NOT NULL,
	[countdownRemaining] [int] NOT NULL,
 CONSTRAINT [PK_PlayerBuffs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlayerResources]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlayerResources](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[resourceTypeID] [int] NOT NULL,
	[qty] [int] NOT NULL,
	[playerID] [int] NOT NULL,
 CONSTRAINT [PK_PlayerResources] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlayerSettings]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlayerSettings](
	[idPlayer] [int] IDENTITY(1,1) NOT NULL,
	[sendEmails] [bit] NOT NULL,
	[sendPush] [bit] NOT NULL,
	[sendBrowserPush] [bit] NOT NULL,
	[alertOnBuildComplete] [bit] NOT NULL,
	[alertOnBeingAttacked] [bit] NOT NULL,
	[alertOnAttack] [bit] NOT NULL,
	[musicEnabled] [bit] NOT NULL,
	[soundEffectsEnabled] [bit] NOT NULL,
	[tutorialEnabled] [bit] NOT NULL,
 CONSTRAINT [PK_PlayerSettings] PRIMARY KEY CLUSTERED 
(
	[idPlayer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResearchCompleted]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResearchCompleted](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[playerID] [int] NOT NULL,
	[researchTypeID] [int] NOT NULL,
	[level] [int] NOT NULL,
 CONSTRAINT [PK_ResearchCompleted] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResearchCosts]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResearchCosts](
	[id] [int] NOT NULL,
	[researchTypeID] [int] NOT NULL,
	[resourceID1] [int] NOT NULL,
	[resourceID2] [int] NOT NULL,
	[resourceID3] [int] NOT NULL,
	[resourceID4] [int] NOT NULL,
	[resourceID5] [int] NOT NULL,
	[resourceQty1] [int] NOT NULL,
	[resourceQty2] [int] NOT NULL,
	[resourceQty3] [int] NOT NULL,
	[resourceQty4] [int] NOT NULL,
	[resourceQty5] [int] NOT NULL,
	[costModifierPerLevel] [decimal](4, 2) NOT NULL,
	[maxLevel] [int] NOT NULL,
 CONSTRAINT [PK_ResearchCosts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResearchTree]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResearchTree](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[researchTreeParentID] [int] NOT NULL,
	[researchTreeChild1ID] [int] NOT NULL,
	[researchTreeChild2ID] [int] NOT NULL,
	[researchTreeChild3ID] [int] NOT NULL,
 CONSTRAINT [PK_ResearchTree] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResearchTypes]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResearchTypes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](15) NOT NULL,
	[requiresStationID] [int] NOT NULL,
	[stationLevelRequired] [int] NOT NULL,
 CONSTRAINT [PK_ReearchTypes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResourceTypes]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResourceTypes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [int] NOT NULL,
	[icon] [int] NOT NULL,
	[cargoSize] [int] NOT NULL,
	[description] [text] NOT NULL,
 CONSTRAINT [PK_ResourceTypes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sector]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sector](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](10) NOT NULL,
	[allowsNewPlayers] [bit] NOT NULL,
	[visibleToPlayers] [bit] NOT NULL,
	[enabled] [bit] NOT NULL,
	[createdTimestamp] [date] NOT NULL,
 CONSTRAINT [PK_Sector] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShipCost]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShipCost](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[shipTypeID] [int] NULL,
	[resourceID1] [int] NOT NULL,
	[resourceID2] [int] NOT NULL,
	[resourceID3] [int] NOT NULL,
	[resourceID4] [int] NOT NULL,
	[resourceID5] [int] NOT NULL,
	[resourceQty1] [int] NOT NULL,
	[resourceQty2] [int] NOT NULL,
	[resourceQty3] [int] NOT NULL,
	[resourceQty4] [int] NOT NULL,
	[resourceQty5] [int] NOT NULL,
	[openToPlayers] [bit] NOT NULL,
	[requiredStationType] [int] NOT NULL,
	[requiredStationLevel] [int] NOT NULL,
 CONSTRAINT [PK_ShipCost] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ships]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ships](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [int] NOT NULL,
	[icon] [varchar](50) NOT NULL,
	[worldMapAnimationImage] [varchar](50) NOT NULL,
	[baseAttack] [int] NOT NULL,
	[baseDefense] [int] NOT NULL,
	[baseCargoHold] [int] NOT NULL,
 CONSTRAINT [PK_Ships] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShipsLostLineItems]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShipsLostLineItems](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[battleID] [int] NOT NULL,
	[playerID] [int] NOT NULL,
	[shipID] [int] NOT NULL,
	[qty] [int] NOT NULL,
 CONSTRAINT [PK_ShipsLostLineItems] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShipsRemainingLineItems]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShipsRemainingLineItems](
	[id] [int] NOT NULL,
	[battleID] [int] NOT NULL,
	[playerID] [int] NOT NULL,
	[shipID] [int] NOT NULL,
	[qty] [int] NOT NULL,
 CONSTRAINT [PK_ShipsRemainingLineItems] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Station]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Station](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[outpostID] [int] NOT NULL,
	[stationTypeID] [int] NOT NULL,
	[level] [int] NOT NULL,
 CONSTRAINT [PK_Stations] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StationTypes]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StationTypes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](20) NOT NULL,
	[icon] [varchar](50) NOT NULL,
	[description] [text] NOT NULL,
 CONSTRAINT [PK_StationTypes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StationUpgradesCost]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StationUpgradesCost](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[stationTypeID] [int] NOT NULL,
	[level] [int] NOT NULL,
	[resourceID1] [int] NOT NULL,
	[resourceID2] [int] NOT NULL,
	[resourceID3] [int] NOT NULL,
	[resourceID4] [int] NOT NULL,
	[resourceID5] [int] NOT NULL,
	[resourceQty1] [int] NOT NULL,
	[resourceQty2] [int] NOT NULL,
	[resourceQty3] [int] NOT NULL,
	[resourceQty4] [int] NOT NULL,
	[resourceQty5] [int] NOT NULL,
	[openToPlayers] [bit] NOT NULL,
 CONSTRAINT [PK_StationUpgradesCost] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatTypes]    Script Date: 5/20/2018 7:11:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatTypes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](10) NOT NULL,
	[visibleToPlayer] [bit] NOT NULL,
	[forFleet] [bit] NOT NULL,
	[forOutpost] [bit] NOT NULL,
 CONSTRAINT [PK_StatTypes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Alliance] ADD  CONSTRAINT [DF_Alliance_icon]  DEFAULT ((0)) FOR [icon]
GO
ALTER TABLE [dbo].[Alliance] ADD  CONSTRAINT [DF_Alliance_banner]  DEFAULT ((0)) FOR [banner]
GO
ALTER TABLE [dbo].[Alliance] ADD  CONSTRAINT [DF_Alliance_rank1title]  DEFAULT ('General') FOR [rank1title]
GO
ALTER TABLE [dbo].[Alliance] ADD  CONSTRAINT [DF_Alliance_rank2title]  DEFAULT ('Lieutenant') FOR [rank2title]
GO
ALTER TABLE [dbo].[Alliance] ADD  CONSTRAINT [DF_Alliance_rank3title]  DEFAULT ('Sergeant') FOR [rank3title]
GO
ALTER TABLE [dbo].[Alliance] ADD  CONSTRAINT [DF_Alliance_rank4title]  DEFAULT ('Private') FOR [rank4title]
GO
ALTER TABLE [dbo].[Alliance] ADD  CONSTRAINT [DF_Alliance_rank5title]  DEFAULT ('Recruit') FOR [rank5title]
GO
ALTER TABLE [dbo].[Alliance] ADD  CONSTRAINT [DF_Alliance_permInviteMembers]  DEFAULT ((2)) FOR [permInviteMembers]
GO
ALTER TABLE [dbo].[Alliance] ADD  CONSTRAINT [DF_Alliance_permRemoveMembers]  DEFAULT ((2)) FOR [permRemoveMembers]
GO
ALTER TABLE [dbo].[Alliance] ADD  CONSTRAINT [DF_Alliance_permKickMember]  DEFAULT ((2)) FOR [permKickMember]
GO
ALTER TABLE [dbo].[Alliance] ADD  CONSTRAINT [DF_Alliance_permEditClan]  DEFAULT ((1)) FOR [permEditClan]
GO
ALTER TABLE [dbo].[Alliance] ADD  CONSTRAINT [DF_Alliance_permEditPerms]  DEFAULT ((1)) FOR [permEditPerms]
GO
ALTER TABLE [dbo].[AllianceMember] ADD  CONSTRAINT [DF_AllianceMember_rank]  DEFAULT ((5)) FOR [rank]
GO
ALTER TABLE [dbo].[AllianceWallet] ADD  CONSTRAINT [DF_AllianceWallet_resourceQty1]  DEFAULT ((0)) FOR [resourceQty1]
GO
ALTER TABLE [dbo].[AllianceWallet] ADD  CONSTRAINT [DF_AllianceWallet_resourceQty2]  DEFAULT ((0)) FOR [resourceQty2]
GO
ALTER TABLE [dbo].[AllianceWallet] ADD  CONSTRAINT [DF_AllianceWallet_resourceQty3]  DEFAULT ((0)) FOR [resourceQty3]
GO
ALTER TABLE [dbo].[AllianceWallet] ADD  CONSTRAINT [DF_AllianceWallet_resourceQty4]  DEFAULT ((0)) FOR [resourceQty4]
GO
ALTER TABLE [dbo].[AllianceWallet] ADD  CONSTRAINT [DF_AllianceWallet_resourceQty5]  DEFAULT ((0)) FOR [resourceQty5]
GO
ALTER TABLE [dbo].[BattleEvent] ADD  CONSTRAINT [DF_BattleEvent_timestamp]  DEFAULT (getdate()) FOR [timestamp]
GO
ALTER TABLE [dbo].[Login] ADD  CONSTRAINT [DF_Login_timestamp]  DEFAULT (getdate()) FOR [timestamp]
GO
ALTER TABLE [dbo].[Player] ADD  CONSTRAINT [DF_Player_allianceID]  DEFAULT ((-1)) FOR [allianceID]
GO
ALTER TABLE [dbo].[Player] ADD  CONSTRAINT [DF_Player_firstLoginComplete]  DEFAULT ((0)) FOR [firstLoginComplete]
GO
ALTER TABLE [dbo].[Player] ADD  CONSTRAINT [DF_Player_canLoginDuringMaintnence]  DEFAULT ((0)) FOR [canLoginDuringMaintnence]
GO
ALTER TABLE [dbo].[PlayerSettings] ADD  CONSTRAINT [DF_PlayerSettings_sendEmails]  DEFAULT ((1)) FOR [sendEmails]
GO
ALTER TABLE [dbo].[PlayerSettings] ADD  CONSTRAINT [DF_PlayerSettings_sendPush]  DEFAULT ((1)) FOR [sendPush]
GO
ALTER TABLE [dbo].[PlayerSettings] ADD  CONSTRAINT [DF_PlayerSettings_sendBrowserPush]  DEFAULT ((1)) FOR [sendBrowserPush]
GO
ALTER TABLE [dbo].[PlayerSettings] ADD  CONSTRAINT [DF_PlayerSettings_alertOnBuildComplete]  DEFAULT ((1)) FOR [alertOnBuildComplete]
GO
ALTER TABLE [dbo].[PlayerSettings] ADD  CONSTRAINT [DF_PlayerSettings_alertOnBeingAttacked]  DEFAULT ((1)) FOR [alertOnBeingAttacked]
GO
ALTER TABLE [dbo].[PlayerSettings] ADD  CONSTRAINT [DF_PlayerSettings_alertOnAttack]  DEFAULT ((1)) FOR [alertOnAttack]
GO
ALTER TABLE [dbo].[PlayerSettings] ADD  CONSTRAINT [DF_PlayerSettings_musicEnabled]  DEFAULT ((1)) FOR [musicEnabled]
GO
ALTER TABLE [dbo].[PlayerSettings] ADD  CONSTRAINT [DF_PlayerSettings_soundEffectsEnabled]  DEFAULT ((1)) FOR [soundEffectsEnabled]
GO
ALTER TABLE [dbo].[PlayerSettings] ADD  CONSTRAINT [DF_PlayerSettings_tutorialEnabled]  DEFAULT ((1)) FOR [tutorialEnabled]
GO
ALTER TABLE [dbo].[Sector] ADD  CONSTRAINT [DF_Sector_allowsNewPlayers]  DEFAULT ((0)) FOR [allowsNewPlayers]
GO
ALTER TABLE [dbo].[Sector] ADD  CONSTRAINT [DF_Sector_visibleToPlayers]  DEFAULT ((0)) FOR [visibleToPlayers]
GO
ALTER TABLE [dbo].[Sector] ADD  CONSTRAINT [DF_Sector_enabled]  DEFAULT ((0)) FOR [enabled]
GO
ALTER TABLE [dbo].[Sector] ADD  CONSTRAINT [DF_Sector_createdTimestamp]  DEFAULT (getdate()) FOR [createdTimestamp]
GO
ALTER TABLE [dbo].[AllianceLedger]  WITH CHECK ADD  CONSTRAINT [FK_AllianceLedger_Alliance] FOREIGN KEY([allianceID])
REFERENCES [dbo].[Alliance] ([id])
GO
ALTER TABLE [dbo].[AllianceLedger] CHECK CONSTRAINT [FK_AllianceLedger_Alliance]
GO
ALTER TABLE [dbo].[AllianceLedger]  WITH CHECK ADD  CONSTRAINT [FK_AllianceLedger_Item] FOREIGN KEY([itemID])
REFERENCES [dbo].[Item] ([id])
GO
ALTER TABLE [dbo].[AllianceLedger] CHECK CONSTRAINT [FK_AllianceLedger_Item]
GO
ALTER TABLE [dbo].[AllianceLedger]  WITH CHECK ADD  CONSTRAINT [FK_AllianceLedger_Player] FOREIGN KEY([playerID])
REFERENCES [dbo].[Player] ([id])
GO
ALTER TABLE [dbo].[AllianceLedger] CHECK CONSTRAINT [FK_AllianceLedger_Player]
GO
ALTER TABLE [dbo].[AllianceMember]  WITH CHECK ADD  CONSTRAINT [FK_AllianceMember_Alliance] FOREIGN KEY([idAlliance])
REFERENCES [dbo].[Alliance] ([id])
GO
ALTER TABLE [dbo].[AllianceMember] CHECK CONSTRAINT [FK_AllianceMember_Alliance]
GO
ALTER TABLE [dbo].[AllianceMember]  WITH CHECK ADD  CONSTRAINT [FK_AllianceMember_Player] FOREIGN KEY([idPlayer])
REFERENCES [dbo].[Player] ([id])
GO
ALTER TABLE [dbo].[AllianceMember] CHECK CONSTRAINT [FK_AllianceMember_Player]
GO
ALTER TABLE [dbo].[AllianceStore]  WITH CHECK ADD  CONSTRAINT [FK_AllianceStore_Alliance] FOREIGN KEY([allianceID])
REFERENCES [dbo].[Alliance] ([id])
GO
ALTER TABLE [dbo].[AllianceStore] CHECK CONSTRAINT [FK_AllianceStore_Alliance]
GO
ALTER TABLE [dbo].[AllianceStore]  WITH CHECK ADD  CONSTRAINT [FK_AllianceStore_Item] FOREIGN KEY([itemID])
REFERENCES [dbo].[Item] ([id])
GO
ALTER TABLE [dbo].[AllianceStore] CHECK CONSTRAINT [FK_AllianceStore_Item]
GO
ALTER TABLE [dbo].[AllianceWallet]  WITH CHECK ADD  CONSTRAINT [FK_AllianceWallet_Alliance] FOREIGN KEY([idAlliance])
REFERENCES [dbo].[Alliance] ([id])
GO
ALTER TABLE [dbo].[AllianceWallet] CHECK CONSTRAINT [FK_AllianceWallet_Alliance]
GO
ALTER TABLE [dbo].[Auth]  WITH CHECK ADD  CONSTRAINT [FK_Auth_Player] FOREIGN KEY([playerID])
REFERENCES [dbo].[Player] ([id])
GO
ALTER TABLE [dbo].[Auth] CHECK CONSTRAINT [FK_Auth_Player]
GO
ALTER TABLE [dbo].[fleetBuilding]  WITH CHECK ADD  CONSTRAINT [FK_fleetBuilding_Player] FOREIGN KEY([idPlayer])
REFERENCES [dbo].[Player] ([id])
GO
ALTER TABLE [dbo].[fleetBuilding] CHECK CONSTRAINT [FK_fleetBuilding_Player]
GO
ALTER TABLE [dbo].[fleetBuilding]  WITH CHECK ADD  CONSTRAINT [FK_fleetBuilding_Ships] FOREIGN KEY([shipID])
REFERENCES [dbo].[Ships] ([id])
GO
ALTER TABLE [dbo].[fleetBuilding] CHECK CONSTRAINT [FK_fleetBuilding_Ships]
GO
ALTER TABLE [dbo].[Fleets]  WITH CHECK ADD  CONSTRAINT [FK_Fleets_Player] FOREIGN KEY([playerID])
REFERENCES [dbo].[Player] ([id])
GO
ALTER TABLE [dbo].[Fleets] CHECK CONSTRAINT [FK_Fleets_Player]
GO
ALTER TABLE [dbo].[Fleets]  WITH CHECK ADD  CONSTRAINT [FK_Fleets_Sector] FOREIGN KEY([sectorID])
REFERENCES [dbo].[Sector] ([id])
GO
ALTER TABLE [dbo].[Fleets] CHECK CONSTRAINT [FK_Fleets_Sector]
GO
ALTER TABLE [dbo].[Fleets]  WITH CHECK ADD  CONSTRAINT [FK_Fleets_Ships] FOREIGN KEY([shipID])
REFERENCES [dbo].[Ships] ([id])
GO
ALTER TABLE [dbo].[Fleets] CHECK CONSTRAINT [FK_Fleets_Ships]
GO
ALTER TABLE [dbo].[Inventory]  WITH CHECK ADD  CONSTRAINT [FK_Inventory_Item] FOREIGN KEY([itemID])
REFERENCES [dbo].[Item] ([id])
GO
ALTER TABLE [dbo].[Inventory] CHECK CONSTRAINT [FK_Inventory_Item]
GO
ALTER TABLE [dbo].[Inventory]  WITH CHECK ADD  CONSTRAINT [FK_Inventory_Player] FOREIGN KEY([playerID])
REFERENCES [dbo].[Player] ([id])
GO
ALTER TABLE [dbo].[Inventory] CHECK CONSTRAINT [FK_Inventory_Player]
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [FK_Login_Auth] FOREIGN KEY([authID])
REFERENCES [dbo].[Auth] ([id])
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [FK_Login_Auth]
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [FK_Login_Player] FOREIGN KEY([idPlayer])
REFERENCES [dbo].[Player] ([id])
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [FK_Login_Player]
GO
ALTER TABLE [dbo].[Nodes]  WITH CHECK ADD  CONSTRAINT [FK_Nodes_ResourceTypes] FOREIGN KEY([resourceTypeID])
REFERENCES [dbo].[ResourceTypes] ([id])
GO
ALTER TABLE [dbo].[Nodes] CHECK CONSTRAINT [FK_Nodes_ResourceTypes]
GO
ALTER TABLE [dbo].[Nodes]  WITH CHECK ADD  CONSTRAINT [FK_Nodes_Sector] FOREIGN KEY([sectorID])
REFERENCES [dbo].[Sector] ([id])
GO
ALTER TABLE [dbo].[Nodes] CHECK CONSTRAINT [FK_Nodes_Sector]
GO
ALTER TABLE [dbo].[Outpost]  WITH CHECK ADD  CONSTRAINT [FK_Outpost_Player] FOREIGN KEY([IdPlayer])
REFERENCES [dbo].[Player] ([id])
GO
ALTER TABLE [dbo].[Outpost] CHECK CONSTRAINT [FK_Outpost_Player]
GO
ALTER TABLE [dbo].[Outpost]  WITH CHECK ADD  CONSTRAINT [FK_Outpost_Sector] FOREIGN KEY([sectorID])
REFERENCES [dbo].[Sector] ([id])
GO
ALTER TABLE [dbo].[Outpost] CHECK CONSTRAINT [FK_Outpost_Sector]
GO
ALTER TABLE [dbo].[Player]  WITH CHECK ADD  CONSTRAINT [FK_Player_Sector] FOREIGN KEY([sectorID])
REFERENCES [dbo].[Sector] ([id])
GO
ALTER TABLE [dbo].[Player] CHECK CONSTRAINT [FK_Player_Sector]
GO
ALTER TABLE [dbo].[PlayerBuff]  WITH CHECK ADD  CONSTRAINT [FK_PlayerBuff_Player] FOREIGN KEY([IdPlayer])
REFERENCES [dbo].[Player] ([id])
GO
ALTER TABLE [dbo].[PlayerBuff] CHECK CONSTRAINT [FK_PlayerBuff_Player]
GO
ALTER TABLE [dbo].[PlayerBuff]  WITH CHECK ADD  CONSTRAINT [FK_PlayerBuff_PlayerBuff] FOREIGN KEY([statID])
REFERENCES [dbo].[StatTypes] ([id])
GO
ALTER TABLE [dbo].[PlayerBuff] CHECK CONSTRAINT [FK_PlayerBuff_PlayerBuff]
GO
ALTER TABLE [dbo].[PlayerResources]  WITH CHECK ADD  CONSTRAINT [FK_PlayerResources_Player] FOREIGN KEY([playerID])
REFERENCES [dbo].[Player] ([id])
GO
ALTER TABLE [dbo].[PlayerResources] CHECK CONSTRAINT [FK_PlayerResources_Player]
GO
ALTER TABLE [dbo].[PlayerResources]  WITH CHECK ADD  CONSTRAINT [FK_PlayerResources_ResourceTypes] FOREIGN KEY([resourceTypeID])
REFERENCES [dbo].[ResourceTypes] ([id])
GO
ALTER TABLE [dbo].[PlayerResources] CHECK CONSTRAINT [FK_PlayerResources_ResourceTypes]
GO
ALTER TABLE [dbo].[PlayerSettings]  WITH CHECK ADD  CONSTRAINT [FK_PlayerSettings_Player] FOREIGN KEY([idPlayer])
REFERENCES [dbo].[Player] ([id])
GO
ALTER TABLE [dbo].[PlayerSettings] CHECK CONSTRAINT [FK_PlayerSettings_Player]
GO
ALTER TABLE [dbo].[ResearchCompleted]  WITH CHECK ADD  CONSTRAINT [FK_ResearchCompleted_Player] FOREIGN KEY([playerID])
REFERENCES [dbo].[Player] ([id])
GO
ALTER TABLE [dbo].[ResearchCompleted] CHECK CONSTRAINT [FK_ResearchCompleted_Player]
GO
ALTER TABLE [dbo].[ResearchCompleted]  WITH CHECK ADD  CONSTRAINT [FK_ResearchCompleted_ResearchTypes] FOREIGN KEY([researchTypeID])
REFERENCES [dbo].[ResearchTypes] ([id])
GO
ALTER TABLE [dbo].[ResearchCompleted] CHECK CONSTRAINT [FK_ResearchCompleted_ResearchTypes]
GO
ALTER TABLE [dbo].[ResearchCosts]  WITH CHECK ADD  CONSTRAINT [FK_ResearchCosts_ResearchTypes] FOREIGN KEY([researchTypeID])
REFERENCES [dbo].[ResearchTypes] ([id])
GO
ALTER TABLE [dbo].[ResearchCosts] CHECK CONSTRAINT [FK_ResearchCosts_ResearchTypes]
GO
ALTER TABLE [dbo].[ShipCost]  WITH CHECK ADD  CONSTRAINT [FK_ShipCost_Ships] FOREIGN KEY([shipTypeID])
REFERENCES [dbo].[Ships] ([id])
GO
ALTER TABLE [dbo].[ShipCost] CHECK CONSTRAINT [FK_ShipCost_Ships]
GO
ALTER TABLE [dbo].[ShipsLostLineItems]  WITH CHECK ADD  CONSTRAINT [FK_ShipsLostLineItems_BattleEvent] FOREIGN KEY([battleID])
REFERENCES [dbo].[BattleEvent] ([id])
GO
ALTER TABLE [dbo].[ShipsLostLineItems] CHECK CONSTRAINT [FK_ShipsLostLineItems_BattleEvent]
GO
ALTER TABLE [dbo].[ShipsLostLineItems]  WITH CHECK ADD  CONSTRAINT [FK_ShipsLostLineItems_Ships] FOREIGN KEY([shipID])
REFERENCES [dbo].[Ships] ([id])
GO
ALTER TABLE [dbo].[ShipsLostLineItems] CHECK CONSTRAINT [FK_ShipsLostLineItems_Ships]
GO
ALTER TABLE [dbo].[ShipsRemainingLineItems]  WITH CHECK ADD  CONSTRAINT [FK_ShipsRemainingLineItems_BattleEvent] FOREIGN KEY([battleID])
REFERENCES [dbo].[BattleEvent] ([id])
GO
ALTER TABLE [dbo].[ShipsRemainingLineItems] CHECK CONSTRAINT [FK_ShipsRemainingLineItems_BattleEvent]
GO
ALTER TABLE [dbo].[ShipsRemainingLineItems]  WITH CHECK ADD  CONSTRAINT [FK_ShipsRemainingLineItems_Ships] FOREIGN KEY([shipID])
REFERENCES [dbo].[Ships] ([id])
GO
ALTER TABLE [dbo].[ShipsRemainingLineItems] CHECK CONSTRAINT [FK_ShipsRemainingLineItems_Ships]
GO
ALTER TABLE [dbo].[Station]  WITH CHECK ADD  CONSTRAINT [FK_Stations_Outpost] FOREIGN KEY([outpostID])
REFERENCES [dbo].[Outpost] ([IdPlayer])
GO
ALTER TABLE [dbo].[Station] CHECK CONSTRAINT [FK_Stations_Outpost]
GO
ALTER TABLE [dbo].[Station]  WITH CHECK ADD  CONSTRAINT [FK_Stations_StationTypes] FOREIGN KEY([stationTypeID])
REFERENCES [dbo].[StationTypes] ([id])
GO
ALTER TABLE [dbo].[Station] CHECK CONSTRAINT [FK_Stations_StationTypes]
GO
ALTER TABLE [dbo].[StationUpgradesCost]  WITH CHECK ADD  CONSTRAINT [FK_StationUpgradesCost_StationTypes] FOREIGN KEY([stationTypeID])
REFERENCES [dbo].[StationTypes] ([id])
GO
ALTER TABLE [dbo].[StationUpgradesCost] CHECK CONSTRAINT [FK_StationUpgradesCost_StationTypes]
GO
USE [master]
GO
ALTER DATABASE [outpostwars] SET  READ_WRITE 
GO
