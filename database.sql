-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jan 10, 2021 at 02:54 PM
-- Server version: 5.7.24
-- PHP Version: 7.4.1

START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `database`
--

-- --------------------------------------------------------

--
-- Table structure for table `disease`
--

CREATE TABLE `disease` (
  `DiseaseID` int(30) UNSIGNED NOT NULL AUTO_INCREMENT, 
  `Disease` varchar(30) NOT NULL, 
  PRIMARY KEY (`DiseaseID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `disease`
--

INSERT INTO `disease` (`DiseaseID`, `Disease`) VALUES
(1, 'COVID-19'),
(2, 'Воспаление легких'),
(3, 'ОРВИ');

-- --------------------------------------------------------

--
-- Table structure for table `doctor`
--

CREATE TABLE `doctor` (
  `DoctorID` int(32) UNSIGNED NOT NULL AUTO_INCREMENT,
  `FIO` varchar(32) NOT NULL,
  `Doljnost` varchar(30) NOT NULL,
  `StajRaboti` int(20) UNSIGNED NOT NULL,
  `MestoRaboti` int(32) UNSIGNED NOT NULL,
  PRIMARY KEY (`DoctorID`) -- метка по которой в таблице можно однозначно определить запись в таблице (уникальный ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `doctor`
--

INSERT INTO `doctor` (`DoctorID`, `FIO`, `Doljnost`, `StajRaboti`, `MestoRaboti`) VALUES
(1, 'Дъяченко Павел Сергеевич', 'Анестезиолог', 20, 4),
(2, 'Рябчиков Илья Владимирович', 'Хирург', 31, 5),
(3, 'Масгутов Руслан Фаридович', 'Терапевт', 19, 3),
(4, 'Шайхутдинов Рустем Рафкатович', 'Анестезиолог', 27, 2),
(5, 'Амирян Азат Мулланурович', 'Должность', 14, 1);

-- --------------------------------------------------------

--
-- Table structure for table `hospital`
--

CREATE TABLE `hospital` (
  `HospitalID` int(30) UNSIGNED NOT NULL AUTO_INCREMENT,
  `Hospital` tinytext NOT NULL,
  `AdressHospital` varchar(30) NOT NULL,
  `NumberHospital` bigint(30) NOT NULL,
  `MailHospital` varchar(11) NOT NULL,
  PRIMARY KEY (`HospitalID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `hospital`
--

INSERT INTO `hospital` (`HospitalID`, `Hospital`, `AdressHospital`, `NumberHospital`, `MailHospital`) VALUES
(1, 'Городская больница №7', 'ул.Маршала Чуйкова, 54', 89365547821, 'gkb7@bk.ru'),
(2, 'Центральная городская больница №18', 'ул. Мавлютова, д. 2', 88435282005, 'gkb18@bk.ru'),
(3, 'Хирургическая клиника имени В.П. Крупина (бывш. Городская больница №5)', 'ул. Шарифа Камала, д. 12', 84382782830, 'gkb5@bk.ru'),
(4, 'РКБ', 'пр. Победы, д. 83', 89475561298, 'gkb@bk.ru'),
(5, 'Центральная больница Казани', 'ул. Чехова, д. 1А', 89093756812, 'gkb2@bk.ru');

-- --------------------------------------------------------

--
-- Table structure for table `methodtreatment`
--

CREATE TABLE `methodtreatment` (
  `MethodID` int(30) UNSIGNED NOT NULL AUTO_INCREMENT,
  `Description` tinytext NOT NULL,
  PRIMARY KEY (`MethodID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `methodtreatment`
--

INSERT INTO `methodtreatment` (`MethodID`, `Description`) VALUES
(1, 'ЭВЛ лечение'),
(2, 'Стационарное лечение'),
(3, 'Домашнее лечение'),
(4, 'Амбулаторное лечение');

-- --------------------------------------------------------

--
-- Table structure for table `sick`
--

CREATE TABLE `sick` (
  `SickID` int(32) UNSIGNED NOT NULL AUTO_INCREMENT,
  `FIO` tinytext NOT NULL,
  `Nationality` varchar(50) NOT NULL,
  `Registration` varchar(50) NOT NULL,
  `Age` int(150) NOT NULL,
  `DateDiagnosis` date NOT NULL,
  `DiseaseID` int(32) UNSIGNED NOT NULL,
  `severityID` int(32) UNSIGNED NOT NULL,
  `MethodID` int(32) UNSIGNED NOT NULL,
  `HospitalID` int(32) UNSIGNED NOT NULL,
  `DoctorID` int(32) UNSIGNED NOT NULL,
  `BirthDay` date NOT NULL,
  `StatusID` int(32) UNSIGNED NOT NULL,
  PRIMARY KEY (`SickID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `sick`
--

INSERT INTO `sick` (`SickID`, `FIO`, `Nationality`, `Registration`, `Age`, `DateDiagnosis`, `DiseaseID`, `severityID`, `MethodID`, `HospitalID`, `DoctorID`, `BirthDay`, `StatusID`) VALUES
(1, 'Петров Петр Петрович', 'Россия', 'Казань', 20, '2000-12-20', 2, 1, 1, 1, 1, '2012-12-20', 1),
(2, 'Александров Александр Александрович', 'Россия', 'Казань', 29, '2017-12-15', 1, 3, 4, 2, 5, '1991-12-03', 2),
(3, 'Артемьев Артемий Артемьевич', 'Россия', 'Казань', 40, '2019-10-15', 3, 1, 2, 3, 4, '1980-03-01', 3),
(4, 'Владимиров Владимир Владимирович', 'Россия', 'Казань', 45, '2020-10-19', 1, 3, 3, 4, 2, '1875-03-03', 2),
(5, 'Никитов Никита Никитович', 'Россия', 'Казань', 18, '2021-01-01', 2, 1, 1, 1, 3, '2002-11-03', 2),
(6, 'Данилов Даниил Данилович', 'Россия', 'Казань', 70, '2020-12-15', 1, 3, 1, 5, 4, '1950-12-09', 3),
(7, 'Антонов Антон Антонович', 'Россия', 'Казань', 33, '2020-07-07', 3, 2, 3, 2, 5, '1987-12-03', 1),
(8, 'Николаев Николай Николаевич', 'Россия', 'Казань', 22, '2019-12-15', 2, 3, 2, 4, 3, '1998-12-03', 3),
(9, 'Романов Роман Романович', 'Россия', 'Казань', 31, '2019-05-15', 2, 1, 1, 2, 5, '1989-01-03', 2),
(10, 'Алексеев Алексей Алексеевич', 'Россия', 'Казань', 19, '2020-01-08', 3, 2, 3, 3, 1, '2001-09-03', 1);

-- --------------------------------------------------------

--
-- Table structure for table `statussick`
--

CREATE TABLE `statussick` (
  `StatusSickID` int(32) UNSIGNED NOT NULL AUTO_INCREMENT,
  `StatusSick` varchar(20) NOT NULL,
  PRIMARY KEY (`StatusSickID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `statussick`
--

INSERT INTO `statussick` (`StatusSickID`, `StatusSick`) VALUES
(1, 'Выздоровел'),
(2, 'Болеет'),
(3, 'Умер');

-- --------------------------------------------------------

--
-- Table structure for table `severity`
--

CREATE TABLE `severity` (
  `severityID` int(32) UNSIGNED NOT NULL AUTO_INCREMENT,
  `severity` tinytext NOT NULL,
  PRIMARY KEY (`severityID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `severity`
--

INSERT INTO `severity` (`severityID`, `severity`) VALUES
(1, 'Легкая степень тяжести'),
(2, 'Средняя степень тяжести'),
(3, 'Тяжелая степень тяжести');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `disease`
--

--
-- Indexes for table `doctor`
--
ALTER TABLE `doctor`
  ADD KEY `MestoRaboti` (`MestoRaboti`); -- одназначный ID номер 

--
-- Indexes for table `hospital`
--


--
-- Indexes for table `methodtreatment`
--

--
-- Indexes for table `sick`
--
ALTER TABLE `sick`
  ADD KEY `DoctorID` (`DoctorID`),
  ADD KEY `StatusID` (`StatusID`),
  ADD KEY `severityID` (`severityID`),
  ADD KEY `HospitalID` (`HospitalID`),
  ADD KEY `MethodID` (`MethodID`),
  ADD KEY `DiseaseID` (`DiseaseID`);

--
-- Indexes for table `statussick`
--

--
-- Indexes for table `severity`
--

--
-- Constraints for dumped tables
--

--
-- Constraints for table `doctor`
--
ALTER TABLE `doctor`
  ADD CONSTRAINT `doctor_ibfk_1` FOREIGN KEY (`MestoRaboti`) REFERENCES `hospital` (`HospitalID`);
  -- ограничение                 имя ключа                     имя таблицы на которуб ссылается    
--
-- Constraints for table `sick`
--
ALTER TABLE `sick`
  ADD CONSTRAINT `sick_ibfk_1` FOREIGN KEY (`DoctorID`) REFERENCES `doctor` (`DoctorID`),
  ADD CONSTRAINT `sick_ibfk_2` FOREIGN KEY (`StatusID`) REFERENCES `statussick` (`StatusSickID`),
  ADD CONSTRAINT `sick_ibfk_3` FOREIGN KEY (`severityID`) REFERENCES `severity` (`severityID`),
  ADD CONSTRAINT `sick_ibfk_4` FOREIGN KEY (`HospitalID`) REFERENCES `hospital` (`HospitalID`),
  ADD CONSTRAINT `sick_ibfk_5` FOREIGN KEY (`MethodID`) REFERENCES `methodtreatment` (`MethodID`),
  ADD CONSTRAINT `sick_ibfk_6` FOREIGN KEY (`DiseaseID`) REFERENCES `disease` (`DiseaseID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
