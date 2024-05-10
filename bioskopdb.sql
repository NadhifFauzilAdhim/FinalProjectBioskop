-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 10 Bulan Mei 2024 pada 16.07
-- Versi server: 10.4.28-MariaDB
-- Versi PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bioskopdb`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `customer`
--

CREATE TABLE `customer` (
  `id` int(11) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `password` varchar(255) DEFAULT NULL,
  `balance` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `customer`
--

INSERT INTO `customer` (`id`, `nama`, `password`, `balance`) VALUES
(2211, 'TESTING', 'wadawdawdwd', 100000),
(22115018, 'Dwi Ferdiyanto', 'UKDd88xYpKK05ftRmcLAcQ==', 100000),
(22115035, 'Nadhif Fauzil A', 'UKDd88xYpKK05ftRmcLAcQ==', 9949999),
(22115041, 'Julian Kiyosaki H', 'UKDd88xYpKK05ftRmcLAcQ==', 100000),
(22115044, 'ArabisGroup', '+sQJwxSd6ngYTbDLBnoTtf5lD2vbbKrfETMybHHYLsY=', 100000),
(22115045, 'Arabis Group', 'HVioUkf6FgM7T0EFdz25qQ==', 100000),
(22115046, 'crazykiller', 'E9E7IdBQCI+bHbNSLmF6QQ==', 100000),
(22115047, 'test', 'UKDd88xYpKK05ftRmcLAcQ==', 100000),
(22115050, 'Testing Account', 'UKDd88xYpKK05ftRmcLAcQ==', 100000),
(22115051, 'NEWACCOUNT', 'UKDd88xYpKK05ftRmcLAcQ==', 100000),
(22115052, 'amikom', '+T0rT79hu/f9/moFjJPyoQ==', 50000),
(22115053, 'Suci Prasetyaningsih', 'UKDd88xYpKK05ftRmcLAcQ==', 100000),
(22115054, 'Amikom', 'DzNxclh3WslrECHKOFJYZQ==', 1000000),
(22115059, 'budi', '$2y$10$FCcI60RFNGudHQ4HxnDHMe6shtIDdPKjGmpZKkoqluOe7VDBRHJN6', 0),
(22115060, 'julian', '$2y$10$uTtUJPfxQKEpCbGAfh01u..xtUp7Sjmra3cJNfmYhIaOzgo5SVNDC', 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `film`
--

CREATE TABLE `film` (
  `IdFilm` varchar(10) NOT NULL,
  `FilmName` varchar(100) DEFAULT NULL,
  `Harga` decimal(10,0) DEFAULT NULL,
  `Durasi` time DEFAULT NULL,
  `ThnRilis` varchar(4) DEFAULT NULL,
  `Genre` varchar(20) DEFAULT NULL,
  `Jam_tayang` time DEFAULT NULL,
  `Poster` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `film`
--

INSERT INTO `film` (`IdFilm`, `FilmName`, `Harga`, `Durasi`, `ThnRilis`, `Genre`, `Jam_tayang`, `Poster`) VALUES
('BtnFilm1', 'The Marvel', 50000, '01:45:00', '2023', 'Action', '18:40:00', '65d44e345432b.jpeg'),
('BtnFilm2', 'Sehabis Magrib', 40000, '01:40:00', '2023', 'Horror', '13:30:00', '65d5e7a78846b.jpg'),
('BtnFilm3', 'Trolls', 35000, '01:31:00', '2023', 'Comedy', '12:30:00', '65d44f9fdb91a.jpg'),
('BtnFilm4', 'Sijjin', 40000, '01:40:00', '2023', 'Horror', '17:00:00', '65d44ffac6882.jpg'),
('BtnFilm5', '172 Days', 30000, '01:43:00', '2023', 'Drama', '11:00:00', '65d45015f3aab.jpg'),
('BtnFilm6', 'Gampang Cuan', 40000, '01:58:00', '2023', 'Drama', '20:50:00', '65d450363f7df.jpeg'),
('BtnFilm7', 'Saranjana', 40000, '01:38:00', '2023', 'Horror', '12:00:00', '65d44e01b5106.jpg'),
('BtnFIlm8', 'FerdiFIlm', 50000, '01:40:00', '2023', 'Romance', '11:00:00', '65def9dd2afee.jpg');

-- --------------------------------------------------------

--
-- Struktur dari tabel `payment`
--

CREATE TABLE `payment` (
  `IdPayment` int(11) NOT NULL,
  `Idcustomer` int(11) NOT NULL,
  `SeatNumber` varchar(2) NOT NULL,
  `IdFilm` varchar(10) NOT NULL,
  `NamaCus` varchar(100) DEFAULT NULL,
  `FilmName` varchar(100) DEFAULT NULL,
  `Harga` decimal(10,0) DEFAULT NULL,
  `TglPesan` datetime DEFAULT NULL,
  `Ticket_valid` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `payment`
--

INSERT INTO `payment` (`IdPayment`, `Idcustomer`, `SeatNumber`, `IdFilm`, `NamaCus`, `FilmName`, `Harga`, `TglPesan`, `Ticket_valid`) VALUES
(9, 22115035, 'A1', 'BtnFilm3', 'Nadhif Fauzil A', 'Trolls', 35000, '2023-11-28 11:59:37', '2023-11-28 07:59:37'),
(11, 22115035, 'A1', 'BtnFilm1', 'Nadhif Fauzil A', 'The Marvel', 50000, '2023-12-02 16:22:08', '2023-12-02 12:22:08'),
(12, 22115035, 'A1', 'BtnFilm7', 'Nadhif Fauzil A', 'Saranjana', 40000, '2023-12-02 19:35:55', '2023-12-02 15:35:55'),
(13, 22115035, 'A1', 'BtnFilm4', 'Nadhif Fauzil A', 'Sijjin', 40000, '2023-12-02 19:43:40', '2023-12-02 15:43:40'),
(14, 22115035, 'A1', 'BtnFilm3', 'Nadhif Fauzil A', 'Trolls', 35000, '2023-12-02 19:57:21', '2023-12-02 15:57:21'),
(15, 22115035, 'A1', 'BtnFilm7', 'Nadhif Fauzil A', 'Saranjana', 40000, '2023-12-02 20:28:40', '2023-12-02 16:28:40'),
(16, 22115035, 'A1', 'BtnFilm7', 'Nadhif Fauzil A', 'Saranjana', 40000, '2023-12-02 20:32:21', '2023-12-02 16:32:21'),
(17, 22115035, 'A1', 'BtnFilm7', 'Nadhif Fauzil A', 'Saranjana', 40000, '2023-12-02 22:58:57', '2023-12-02 18:58:57'),
(29, 22115035, 'C1', 'BtnFilm6', 'Nadhif Fauzil A', 'Gampang Cuan', 40000, '2023-12-03 11:00:54', '2023-12-03 07:00:54'),
(30, 22115035, 'A1', 'BtnFilm1', 'Nadhif Fauzil A', 'The Marvel', 50000, '2023-12-03 21:14:19', '2023-12-03 17:14:19'),
(31, 22115035, 'A1', 'BtnFilm1', 'Nadhif Fauzil A', 'The Marvel', 50000, '2023-12-04 08:58:18', '2023-12-04 04:58:18'),
(32, 22115035, 'A2', 'BtnFilm1', 'Nadhif Fauzil A', 'The Marvel', 50000, '2023-12-04 09:15:05', '2023-12-04 05:15:05'),
(33, 22115035, 'A2', 'BtnFilm2', 'Nadhif Fauzil A', 'Sehabis Magrib', 40000, '2023-12-06 18:20:27', '2023-12-06 14:20:27'),
(34, 22115035, 'A1', 'BtnFilm1', 'Nadhif Fauzil A', 'The Marvel', 50000, '2023-12-06 21:36:07', '2023-12-06 17:36:07'),
(35, 22115052, 'A3', 'BtnFilm1', 'amikom', 'The Marvel', 50000, '2023-12-07 07:54:47', '2023-12-07 03:54:47'),
(36, 22115035, 'B1', 'BtnFilm7', 'Nadhif Fauzil A', 'Saranjana', 40000, '2023-12-09 19:24:02', '2023-12-09 15:24:02'),
(37, 22115035, 'B1', 'BtnFilm1', 'Nadhif Fauzil A', 'The Marvel', 50000, '2023-12-14 07:26:04', '2023-12-14 03:26:04'),
(38, 22115035, 'A5', 'BtnFilm6', 'Nadhif Fauzil A', 'Gampang Cuan', 40000, '2023-12-22 20:19:35', '2023-12-22 16:19:35'),
(39, 22115035, 'A3', 'BtnFilm1', 'Nadhif Fauzil A', 'The Marvel', 50000, '2023-12-26 08:28:24', '2023-12-26 04:28:24'),
(40, 22115035, 'A1', 'BtnFilm1', 'Nadhif Fauzil A', 'The Marvel', 50000, '2024-01-14 18:54:47', '2024-01-14 14:54:47');

-- --------------------------------------------------------

--
-- Struktur dari tabel `seatstatus`
--

CREATE TABLE `seatstatus` (
  `SeatNumber` varchar(2) NOT NULL,
  `Status` tinyint(1) DEFAULT NULL,
  `11:00:00` tinyint(1) DEFAULT NULL,
  `12:00:00` tinyint(1) DEFAULT NULL,
  `12:30:00` tinyint(1) DEFAULT NULL,
  `13:30:00` tinyint(1) DEFAULT NULL,
  `17:00:00` tinyint(1) DEFAULT NULL,
  `18:40:00` tinyint(1) DEFAULT NULL,
  `20:50:00` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `seatstatus`
--

INSERT INTO `seatstatus` (`SeatNumber`, `Status`, `11:00:00`, `12:00:00`, `12:30:00`, `13:30:00`, `17:00:00`, `18:40:00`, `20:50:00`) VALUES
('A1', 1, 1, 0, 1, 0, 1, 0, 1),
('A2', 1, 0, 0, 1, 0, 1, 1, 1),
('A3', 1, 0, 0, 1, 1, 1, 1, 1),
('A4', 1, 1, 1, 1, 1, 1, 1, 1),
('A5', 1, 1, 1, 0, 1, 0, 1, 0),
('A6', 1, 1, 1, 1, 1, 1, 1, 1),
('B1', 1, 1, 0, 1, 1, 1, 1, 1),
('B2', 1, 1, 1, 0, 0, 1, 1, 1),
('B3', 1, 1, 1, 1, 1, 1, 1, 1),
('B4', 1, 1, 1, 1, 1, 1, 1, 1),
('B5', 1, 1, 1, 1, 1, 1, 1, 1),
('B6', 1, 1, 1, 1, 1, 1, 1, 1),
('C1', 1, 1, 1, 1, 1, 1, 1, 0),
('C2', 1, 1, 1, 1, 1, 1, 1, 1),
('C3', 1, 1, 1, 1, 1, 1, 1, 1),
('C4', 1, 1, 1, 1, 1, 0, 1, 1),
('C5', 1, 1, 1, 1, 0, 1, 1, 1),
('C6', 1, 1, 1, 1, 1, 1, 1, 1),
('D1', 0, 1, 1, 1, 1, 1, 1, 1),
('D2', 1, 1, 1, 1, 1, 1, 1, 1),
('D3', 1, 1, 1, 1, 1, 1, 1, 1),
('D4', 1, 1, 1, 1, 1, 1, 1, 1),
('D5', 1, 1, 1, 1, 1, 1, 1, 1),
('D6', 1, 1, 1, 1, 1, 1, 1, 1),
('E1', 0, 1, 1, 1, 1, 1, 1, 0),
('E2', 0, 1, 1, 1, 1, 1, 1, 1),
('E3', 0, 1, 1, 1, 1, 1, 1, 1),
('E4', 1, 1, 1, 1, 1, 1, 1, 1),
('E5', 1, 1, 1, 1, 1, 1, 1, 1),
('E6', 1, 1, 1, 1, 1, 1, 1, 1);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `film`
--
ALTER TABLE `film`
  ADD PRIMARY KEY (`IdFilm`);

--
-- Indeks untuk tabel `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`IdPayment`),
  ADD UNIQUE KEY `IdPayment_UNIQUE` (`IdPayment`),
  ADD KEY `PaymentSeatNum_idx` (`SeatNumber`),
  ADD KEY `PaymentIDFilm_idx` (`IdFilm`),
  ADD KEY `PaymentIDCus_idx` (`Idcustomer`);

--
-- Indeks untuk tabel `seatstatus`
--
ALTER TABLE `seatstatus`
  ADD PRIMARY KEY (`SeatNumber`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `customer`
--
ALTER TABLE `customer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22115061;

--
-- AUTO_INCREMENT untuk tabel `payment`
--
ALTER TABLE `payment`
  MODIFY `IdPayment` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `payment`
--
ALTER TABLE `payment`
  ADD CONSTRAINT `PaymentIDCus` FOREIGN KEY (`Idcustomer`) REFERENCES `customer` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `PaymentIDFilm` FOREIGN KEY (`IdFilm`) REFERENCES `film` (`IdFilm`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `PaymentSeatNum` FOREIGN KEY (`SeatNumber`) REFERENCES `seatstatus` (`SeatNumber`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
