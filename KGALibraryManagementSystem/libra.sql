-- phpMyAdmin SQL Dump
-- version 4.3.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 19, 2020 at 09:15 AM
-- Server version: 5.6.24
-- PHP Version: 5.6.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `libra`
--

-- --------------------------------------------------------

--
-- Table structure for table `admins`
--

CREATE TABLE IF NOT EXISTS `admins` (
  `id` varchar(50) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admins`
--

INSERT INTO `admins` (`id`, `firstname`, `lastname`, `password`) VALUES
('111', 'aass', 'aaaa', '123'),
('182-0206', 'James', 'Cabiao', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE IF NOT EXISTS `books` (
  `id` varchar(50) NOT NULL,
  `title` varchar(50) NOT NULL,
  `author` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL,
  `barrower` varchar(50) NOT NULL,
  `returndate` varchar(50) NOT NULL,
  `returned` varchar(50) NOT NULL,
  `balik` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`id`, `title`, `author`, `status`, `barrower`, `returndate`, `returned`, `balik`) VALUES
('001', 'The Other Boleyn Girl', 'Philippa Gregory', 'available', '1123', '2020-02-16 13:34:15.373814', '', ''),
('002', 'Heartstone', 'CJ Sansom', 'available', '1123', '2020-02-16 13:54:53.505829', '', ''),
('003', 'Computer Programming Language', 'Cyberpunk Architect', 'available', '', '2020-02-19 14:53:52.783693', '', ''),
('004', 'Python', 'Paul Jones', 'available', '123', '2020-02-17 15:03:10.262764', '', ''),
('006', 'More Than Words', 'Jill Santopolo', 'available', '', '', '2020-02-19 15:37:54.746936', '182-0206'),
('007', 'The Silent Patient', 'Alex Michaelides', 'available', '', '2020-02-19 14:53:52.783693', '', ''),
('008', 'The Hobbit', 'J.R.R Tolkien', 'available', '123', '2020-02-17 15:06:08.248925', '', ''),
('009', 'Before We Were Yours', 'Lisa Wingate', 'available', '1123', '2020-02-17 10:49:50.915462', '', ''),
('010', 'Harry Potter', 'J.K. Rowlings', 'available', '', '', '2020-02-19 15:46:53.210264', '182-0206'),
('122', 'The Man', 'mamao', 'available', '123', '2020-02-17 15:03:10.262764', '', ''),
('998', 'Koko the bobo', 'Mamamo', 'available', '', '2020-02-19 14:53:52.783693', '', ''),
('111', 'The nun', 'lola mo', 'available', '123', '2020-02-17 15:06:08.248925', '', ''),
('011', 'The Old Stock', 'Allan Berg', 'available', '', '', '2020-02-19 15:51:56.923272', '182-0206');

-- --------------------------------------------------------

--
-- Table structure for table `gumamit`
--

CREATE TABLE IF NOT EXISTS `gumamit` (
  `regnum` varchar(50) NOT NULL,
  `fname` varchar(50) NOT NULL,
  `lname` varchar(50) NOT NULL,
  `gender` varchar(50) NOT NULL,
  `dept` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `no_books` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `regnum` varchar(50) NOT NULL,
  `fname` varchar(50) NOT NULL,
  `lname` varchar(50) NOT NULL,
  `gender` varchar(50) NOT NULL,
  `dept` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `no_books` varchar(50) NOT NULL,
  `book_no` int(50) NOT NULL,
  `listbar` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`regnum`, `fname`, `lname`, `gender`, `dept`, `email`, `password`, `no_books`, `book_no`, `listbar`) VALUES
('182-0098', 'Glyza', 'Rafols', 'Female', 'Computer Engineering ', 'Pop', '124', '', 0, ''),
('182-0206', 'James', 'Cabiao', 'Male', 'Computer Engineering ', 'art@gmail.com', '123', '', 0, '');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
