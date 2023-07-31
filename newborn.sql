-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 13, 2021 at 06:49 PM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `newborn`
--

-- --------------------------------------------------------

--
-- Table structure for table `bayis`
--

CREATE TABLE `bayis` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `berat` float NOT NULL,
  `panjang` float NOT NULL,
  `tanggal_lahir` date NOT NULL,
  `jenis_kelamin` enum('Laki-laki','Perempuan') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `bayi_pengguna`
--

CREATE TABLE `bayi_pengguna` (
  `bayis_id` int(11) NOT NULL,
  `penggunas_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `minum_susus`
--

CREATE TABLE `minum_susus` (
  `id` int(11) NOT NULL,
  `waktu` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `volume` int(11) NOT NULL,
  `bayis_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `penggunas`
--

CREATE TABLE `penggunas` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `penggunas`
--

INSERT INTO `penggunas` (`id`, `nama`, `username`, `password`) VALUES
(1, 'Jimmy', 'jimmy', '829b36babd21be519fa5f9353daf5dbdb796993e'),
(2, 'Liliana', 'lili', '829b36babd21be519fa5f9353daf5dbdb796993e'),
(3, 'Daniel Soesanto', 'daniels', '829b36babd21be519fa5f9353daf5dbdb796993e'),
(4, 'Maya Hilda', 'maya', '829b36babd21be519fa5f9353daf5dbdb796993e'),
(5, 'Ahmad Miftah', 'miftah', '829b36babd21be519fa5f9353daf5dbdb796993e');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bayis`
--
ALTER TABLE `bayis`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `bayi_pengguna`
--
ALTER TABLE `bayi_pengguna`
  ADD PRIMARY KEY (`bayis_id`,`penggunas_id`),
  ADD KEY `fk_bayis_has_penggunas_penggunas1_idx` (`penggunas_id`),
  ADD KEY `fk_bayis_has_penggunas_bayis1_idx` (`bayis_id`);

--
-- Indexes for table `minum_susus`
--
ALTER TABLE `minum_susus`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_minum_susus_bayis1_idx` (`bayis_id`);

--
-- Indexes for table `penggunas`
--
ALTER TABLE `penggunas`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username_UNIQUE` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bayis`
--
ALTER TABLE `bayis`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `minum_susus`
--
ALTER TABLE `minum_susus`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `penggunas`
--
ALTER TABLE `penggunas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `bayi_pengguna`
--
ALTER TABLE `bayi_pengguna`
  ADD CONSTRAINT `fk_bayis_has_penggunas_bayis1` FOREIGN KEY (`bayis_id`) REFERENCES `bayis` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_bayis_has_penggunas_penggunas1` FOREIGN KEY (`penggunas_id`) REFERENCES `penggunas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `minum_susus`
--
ALTER TABLE `minum_susus`
  ADD CONSTRAINT `fk_minum_susus_bayis1` FOREIGN KEY (`bayis_id`) REFERENCES `bayis` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
