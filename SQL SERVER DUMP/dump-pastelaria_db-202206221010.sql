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
INSERT INTO `tb_produto` VALUES (3,'Pastel de Carne e Ovo','Comida',_binary 'ˇ\ÿˇ\‡\0JFIF\0\0`\0`\0\0ˇ\€\0C\0		\n\r\Z\Z $.\' \",#(7),01444\'9=82<.342ˇ\€\0C			\r\r2!!22222222222222222222222222222222222222222222222222ˇ¿\0\0b\0Ç\"\0ˇ\ƒ\0\0\0\0\0\0\0\0\0\0\0	\nˇ\ƒ\0µ\0\0\0}\0!1AQa\"q2Åë°#B±¡R\—\$3brÇ	\n\Z%&\'()*456789:CDEFGHIJSTUVWXYZcdefghijstuvwxyzÉÑÖÜáàâäíìîïñóòôö¢£§•¶ß®©™≤≥¥µ∂∑∏π∫\¬\√\ƒ\≈\∆\«\»\…\ \“\”\‘\’\÷\◊\ÿ\Ÿ\⁄\·\‚\„\‰\Â\Ê\Á\Ë\È\Í\Ò\Ú\Û\Ù\ı\ˆ\˜¯˘˙ˇ\ƒ\0\0\0\0\0\0\0\0	\nˇ\ƒ\0µ\0\0w\0!1AQaq\"2ÅBë°±¡	#3R\br\—\n$4\·%\Ò\Z&\'()*56789:CDEFGHIJSTUVWXYZcdefghijstuvwxyzÇÉÑÖÜáàâäíìîïñóòôö¢£§•¶ß®©™≤≥¥µ∂∑∏π∫\¬\√\ƒ\≈\∆\«\»\…\ \“\”\‘\’\÷\◊\ÿ\Ÿ\⁄\‚\„\‰\Â\Ê\Á\Ë\È\Í\Ú\Û\Ù\ı\ˆ\˜¯˘˙ˇ\⁄\0\0\0?\0\În\Ó\“\ÃrQç\ \ÿ\‡‘çt¢4ë]zgÉ\‘T:†é\‚\ŸÄ\…8\ËN=´ô\‘\ÃqK\‰™m¨\0 å\Ò\Î\ŒjL\Ùh\Ô\“M\÷\Òë\‹fØ¢˘v\ﬂ\Ì5gZ®ò\ˆ¥\‰ï\ÔîR(ö\∆-êíG,rio$1\€H\·\ÿ\ÌQã\ËÇ\ÌJÜF3˘à\»¿#µZDY\ﬁ\Â\r:\	a_9]n \0;Xcp\ˆØZΩ•h\”lK®KåeDÉ#5\«\ÈæÜŸº\Ÿ\›\Âho.ß1ï¿\»\«Sî$˛X\Ê¥\ı}2\ﬁ\ÀJíM/M[â°ï€£òé\ƒg–ÉèaRÀ±\◊≤zMÄuÆL‘µ\Õ\˜f¥πjX\œo8\»%õ*\˜¿\»\„⁄∫{_X\…\"\€^1¥∫Ÿπ£õ\Â¿\‹W©\˜]\‚\÷\≈˘`G8d*î˙=¥™A^µß\«2yê»í!\Ë\»r)J˙\“\ÂCR8]S¿6◊ä\∆\'\Ú\ÿ˚W\'\‡]J\ \ŒVéwbÄï\»\‡˚W≤˙\‘SF#\"•\«Bîµ>{±\Ê≠©\ÕÂ§™ß˝¢kS˛¶∞QûKà∞?⁄Ø]∞\–\Ì\"gë&≠IlO¢£Ÿç¥xü¸+çS’ø\n+\‹\’\"\n\0\«J)\Útró\Ò;\€I\Z.\\r£8\Ê≤\Ï5m?Sçay\—.Ö(\Á\ÛÅ◊ækcUπ∂\”\Ê_¥\\\≈öN\›\Ìå˙\◊6 ¥˛\‹IU#tv´Ä{\~¢µ∞åR∑ºá\ÓD∏SP\\jG )í7óo∑8f˘çPh$∫Ç\·#;F¡[\–„ä∏\«A6d\›|E\”t˚¶Ö\ÓJú3!¬É\Ï{\÷ˇ\0áºi•\Î\Ãaâ\⁄\«¸≥ì?J\ychú°\·Å¡ï-î\Ô\À$NVE9T9XQª\‹˙\Ú˙-:˙C1M\¬a¡\È\«\»\Û\Ùè•x∫\‹\›I\Ò,á,¸\‡∂0\œM\ÿ¿ \qû+Öø’ØØ\Ï\“9¶;±èz°kf\÷\Ár\»w§\ı¨%W]ÖMû\≈7àÑAft\Góp\Ú!y8\·@R{\„ú\ˆØ\Ò^ø}≠\Í≤\\L\Âc<E\Ë´⁄∂ìbè\Û\«÷±Ó¨å\»\«`8ï[ΩG*:hk¸4\’o,<Oon$smtJHÑ\Òúpq\Îö\˜\\\Û\Õx/Ç\\\«\‚;Ed$\∆≈õ\‘`\Z\ˆõmF;é¡\Ùn+x\»¡¡\Ó_-É\≈C$†p\‹R< ΩjÑ\˜à\√ÖVÇQ-A(I\ˆˇ\0UπTö\Á\‡∫Tùr~Rz˙VŸú*\ı\‚ß`k[¢πCìE4\ﬁCì\Õ¥*\Ã\Û˝b\◊Rä+MH\¬\“(˘]π\‹:æΩx˙Sº9h¯H\’˛\…oœªüL˙t˝kê\”l#-\ˆâWz®‹π\È˘~u\‹\È◊∂\ˆztk#2Ms\»,å°Ω\0$`˛POf\Ã\Ô}Mi\Êkâ∂.q\ÌW]óO≥cëºé\ıF\“\Ê\⁄\Ÿ<\ÈI=+U÷ç\‹\‰+Ä£†5síä*)∂qû$∞e‘ûXî\Ïù\Àv\'≠7O\—≈´˘≥a¡˙WD§\\8\"´\›\ÒπLW\Í]\ŸT\È[Vg\«0{≤™…≠v\"eπ\„ä\Á-ßq©,aI√Öf\«\0û\ﬂ^\rn]1ë≥¿T8\Ík	s&L∑(@\\\Ûäßqp8=9\≈SB\»\‰ìY∑W&\≈2∏X|π\Á\ÎN1\Ádv˙ïkr\˜@\0\Â6ûµø¥ûb\„i+\”5\À\È”Æ\Ã∫z\Zñ\Ëºπç5+0q\“\Ë\Ì/u◊ñ\Ÿ\√\»ç˝£(lñ&©\Ë\◊iqãYì8zUΩKMûÕæu;O\›a\–\◊Du0ñÑ£X8¡<\÷≈∑àVxDç¿pkáêê‘∂\“2\\)\œ\ÛZ5°ç\ı:\„zI\'q\ÎEd\Ô\ÎE`hd[\ÈìhpJuê\∆0>fâsë¿\0{\‰˛µª6áu,aöeö\⁄@#\ƒ\√k¢\·\\p\–vÔä≠•¯µ.ö[idXc?\Ú\Ú\„pP:\‡`\Û\ı\„\Î“¥\ıüiˇ\0cAh\Íb*\Ï1∏˙\Û\–c˘ö\Ÿ+\›Wˇ\0Ëñ±\€uëT+|\Ÿ\Áß\Ú\≈sßõñ\ı\ÈZñwë_\\3ô\Û\‹\‘:ÑB\√)\Ë+\Zè¢6Ç\“‰ê´*vï–∞Àè\«÷ï$›¥≥dT\Ú\›ãVÑW?S≠=\Z:\ˆ=e\Âv+\Ú\‡\‡÷î≤J™ÀísZgUv\ÒJm£\Œ^\ı£w\"ú9v2 1\…-÷ï\r\‚)ëp√ú\÷\Ïvq˘n>µ	Ÿùáøù\÷∆é	´1\⁄|^\\JªÅ\n1ö∂\≈XrsY\ﬂ4z\Ì\Ï*CrgÄ8•mE{\"˝à&FÖ\Û?á\'å\◊e¶Àç9`\‘$\¬\·¿9”ö\Û\À2H$`\◊y\·≠vi\Z{9\‘H\"åHºrFNF}∆µå\‘5ë\œ=L≠_B{p\”\¬\√\ﬂ\’~µàúL∏\ıØX1\€\œx\Q\∆A¡Æ3Y\–\“≈ñ\€\03rü\·];£ü©ôö*\ﬂ\ˆd˝±EccK£\À4MM¥\˜Iê∂\◊ê\‡÷Ω∆ë©˚¯Hµ.r\ŒWìˇ\0˛µõ°Eo¢\¬CºFπE#é\ﬂ ∫\ÌA\Z<(*ß-}\“0\Ùìç\Á±%ûëgalrª>\ﬁ[Åì\ÎUÆ.\⁄3±Ü\Â\ı=ED∑\Án3P\Õ ìö\ÀVuµ≠]Y|\ƒ¿\Ù§\Õ\Úö\…\…\‰èJù5DáB)8\ﬂb¨tVv†B\Õ‘öŒº\ﬂ\ÈO∑\◊ Uú\n≥4ê\ﬁE\√\≈5\‘˚Î™†LzsN≤ì\Ì3ó¡\«l\÷|ëF∑!RJ∫om\Ï!¿9s⁄≠•a∫çó\Ô@¿\Áö…ö\‰m*º\Ì?5g\›jí\‹∑Å\ÈQ\ƒ\‰\»œüº0EG*D\Û\\€∞∫hﬂÖ\„µuVm2F;Z\‰¥\.k£ÅÄ\0b≥ñ¶–éáCi¨Imo;c@Éû†UoSy&V9F\Áûd\Á¶Kâadnå1W\Z≠ngRÇz\ƒQ¨\›`~\˛fä\ƒ:T\Ÿ8ªì\„\Ê4Væ\’w9}ïN\∆oÑº?.©´+|ÑBe_A˛}+Æø\D&@ ºu\›u\œ\Î[Z-ù∂ëfñ\÷ÀÖQ\À¨}Mk∞ä\Ïcv\∆\ÎXSI{\∆*Mly>≠•G•§g\Ì~dÑ\È≥Xv\Œy¨\'\‘$N{ø\Z\Î<]£\›Y^,Ø\Û¡#é:z\‚π\·nü\ƒ3X\…Yù	\ﬂc9\ı)qˇ\0\‰ì\ÔPˇ\0h9<€û=\ÎREçWÖX¢≤üîsIœπS˚G˝Sf§]bX\◊á¥è\0F*â‘≤5ã¶\„\Ê\Ù\”3;nbI®Të°&Å´ì\∆3Wc^ïY08´qëäÜkV\œ\n3Zi9\0ïën\ÿU•ó\'õ7R±®<‘æ`+\Œ3Yks∑äxú0©±NE\Ì\À\Í(™^p\ı¢çI\Ê;Ë¢≠C˛≤ä+\“<§U\Ò\Z´\Ëó¿`FFpkÀü≠Vw6ß±˝\ﬂ∆£=(¢£°©ù\rBh¢Ñ&©\—}\Í(†HòT\…⁄ä*MM>\ÌNΩË¢†\—\0\ÔO\—E.Éb\‰˙\—E\…?ˇ\Ÿ',1000.00);
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
