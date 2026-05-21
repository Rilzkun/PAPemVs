SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";
SET NAMES utf8mb4;

CREATE DATABASE IF NOT EXISTS `db_kost`
  CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;

USE `db_kost`;
DROP TABLE IF EXISTS `pemesanan`;
DROP TABLE IF EXISTS `kamar`;
DROP TABLE IF EXISTS `users`;
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
('rasyid',   'rasyid123',   'Muhammad Rasyid',   '081345162892', 'user'),
('zidan',   'zidan123',   'Raffi Zidane',    '089876543210', 'user');

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

-- Data contoh
INSERT INTO `pemesanan` (`idUser`, `idKamar`, `durasi`, `totalHarga`, `tanggalMulai`, `tanggalSelesai`, `statusPesan`) VALUES
(2, 2, 3, 2400000, '2026-01-01', '2026-04-01', 'Aktif'),
(3, 4, 2, 1000000, '2026-03-15', '2026-05-15', 'Aktif');

COMMIT;
