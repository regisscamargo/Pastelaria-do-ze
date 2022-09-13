-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: pastelaria_db
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `comanda_produto`
--

DROP TABLE IF EXISTS `comanda_produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `comanda_produto` (
  `ID_COMANDA_PRODUTO` int NOT NULL AUTO_INCREMENT,
  `COMANDA_ID` int NOT NULL,
  `PRODUTO_ID` int NOT NULL,
  `FUNCIONARIO_ID` int NOT NULL,
  `QUANTIDADE` int NOT NULL,
  `VALOR_UNITARIO` decimal(10,0) NOT NULL,
  PRIMARY KEY (`ID_COMANDA_PRODUTO`),
  KEY `comanda_produto_FK` (`COMANDA_ID`),
  KEY `comanda_produto_FK_1` (`PRODUTO_ID`),
  KEY `comanda_produto_FK_2` (`FUNCIONARIO_ID`),
  CONSTRAINT `comanda_produto_FK` FOREIGN KEY (`COMANDA_ID`) REFERENCES `tb_comanda` (`ID_COMANDA`),
  CONSTRAINT `comanda_produto_FK_1` FOREIGN KEY (`PRODUTO_ID`) REFERENCES `tb_produto` (`ID_PRODUTO`),
  CONSTRAINT `comanda_produto_FK_2` FOREIGN KEY (`FUNCIONARIO_ID`) REFERENCES `tb_funcionario` (`ID_FUNCIONARIO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comanda_produto`
--

LOCK TABLES `comanda_produto` WRITE;
/*!40000 ALTER TABLE `comanda_produto` DISABLE KEYS */;
/*!40000 ALTER TABLE `comanda_produto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_cliente`
--

DROP TABLE IF EXISTS `tb_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_cliente` (
  `ID_CLIENTE` int NOT NULL AUTO_INCREMENT,
  `NOME` varchar(100) NOT NULL,
  `CPF` char(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `TELEFONE` char(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `COMPRA_FIADO` smallint NOT NULL,
  `DIA_FIADO` int NOT NULL,
  `SENHA` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`ID_CLIENTE`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_cliente`
--

LOCK TABLES `tb_cliente` WRITE;
/*!40000 ALTER TABLE `tb_cliente` DISABLE KEYS */;
INSERT INTO `tb_cliente` VALUES (5,'Joao da Silva','2036462356','4998655644',1,10,'03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4'),(6,'Renata Rodrigues','45196258896','4965589654',1,5,'03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4'),(7,'Andre Roberto','45962159960','4899856621',1,2,'03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4'),(9,'Floris Bela','02565968874','4988999898',1,10,'03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4'),(11,'Joao mattos','03625596646','4988856566',1,10,'03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4'),(12,'Raissa Gonzatto','65956232122','4988996565',1,10,'03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4'),(13,'Fernanda Lima','03265996520','4866599865',1,4,'e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855');
/*!40000 ALTER TABLE `tb_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_comanda`
--

DROP TABLE IF EXISTS `tb_comanda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_comanda` (
  `ID_COMANDA` int NOT NULL AUTO_INCREMENT,
  `COMANDA` varchar(100) NOT NULL,
  `DATA_HORA` datetime NOT NULL,
  `STATUS_COMANDA` smallint NOT NULL,
  `STATUS_PAGAMENTO` smallint NOT NULL,
  `FUNCIONARIO_ID` int NOT NULL,
  `CLIENTE_ID` int NOT NULL,
  `DATA_ASSINATURA_FIADO` smallint NOT NULL,
  PRIMARY KEY (`ID_COMANDA`),
  KEY `tb_comanda_FK` (`CLIENTE_ID`),
  KEY `tb_comanda_FK_1` (`FUNCIONARIO_ID`),
  CONSTRAINT `tb_comanda_FK` FOREIGN KEY (`CLIENTE_ID`) REFERENCES `tb_cliente` (`ID_CLIENTE`),
  CONSTRAINT `tb_comanda_FK_1` FOREIGN KEY (`FUNCIONARIO_ID`) REFERENCES `tb_funcionario` (`ID_FUNCIONARIO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_comanda`
--

LOCK TABLES `tb_comanda` WRITE;
/*!40000 ALTER TABLE `tb_comanda` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_comanda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_comanda_recebimento`
--

DROP TABLE IF EXISTS `tb_comanda_recebimento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_comanda_recebimento` (
  `RECEBIMENTO_ID` int NOT NULL,
  `COMANDA_ID` int NOT NULL,
  KEY `tb_comanda_recebimento_FK` (`RECEBIMENTO_ID`),
  KEY `tb_comanda_recebimento_FK_1` (`COMANDA_ID`),
  CONSTRAINT `tb_comanda_recebimento_FK` FOREIGN KEY (`RECEBIMENTO_ID`) REFERENCES `tb_recebimento` (`ID_RECEBIMENTO`),
  CONSTRAINT `tb_comanda_recebimento_FK_1` FOREIGN KEY (`COMANDA_ID`) REFERENCES `tb_comanda` (`ID_COMANDA`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_comanda_recebimento`
--

LOCK TABLES `tb_comanda_recebimento` WRITE;
/*!40000 ALTER TABLE `tb_comanda_recebimento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_comanda_recebimento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_empresa`
--

DROP TABLE IF EXISTS `tb_empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_empresa` (
  `TAXA_JURO_DIARIO` decimal(11,2) DEFAULT NULL,
  `MULTA_ATRASO` decimal(11,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_empresa`
--

LOCK TABLES `tb_empresa` WRITE;
/*!40000 ALTER TABLE `tb_empresa` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_funcionario`
--

DROP TABLE IF EXISTS `tb_funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_funcionario` (
  `ID_FUNCIONARIO` int NOT NULL AUTO_INCREMENT,
  `NOME` varchar(100) NOT NULL,
  `MATRICULA` char(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CPF` char(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `TELEFONE` char(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `GRUPO` smallint NOT NULL,
  `SENHA` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`ID_FUNCIONARIO`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_funcionario`
--

LOCK TABLES `tb_funcionario` WRITE;
/*!40000 ALTER TABLE `tb_funcionario` DISABLE KEYS */;
INSERT INTO `tb_funcionario` VALUES (5,'Kevelin','125','01271559960','4986565445',1,'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92'),(6,'Luiz Mondadori','126','02669563321','4899564221',2,'03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4'),(8,'Higor Fernandes','127','02569541126','4899652332',2,'03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4'),(9,'Sergio Mattos','129','74596624966','4899658775',2,'03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4'),(10,'Deyse ','129','01265623266','',2,'03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4'),(11,'Guilherme','122','02156465122','1546545488',1,'03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4'),(12,'Deyse Fernandes','2','01265623266','4654654122',2,'e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855');
/*!40000 ALTER TABLE `tb_funcionario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_produto`
--

DROP TABLE IF EXISTS `tb_produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_produto` (
  `ID_PRODUTO` int NOT NULL AUTO_INCREMENT,
  `NOME` varchar(100) NOT NULL,
  `DESCRICAO` varchar(200) DEFAULT NULL,
  `FOTO` blob,
  `VALOR_UNITARIO` decimal(11,2) DEFAULT NULL,
  PRIMARY KEY (`ID_PRODUTO`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_produto`
--

LOCK TABLES `tb_produto` WRITE;
/*!40000 ALTER TABLE `tb_produto` DISABLE KEYS */;
INSERT INTO `tb_produto` VALUES (3,'Pastel de Carne e Ovo','Comida',_binary '�\��\�\0JFIF\0\0`\0`\0\0�\�\0C\0		\n\r\Z\Z $.\' \",#(7),01444\'9=82<.342�\�\0C			\r\r2!!22222222222222222222222222222222222222222222222222��\0\0b\0�\"\0�\�\0\0\0\0\0\0\0\0\0\0\0	\n�\�\0�\0\0\0}\0!1AQa\"q2���#B��R\�\�$3br�	\n\Z%&\'()*456789:CDEFGHIJSTUVWXYZcdefghijstuvwxyz�����������������������������������\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�����\�\0\0\0\0\0\0\0\0	\n�\�\0�\0\0w\0!1AQaq\"2�B����	#3R\�br\�\n$4\�%\�\Z&\'()*56789:CDEFGHIJSTUVWXYZcdefghijstuvwxyz������������������������������������\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�����\�\0\0\0?\0\�n\�\�\�rQ�\�\�\�ԍt�4�]zg�\�T:��\�\��\�8\�N=��\�\�qK\�m�\0 �\�\�\�jL\�h\�\�M\�\�\�f���v\�\�5gZ��\��\�\��R(�\�-��G,rio$1\�H\�\�\�Q�\�\�J�F3��\��#�ZDY\�\�\r:\�	a_9]n \0;Xcp\��Z��h\�lK�K�eD�#5\�\��ټ\�\�\�ho.�1��\�\�S�$�X\�\�}2\�\�J�M/M[���ۣ��\�gЃ�aR˱\��zM�u�LԵ\�\�f��jX\�o8\�%�*\��\�\�ں{_X\�\"\�^1��ٹ��\��\�W�\�]\�\�\��`G8d*��=��A^��\�2y�Ȓ!\�\�r)J�\�\�CR8]S�6׊\�\'\�\��W\'\�]J\�\�V�wb��\�\��W��\�SF#\"�\�B��>{�\�歩\�太���kS���Q�K��?گ]�\�\�\"g�&�IlO��ٍ�x��+�Sտ\n+\�\�\"\n\0\�J)\�tr�\�;\�I\Z.\\r�8\�\�5m?S�ay\�.�(\�\�׾kcU��\�\�_�\\\��N\�\��\�6 ��\�IU#tv��{\�~����R���\�D�SP\\jG )�7�o�8f��Ph$��\�#;F�[\�㊸\�A6d\�|E\�t���\�J�3!\�{\��\0��i�\�\�a�\�\����?J\�ych��\���-�\�\�$NVE9T9XQ�\��\��-:�C1M\�a�\�\�\�\�\���x�\�\�I\�,�,�\�0\�M\�� \�q�+��կ�\�\�9�;��z�kf\�\�r\�w�\��%W]�M�\�7��Aft\�G�p\�!y8\�@R{\�\��\�^�}�\�\\L\�c<E\�ڶ�b�\�\�ֱ\�\�`8�[�G*:hk�4\�o,<Oon$smtJH�\�pq\�\�\\\�\�x/�\\\�\�;Ed$\�ś\�`\Z\��mF;��\�n+x\���\�_-�\�C$�p\�R<ʽj�\��\��V�Q-A(I\��\0U�T�\�\�T�r~Rz�Vٜ*\�\�`k[��C�E4\�C�\��*\�\��b\�R�+MH\�\�(�]�\�:��x�S�9h�H\��\�oϻ�L�t�k�\�l#-\��Wz�ܹ\��~u\�\�׶\�ztk#2Ms\�,���\0$`�POf\�\�}Mi\�k��.q\�W]�O�c���\�F\�\�\�\�<\�I=+U֍\�\�+���5s��*)�q�$�eԞX�\�\�v\'�7O\�ū��a��WD�\\8\"�\�\�LW\�]\�T\�[Vg\�0{��ɭv\"e�\�\�-�q�,aIÅf\�\0�\�^\rn]1���T8\�k	s&L�(@\\\�qp8=9\�SB\�\�Y�W&\�2�X|�\�\�N1\�dv��kr\�@\0\�6�����b\�i+\�5\�\�Ӯ\��z\Z�\����5+0q\�\�\�/uז\�\�\����(l�&�\�\�iq�Y�8zU�KM�;u;O\�a\�\�Du0���X8�<\�ŷ�VxD��pk���Զ\�2\\)\�\�Z5��\�:\�zI\'q\�Ed\�\�E`hd[\�hpJu�\�0>f�s��\0{\����6�u,a�e�\�@#\�\�k�\�\\p\�v���.�[idXc?\�\�\�pP:\�`\�\�\�\�Ҵ\��i�\0cAh\�b*\�1��\�\�c��\�+\�W�\0薱\�u�T+|\�\�\�\�s���\�\�Z�w�_\\3�\�\�\�:�B\�)\�+\Z��6�\�䐫*v�аˏ\�֕$ݴ�dT\�\��V�W?S�=\Z:\�=e\�v+\�\�\�֔�J�˒sZgUv\�Jm�\�^\��w\"�9v2 1\�-֕\r\�)�pÜ\�\�vq�n>�	ٝ���\�Ǝ	�1\�|^\\J��\n1��\�XrsY\�4z\�\�*Crg�8�mE{\"��&F�\�?�\'�\�e�ˍ9`\�$\�\��9Ӛ\�\�2H$`\�y\�vi\Z{9\�H\"�H�rFNF}Ƶ�\�5�\�=L�_B{p\�\�\�\�\�~���L�\��X1\�\�x\�Q\�A��3Y\�\�Ŗ\�\03r�\�];�����*\�\�d��EccK�\�4MM�\�I��\��\�ֽƑ���H�.r\�W��\0����Eo�\�C�F�E#�\�ʺ\�A\Z<(*�-}\�0\���\�%��galr�>\�[��\�U�.\�3��\�\�=ED�\�n3P\� ��\�Vu��]Y|\��\��\�\�\�\�\��J�5D�B)8\�b�tVv�B\�Ԛμ\�\�O�\� U�\n�4�\�E\�\�5\��몠LzsN��\�3��\�l\�|�F�!RJ�om\�!�9sڭ�a���\�@�\�ɚ\�m*�\�?5g\�j�\���\�Q\�\�\�ϟ�0EG*D\�\\۰�h߅\�uVm2F;Z\�\�.k���\0b���Ў�Ci�Imo;c@���UoSy&V9F\��d\��K�adn�1W\Z�ngR�z\�Q�\�`~\��f�\�:T\�8��\�\�4V�\�w9}�N\�o��?.��+|�Be_A�}+��\�D&@ �u\�u\�\�[Z-���f�\�˅Q\��}Mk��\�cv\�\�XSI{\�*Mly>��G��g\�~d�\�Xv\�y�\'\�$N{�\Z\�<]�\�Y^,�\��#�:z\�\�n�\�3X\�Y�	\�c9\�)q�\0\�\�P�\0h9<۞=\�RE�W�X����sIϹS�G�Sf�]bX\����\0F*�Բ5��\�\�\�\�3;nbI�T��&���\�3Wc^�Y08�q���kV\�\n3Zi9\0��n\�U��\'�7R��<Ծ`+\�3Yks��x�0��NE\�\�\�(�^p\���I\�;袭C���+\�<�U\�\Z�\��`FFpk˟�Vw6���\�ƣ=(�����\rBh��&�\�}\�(�H�T\�ڊ*MM>\�N�袠\�\0\�O\�E.�b\��\�E\�?�\�',1000.00);
/*!40000 ALTER TABLE `tb_produto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_recebimento`
--

DROP TABLE IF EXISTS `tb_recebimento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_recebimento` (
  `ID_RECEBIMENTO` int NOT NULL AUTO_INCREMENT,
  `ID_FUNCIONARIO` int NOT NULL,
  `DATA_HORA` datetime NOT NULL,
  `TIPO` smallint NOT NULL,
  `VALOR_ACRESCIMO` decimal(10,0) DEFAULT NULL,
  `VALOR_DESCONTO` decimal(10,0) DEFAULT NULL,
  `VALOR_TOTAL` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`ID_RECEBIMENTO`),
  KEY `tb_recebimento_FK` (`ID_FUNCIONARIO`),
  CONSTRAINT `tb_recebimento_FK` FOREIGN KEY (`ID_FUNCIONARIO`) REFERENCES `tb_funcionario` (`ID_FUNCIONARIO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_recebimento`
--

LOCK TABLES `tb_recebimento` WRITE;
/*!40000 ALTER TABLE `tb_recebimento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_recebimento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'pastelaria_db'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-06-22 10:10:30
