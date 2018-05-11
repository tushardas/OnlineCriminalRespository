-- MySQL dump 10.13  Distrib 5.7.21, for Linux (x86_64)
--
-- Host: localhost    Database: ORP
-- ------------------------------------------------------
-- Server version	5.7.21-0ubuntu0.16.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Cop`
--

DROP TABLE IF EXISTS `Cop`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Cop` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Address` longtext,
  `CopID` longtext,
  `DateOfBirth` datetime(6) NOT NULL,
  `Designation` longtext,
  `Name` longtext,
  `PhoneNumber` longtext,
  `PoliceStation` longtext,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Cop`
--

LOCK TABLES `Cop` WRITE;
/*!40000 ALTER TABLE `Cop` DISABLE KEYS */;
INSERT INTO `Cop` VALUES (1,'Y7Y7','ASD1234567','0001-01-01 00:00:00.000000','Constable','BKH','9999999999','EYHUHLU'),(2,'RT','AAA1234567','0001-01-01 00:00:00.000000','Commissioner','TYU','6666666666','TYU');
/*!40000 ALTER TABLE `Cop` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Criminal`
--

DROP TABLE IF EXISTS `Criminal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Criminal` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Address` longtext,
  `Complexion` longtext,
  `CrimeRate` int(11) NOT NULL,
  `DateOfBirth` datetime(6) NOT NULL,
  `EyeColor` longtext,
  `Gender` longtext,
  `Height` longtext,
  `Name` longtext,
  `Weight` int(11) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Criminal`
--

LOCK TABLES `Criminal` WRITE;
/*!40000 ALTER TABLE `Criminal` DISABLE KEYS */;
/*!40000 ALTER TABLE `Criminal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `__EFMigrationsHistory`
--

DROP TABLE IF EXISTS `__EFMigrationsHistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__EFMigrationsHistory`
--

LOCK TABLES `__EFMigrationsHistory` WRITE;
/*!40000 ALTER TABLE `__EFMigrationsHistory` DISABLE KEYS */;
INSERT INTO `__EFMigrationsHistory` VALUES ('20180510210518_InitialCreate','2.0.3-rtm-10026'),('20180510212625_SecondCreate','2.0.3-rtm-10026'),('20180510214056_ThirdCreate','2.0.3-rtm-10026'),('20180511121759_updatedtable','2.0.3-rtm-10026'),('20180511140450_CopTableAdded','2.0.3-rtm-10026'),('20180511142708_updatedCop','2.0.3-rtm-10026');
/*!40000 ALTER TABLE `__EFMigrationsHistory` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-05-11 20:33:28
