-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jul 06, 2025 at 05:58 PM
-- Server version: 9.1.0
-- PHP Version: 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pristineshine`
--

-- --------------------------------------------------------

--
-- Table structure for table `ai_detection`
--

DROP TABLE IF EXISTS `ai_detection`;
CREATE TABLE IF NOT EXISTS `ai_detection` (
  `Ai_id` int NOT NULL AUTO_INCREMENT,
  `Ai_Issues` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Ai_Suggestion` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Ai_Date` date NOT NULL,
  PRIMARY KEY (`Ai_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `ai_detection`
--

INSERT INTO `ai_detection` (`Ai_id`, `Ai_Issues`, `Ai_Suggestion`, `Ai_Date`) VALUES
(1, 'None visible', 'Basic Wash, Tire & Wheel Cleaning', '2025-07-06'),
(2, 'Light dust and dirt on the surface, dull paint finish', 'Hand Wash, Polishing, Waxing', '2025-07-06');

-- --------------------------------------------------------

--
-- Table structure for table `appointment`
--

DROP TABLE IF EXISTS `appointment`;
CREATE TABLE IF NOT EXISTS `appointment` (
  `Appointment_Id` int NOT NULL AUTO_INCREMENT,
  `Appointment_Client_Id` int NOT NULL,
  `Appointment_Employee_Id` int NOT NULL,
  `Appointment_Date` date NOT NULL,
  `Appointment_Total` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Appointment_Discount` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Appointment_Grand_Total` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Appointment_Pay_Method` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Appointment_Booked_By` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Appointment_Alert` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Appointment_Status` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`Appointment_Id`),
  KEY `Appointment_Client_Id` (`Appointment_Client_Id`,`Appointment_Employee_Id`),
  KEY `Appointment_Employee_Id` (`Appointment_Employee_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `appointment`
--

INSERT INTO `appointment` (`Appointment_Id`, `Appointment_Client_Id`, `Appointment_Employee_Id`, `Appointment_Date`, `Appointment_Total`, `Appointment_Discount`, `Appointment_Grand_Total`, `Appointment_Pay_Method`, `Appointment_Booked_By`, `Appointment_Alert`, `Appointment_Status`) VALUES
(16, 13, 13, '2025-07-06', '10500.00', '0.00', '10500.00', 'Cash', 'M Faizan Abbas', '1', 'Pending'),
(17, 14, 10, '2025-07-06', '120000.00', '0.00', '120000.00', 'Card', 'M Faizan Abbas', '1', 'Pending'),
(18, 15, 13, '2025-07-06', '40000.00', '0.00', '40000.00', 'Card', 'M Faizan Abbas', '1', 'Pending'),
(19, 16, 19, '2025-07-06', '120000.00', '0.00', '120000.00', 'Card', 'M Faizan Abbas', '1', 'Pending'),
(20, 17, 8, '2025-07-06', '2500.00', '0.00', '2500.00', 'Card', 'M Faizan Abbas', '1', 'Pending'),
(21, 18, 5, '2025-07-06', '7000.00', '1500.00', '5500.00', 'Card', 'M Faizan Abbas', '1', 'Pending'),
(22, 19, 5, '2025-07-06', '12000.00', '0.00', '12000.00', 'Card', 'M Faizan Abbas', '1', 'Pending'),
(23, 20, 8, '2025-07-06', '7000.00', '0.00', '7000.00', 'Card', 'M Faizan Abbas', '1', 'Pending'),
(24, 21, 13, '2025-07-06', '3000.00', '0.00', '3000.00', 'Card', 'M Faizan Abbas', '1', 'Pending'),
(25, 22, 13, '2025-07-06', '1000.00', '0.00', '1000.00', 'Card', 'M Faizan Abbas', '1', 'Pending'),
(26, 23, 9, '2025-07-06', '6000.00', '0.00', '6000.00', 'Card', 'M Faizan Abbas', '1', 'Pending');

-- --------------------------------------------------------

--
-- Table structure for table `appointment_services`
--

DROP TABLE IF EXISTS `appointment_services`;
CREATE TABLE IF NOT EXISTS `appointment_services` (
  `AppointmentService_Id` int NOT NULL AUTO_INCREMENT,
  `Appointment_Id` int NOT NULL,
  `Service_Id` int NOT NULL,
  PRIMARY KEY (`AppointmentService_Id`),
  KEY `Appointment_Id` (`Appointment_Id`),
  KEY `Service_Id` (`Service_Id`)
) ENGINE=MyISAM AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `appointment_services`
--

INSERT INTO `appointment_services` (`AppointmentService_Id`, `Appointment_Id`, `Service_Id`) VALUES
(8, 17, 23),
(7, 16, 8),
(6, 16, 6),
(5, 16, 5),
(9, 18, 25),
(10, 19, 23),
(11, 20, 6),
(12, 21, 8),
(13, 22, 7),
(14, 23, 8),
(15, 24, 14),
(16, 25, 13),
(17, 26, 5),
(18, 26, 15);

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
CREATE TABLE IF NOT EXISTS `clients` (
  `Client_id` int NOT NULL AUTO_INCREMENT,
  `Client_Name` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Client_Phone` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Client_Address` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Client_Cnic` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Client_Car_Number` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Client_Car_Model` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Client_Car_Make` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Client_Car_Year` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Client_Car_Color` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`Client_id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `clients`
--

INSERT INTO `clients` (`Client_id`, `Client_Name`, `Client_Phone`, `Client_Address`, `Client_Cnic`, `Client_Car_Number`, `Client_Car_Model`, `Client_Car_Make`, `Client_Car_Year`, `Client_Car_Color`) VALUES
(13, 'Ali Raza', '+923062255225', 'Multan Cant', '3630212345678', 'LEA 1234', 'Civic', 'Honda', '2018', 'White'),
(14, 'Ali Raza', '+923062255225', 'Multan Cantt', '3630212345678', 'LEC 4321', 'Alto', 'Suzuki', '2022', 'Blue'),
(15, 'Ahmed Rafiq', '+923062255225', 'Gulberg Lahore', '3520111122223', 'LEA 1234', 'Civic', 'Honda', '2018', 'White'),
(16, 'Hassan Bilal', '+923062255225', 'Sadar Karachi', '4210199887761', 'AFR 7788', 'Sportage', 'Kia', '2021', 'Black'),
(17, 'Fatima Noor', '+923062255225', 'F-8 Islamabad', '3740654321987', 'IDK 9999', 'Cultus', 'Suzuki', '2020', 'Grey'),
(18, 'Zara Shah', '+923062255225', 'DHA Lahore', '3520367894562', 'BGL 5567', 'Grande', 'Toyota', '2019', 'Silver'),
(19, 'Zara Shah', '+923062255225', 'Gulshan, Karachi', '3520198891223', 'LEA 9283', 'Civic', 'Honda', '2022', 'White'),
(20, 'Zara Shah', '+923062255225', 'Gulshan, Karachi', '3520198891223', 'ABC 7777', 'Corolla', 'Toyota', '2020', 'Black'),
(21, 'Zara Shah', '+923062255225', 'Gulshan, Karachi', '3520198891223', 'MNP 1234', 'City', 'Honda', '2023', 'Silver'),
(22, 'Muhammad Faizan Abbas', '+923062255225', 'New Multan, Multan', '3630266899245', 'ML 6300', 'Baleno', 'Suzuki', '2003', 'White'),
(23, 'Muhammad Faizan Abbas', '+923062255225', 'New Multan, Multan', '3630266899245', 'MNP 7953', 'City', 'Honda', '2019', 'Black');

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
CREATE TABLE IF NOT EXISTS `employees` (
  `Employee_id` int NOT NULL AUTO_INCREMENT,
  `Employee_Name` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Employee_PhoneNumber` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Employee_Email` char(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Employee_Cnic` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Employee_Role` char(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Employee_Salary` char(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Employee_Address` varchar(535) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`Employee_id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`Employee_id`, `Employee_Name`, `Employee_PhoneNumber`, `Employee_Email`, `Employee_Cnic`, `Employee_Role`, `Employee_Salary`, `Employee_Address`) VALUES
(1, 'Muhammad Faizan Abbas', '+923062255225', 'muhammadfaizan_abbas@icloud.com', '3630266899245', 'Owner', '150,000', 'New Multan, Multan'),
(2, 'Muhammad Ali', '+923394022850', 'muhammadali@pristineshine.com', '3630266788345', 'Cleaner', '15,000', 'Setalmari, Multan'),
(4, 'Usman Raza', '+923062255225', 'usman.raza@pristineshine.com', '3520212345671', 'Detailer', '38,000', 'Gulgasht  Colony, Multan'),
(5, 'Ahsan Javed', '+923062255225', 'ahsan.javed@pristineshine.com', '3740698765432', 'Paint Specialist', '45,000', 'Satellite Town, Rawalpindi'),
(6, 'Bilal Ahmed', '+923062255225', 'bilal.ahmed@pristineshine.com', '6110111223345', 'Manager', '120,000', 'DHA Phase 5, Lahore'),
(7, 'Saad Farooq', '+923062255225', 'saad.farooq@pristineshine.com', '4210199887763', 'Receptionist', '30,000', 'Gulshan-e-Iqbal, Karachi'),
(8, 'Waqas Shah', '+923062255225', 'waqas.shah@pristineshine.com', '3310255667786', 'Ai Assistant', '50,000', 'Nishtar Road, Peshawar'),
(9, 'Salman Yousaf', '+923062255225', 'salman.yousaf@pristineshine.com', '3720344556674', 'Senior Detailler', '48,000', 'Johar Town, Lahore'),
(10, 'Talha Khan', '+923062255225', 'talha.khan@pristineshine.com', '3520122334457', 'Detailer', '36,000', 'Model Town, Sialkot'),
(11, 'Hamza Tariq', '+923062255225', 'hamza.tariq@pristineshine.com', '4210455443328', 'Inventory Manager', '42,000', 'North Nazimabad, Karachi'),
(12, 'Zohaib Anwar', '+923062255225', 'zohaib.anwar@pristineshine.com', '3740266778859', 'Accoutant', '55,000', 'Bahria Town, Islamabad'),
(13, 'Umar Ali', '+923062255225', 'umair.ali@pristineshine.com', '3520288990010', 'Customer Support', '34,000', 'Cantt Area,  Multan'),
(14, 'Usman Rashid', '+923062255225', 'usman.rashid@pristineshine.com', '3520311223343', 'Assistant Manager', '100,000', 'Shah Rukn-e-Alam, Multan'),
(15, 'Hina Siddiqui', '+923062255225', 'hina.siddiqui@pristineshine.com', '3520455667784', 'Supervisor', '85,000', 'Bahria Town, Lahore'),
(16, 'Anam Tariq', '+923062255225', 'anam.tariq@pristineshine.comanam.tariq@pristineshine.com', '3520633445566', 'Admin Staff', '75,000', 'DHA Phase 3, Islamabad'),
(17, 'Asad Iqbal', '+923062255225', 'asad.iqbal@pristineshine.com', '3520766778897', 'Operations Lead', '90,000', 'University Road, Karachi'),
(18, 'Zubair Nasir', '+923062255225', 'zubair.nasir@pristineshine.com', '3520599887765', 'Receptionist Manager', '80,000', 'Satellite Town, Rawalpindi'),
(19, 'Danish Raza', '+923062255225', 'danish.raza@pristineshine.com', '3521144556671', 'Car Wash Specialist', '50,000', 'Samanabad, Faisalabad');

-- --------------------------------------------------------

--
-- Table structure for table `expenses`
--

DROP TABLE IF EXISTS `expenses`;
CREATE TABLE IF NOT EXISTS `expenses` (
  `Expense_Id` int NOT NULL AUTO_INCREMENT,
  `Expense_Discription` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Expense_Amount` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Expense_Date` date NOT NULL,
  PRIMARY KEY (`Expense_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `income`
--

DROP TABLE IF EXISTS `income`;
CREATE TABLE IF NOT EXISTS `income` (
  `Income_Id` int NOT NULL AUTO_INCREMENT,
  `Income_Source` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Income_Amount` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Income_Date` date NOT NULL,
  `Income_Appointment_Id` int NOT NULL,
  PRIMARY KEY (`Income_Id`),
  KEY `Income_Appointment_Id` (`Income_Appointment_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `services`
--

DROP TABLE IF EXISTS `services`;
CREATE TABLE IF NOT EXISTS `services` (
  `Service_id` int NOT NULL AUTO_INCREMENT,
  `Service_Name` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Service_Discription` varchar(535) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Service_Price` char(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`Service_id`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `services`
--

INSERT INTO `services` (`Service_id`, `Service_Name`, `Service_Discription`, `Service_Price`) VALUES
(3, 'Basic Wash', 'Simple hand wash to remove dirt and dust.', '500'),
(4, 'Hand Wash', 'Thorough hand cleaning of exterior.', '800'),
(5, 'Pressure Wash', 'High-pressure water cleaning to remove tough dirt.', '1,000'),
(6, 'Clay Bar Treatment', 'Removes embedded contaminants from paint surface.', '2,500'),
(7, 'Paint Correction', 'Removes scratches, swirl marks; restores shine.', '12,000'),
(8, 'Scratch & Swirl Removal', 'Polishing to fix light scratches and swirls.', '7,000'),
(9, 'Polishing', 'Buffing paint to enhance gloss and smoothness.', '8,000'),
(10, 'Waxing', 'Protective wax layer to shield paintwork.', '5,000'),
(11, 'Sealant Application', 'Synthetic paint sealant for longer protection.', '10,000'),
(12, 'Ceramic Coating', 'Durable ceramic layer protecting paint for years.', '45,000'),
(13, 'Glass Cleaning', 'Cleaning and polishing glass surfaces.', '1,000'),
(14, 'Headlight Restoration', 'Polishing to restore clarity on foggy headlights.', '3,000'),
(15, 'Engine Bay Cleaning', 'Cleaning engine compartment safely.', '5,000'),
(16, 'Tire & Wheel Cleaning', 'Cleaning rims and tires; removes brake dust.', '1,200'),
(17, 'Tire Dressing & Shine', 'Application of shine & protectant on tires.', '1,500'),
(18, 'Ceramic Coating Maintenance', 'Cleaning & upkeep of existing ceramic coating.', '7,000'),
(19, 'Full Detail Package', 'Complete interior and exterior cleaning.', '25,000'),
(20, 'Express Detail', 'Quick wash and vacuum, basic cleaning.', '2,500'),
(21, 'Seasonal Detail Package', 'Deep cleaning & protection 3–4 times per year.', '30,000'),
(22, 'Monthly Detail Package', 'Regular cleaning & protection every month.', '10,000'),
(23, 'Paint Protection Film', 'Clear protective film to prevent scratches.', '120,000'),
(24, 'Vinyl Wrap Application', 'Applying colored vinyl sheets on car body.', '250,000'),
(25, 'Glass Tinting', 'Applying tint film to windows for UV protection.', '40,000'),
(26, 'Scratch & Dent Repair', 'Fixing minor dents and scratches without repainting.', '10,000');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `User_id` int NOT NULL AUTO_INCREMENT,
  `User_Employee_Id` int DEFAULT NULL,
  `User_Account_type` char(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `User_Name` varchar(535) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `User_UserName` char(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `User_Password` char(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `User_Occupation` char(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `User_Email` char(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `User_PhoneNumber` char(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `User_Cnic` char(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `User_SecurityQuestions` char(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `User_SecurityAnswer` char(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`User_id`),
  KEY `User_Employee_Id` (`User_Employee_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`User_id`, `User_Employee_Id`, `User_Account_type`, `User_Name`, `User_UserName`, `User_Password`, `User_Occupation`, `User_Email`, `User_PhoneNumber`, `User_Cnic`, `User_SecurityQuestions`, `User_SecurityAnswer`) VALUES
(6, 1, 'Admin', 'M Faizan Abbas', 'fazi323', 'fazi', 'Owner', 'faizan.abbas@pristineshine.com', '+923062255225', '3630266899245', 'School Name', 'Nfc Iet'),
(7, 6, 'Admin', 'Bilal Ahmed', 'bilal', 'bilal', 'Manager', 'bilal.ahmed@pristineshine.com', '+923062255225', '6110111223345', 'School Name', 'Nfc Iet'),
(8, 1, 'Employee', 'M Faizan Abbas', 'fazi', 'faizan', 'Owner', 'faizan.abbas@pristineshine.com', '+923062255225', '3630266899245', 'School Name', 'Nfc Iet');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `appointment`
--
ALTER TABLE `appointment`
  ADD CONSTRAINT `appointment_ibfk_1` FOREIGN KEY (`Appointment_Client_Id`) REFERENCES `clients` (`Client_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `appointment_ibfk_3` FOREIGN KEY (`Appointment_Employee_Id`) REFERENCES `employees` (`Employee_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `income`
--
ALTER TABLE `income`
  ADD CONSTRAINT `income_ibfk_1` FOREIGN KEY (`Income_Appointment_Id`) REFERENCES `appointment` (`Appointment_Id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`User_Employee_Id`) REFERENCES `employees` (`Employee_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
