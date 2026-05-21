-- =====================================================
-- Database: db_kost
-- Sistem Manajemen dan Pemesanan Kamar Kost
-- Tabel: users, kamar, pemesanan
-- =====================================================

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";
SET NAMES utf8mb4;

CREATE DATABASE IF NOT EXISTS `db_kost`
  CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;

USE `db_kost`;

-- --------------------------------------------------------
-- Drop urutan: child dulu, baru parent
-- --------------------------------------------------------
DROP TABLE IF EXISTS `pemesanan`;
DROP TABLE IF EXISTS `kamar`;
DROP TABLE IF EXISTS `users`;

-- --------------------------------------------------------
-- Tabel: users
-- --------------------------------------------------------
CREATE TABLE `users` (
  `idUser`       INT(11)       NOT NULL AUTO_INCREMENT,
  `username`     VARCHAR(50)   NOT NULL UNIQUE,
  `password`     VARCHAR(100)  NOT NULL,
  `namaLengkap`  VARCHAR(100)  NOT NULL,
  `noTelp`       VARCHAR(20)   NOT NULL,
  `role`         VARCHAR(10)   NOT NULL DEFAULT 'user'
                               COMMENT 'admin atau user',
  `createdAt`    DATETIME      NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`idUser`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Akun default: admin / admin123  |  user / user123
INSERT INTO `users` (`username`, `password`, `namaLengkap`, `noTelp`, `role`) VALUES
('admin',  'admin123',  'Administrator',  '081200000000', 'admin'),
('budi',   'budi123',   'Budi Santoso',   '081234567890', 'user'),
('siti',   'siti123',   'Siti Aminah',    '089876543210', 'user');

-- --------------------------------------------------------
-- Tabel: kamar
-- --------------------------------------------------------
CREATE TABLE `kamar` (
  `idKamar`     INT(11)       NOT NULL AUTO_INCREMENT,
  `nomorKamar`  VARCHAR(10)   NOT NULL UNIQUE,
  `tipeKamar`   VARCHAR(20)   NOT NULL
                              COMMENT 'Biasa | Eksekutif | VIP',
  `hargaKamar`  INT(11)       NOT NULL DEFAULT 0,
  `statusKamar` VARCHAR(20)   NOT NULL DEFAULT 'Tersedia'
                              COMMENT 'Tersedia | Dipesan | Maintenance',
  `deskripsi`   VARCHAR(255)  DEFAULT NULL,
  `createdAt`   DATETIME      NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`idKamar`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `kamar` (`nomorKamar`, `tipeKamar`, `hargaKamar`, `statusKamar`, `deskripsi`) VALUES
('K01', 'Biasa',     500000,  'Tersedia',    'Kamar standar, kipas angin'),
('K02', 'Eksekutif', 800000,  'Dipesan',     'Kamar AC, lemari, meja belajar'),
('K03', 'VIP',       1200000, 'Tersedia',    'Kamar AC, TV, kamar mandi dalam'),
('K04', 'Biasa',     500000,  'Dipesan',     'Kamar standar, kipas angin'),
('K05', 'Eksekutif', 800000,  'Maintenance', 'Sedang renovasi'),
('K06', 'VIP',       1200000, 'Tersedia',    'Kamar mewah, full furnish');

-- --------------------------------------------------------
-- Tabel: pemesanan
-- --------------------------------------------------------
CREATE TABLE `pemesanan` (
  `idPesan`        INT(11)   NOT NULL AUTO_INCREMENT,
  `idUser`         INT(11)   NOT NULL,
  `idKamar`        INT(11)   NOT NULL,
  `durasi`         INT(11)   NOT NULL DEFAULT 1
                             COMMENT 'dalam bulan',
  `totalHarga`     INT(11)   NOT NULL DEFAULT 0,
  `tanggalMulai`   DATE      NOT NULL,
  `tanggalSelesai` DATE      NOT NULL,
  `statusPesan`    VARCHAR(20) NOT NULL DEFAULT 'Aktif'
                             COMMENT 'Aktif | Selesai | Dibatalkan',
  `createdAt`      DATETIME  NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`idPesan`),
  CONSTRAINT `fk_pesan_user`
    FOREIGN KEY (`idUser`) REFERENCES `users` (`idUser`)
    ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_pesan_kamar`
    FOREIGN KEY (`idKamar`) REFERENCES `kamar` (`idKamar`)
    ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data contoh: budi sewa K02, siti sewa K04
INSERT INTO `pemesanan` (`idUser`, `idKamar`, `durasi`, `totalHarga`, `tanggalMulai`, `tanggalSelesai`, `statusPesan`) VALUES
(2, 2, 3, 2400000, '2025-01-01', '2025-04-01', 'Aktif'),
(3, 4, 2, 1000000, '2025-03-15', '2025-05-15', 'Aktif');

COMMIT;
