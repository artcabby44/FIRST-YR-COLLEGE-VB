-- phpMyAdmin SQL Dump
-- version 4.3.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 02, 2020 at 11:25 AM
-- Server version: 5.6.24
-- PHP Version: 5.6.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `benk`
--

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `name` varchar(50) NOT NULL,
  `gen` varchar(50) NOT NULL,
  `address` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `phone` varchar(50) NOT NULL,
  `cardnum` varchar(50) NOT NULL,
  `pin` varchar(50) NOT NULL,
  `bal` int(50) NOT NULL,
  `fixedbal` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`name`, `gen`, `address`, `email`, `phone`, `cardnum`, `pin`, `bal`, `fixedbal`) VALUES
('James', 'Male', 'Camarin ', 'adasd', '0987324623', '1028 5600 9915 7972', '123', 900, 600),
('khent Barangas', 'Male', 'asdasd', 'dqwdqw', 'qwdqwd', '1643 5875 9676 2546', '123', 5000, 0),
('glyza', 'Male', 'manila', 'glygly', '091111111111', '1460 5188 9240 8123', '12345', 500000, 0),
('khent', 'Male', 'jahjshfhwe', 'qwertyui', '123456789', '1107 5301 9434 3243', '12345678', 1000000, 0),
('James', 'Male', 'qwerty', 'weqwe', '1233', '1883 5322 9512 8860', '123', 0, 3000),
('Sarah', 'Male', 'kmklnn', 'okkp', '0987', '1651 5348 9084 8700', '123', 1000, 5500),
('People', 'Male', 'nsajdas', 'wewr', '212', '1618 5789 9733 5908', '123', 0, 500),
('Jalibee', 'Male', 'opaa', '23', '12321', '1754 5478 9280 2623', '123', 600, 500),
('James', 'Male', 'weqwe', 'asdasd', '09231311', '1877 5775 9315 1863', '123', 300, 0),
('james', 'Male', 'huhuhhgjhg', 'fgdgf', 'dfgdf', '1913 5895 9993 4504', '123', 433, 0),
('joms', 'Male', 'sadasdas', 'weqrwer', '0978973', '1462 5892 9077 1859', '123', 0, 20099);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
