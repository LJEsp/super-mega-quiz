-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 12, 2017 at 08:24 PM
-- Server version: 10.1.26-MariaDB
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbsupermegaquiz`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblmath`
--

CREATE TABLE `tblmath` (
  `number` int(11) NOT NULL,
  `question` varchar(35) NOT NULL,
  `answer` varchar(35) NOT NULL,
  `choice1` varchar(35) NOT NULL,
  `choice2` varchar(35) NOT NULL,
  `choice3` varchar(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblmath`
--

INSERT INTO `tblmath` (`number`, `question`, `answer`, `choice1`, `choice2`, `choice3`) VALUES
(1, '1+1', '2', '3', '4', '5'),
(2, '2+2', '4', '1', '2', '3'),
(3, '5 x 5', '25', '10', '5', '50');

-- --------------------------------------------------------

--
-- Table structure for table `tblscience`
--

CREATE TABLE `tblscience` (
  `number` int(11) NOT NULL,
  `question` varchar(100) NOT NULL,
  `answer` varchar(35) NOT NULL,
  `choice1` varchar(35) NOT NULL,
  `choice2` varchar(35) NOT NULL,
  `choice3` varchar(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblscience`
--

INSERT INTO `tblscience` (`number`, `question`, `answer`, `choice1`, `choice2`, `choice3`) VALUES
(1, 'Who was the first man to fly around the earth with a spaceship?	', 'Gagarin', 'Alan Shepard', 'Alexander Fleming', 'James Watt'),
(2, 'Who invented vulcanized rubber?	', 'Goodyear', 'Gagarin', 'Alan Shepard', 'Robert Oppenheimer'),
(3, 'Who is the father of the atomic bomb?	', 'Robert Oppenheimer', 'Alan Shepard', 'James Watt', 'Alexander Fleming'),
(4, 'Who was the first American in space?	', 'Alan Shepard', 'Torricelli', 'Gagarin', 'James Watt'),
(5, 'Who invented the barometer?	', 'Torricelli', 'Robert Oppenheimer', 'Alexander Fleming', 'Goodyear'),
(6, 'Who discoved one of the first antibiotics: penicillin ?	', 'Alexander Fleming', 'Alan Shepard', 'Torricelli', 'James Watt');

-- --------------------------------------------------------

--
-- Table structure for table `tblusers`
--

CREATE TABLE `tblusers` (
  `username` varchar(35) NOT NULL,
  `password` varchar(35) NOT NULL,
  `scoremath` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblusers`
--

INSERT INTO `tblusers` (`username`, `password`, `scoremath`) VALUES
('Admin', 'password', ''),
('John', 'password', ''),
('Leandro', 'esparrago', '1/3'),
('v5j9%C@)Ieeeeeeeeeeeeeeeawvrwpjcwpj', 'pass', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblmath`
--
ALTER TABLE `tblmath`
  ADD UNIQUE KEY `number` (`number`);

--
-- Indexes for table `tblscience`
--
ALTER TABLE `tblscience`
  ADD UNIQUE KEY `number` (`number`);

--
-- Indexes for table `tblusers`
--
ALTER TABLE `tblusers`
  ADD UNIQUE KEY `username` (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
