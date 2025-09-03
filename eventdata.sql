-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 03, 2025 at 05:48 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `eventdata`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `AdminID` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_admin`
--

INSERT INTO `tbl_admin` (`AdminID`, `Username`, `Password`) VALUES
(1, 'Hirushan', 'Hirushan123');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_attendee`
--

CREATE TABLE `tbl_attendee` (
  `AttendeeID` int(11) NOT NULL,
  `FullName` varchar(100) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Password` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_attendee`
--

INSERT INTO `tbl_attendee` (`AttendeeID`, `FullName`, `Email`, `Password`) VALUES
(1, 'Dulen', 'dulen@gmail.com', 'dulen123'),
(2, 'Sithija', 'sithija@gmail.com', 'sithija123'),
(3, 'Navod', 'navod@gmail.com', 'navod123'),
(6, 'Heshan', 'heshan@gmail.com', 'heshan123');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_event`
--

CREATE TABLE `tbl_event` (
  `EventName` varchar(100) NOT NULL,
  `EventID` varchar(10) NOT NULL,
  `Date` varchar(100) NOT NULL,
  `venue` varchar(100) NOT NULL,
  `Discription` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_event`
--

INSERT INTO `tbl_event` (`EventName`, `EventID`, `Date`, `venue`, `Discription`) VALUES
('kuweniya', '1', '25/12/2025', 'nelum pokuna', 'music'),
('sarigama', '2', '29/7/2025', 'kottawa', 'music'),
('aale', '3', '21/11/2025', 'jaffna', 'music');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_events`
--

CREATE TABLE `tbl_events` (
  `EventID` int(11) NOT NULL,
  `EventName` varchar(100) NOT NULL,
  `Date` date NOT NULL,
  `Venue` varchar(150) DEFAULT NULL,
  `Description` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_events`
--

INSERT INTO `tbl_events` (`EventID`, `EventName`, `Date`, `Venue`, `Description`) VALUES
(2, 'Aale', '2025-06-04', 'Colombo', 'Musical show by Daddy Band'),
(3, 'Agamana', '2025-05-31', 'Kottawa', 'Musical Show by Infinity Band'),
(17, 'Kuweni', '2025-06-11', 'Nelum Pokuna', 'Music by Charith Attalage'),
(21, 'Nadagama', '2025-09-18', 'Kandy', 'Musical Show Danith Sri'),
(22, 'Drive in Concert', '2025-09-07', 'Colombo', 'Music');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_feedback`
--

CREATE TABLE `tbl_feedback` (
  `FeedbackID` int(11) NOT NULL,
  `AttendeeID` int(11) NOT NULL,
  `EventID` int(11) NOT NULL,
  `Rating` int(11) NOT NULL,
  `Comment` text DEFAULT NULL,
  `CreatedAt` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_feedback`
--

INSERT INTO `tbl_feedback` (`FeedbackID`, `AttendeeID`, `EventID`, `Rating`, `Comment`, `CreatedAt`) VALUES
(1, 3, 2, 3, 'Best Show Ever !', '2025-09-02 00:11:05'),
(2, 1, 2, 3, 'Good !', '2025-09-02 20:16:21'),
(3, 1, 2, 4, 'fdthfgthfh', '2025-09-03 21:09:39');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_ticket`
--

CREATE TABLE `tbl_ticket` (
  `TicketID` int(11) NOT NULL,
  `EventID` int(11) NOT NULL,
  `TicketType` varchar(50) DEFAULT NULL,
  `Price` decimal(10,2) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `Available` int(11) DEFAULT NULL,
  `Sold` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_ticket`
--

INSERT INTO `tbl_ticket` (`TicketID`, `EventID`, `TicketType`, `Price`, `Quantity`, `Available`, `Sold`) VALUES
(4, 3, 'general', 1500.00, 800, NULL, 173),
(6, 2, 'fhf', 555.00, 5, NULL, 850),
(16, 2, 'VVIP', 5000.00, 500, NULL, 217),
(19, 2, 'Vip', 5666.00, 3, NULL, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_ticket_purchase`
--

CREATE TABLE `tbl_ticket_purchase` (
  `PurchaseID` int(11) NOT NULL,
  `AttendeeID` int(11) DEFAULT NULL,
  `TicketID` int(11) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `PurchaseDate` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_ticket_purchase`
--

INSERT INTO `tbl_ticket_purchase` (`PurchaseID`, `AttendeeID`, `TicketID`, `Quantity`, `PurchaseDate`) VALUES
(18, 3, 4, 56, '2025-08-31 09:06:59'),
(19, 3, 4, 56, '2025-08-31 20:10:08'),
(20, 3, 4, 56, '2025-08-31 20:10:13'),
(21, 3, 16, 78, '2025-08-31 20:15:32'),
(22, 3, 6, 3, '2025-08-31 21:02:30'),
(23, 3, 6, 56, '2025-08-31 21:08:21'),
(24, 3, 6, 3, '2025-08-31 21:50:11'),
(25, 3, 6, 78, '2025-08-31 22:48:52'),
(26, 3, 6, 78, '2025-08-31 22:49:12'),
(27, 3, 6, 78, '2025-08-31 22:49:40'),
(28, 3, 6, 78, '2025-08-31 22:49:53'),
(29, 3, 6, 8, '2025-08-31 22:55:27'),
(30, 3, 6, 8, '2025-08-31 22:55:50'),
(31, 3, 6, 67, '2025-08-31 22:58:20'),
(32, 3, 6, 6, '2025-08-31 23:18:33'),
(33, 3, 6, 345, '2025-09-01 06:30:39'),
(34, 3, 6, 6, '2025-09-01 08:04:28'),
(35, 3, 6, 7, '2025-09-01 08:12:07'),
(36, 3, 16, 7, '2025-09-01 08:12:26'),
(37, 3, 6, 7, '2025-09-01 08:14:04'),
(38, 3, 6, 9, '2025-09-01 08:17:16'),
(39, 3, 6, 5, '2025-09-01 08:45:42'),
(40, 3, 6, 5, '2025-09-01 23:14:23'),
(41, 3, 6, 7, '2025-09-01 23:30:17'),
(42, 3, 6, 4, '2025-09-02 12:28:02'),
(43, 3, 6, 7, '2025-09-02 13:49:18'),
(44, 3, 6, 7, '2025-09-02 14:03:29'),
(45, 3, 6, 6, '2025-09-02 14:19:11'),
(46, 3, 6, 1, '2025-09-02 14:20:09'),
(47, 3, 16, 1, '2025-09-02 14:24:09'),
(48, 3, 16, 3, '2025-09-02 14:25:27'),
(49, 3, 16, 67, '2025-09-02 14:27:45'),
(50, 3, 4, 5, '2025-09-02 14:30:54'),
(52, 1, 16, 5, '2025-09-03 19:42:05'),
(53, 1, 16, 6, '2025-09-03 20:44:44'),
(54, 1, 16, 3, '2025-09-03 20:59:28'),
(55, 1, 16, 5, '2025-09-03 21:03:41'),
(56, 1, 16, 4, '2025-09-03 21:06:23'),
(57, 1, 16, 45, '2025-09-03 21:12:18');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`AdminID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- Indexes for table `tbl_attendee`
--
ALTER TABLE `tbl_attendee`
  ADD PRIMARY KEY (`AttendeeID`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- Indexes for table `tbl_events`
--
ALTER TABLE `tbl_events`
  ADD PRIMARY KEY (`EventID`);

--
-- Indexes for table `tbl_feedback`
--
ALTER TABLE `tbl_feedback`
  ADD PRIMARY KEY (`FeedbackID`),
  ADD KEY `AttendeeID` (`AttendeeID`),
  ADD KEY `EventID` (`EventID`);

--
-- Indexes for table `tbl_ticket`
--
ALTER TABLE `tbl_ticket`
  ADD PRIMARY KEY (`TicketID`),
  ADD KEY `idx_event` (`EventID`);

--
-- Indexes for table `tbl_ticket_purchase`
--
ALTER TABLE `tbl_ticket_purchase`
  ADD PRIMARY KEY (`PurchaseID`),
  ADD KEY `AttendeeID` (`AttendeeID`),
  ADD KEY `TicketID` (`TicketID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  MODIFY `AdminID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbl_attendee`
--
ALTER TABLE `tbl_attendee`
  MODIFY `AttendeeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbl_events`
--
ALTER TABLE `tbl_events`
  MODIFY `EventID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `tbl_feedback`
--
ALTER TABLE `tbl_feedback`
  MODIFY `FeedbackID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_ticket`
--
ALTER TABLE `tbl_ticket`
  MODIFY `TicketID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `tbl_ticket_purchase`
--
ALTER TABLE `tbl_ticket_purchase`
  MODIFY `PurchaseID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=58;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_feedback`
--
ALTER TABLE `tbl_feedback`
  ADD CONSTRAINT `tbl_feedback_ibfk_1` FOREIGN KEY (`AttendeeID`) REFERENCES `tbl_attendee` (`AttendeeID`),
  ADD CONSTRAINT `tbl_feedback_ibfk_2` FOREIGN KEY (`EventID`) REFERENCES `tbl_events` (`EventID`);

--
-- Constraints for table `tbl_ticket`
--
ALTER TABLE `tbl_ticket`
  ADD CONSTRAINT `fk_event` FOREIGN KEY (`EventID`) REFERENCES `tbl_events` (`EventID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_ticket_purchase`
--
ALTER TABLE `tbl_ticket_purchase`
  ADD CONSTRAINT `tbl_ticket_purchase_ibfk_1` FOREIGN KEY (`AttendeeID`) REFERENCES `tbl_attendee` (`AttendeeID`),
  ADD CONSTRAINT `tbl_ticket_purchase_ibfk_2` FOREIGN KEY (`TicketID`) REFERENCES `tbl_ticket` (`TicketID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
